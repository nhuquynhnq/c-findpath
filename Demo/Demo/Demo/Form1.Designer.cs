namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawCheck = new System.Windows.Forms.CheckBox();
            this.checkLine = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbfrom = new System.Windows.Forms.ComboBox();
            this.cbto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdodai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkDelete = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawCheck
            // 
            this.drawCheck.AutoSize = true;
            this.drawCheck.Location = new System.Drawing.Point(9, 31);
            this.drawCheck.Name = "drawCheck";
            this.drawCheck.Size = new System.Drawing.Size(80, 17);
            this.drawCheck.TabIndex = 0;
            this.drawCheck.Text = "Draw Node";
            this.drawCheck.UseVisualStyleBackColor = true;
            // 
            // checkLine
            // 
            this.checkLine.AutoSize = true;
            this.checkLine.Location = new System.Drawing.Point(92, 31);
            this.checkLine.Name = "checkLine";
            this.checkLine.Size = new System.Drawing.Size(79, 17);
            this.checkLine.TabIndex = 2;
            this.checkLine.Text = "Draw Lines";
            this.checkLine.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(72, 66);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(121, 20);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Find Path:";
            // 
            // cbfrom
            // 
            this.cbfrom.FormattingEnabled = true;
            this.cbfrom.Location = new System.Drawing.Point(72, 113);
            this.cbfrom.Name = "cbfrom";
            this.cbfrom.Size = new System.Drawing.Size(121, 21);
            this.cbfrom.TabIndex = 6;
            // 
            // cbto
            // 
            this.cbto.FormattingEnabled = true;
            this.cbto.Location = new System.Drawing.Point(72, 148);
            this.cbto.Name = "cbto";
            this.cbto.Size = new System.Drawing.Size(121, 21);
            this.cbto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total:";
            // 
            // txtdodai
            // 
            this.txtdodai.Location = new System.Drawing.Point(63, 247);
            this.txtdodai.Name = "txtdodai";
            this.txtdodai.Size = new System.Drawing.Size(121, 20);
            this.txtdodai.TabIndex = 11;
            this.txtdodai.TextChanged += new System.EventHandler(this.txtdodai_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Path:";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(63, 221);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(121, 20);
            this.txtkq.TabIndex = 13;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(88, 182);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 16;
            // 
            // checkDelete
            // 
            this.checkDelete.AutoSize = true;
            this.checkDelete.Location = new System.Drawing.Point(177, 31);
            this.checkDelete.Name = "checkDelete";
            this.checkDelete.Size = new System.Drawing.Size(57, 17);
            this.checkDelete.TabIndex = 17;
            this.checkDelete.Text = "Delete";
            this.checkDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listbox);
            this.groupBox1.Controls.Add(this.drawCheck);
            this.groupBox1.Controls.Add(this.checkDelete);
            this.groupBox1.Controls.Add(this.txtdodai);
            this.groupBox1.Controls.Add(this.txtkq);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkLine);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbfrom);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 449);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Show matrix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(9, 312);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(257, 121);
            this.listbox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Text = "Find Shortest Path";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox drawCheck;
        private System.Windows.Forms.CheckBox checkLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbfrom;
        private System.Windows.Forms.ComboBox cbto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdodai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button button1;
    }
}