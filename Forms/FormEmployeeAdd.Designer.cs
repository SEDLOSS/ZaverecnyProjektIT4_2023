namespace ZaverecnyProjektIT4_2023
{
    partial class FormEmployeeAdd
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
            this.Addbtn = new System.Windows.Forms.Button();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Name1txt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Birthtxt = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(230, 226);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(123, 36);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Text = "Přidat zaměstnance";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(153, 81);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(200, 20);
            this.Nametxt.TabIndex = 1;
            // 
            // Name1txt
            // 
            this.Name1txt.Location = new System.Drawing.Point(153, 107);
            this.Name1txt.Name = "Name1txt";
            this.Name1txt.Size = new System.Drawing.Size(200, 20);
            this.Name1txt.TabIndex = 2;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(153, 159);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(200, 20);
            this.Emailtxt.TabIndex = 3;
            // 
            // Phonetxt
            // 
            this.Phonetxt.Location = new System.Drawing.Point(153, 185);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(200, 20);
            this.Phonetxt.TabIndex = 4;
            this.Phonetxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(115, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zaměstnanec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jméno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Příjmení";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum narození";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefon";
            // 
            // Birthtxt
            // 
            this.Birthtxt.Location = new System.Drawing.Point(153, 133);
            this.Birthtxt.Name = "Birthtxt";
            this.Birthtxt.Size = new System.Drawing.Size(200, 20);
            this.Birthtxt.TabIndex = 11;
            // 
            // FormEmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 298);
            this.Controls.Add(this.Birthtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phonetxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Name1txt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Addbtn);
            this.MaximizeBox = false;
            this.Name = "FormEmployeeAdd";
            this.ShowIcon = false;
            this.Text = "Zaměstnanec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Name1txt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Birthtxt;
    }
}