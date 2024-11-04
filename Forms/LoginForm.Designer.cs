namespace Trackit.Forms
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            lblUsername = new Label();
            txtBoxUsername = new TextBox();
            txtBoxPassword = new TextBox();
            lblPassword = new Label();
            btnSignIn = new Button();
            btnSignup = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Tai Le", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(167, 56);
            label1.Name = "label1";
            label1.Size = new Size(222, 44);
            label1.TabIndex = 0;
            label1.Text = "TRACK";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Tai Le", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(296, 56);
            label2.Name = "label2";
            label2.Size = new Size(197, 44);
            label2.TabIndex = 1;
            label2.Text = "IT";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(167, 130);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(64, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(169, 148);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(186, 23);
            txtBoxUsername.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(169, 205);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(186, 23);
            txtBoxPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(172, 187);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(59, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(172, 265);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(75, 23);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(192, 0, 0);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(269, 265);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(75, 27);
            btnSignup.TabIndex = 7;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 368);
            Controls.Add(btnSignup);
            Controls.Add(btnSignIn);
            Controls.Add(txtBoxPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtBoxUsername);
            Controls.Add(lblUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Portal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblUsername;
        private TextBox txtBoxUsername;
        private TextBox txtBoxPassword;
        private Label lblPassword;
        private Button btnSignIn;
        private Button btnSignup;
    }
}