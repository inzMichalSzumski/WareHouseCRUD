namespace WarehouseCRUD
{
    partial class LoginWindow
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
            this.LoginTextLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginTextLabel
            // 
            this.LoginTextLabel.AutoSize = true;
            this.LoginTextLabel.Location = new System.Drawing.Point(12, 56);
            this.LoginTextLabel.Name = "LoginTextLabel";
            this.LoginTextLabel.Size = new System.Drawing.Size(33, 13);
            this.LoginTextLabel.TabIndex = 0;
            this.LoginTextLabel.Text = "Login";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(94, 53);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(243, 20);
            this.LoginTextBox.TabIndex = 1;
            // 
            // PasswordTextLabel
            // 
            this.PasswordTextLabel.AutoSize = true;
            this.PasswordTextLabel.Location = new System.Drawing.Point(11, 98);
            this.PasswordTextLabel.Name = "PasswordTextLabel";
            this.PasswordTextLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordTextLabel.TabIndex = 2;
            this.PasswordTextLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(94, 95);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(243, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(148, 121);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 4;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Log in to github";
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordTextLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginTextLabel);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginTextLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label PasswordTextLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label label1;
    }
}