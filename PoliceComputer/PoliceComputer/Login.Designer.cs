namespace PoliceComputer
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.errorLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.errorLogin.SetError(this.txtUsername, resources.GetString("txtUsername.Error"));
            this.errorLogin.SetIconAlignment(this.txtUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUsername.IconAlignment"))));
            this.errorLogin.SetIconPadding(this.txtUsername, ((int)(resources.GetObject("txtUsername.IconPadding"))));
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.errorLogin.SetError(this.btnLogin, resources.GetString("btnLogin.Error"));
            this.errorLogin.SetIconAlignment(this.btnLogin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnLogin.IconAlignment"))));
            this.errorLogin.SetIconPadding(this.btnLogin, ((int)(resources.GetObject("btnLogin.IconPadding"))));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.errorLogin.SetError(this.txtPassword, resources.GetString("txtPassword.Error"));
            this.errorLogin.SetIconAlignment(this.txtPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPassword.IconAlignment"))));
            this.errorLogin.SetIconPadding(this.txtPassword, ((int)(resources.GetObject("txtPassword.IconPadding"))));
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // errorLogin
            // 
            this.errorLogin.ContainerControl = this;
            resources.ApplyResources(this.errorLogin, "errorLogin");
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.errorLogin.SetError(this.lblUsername, resources.GetString("lblUsername.Error"));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.errorLogin.SetIconAlignment(this.lblUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblUsername.IconAlignment"))));
            this.errorLogin.SetIconPadding(this.lblUsername, ((int)(resources.GetObject("lblUsername.IconPadding"))));
            this.lblUsername.Name = "lblUsername";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.errorLogin.SetError(this.lblPassword, resources.GetString("lblPassword.Error"));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.errorLogin.SetIconAlignment(this.lblPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPassword.IconAlignment"))));
            this.errorLogin.SetIconPadding(this.lblPassword, ((int)(resources.GetObject("lblPassword.IconPadding"))));
            this.lblPassword.Name = "lblPassword";
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.errorLogin.SetError(this.lblError, resources.GetString("lblError.Error"));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.errorLogin.SetIconAlignment(this.lblError, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblError.IconAlignment"))));
            this.errorLogin.SetIconPadding(this.lblError, ((int)(resources.GetObject("lblError.IconPadding"))));
            this.lblError.Name = "lblError";
            // 
            // logo
            // 
            resources.ApplyResources(this.logo, "logo");
            this.errorLogin.SetError(this.logo, resources.GetString("logo.Error"));
            this.errorLogin.SetIconAlignment(this.logo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("logo.IconAlignment"))));
            this.errorLogin.SetIconPadding(this.logo, ((int)(resources.GetObject("logo.IconPadding"))));
            this.logo.Image = global::PoliceComputer.Properties.Resources.logo1invert;
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            // 
            // loginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ErrorProvider errorLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
    }
}

