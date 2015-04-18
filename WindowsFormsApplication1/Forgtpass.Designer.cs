namespace WindowsFormsApplication1
{
    partial class frmforgtpass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmforgtpass));
            this.btngetpass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtnname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btngetpass
            // 
            this.btngetpass.Location = new System.Drawing.Point(192, 225);
            this.btngetpass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btngetpass.Name = "btngetpass";
            this.btngetpass.Size = new System.Drawing.Size(137, 27);
            this.btngetpass.TabIndex = 0;
            this.btngetpass.Text = "Get Password";
            this.btngetpass.UseVisualStyleBackColor = true;
            this.btngetpass.Click += new System.EventHandler(this.btngetpass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Mother\'s Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Mick Name:";
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(280, 120);
            this.txtmname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(132, 21);
            this.txtmname.TabIndex = 3;
            // 
            // txtnname
            // 
            this.txtnname.Location = new System.Drawing.Point(280, 172);
            this.txtnname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnname.Name = "txtnname";
            this.txtnname.Size = new System.Drawing.Size(132, 21);
            this.txtnname.TabIndex = 4;
            // 
            // frmforgtpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 312);
            this.Controls.Add(this.txtnname);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngetpass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmforgtpass";
            this.Text = "Forgot Password?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngetpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.TextBox txtnname;
    }
}