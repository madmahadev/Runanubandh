namespace WindowsFormsApplication1
{
    partial class frminterestsub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminterestsub));
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbmember = new System.Windows.Forms.ComboBox();
            this.cmbdate = new System.Windows.Forms.ComboBox();
            this.cmbmonth = new System.Windows.Forms.ComboBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblrem = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            this.btnsubmit.ForeColor = System.Drawing.Color.Blue;
            this.btnsubmit.Location = new System.Drawing.Point(270, 287);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(85, 32);
            this.btnsubmit.TabIndex = 0;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // btncancle
            // 
            this.btncancle.ForeColor = System.Drawing.Color.Blue;
            this.btncancle.Location = new System.Drawing.Point(166, 287);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(86, 32);
            this.btncancle.TabIndex = 1;
            this.btncancle.Text = "Cancle";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Member Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(54, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Date Of Loan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(32, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Month Of Interest";
            // 
            // cmbmember
            // 
            this.cmbmember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbmember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbmember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmember.ForeColor = System.Drawing.Color.Blue;
            this.cmbmember.FormattingEnabled = true;
            this.cmbmember.Location = new System.Drawing.Point(207, 12);
            this.cmbmember.Name = "cmbmember";
            this.cmbmember.Size = new System.Drawing.Size(161, 23);
            this.cmbmember.TabIndex = 6;
            this.cmbmember.SelectedValueChanged += new System.EventHandler(this.cmbmember_SelectedValueChanged);
            // 
            // cmbdate
            // 
            this.cmbdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdate.ForeColor = System.Drawing.Color.Blue;
            this.cmbdate.FormattingEnabled = true;
            this.cmbdate.Location = new System.Drawing.Point(207, 73);
            this.cmbdate.Name = "cmbdate";
            this.cmbdate.Size = new System.Drawing.Size(161, 23);
            this.cmbdate.TabIndex = 7;
            this.cmbdate.SelectedValueChanged += new System.EventHandler(this.cmbdate_SelectedValueChanged);
            // 
            // cmbmonth
            // 
            this.cmbmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmonth.ForeColor = System.Drawing.Color.Blue;
            this.cmbmonth.FormattingEnabled = true;
            this.cmbmonth.Location = new System.Drawing.Point(207, 133);
            this.cmbmonth.Name = "cmbmonth";
            this.cmbmonth.Size = new System.Drawing.Size(161, 23);
            this.cmbmonth.TabIndex = 8;
            this.cmbmonth.SelectedValueChanged += new System.EventHandler(this.cmbmonth_SelectedValueChanged);
            // 
            // txtamount
            // 
            this.txtamount.ForeColor = System.Drawing.Color.Blue;
            this.txtamount.Location = new System.Drawing.Point(203, 232);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(152, 21);
            this.txtamount.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(24, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Amount To Be Submitted:";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.ForeColor = System.Drawing.Color.Blue;
            this.lable1.Location = new System.Drawing.Point(413, 15);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(79, 15);
            this.lable1.TabIndex = 12;
            this.lable1.Text = "loan Status";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.ForeColor = System.Drawing.Color.Blue;
            this.lable2.Location = new System.Drawing.Point(518, 15);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(124, 15);
            this.lable2.TabIndex = 13;
            this.lable2.Text = "remaining Amount";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.ForeColor = System.Drawing.Color.Red;
            this.lblstatus.Location = new System.Drawing.Point(429, 83);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 15);
            this.lblstatus.TabIndex = 14;
            // 
            // lblrem
            // 
            this.lblrem.AutoSize = true;
            this.lblrem.ForeColor = System.Drawing.Color.Red;
            this.lblrem.Location = new System.Drawing.Point(572, 83);
            this.lblrem.Name = "lblrem";
            this.lblrem.Size = new System.Drawing.Size(0, 15);
            this.lblrem.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(11, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Select Date  Of Submission:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // lblst
            // 
            this.lblst.AutoSize = true;
            this.lblst.Location = new System.Drawing.Point(382, 235);
            this.lblst.Name = "lblst";
            this.lblst.Size = new System.Drawing.Size(47, 15);
            this.lblst.TabIndex = 18;
            this.lblst.Text = "label4";
            // 
            // frminterestsub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 369);
            this.Controls.Add(this.lblst);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblrem);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.cmbmonth);
            this.Controls.Add(this.cmbdate);
            this.Controls.Add(this.cmbmember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnsubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frminterestsub";
            this.Text = "Submit Loan Interest";
            this.Load += new System.EventHandler(this.frminterestsub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbmember;
        private System.Windows.Forms.ComboBox cmbdate;
        private System.Windows.Forms.ComboBox cmbmonth;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblrem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblst;
    }
}