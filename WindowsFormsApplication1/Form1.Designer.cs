namespace WindowsFormsApplication1
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnforgot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmob = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnicon = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(289, 213);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 27);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Log In";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnforgot
            // 
            this.btnforgot.Location = new System.Drawing.Point(117, 213);
            this.btnforgot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnforgot.Name = "btnforgot";
            this.btnforgot.Size = new System.Drawing.Size(164, 27);
            this.btnforgot.TabIndex = 3;
            this.btnforgot.Text = "Forgot password?";
            this.btnforgot.UseVisualStyleBackColor = true;
            this.btnforgot.Click += new System.EventHandler(this.btnforgot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mobile NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // txtmob
            // 
            this.txtmob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtmob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtmob.Location = new System.Drawing.Point(223, 113);
            this.txtmob.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmob.MaxLength = 10;
            this.txtmob.Name = "txtmob";
            this.txtmob.Size = new System.Drawing.Size(208, 21);
            this.txtmob.TabIndex = 0;
            this.txtmob.LocationChanged += new System.EventHandler(this.txtmob_LocationChanged);
            this.txtmob.TextChanged += new System.EventHandler(this.txtmob_TextChanged);
            this.txtmob.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.txtmob_ControlRemoved);
            this.txtmob.Leave += new System.EventHandler(this.txtmob_Leave);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(223, 164);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(208, 21);
            this.txtpass.TabIndex = 1;
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // btnicon
            // 
            this.btnicon.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnicon.Enabled = false;
            this.btnicon.Image = ((System.Drawing.Image)(resources.GetObject("btnicon.Image")));
            this.btnicon.Location = new System.Drawing.Point(-3, 1);
            this.btnicon.Name = "btnicon";
            this.btnicon.Size = new System.Drawing.Size(519, 106);
            this.btnicon.TabIndex = 6;
            this.btnicon.UseVisualStyleBackColor = true;
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(397, 213);
            this.btncancle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(100, 27);
            this.btncancle.TabIndex = 7;
            this.btncancle.Text = "Cancle";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 325);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnicon);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtmob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnforgot);
            this.Controls.Add(this.btnlogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmlogin";
            this.Text = "LogIn";
            this.Activated += new System.EventHandler(this.frmlogin_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnforgot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmob;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnicon;
        private System.Windows.Forms.Button btncancle;

    }
}

