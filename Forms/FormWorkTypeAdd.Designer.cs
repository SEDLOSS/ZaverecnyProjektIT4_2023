﻿namespace ZaverecnyProjektIT4_2023
{
    partial class FormWorkTypeAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Descriptiontxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(166, 229);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Text = "button1";
            this.Addbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Přidání typu práce";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(88, 99);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(153, 20);
            this.Nametxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Název";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Popis";
            // 
            // Descriptiontxt
            // 
            this.Descriptiontxt.Location = new System.Drawing.Point(88, 132);
            this.Descriptiontxt.Multiline = true;
            this.Descriptiontxt.Name = "Descriptiontxt";
            this.Descriptiontxt.Size = new System.Drawing.Size(153, 73);
            this.Descriptiontxt.TabIndex = 5;
            this.Descriptiontxt.TextChanged += new System.EventHandler(this.Descriptiontxt_TextChanged);
            // 
            // FormWorkTypeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 289);
            this.Controls.Add(this.Descriptiontxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Addbtn);
            this.Name = "FormWorkTypeAdd";
            this.ShowIcon = false;
            this.Text = "Přidání typu práce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Descriptiontxt;
    }
}