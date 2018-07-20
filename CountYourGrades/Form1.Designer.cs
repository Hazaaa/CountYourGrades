namespace CountYourGrades
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txbIspit = new System.Windows.Forms.TextBox();
            this.txbOcena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnIspit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOcena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblbrojIspita = new System.Windows.Forms.Label();
            this.lblprosek = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course:";
            // 
            // txbIspit
            // 
            this.txbIspit.Location = new System.Drawing.Point(87, 22);
            this.txbIspit.Name = "txbIspit";
            this.txbIspit.Size = new System.Drawing.Size(139, 20);
            this.txbIspit.TabIndex = 1;
            // 
            // txbOcena
            // 
            this.txbOcena.Location = new System.Drawing.Point(87, 48);
            this.txbOcena.Name = "txbOcena";
            this.txbOcena.Size = new System.Drawing.Size(139, 20);
            this.txbOcena.TabIndex = 3;
            this.txbOcena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbOcena_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grade:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIspit,
            this.columnOcena});
            this.listView1.Location = new System.Drawing.Point(256, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(215, 163);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnIspit
            // 
            this.columnIspit.Text = "Course";
            this.columnIspit.Width = 150;
            // 
            // columnOcena
            // 
            this.columnOcena.Text = "Grade";
            this.columnOcena.Width = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Load saved data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of passed courses:";
            // 
            // lblbrojIspita
            // 
            this.lblbrojIspita.AutoSize = true;
            this.lblbrojIspita.Location = new System.Drawing.Point(165, 157);
            this.lblbrojIspita.Name = "lblbrojIspita";
            this.lblbrojIspita.Size = new System.Drawing.Size(56, 13);
            this.lblbrojIspita.TabIndex = 8;
            this.lblbrojIspita.Text = "#brojIspita";
            // 
            // lblprosek
            // 
            this.lblprosek.AutoSize = true;
            this.lblprosek.Location = new System.Drawing.Point(165, 185);
            this.lblprosek.Name = "lblprosek";
            this.lblprosek.Size = new System.Drawing.Size(46, 13);
            this.lblprosek.TabIndex = 10;
            this.lblprosek.Text = "#prosek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Avrage grade:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 231);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblprosek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblbrojIspita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbOcena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIspit);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Count Your Grades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIspit;
        private System.Windows.Forms.TextBox txbOcena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnIspit;
        private System.Windows.Forms.ColumnHeader columnOcena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblbrojIspita;
        private System.Windows.Forms.Label lblprosek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}

