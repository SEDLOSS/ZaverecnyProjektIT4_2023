namespace ZaverecnyProjektIT4_2023
{
    partial class FormAddUser
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
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Isadmintxt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(31, 235);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(121, 23);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Text = "Přidat uživatele";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(31, 65);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(121, 20);
            this.Nametxt.TabIndex = 1;
            this.Nametxt.TextChanged += new System.EventHandler(this.Nametxt_TextChanged);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(31, 135);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(121, 20);
            this.Passwordtxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Heslo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Isadmintxt
            // 
            this.Isadmintxt.FormattingEnabled = true;
            this.Isadmintxt.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.Isadmintxt.Location = new System.Drawing.Point(31, 191);
            this.Isadmintxt.Name = "Isadmintxt";
            this.Isadmintxt.Size = new System.Drawing.Size(121, 21);
            this.Isadmintxt.TabIndex = 6;
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 296);
            this.Controls.Add(this.Isadmintxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Addbtn);
            this.Name = "FormAddUser";
            this.ShowIcon = false;
            this.Text = "Přidej uživatele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Isadmintxt;
    }
}