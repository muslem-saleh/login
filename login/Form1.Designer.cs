
namespace login
{
    partial class fomLogin
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bonLogin = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.tb_Uuser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bonLogin
            // 
            this.bonLogin.Location = new System.Drawing.Point(180, 250);
            this.bonLogin.Name = "bonLogin";
            this.bonLogin.Size = new System.Drawing.Size(75, 23);
            this.bonLogin.TabIndex = 0;
            this.bonLogin.Text = "Login";
            this.bonLogin.UseVisualStyleBackColor = true;
            this.bonLogin.Click += new System.EventHandler(this.bonLogin_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(81, 76);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(75, 17);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "user name";
            // 
            // tb_Uuser
            // 
            this.tb_Uuser.Location = new System.Drawing.Point(180, 73);
            this.tb_Uuser.Name = "tb_Uuser";
            this.tb_Uuser.Size = new System.Drawing.Size(163, 22);
            this.tb_Uuser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(180, 148);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(163, 22);
            this.txtPass.TabIndex = 4;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(81, 153);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(69, 17);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password";
            // 
            // fomLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.tb_Uuser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.bonLogin);
            this.Name = "fomLogin";
            this.Text = "login";
            this.Load += new System.EventHandler(this.fomLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bonLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tb_Uuser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
    }
}

