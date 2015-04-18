namespace WindowsFormsApplication1
{
    partial class frmloaninterest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmloaninterest));
            this.cmbmember = new System.Windows.Forms.ComboBox();
            this.cmbamount = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnaccept = new System.Windows.Forms.Button();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbmember
            // 
            this.cmbmember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbmember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbmember.FormattingEnabled = true;
            this.cmbmember.Location = new System.Drawing.Point(274, 12);
            this.cmbmember.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbmember.Name = "cmbmember";
            this.cmbmember.Size = new System.Drawing.Size(190, 23);
            this.cmbmember.TabIndex = 0;
            this.cmbmember.SelectedValueChanged += new System.EventHandler(this.cmbmember_SelectedValueChanged);
            // 
            // cmbamount
            // 
            this.cmbamount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbamount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbamount.FormattingEnabled = true;
            this.cmbamount.Location = new System.Drawing.Point(274, 77);
            this.cmbamount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbamount.Name = "cmbamount";
            this.cmbamount.Size = new System.Drawing.Size(190, 23);
            this.cmbamount.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(274, 132);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(274, 238);
            this.txtamount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(132, 21);
            this.txtamount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Member Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Date Of Return:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount To Be return:";
            // 
            // btnaccept
            // 
            this.btnaccept.Location = new System.Drawing.Point(184, 278);
            this.btnaccept.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(171, 27);
            this.btnaccept.TabIndex = 10;
            this.btnaccept.Text = "Accept Interest";
            this.btnaccept.UseVisualStyleBackColor = true;
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(273, 184);
            this.txtmonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(132, 21);
            this.txtmonth.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter Month Of Interest(Jun2014):";
            // 
            // frmloaninterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 384);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnaccept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbamount);
            this.Controls.Add(this.cmbmember);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmloaninterest";
            this.Text = "Return Loan Interest";
            this.Load += new System.EventHandler(this.frmloaninterest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbmember;
        private System.Windows.Forms.ComboBox cmbamount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnaccept;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.Label label5;
    }
}