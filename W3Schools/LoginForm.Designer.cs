﻿namespace W3Schools
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
            LoginLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            UsernameTextbox = new TextBox();
            PasswordTextbox = new TextBox();
            CancelButton = new Button();
            ConnectButton = new Button();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.Location = new Point(58, 44);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(282, 24);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Access W3Schools database";
            LoginLabel.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 144);
            label2.Name = "label2";
            label2.Size = new Size(148, 19);
            label2.TabIndex = 1;
            label2.Text = "Username or Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 241);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.Anchor = AnchorStyles.None;
            UsernameTextbox.Location = new Point(58, 164);
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.PlaceholderText = "es.: CiccioBenzina";
            UsernameTextbox.Size = new Size(292, 27);
            UsernameTextbox.TabIndex = 3;
            UsernameTextbox.TextChanged += textBox1_TextChanged;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Anchor = AnchorStyles.None;
            PasswordTextbox.Location = new Point(58, 261);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(292, 27);
            PasswordTextbox.TabIndex = 4;
            PasswordTextbox.UseSystemPasswordChar = true;
            PasswordTextbox.TextChanged += textBox2_TextChanged;
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(230, 401);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(120, 48);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // ConnectButton
            // 
            ConnectButton.BackColor = SystemColors.ActiveCaption;
            ConnectButton.FlatAppearance.BorderColor = Color.DarkCyan;
            ConnectButton.FlatAppearance.BorderSize = 3;
            ConnectButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            ConnectButton.Location = new Point(103, 401);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(121, 48);
            ConnectButton.TabIndex = 6;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(409, 523);
            ControlBox = false;
            Controls.Add(ConnectButton);
            Controls.Add(CancelButton);
            Controls.Add(PasswordTextbox);
            Controls.Add(UsernameTextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LoginLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginForm";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private Label label2;
        private Label label3;
        private TextBox UsernameTextbox;
        private TextBox PasswordTextbox;
        private Button CancelButton;
        private Button ConnectButton;
    }
}