namespace ZaverecnyProjektIT4_2023
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginbutton = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(69, 221);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "Přihlásit";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click_1);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(92, 52);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(38, 13);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "Jméno";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(47, 85);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(125, 20);
            this.nametextBox.TabIndex = 2;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(47, 158);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(125, 20);
            this.passwordtextBox.TabIndex = 3;
            this.passwordtextBox.UseSystemPasswordChar = true;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(92, 130);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(34, 13);
            this.passwordlabel.TabIndex = 4;
            this.passwordlabel.Text = "Heslo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 277);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.loginbutton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Přihlášení";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label passwordlabel;
    }
}

