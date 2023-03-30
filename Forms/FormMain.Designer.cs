namespace ZaverecnyProjektIT4_2023
{
    partial class main
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
            this.mainlistview = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Roleid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gatherUsersButton_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainlistview
            // 
            this.mainlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.newname,
            this.Roleid});
            this.mainlistview.FullRowSelect = true;
            this.mainlistview.HideSelection = false;
            this.mainlistview.Location = new System.Drawing.Point(12, 106);
            this.mainlistview.Name = "mainlistview";
            this.mainlistview.Size = new System.Drawing.Size(686, 425);
            this.mainlistview.TabIndex = 0;
            this.mainlistview.UseCompatibleStateImageBehavior = false;
            this.mainlistview.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 200;
            // 
            // newname
            // 
            this.newname.Text = "Jméno";
            this.newname.Width = 200;
            // 
            // Roleid
            // 
            this.Roleid.Text = "ID role";
            this.Roleid.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(803, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(818, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // gatherUsersButton_Click
            // 
            this.gatherUsersButton_Click.Location = new System.Drawing.Point(773, 150);
            this.gatherUsersButton_Click.Name = "gatherUsersButton_Click";
            this.gatherUsersButton_Click.Size = new System.Drawing.Size(75, 23);
            this.gatherUsersButton_Click.TabIndex = 6;
            this.gatherUsersButton_Click.Text = "Zobrazit uživatele";
            this.gatherUsersButton_Click.UseVisualStyleBackColor = true;
            this.gatherUsersButton_Click.Click += new System.EventHandler(this.gatherUsersButton_Click_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 588);
            this.Controls.Add(this.gatherUsersButton_Click);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainlistview);
            this.Name = "main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView mainlistview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button gatherUsersButton_Click;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader newname;
        private System.Windows.Forms.ColumnHeader Roleid;
    }
}