namespace WindowsFormsApplication1
{
    partial class frmofferloan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmofferloan));
            this.btnoffer = new System.Windows.Forms.Button();
            this.cmbmember = new System.Windows.Forms.ComboBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.btncancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnoffer
            // 
            this.btnoffer.Location = new System.Drawing.Point(140, 214);
            this.btnoffer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnoffer.Name = "btnoffer";
            this.btnoffer.Size = new System.Drawing.Size(112, 28);
            this.btnoffer.TabIndex = 2;
            this.btnoffer.Text = "Offer Loan";
            this.btnoffer.UseVisualStyleBackColor = true;
            this.btnoffer.Click += new System.EventHandler(this.btnoffer_Click);
            // 
            // cmbmember
            // 
            this.cmbmember.FormattingEnabled = true;
            this.cmbmember.Location = new System.Drawing.Point(61, 152);
            this.cmbmember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbmember.Name = "cmbmember";
            this.cmbmember.Size = new System.Drawing.Size(180, 24);
            this.cmbmember.TabIndex = 0;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(282, 152);
            this.txtamount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(148, 22);
            this.txtamount.TabIndex = 1;
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(272, 214);
            this.btncancle.Margin = new System.Windows.Forms.Padding(4);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(112, 28);
            this.btncancle.TabIndex = 3;
            this.btncancle.Text = "Cancle";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Member Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Amount";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Date";
            // 
            // frmofferloan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 281);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.cmbmember);
            this.Controls.Add(this.btnoffer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmofferloan";
            this.Text = "Offer Loan";
            this.Load += new System.EventHandler(this.frmofferloan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnoffer;
        private System.Windows.Forms.ComboBox cmbmember;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}