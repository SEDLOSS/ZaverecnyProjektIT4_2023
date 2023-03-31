namespace ZaverecnyProjektIT4_2023
{
    partial class FormContractADD
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
            this.Customertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Desctriptiontxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Customertxt
            // 
            this.Customertxt.Location = new System.Drawing.Point(94, 72);
            this.Customertxt.Name = "Customertxt";
            this.Customertxt.Size = new System.Drawing.Size(155, 20);
            this.Customertxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zakázka";
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(158, 224);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(91, 42);
            this.Addbtn.TabIndex = 2;
            this.Addbtn.Text = "přidat/upravit zakázku";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zákazník";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Popis";
            // 
            // Desctriptiontxt
            // 
            this.Desctriptiontxt.Location = new System.Drawing.Point(94, 112);
            this.Desctriptiontxt.Multiline = true;
            this.Desctriptiontxt.Name = "Desctriptiontxt";
            this.Desctriptiontxt.Size = new System.Drawing.Size(155, 88);
            this.Desctriptiontxt.TabIndex = 5;
            // 
            // FormContractADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 292);
            this.Controls.Add(this.Desctriptiontxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Customertxt);
            this.Name = "FormContractADD";
            this.ShowIcon = false;
            this.Text = "Zakázky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Customertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Desctriptiontxt;
    }
}