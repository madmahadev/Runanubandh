namespace WindowsFormsApplication1
{
    partial class frmAcceptmonthly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceptmonthly));
            this.cmbmember = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaccept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.btncancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbmember
            // 
            this.cmbmember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbmember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbmember.FormattingEnabled = true;
            this.cmbmember.Location = new System.Drawing.Point(17, 113);
            this.cmbmember.Margin = new System.Windows.Forms.Padding(4);
            this.cmbmember.Name = "cmbmember";
            this.cmbmember.Size = new System.Drawing.Size(180, 24);
            this.cmbmember.Sorted = true;
            this.cmbmember.TabIndex = 0;
            this.cmbmember.SelectedIndexChanged += new System.EventHandler(this.cmbmember_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Member:";
            // 
            // btnaccept
            // 
            this.btnaccept.Location = new System.Drawing.Point(139, 189);
            this.btnaccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(112, 28);
            this.btnaccept.TabIndex = 2;
            this.btnaccept.Text = "Accept";
            this.btnaccept.UseVisualStyleBackColor = true;
            this.btnaccept.Click += new System.EventHandler(this.btnaccept_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Amount:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 50);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Date";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(318, 116);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(155, 22);
            this.txtamount.TabIndex = 7;
            this.txtamount.Text = "500";
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(295, 189);
            this.btncancle.Margin = new System.Windows.Forms.Padding(4);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(112, 28);
            this.btncancle.TabIndex = 8;
            this.btncancle.Text = "Cancle";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // frmAcceptmonthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 306);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbmember);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Magenta;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAcceptmonthly";
            this.Text = "Accept Monthly Installment";
            this.Load += new System.EventHandler(this.Acceptmonthly_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbmember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaccept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Button btncancle;
    }
}