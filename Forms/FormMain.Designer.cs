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
            this.EmployeeAddbtn = new System.Windows.Forms.Button();
            this.EmployeeEdtbtn = new System.Windows.Forms.Button();
            this.EmployeeDltbtn = new System.Windows.Forms.Button();
            this.ContractAddbtn = new System.Windows.Forms.Button();
            this.ContractEdtbtn = new System.Windows.Forms.Button();
            this.ContractDltbtn = new System.Windows.Forms.Button();
            this.EmployeeListview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContractListview = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkListview = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkAddbtn = new System.Windows.Forms.Button();
            this.WorkEdtbtn = new System.Windows.Forms.Button();
            this.WorkDelbtn = new System.Windows.Forms.Button();
            this.EmployeeSearchtxt = new System.Windows.Forms.TextBox();
            this.ContractSearchtxt = new System.Windows.Forms.TextBox();
            this.WorkSearchtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeAddbtn
            // 
            this.EmployeeAddbtn.Location = new System.Drawing.Point(19, 672);
            this.EmployeeAddbtn.Name = "EmployeeAddbtn";
            this.EmployeeAddbtn.Size = new System.Drawing.Size(148, 50);
            this.EmployeeAddbtn.TabIndex = 1;
            this.EmployeeAddbtn.Text = "Přidání zaměstnance";
            this.EmployeeAddbtn.UseVisualStyleBackColor = true;
            this.EmployeeAddbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeEdtbtn
            // 
            this.EmployeeEdtbtn.Location = new System.Drawing.Point(190, 672);
            this.EmployeeEdtbtn.Name = "EmployeeEdtbtn";
            this.EmployeeEdtbtn.Size = new System.Drawing.Size(148, 50);
            this.EmployeeEdtbtn.TabIndex = 2;
            this.EmployeeEdtbtn.Text = "Úprava zaměstnance";
            this.EmployeeEdtbtn.UseVisualStyleBackColor = true;
            // 
            // EmployeeDltbtn
            // 
            this.EmployeeDltbtn.Location = new System.Drawing.Point(362, 672);
            this.EmployeeDltbtn.Name = "EmployeeDltbtn";
            this.EmployeeDltbtn.Size = new System.Drawing.Size(148, 50);
            this.EmployeeDltbtn.TabIndex = 3;
            this.EmployeeDltbtn.Text = "Smazání zaměstnance";
            this.EmployeeDltbtn.UseVisualStyleBackColor = true;
            // 
            // ContractAddbtn
            // 
            this.ContractAddbtn.Location = new System.Drawing.Point(778, 672);
            this.ContractAddbtn.Name = "ContractAddbtn";
            this.ContractAddbtn.Size = new System.Drawing.Size(114, 50);
            this.ContractAddbtn.TabIndex = 4;
            this.ContractAddbtn.Text = "Přidání zakázky";
            this.ContractAddbtn.UseVisualStyleBackColor = true;
            // 
            // ContractEdtbtn
            // 
            this.ContractEdtbtn.Location = new System.Drawing.Point(915, 672);
            this.ContractEdtbtn.Name = "ContractEdtbtn";
            this.ContractEdtbtn.Size = new System.Drawing.Size(114, 50);
            this.ContractEdtbtn.TabIndex = 5;
            this.ContractEdtbtn.Text = "Úprava zakázky";
            this.ContractEdtbtn.UseVisualStyleBackColor = true;
            // 
            // ContractDltbtn
            // 
            this.ContractDltbtn.Location = new System.Drawing.Point(1048, 672);
            this.ContractDltbtn.Name = "ContractDltbtn";
            this.ContractDltbtn.Size = new System.Drawing.Size(113, 50);
            this.ContractDltbtn.TabIndex = 6;
            this.ContractDltbtn.Text = "Smazání zakázky";
            this.ContractDltbtn.UseVisualStyleBackColor = true;
            this.ContractDltbtn.Click += new System.EventHandler(this.gatherUsersButton_Click_Click);
            // 
            // EmployeeListview
            // 
            this.EmployeeListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.EmployeeListview.HideSelection = false;
            this.EmployeeListview.Location = new System.Drawing.Point(19, 143);
            this.EmployeeListview.Name = "EmployeeListview";
            this.EmployeeListview.Size = new System.Drawing.Size(644, 503);
            this.EmployeeListview.TabIndex = 7;
            this.EmployeeListview.UseCompatibleStateImageBehavior = false;
            this.EmployeeListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jméno";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Příjmení";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum narození";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Telefonni číslo";
            this.columnHeader6.Width = 150;
            // 
            // ContractListview
            // 
            this.ContractListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.ContractListview.HideSelection = false;
            this.ContractListview.Location = new System.Drawing.Point(779, 143);
            this.ContractListview.Name = "ContractListview";
            this.ContractListview.Size = new System.Drawing.Size(382, 503);
            this.ContractListview.TabIndex = 8;
            this.ContractListview.UseCompatibleStateImageBehavior = false;
            this.ContractListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 30;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Zákazník";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Popis";
            this.columnHeader9.Width = 200;
            // 
            // WorkListview
            // 
            this.WorkListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.WorkListview.HideSelection = false;
            this.WorkListview.Location = new System.Drawing.Point(1278, 143);
            this.WorkListview.Name = "WorkListview";
            this.WorkListview.Size = new System.Drawing.Size(383, 503);
            this.WorkListview.TabIndex = 9;
            this.WorkListview.UseCompatibleStateImageBehavior = false;
            this.WorkListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            this.columnHeader10.Width = 30;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Název";
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Popis";
            this.columnHeader12.Width = 200;
            // 
            // WorkAddbtn
            // 
            this.WorkAddbtn.Location = new System.Drawing.Point(1278, 672);
            this.WorkAddbtn.Name = "WorkAddbtn";
            this.WorkAddbtn.Size = new System.Drawing.Size(113, 50);
            this.WorkAddbtn.TabIndex = 10;
            this.WorkAddbtn.Text = "Přidání práce";
            this.WorkAddbtn.UseVisualStyleBackColor = true;
            // 
            // WorkEdtbtn
            // 
            this.WorkEdtbtn.Location = new System.Drawing.Point(1416, 672);
            this.WorkEdtbtn.Name = "WorkEdtbtn";
            this.WorkEdtbtn.Size = new System.Drawing.Size(113, 50);
            this.WorkEdtbtn.TabIndex = 11;
            this.WorkEdtbtn.Text = "Úprava práce";
            this.WorkEdtbtn.UseVisualStyleBackColor = true;
            // 
            // WorkDelbtn
            // 
            this.WorkDelbtn.Location = new System.Drawing.Point(1548, 672);
            this.WorkDelbtn.Name = "WorkDelbtn";
            this.WorkDelbtn.Size = new System.Drawing.Size(113, 50);
            this.WorkDelbtn.TabIndex = 12;
            this.WorkDelbtn.Text = "Smazání Práce";
            this.WorkDelbtn.UseVisualStyleBackColor = true;
            // 
            // EmployeeSearchtxt
            // 
            this.EmployeeSearchtxt.Location = new System.Drawing.Point(170, 782);
            this.EmployeeSearchtxt.Name = "EmployeeSearchtxt";
            this.EmployeeSearchtxt.Size = new System.Drawing.Size(188, 20);
            this.EmployeeSearchtxt.TabIndex = 13;
            // 
            // ContractSearchtxt
            // 
            this.ContractSearchtxt.Location = new System.Drawing.Point(878, 782);
            this.ContractSearchtxt.Name = "ContractSearchtxt";
            this.ContractSearchtxt.Size = new System.Drawing.Size(188, 20);
            this.ContractSearchtxt.TabIndex = 14;
            // 
            // WorkSearchtxt
            // 
            this.WorkSearchtxt.Location = new System.Drawing.Point(1383, 782);
            this.WorkSearchtxt.Name = "WorkSearchtxt";
            this.WorkSearchtxt.Size = new System.Drawing.Size(188, 20);
            this.WorkSearchtxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 757);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vyhledávání";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(941, 757);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Vyhledávání";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1440, 757);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Vyhledávání";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(1435, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Přihlášen jako:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.Usernamelbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 84);
            this.panel1.TabIndex = 20;
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Usernamelbl.Location = new System.Drawing.Point(1552, 25);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(132, 30);
            this.Usernamelbl.TabIndex = 20;
            this.Usernamelbl.Text = "(uzivatel)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(255, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Zaměstnanci";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(915, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Zakázky";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(1438, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Práce";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 873);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WorkSearchtxt);
            this.Controls.Add(this.ContractSearchtxt);
            this.Controls.Add(this.EmployeeSearchtxt);
            this.Controls.Add(this.WorkDelbtn);
            this.Controls.Add(this.WorkEdtbtn);
            this.Controls.Add(this.WorkAddbtn);
            this.Controls.Add(this.WorkListview);
            this.Controls.Add(this.ContractListview);
            this.Controls.Add(this.EmployeeListview);
            this.Controls.Add(this.ContractDltbtn);
            this.Controls.Add(this.ContractEdtbtn);
            this.Controls.Add(this.ContractAddbtn);
            this.Controls.Add(this.EmployeeDltbtn);
            this.Controls.Add(this.EmployeeEdtbtn);
            this.Controls.Add(this.EmployeeAddbtn);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            this.Text = "Přehled";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EmployeeAddbtn;
        private System.Windows.Forms.Button EmployeeEdtbtn;
        private System.Windows.Forms.Button EmployeeDltbtn;
        private System.Windows.Forms.Button ContractAddbtn;
        private System.Windows.Forms.Button ContractEdtbtn;
        private System.Windows.Forms.Button ContractDltbtn;
        private System.Windows.Forms.ListView EmployeeListview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView ContractListview;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView WorkListview;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button WorkAddbtn;
        private System.Windows.Forms.Button WorkEdtbtn;
        private System.Windows.Forms.Button WorkDelbtn;
        private System.Windows.Forms.TextBox EmployeeSearchtxt;
        private System.Windows.Forms.TextBox ContractSearchtxt;
        private System.Windows.Forms.TextBox WorkSearchtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}