namespace ZaverecnyProjektIT4_2023
{
    partial class FormLogin
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
            this.Loginbtn = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(69, 213);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 23);
            this.Loginbtn.TabIndex = 0;
            this.Loginbtn.Text = "Přihlásit";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.loginbutton_Click_1);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.namelabel.Location = new System.Drawing.Point(86, 53);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(48, 16);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "Jméno";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(47, 85);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(125, 20);
            this.Nametxt.TabIndex = 2;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(47, 158);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(125, 20);
            this.Passwordtxt.TabIndex = 3;
            this.Passwordtxt.UseSystemPasswordChar = true;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordlabel.Location = new System.Drawing.Point(86, 130);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(43, 16);
            this.passwordlabel.TabIndex = 4;
            this.passwordlabel.Text = "Heslo";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 277);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.Loginbtn);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.Text = "Přihlášení";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label passwordlabel;
    }
}

