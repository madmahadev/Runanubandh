namespace WindowsFormsApplication1
{
    partial class frmmain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.linkacceptmonthlyinst = new System.Windows.Forms.LinkLabel();
            this.linkacceptloaninst = new System.Windows.Forms.LinkLabel();
            this.linkofferloan = new System.Windows.Forms.LinkLabel();
            this.linkseememberdeteil = new System.Windows.Forms.LinkLabel();
            this.linkseeloandetail = new System.Windows.Forms.LinkLabel();
            this.linkseecurrentmonthsub = new System.Windows.Forms.LinkLabel();
            this.linkaddmember = new System.Windows.Forms.LinkLabel();
            this.linkremovemember = new System.Windows.Forms.LinkLabel();
            this.linklogout = new System.Windows.Forms.LinkLabel();
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.lnkloaninterest = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkacceptmonthlyinst
            // 
            this.linkacceptmonthlyinst.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkacceptmonthlyinst.AutoSize = true;
            this.linkacceptmonthlyinst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkacceptmonthlyinst.Location = new System.Drawing.Point(675, 38);
            this.linkacceptmonthlyinst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkacceptmonthlyinst.Name = "linkacceptmonthlyinst";
            this.linkacceptmonthlyinst.Size = new System.Drawing.Size(208, 20);
            this.linkacceptmonthlyinst.TabIndex = 0;
            this.linkacceptmonthlyinst.TabStop = true;
            this.linkacceptmonthlyinst.Text = "Accept Monthly Installments";
            this.linkacceptmonthlyinst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkacceptmonthlyinst.MouseEnter += new System.EventHandler(this.linkLabel1_MouseEnter);
            // 
            // linkacceptloaninst
            // 
            this.linkacceptloaninst.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkacceptloaninst.AutoSize = true;
            this.linkacceptloaninst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkacceptloaninst.Location = new System.Drawing.Point(675, 70);
            this.linkacceptloaninst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkacceptloaninst.Name = "linkacceptloaninst";
            this.linkacceptloaninst.Size = new System.Drawing.Size(181, 20);
            this.linkacceptloaninst.TabIndex = 1;
            this.linkacceptloaninst.TabStop = true;
            this.linkacceptloaninst.Text = "Accept Loan Installment";
            this.linkacceptloaninst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkofferloan
            // 
            this.linkofferloan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkofferloan.AutoSize = true;
            this.linkofferloan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkofferloan.Location = new System.Drawing.Point(675, 140);
            this.linkofferloan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkofferloan.Name = "linkofferloan";
            this.linkofferloan.Size = new System.Drawing.Size(85, 20);
            this.linkofferloan.TabIndex = 2;
            this.linkofferloan.TabStop = true;
            this.linkofferloan.Text = "Offer Loan";
            this.linkofferloan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkofferloan_LinkClicked);
            // 
            // linkseememberdeteil
            // 
            this.linkseememberdeteil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkseememberdeteil.AutoSize = true;
            this.linkseememberdeteil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkseememberdeteil.Location = new System.Drawing.Point(675, 175);
            this.linkseememberdeteil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkseememberdeteil.Name = "linkseememberdeteil";
            this.linkseememberdeteil.Size = new System.Drawing.Size(145, 20);
            this.linkseememberdeteil.TabIndex = 3;
            this.linkseememberdeteil.TabStop = true;
            this.linkseememberdeteil.Text = "See Member Detail";
            this.linkseememberdeteil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkseememberdeteil_LinkClicked);
            // 
            // linkseeloandetail
            // 
            this.linkseeloandetail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkseeloandetail.AutoSize = true;
            this.linkseeloandetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkseeloandetail.Location = new System.Drawing.Point(675, 218);
            this.linkseeloandetail.Name = "linkseeloandetail";
            this.linkseeloandetail.Size = new System.Drawing.Size(123, 20);
            this.linkseeloandetail.TabIndex = 4;
            this.linkseeloandetail.TabStop = true;
            this.linkseeloandetail.Text = "See Loan Detail";
            // 
            // linkseecurrentmonthsub
            // 
            this.linkseecurrentmonthsub.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkseecurrentmonthsub.AutoSize = true;
            this.linkseecurrentmonthsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkseecurrentmonthsub.Location = new System.Drawing.Point(675, 267);
            this.linkseecurrentmonthsub.Name = "linkseecurrentmonthsub";
            this.linkseecurrentmonthsub.Size = new System.Drawing.Size(230, 20);
            this.linkseecurrentmonthsub.TabIndex = 5;
            this.linkseecurrentmonthsub.TabStop = true;
            this.linkseecurrentmonthsub.Text = "See Current Month Submission";
            this.linkseecurrentmonthsub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkseecurrentmonthsub_LinkClicked);
            // 
            // linkaddmember
            // 
            this.linkaddmember.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkaddmember.AutoSize = true;
            this.linkaddmember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkaddmember.Location = new System.Drawing.Point(675, 311);
            this.linkaddmember.Name = "linkaddmember";
            this.linkaddmember.Size = new System.Drawing.Size(135, 20);
            this.linkaddmember.TabIndex = 6;
            this.linkaddmember.TabStop = true;
            this.linkaddmember.Text = "Add New Member";
            this.linkaddmember.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkremovemember
            // 
            this.linkremovemember.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkremovemember.AutoSize = true;
            this.linkremovemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkremovemember.Location = new System.Drawing.Point(678, 352);
            this.linkremovemember.Name = "linkremovemember";
            this.linkremovemember.Size = new System.Drawing.Size(130, 20);
            this.linkremovemember.TabIndex = 7;
            this.linkremovemember.TabStop = true;
            this.linkremovemember.Text = "Remove Member";
            // 
            // linklogout
            // 
            this.linklogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linklogout.AutoSize = true;
            this.linklogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklogout.Location = new System.Drawing.Point(678, 390);
            this.linklogout.Name = "linklogout";
            this.linklogout.Size = new System.Drawing.Size(62, 20);
            this.linklogout.TabIndex = 8;
            this.linklogout.TabStop = true;
            this.linklogout.Text = "LogOut";
            this.linklogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);
            this.linklogout.MouseEnter += new System.EventHandler(this.linkLabel9_MouseEnter);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(346, 279);
            this.dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 658);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lets Start For New Month";
            // 
            // txtcurrent
            // 
            this.txtcurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurrent.Location = new System.Drawing.Point(401, 689);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(175, 21);
            this.txtcurrent.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 693);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Month and year like jun2014";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(582, 689);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 13;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lnkloaninterest
            // 
            this.lnkloaninterest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lnkloaninterest.AutoSize = true;
            this.lnkloaninterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkloaninterest.Location = new System.Drawing.Point(675, 104);
            this.lnkloaninterest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkloaninterest.Name = "lnkloaninterest";
            this.lnkloaninterest.Size = new System.Drawing.Size(240, 20);
            this.lnkloaninterest.TabIndex = 14;
            this.lnkloaninterest.TabStop = true;
            this.lnkloaninterest.Text = "Accept Loan Interest Installment";
            this.lnkloaninterest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkloaninterest_LinkClicked);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 418);
            this.Controls.Add(this.lnkloaninterest);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linklogout);
            this.Controls.Add(this.linkremovemember);
            this.Controls.Add(this.linkaddmember);
            this.Controls.Add(this.linkseecurrentmonthsub);
            this.Controls.Add(this.linkseeloandetail);
            this.Controls.Add(this.linkseememberdeteil);
            this.Controls.Add(this.linkofferloan);
            this.Controls.Add(this.linkacceptloaninst);
            this.Controls.Add(this.linkacceptmonthlyinst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Purple;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmmain";
            this.Text = "Main Page ";
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkacceptmonthlyinst;
        private System.Windows.Forms.LinkLabel linkacceptloaninst;
        private System.Windows.Forms.LinkLabel linkofferloan;
        private System.Windows.Forms.LinkLabel linkseememberdeteil;
        private System.Windows.Forms.LinkLabel linkseeloandetail;
        private System.Windows.Forms.LinkLabel linkseecurrentmonthsub;
        private System.Windows.Forms.LinkLabel linkaddmember;
        private System.Windows.Forms.LinkLabel linkremovemember;
        private System.Windows.Forms.LinkLabel linklogout;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.LinkLabel lnkloaninterest;
    }
}