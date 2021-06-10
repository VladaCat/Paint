
namespace Team_Project_Paint
{
    partial class AutorizationForm
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
            this.signInBtn = new System.Windows.Forms.Button();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.signUpLabel = new System.Windows.Forms.LinkLabel();
            this.loginLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signInBtn
            // 
            this.signInBtn.Enabled = false;
            this.signInBtn.Location = new System.Drawing.Point(141, 209);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(75, 23);
            this.signInBtn.TabIndex = 0;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(129, 183);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.Size = new System.Drawing.Size(100, 20);
            this.PassTextBox.TabIndex = 1;
            this.PassTextBox.TextChanged += new System.EventHandler(this.PassTextBox_TextChanged);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(129, 157);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Location = new System.Drawing.Point(154, 246);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(45, 13);
            this.signUpLabel.TabIndex = 3;
            this.signUpLabel.TabStop = true;
            this.signUpLabel.Text = "Sign Up";
            this.signUpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLabel_LinkClicked);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(70, 160);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(33, 13);
            this.loginLbl.TabIndex = 4;
            this.loginLbl.Text = "Login";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(70, 186);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(53, 13);
            this.passLbl.TabIndex = 5;
            this.passLbl.Text = "Password";
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.signInBtn);
            this.Name = "AutorizationForm";
            this.Text = "Paint";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AutorizationForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.LinkLabel signUpLabel;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label passLbl;
    }
}