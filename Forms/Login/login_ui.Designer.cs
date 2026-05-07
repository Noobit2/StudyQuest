namespace StudyQuest
{
    partial class login_ui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_ui));
            studyQuestLogo = new PictureBox();
            panel1 = new Panel();
            loginButton = new Button();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)studyQuestLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // studyQuestLogo
            // 
            studyQuestLogo.Image = (Image)resources.GetObject("studyQuestLogo.Image");
            studyQuestLogo.Location = new Point(252, 198);
            studyQuestLogo.Name = "studyQuestLogo";
            studyQuestLogo.Size = new Size(796, 195);
            studyQuestLogo.TabIndex = 2;
            studyQuestLogo.TabStop = false;
            studyQuestLogo.Click += studyQuestLogo_Click;
            // 
            // panel1
            // 
            panel1.Font = new Font("Pixelify Sans", 13F);
            panel1.Location = new Point(460, 460);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 3);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint_1;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Pixelify Sans", 13F);
            loginButton.Location = new Point(560, 559);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(169, 36);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += button1_Click;
            // 
            // usernameTextbox
            // 
            usernameTextbox.BackColor = Color.FromArgb(15, 23, 42);
            usernameTextbox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextbox.Font = new Font("Pixelify Sans", 13F);
            usernameTextbox.ForeColor = Color.White;
            usernameTextbox.Location = new Point(499, 427);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.PlaceholderText = "Username";
            usernameTextbox.Size = new Size(292, 33);
            usernameTextbox.TabIndex = 5;
            usernameTextbox.TextAlign = HorizontalAlignment.Center;
            usernameTextbox.TextChanged += usernameTextbox_TextChanged;
            // 
            // passwordTextbox
            // 
            passwordTextbox.BackColor = Color.FromArgb(15, 23, 42);
            passwordTextbox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextbox.Font = new Font("Pixelify Sans", 13F);
            passwordTextbox.ForeColor = Color.White;
            passwordTextbox.Location = new Point(499, 492);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PlaceholderText = "Password";
            passwordTextbox.Size = new Size(292, 33);
            passwordTextbox.TabIndex = 7;
            passwordTextbox.TextAlign = HorizontalAlignment.Center;
            passwordTextbox.TextChanged += usernameTextbox_TextChanged;
            // 
            // panel2
            // 
            panel2.Font = new Font("Pixelify Sans", 13F);
            panel2.Location = new Point(460, 526);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 3);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1274, 764);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // login_ui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1274, 764);
            Controls.Add(passwordTextbox);
            Controls.Add(panel2);
            Controls.Add(usernameTextbox);
            Controls.Add(loginButton);
            Controls.Add(panel1);
            Controls.Add(studyQuestLogo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login_ui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)studyQuestLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox studyQuestLogo;
        private Panel panel1;
        private Button loginButton;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}