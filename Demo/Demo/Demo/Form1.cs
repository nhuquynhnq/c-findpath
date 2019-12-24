using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        int[,] matr = new int[100, 100];
        Graphics g; Pen p; Point cursor;
        int k =0, ki, jk; 
        Point p1, p2;
        string tmp = "0";
        Point[] points = new Point[50];
        
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            p = new Pen(Color.Black, 3);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void txtdodai_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            var text1 = k.ToString();
            List<Point> p1List = new List<Point>();
            List<Point> p2List = new List<Point>();
            if (drawCheck.Checked == true && checkLine.Checked == false && checkDelete.Checked == false)

            {
                float emSize = 10;
                //Ve cac node
                g.DrawEllipse(p, cursor.X - 10, cursor.Y - 10, 20, 20);
                SolidBrush b1 = new SolidBrush(Color.CornflowerBlue);
                //To mau node
                g.FillEllipse(b1, cursor.X - 10, cursor.Y - 10, 20, 20);
                points[k++] = new Point(cursor.X, cursor.Y);
               
                //Đánh số cho các node
                g.DrawString(text1, new Font(FontFamily.GenericSansSerif, emSize, FontStyle.Regular),
                new SolidBrush(Color.Black), cursor.X + 10, cursor.Y + 10);
                cbfrom.Items.Add(text1);
                cbto.Items.Add(text1);



            }
            else if (drawCheck.Checked == false && checkLine.Checked == true && checkDelete.Checked == false)
            {
               
                //Lấy vị trí các node cần vẽ đường nối
                if (p1.X == 0)
                {
                    p1.X = cursor.X;
                    p1.Y = cursor.Y;
                    
                }
                else
                {
                    p2.X = cursor.X;
                    p2.Y = cursor.Y;
                    p1List.Add(p1);
                    p2List.Add(p2);
                    p1.X = 0;
                    
                }
                using (var p = new Pen(Color.LemonChiffon, 2))
                {
                    for (int x = 0; x < p1List.Count; x++)
                    {
                        //vẽ đường nối
                        g.DrawLine(p, p1List[x], p2List[x]);
                        var ptMed = new Point((p1List[x].X + p2List[x].X) / 2, (p1List[x].Y + p2List[x].Y) / 2);
                        var offset = g.MeasureString(tmp, this.Font);
                        ptMed.Y -= (int)offset.Height;
                        ptMed.X -= (int)offset.Width;
                        //Đánh trọng lượng cho đường
                        
                        g.DrawString(tmp, this.Font, Brushes.Chocolate, ptMed);
                        int imin = 20;
                        int iminn = 20;
                       
                        for (int ii = 0; ii < k; ii++)
                        {
                            double kc = Math.Sqrt(Math.Abs((points[ii].X - p1List[0].X)) * Math.Abs((points[ii].X - p1List[0].X)) + Math.Abs((points[ii].Y - p1List[0].Y)) * Math.Abs((points[ii].Y - p1List[0].Y)));
                            double kcc = Math.Sqrt(Math.Pow(Math.Abs((points[ii].X - p2List[0].X)), 2) + Math.Pow(Math.Abs((points[ii].Y - p2List[0].Y)), 2));
                           
                                if (kc < imin)
                                {
                                    ki = ii;
                                }
                            if (kcc < iminn)
                            {
                                jk = ii;
                            }
                        }
                        matr[ki, jk] = int.Parse(tmp);
                        matr[jk, ki] = int.Parse(tmp);
                    }

                }
                
            }
            else if(checkDelete.Checked==true && checkLine.Checked==false && drawCheck.Checked == false)
            {
                this.Invalidate();
                for(int i = 0; i < k; i++)
                {
                    points[i].X = points[i].Y = 0;
                    
                }
                k = 0;
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                txtWeight.Text = "";
                txtkq.Text = "";
                txtdodai.Text = "";
                listbox.Items.Clear();
            }
            
        }






       

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            tmp = objTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmpp = "";
            for (int j = 0; j < k; j++)
            {
                for (int v = 0; v < k; v++)

                {
                    tmpp += matr[j, v] + " ";


                }
                listbox.Items.Add(tmpp);
                tmpp = "";
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            tmp = txtWeight.Text;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
          
            int d = int.Parse(cbfrom.SelectedItem.ToString());
            int c = int.Parse(cbto.SelectedItem.ToString());
            Dijkstra(matr, k, d, c);
            if (txtkq.Text.Contains(c.ToString())==false)
            {
                txtkq.Text += c +" ";
            }
        }
        private void Dijkstra(int[,] matr, int k, int d, int c)
        {
            int[] S = new int[100];
            int[] Len = new int[100];
            int []P = new int[100];
            int  sum = 0;
            int i ;
          
            // nhap ma tran va tinh gia tri vo cung (sum)
            for (i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {

                    sum += matr[i, j];
                }
            }
            // dat vo cung cho tat ca cap canh khong noi voi nhau
            for (int t = 0; t < k; t++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (t!=j && matr[t,j] == 0)
                        matr[t,j] = sum;
                }
            }

            for (int j = 0; j < k; j++)
            {
                if (j != d)
                {
                    Len[j] = sum;                   // khoi tao do dai tu a toi moi dinh la vo cung
                    S[j] = 0;                       // danh sach cac diem da xet
                    P[j] = d;
                }// dat diem bat dau cua moi diem la a
            }

            Len[d] = 0;                         // dat do dai tu a -> a la 0

            // tim duong di ngan nhat tu 1 dinh den moi dinh khac thi thay bang vong for:
            //for (int k = 0; k < n; k++)

            while (S[c] == 0)
            {                 // trong khi diem cuoi chua duoc xet
                for (i = 0; i < k; i++)          // tim 1 vi tri ma khong phai la vo cung
                    if (S[i]==0 && Len[i] < sum)
                        break;

                // i >=n tuc la duyet het cac dinh ma khong the tim thay dinh b -> thoat
                if (i >= k)
                {

                    break;
                }

                for (int j = 0; j < k; j++)
                {    // tim diem co vi tri ma do dai la min
                    if (S[j]==0 && Len[i] > Len[j])
                    {
                        i = j;
                    }
                }

                S[i] = 1;                       // cho i vao danh sach xet roi

                for (int j = 0; j < k; j++)
                {    // tinh lai do dai cua cac diem chua xet
                    if (S[j]==0 && Len[i] + matr[i,j] < Len[j])
                    {
                        Len[j] = Len[i] + matr[i,j];      // thay doi len
                        P[j] = i;                       // danh dau diem truoc no
                    }
                }
            }

                txtdodai.Text =Len[c].ToString();
                if (Len[c] > 0 && Len[c] < sum)
                {
                // truy vet
               
                while (i!=d)
                    {
                    txtkq.Text += i.ToString() + "<==";
                    i = P[i];
                    }
                txtkq.Text += d.ToString()+" ";

            }
            else
                {
                txtkq.Text = "khong co duong di tu "+d+" "+"sang "+c;
                
                }
            

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Lấy vị trí
            cursor = this.PointToClient(Cursor.Position);

        }
        


    }
}
