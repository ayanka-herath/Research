namespace Research
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
            this.label1 = new System.Windows.Forms.Label();
            this.SQL_txtbox = new System.Windows.Forms.TextBox();
            this.Tokenization_btn = new System.Windows.Forms.Button();
            this.Syntax_btn = new System.Windows.Forms.Button();
            this.Tagged_btn = new System.Windows.Forms.Button();
            this.tok_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.POSTag_txtbox = new System.Windows.Forms.TextBox();
            this.POS = new System.Windows.Forms.Label();
            this.syntax_txtbox = new System.Windows.Forms.RichTextBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.Employee_Table = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Query:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SQL_txtbox
            // 
            this.SQL_txtbox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQL_txtbox.Location = new System.Drawing.Point(130, 89);
            this.SQL_txtbox.Multiline = true;
            this.SQL_txtbox.Name = "SQL_txtbox";
            this.SQL_txtbox.Size = new System.Drawing.Size(766, 31);
            this.SQL_txtbox.TabIndex = 1;
            this.SQL_txtbox.TextChanged += new System.EventHandler(this.SQL_txtbox_TextChanged);
            // 
            // Tokenization_btn
            // 
            this.Tokenization_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tokenization_btn.Location = new System.Drawing.Point(19, 152);
            this.Tokenization_btn.Name = "Tokenization_btn";
            this.Tokenization_btn.Size = new System.Drawing.Size(119, 42);
            this.Tokenization_btn.TabIndex = 5;
            this.Tokenization_btn.Text = "Tokenization";
            this.Tokenization_btn.UseVisualStyleBackColor = true;
            this.Tokenization_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Syntax_btn
            // 
            this.Syntax_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syntax_btn.Location = new System.Drawing.Point(250, 152);
            this.Syntax_btn.Name = "Syntax_btn";
            this.Syntax_btn.Size = new System.Drawing.Size(119, 42);
            this.Syntax_btn.TabIndex = 6;
            this.Syntax_btn.Text = "Syntax Analyzer";
            this.Syntax_btn.UseVisualStyleBackColor = true;
            this.Syntax_btn.Click += new System.EventHandler(this.Syntax_btn_Click);
            // 
            // Tagged_btn
            // 
            this.Tagged_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tagged_btn.Location = new System.Drawing.Point(500, 152);
            this.Tagged_btn.Name = "Tagged_btn";
            this.Tagged_btn.Size = new System.Drawing.Size(119, 42);
            this.Tagged_btn.TabIndex = 7;
            this.Tagged_btn.Text = "Tagged Part of Speech";
            this.Tagged_btn.UseVisualStyleBackColor = true;
            this.Tagged_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // tok_txtbox
            // 
            this.tok_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tok_txtbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tok_txtbox.Location = new System.Drawing.Point(130, 240);
            this.tok_txtbox.Multiline = true;
            this.tok_txtbox.Name = "tok_txtbox";
            this.tok_txtbox.Size = new System.Drawing.Size(766, 42);
            this.tok_txtbox.TabIndex = 8;
            this.tok_txtbox.TextChanged += new System.EventHandler(this.tok_txtbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tokenization \r\nOutput: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "Relational :\r\nAlgebra\r\nExpression";
            // 
            // POSTag_txtbox
            // 
            this.POSTag_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSTag_txtbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.POSTag_txtbox.Location = new System.Drawing.Point(130, 400);
            this.POSTag_txtbox.Multiline = true;
            this.POSTag_txtbox.Name = "POSTag_txtbox";
            this.POSTag_txtbox.Size = new System.Drawing.Size(766, 49);
            this.POSTag_txtbox.TabIndex = 11;
            this.POSTag_txtbox.TextChanged += new System.EventHandler(this.POSTag_txtbox_TextChanged);
            // 
            // POS
            // 
            this.POS.AutoSize = true;
            this.POS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POS.Location = new System.Drawing.Point(12, 422);
            this.POS.Name = "POS";
            this.POS.Size = new System.Drawing.Size(67, 15);
            this.POS.TabIndex = 12;
            this.POS.Text = "POS Tag:";
            this.POS.Click += new System.EventHandler(this.label4_Click);
            // 
            // syntax_txtbox
            // 
            this.syntax_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syntax_txtbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.syntax_txtbox.Location = new System.Drawing.Point(130, 323);
            this.syntax_txtbox.Name = "syntax_txtbox";
            this.syntax_txtbox.ReadOnly = true;
            this.syntax_txtbox.Size = new System.Drawing.Size(766, 46);
            this.syntax_txtbox.TabIndex = 13;
            this.syntax_txtbox.Text = "";
            this.syntax_txtbox.TextChanged += new System.EventHandler(this.syntax_txtbox_TextChanged);
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(751, 152);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(119, 42);
            this.clear_btn.TabIndex = 14;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Employee_Table
            // 
            this.Employee_Table.AutoSize = true;
            this.Employee_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Table.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Employee_Table.Location = new System.Drawing.Point(12, 9);
            this.Employee_Table.Name = "Employee_Table";
            this.Employee_Table.Size = new System.Drawing.Size(588, 16);
            this.Employee_Table.TabIndex = 16;
            this.Employee_Table.Text = "Table 1: Employee (Fname:String, Lname:String, Address:String, Age:Int, Dno:Strin" +
    "g)\r\n";
            this.Employee_Table.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Table 2: Department (Dno:String, Dname:String)\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 498);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Employee_Table);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.syntax_txtbox);
            this.Controls.Add(this.POS);
            this.Controls.Add(this.POSTag_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tok_txtbox);
            this.Controls.Add(this.Tagged_btn);
            this.Controls.Add(this.Syntax_btn);
            this.Controls.Add(this.Tokenization_btn);
            this.Controls.Add(this.SQL_txtbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SQL_txtbox;
        private System.Windows.Forms.Button Tokenization_btn;
        private System.Windows.Forms.Button Syntax_btn;
        private System.Windows.Forms.Button Tagged_btn;
        private System.Windows.Forms.TextBox tok_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox POSTag_txtbox;
        private System.Windows.Forms.Label POS;
        private System.Windows.Forms.RichTextBox syntax_txtbox;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label Employee_Table;
        private System.Windows.Forms.Label label4;
    }
}

