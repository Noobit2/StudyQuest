namespace StudyQuest
{
    partial class sidebar_avatar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sidebar_avatar));
            unlockButton = new Button();
            avatarPanel = new Panel();
            pictureBox26 = new PictureBox();
            greetingsUser = new Label();
            avtrItempanel = new Panel();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            applyButton = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            totalXPText = new Label();
            numTotalXP = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            avatarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).BeginInit();
            avtrItempanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // unlockButton
            // 
            unlockButton.FlatStyle = FlatStyle.Flat;
            unlockButton.Font = new Font("Pixelify Sans", 12F);
            unlockButton.ForeColor = Color.White;
            unlockButton.ImageAlign = ContentAlignment.MiddleLeft;
            unlockButton.Location = new Point(846, 672);
            unlockButton.Name = "unlockButton";
            unlockButton.Size = new Size(125, 38);
            unlockButton.TabIndex = 7;
            unlockButton.Text = "Unlock Item";
            unlockButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            unlockButton.UseVisualStyleBackColor = true;
            unlockButton.Click += button1_Click;
            // 
            // avatarPanel
            // 
            avatarPanel.Controls.Add(pictureBox26);
            avatarPanel.Location = new Point(24, 98);
            avatarPanel.Name = "avatarPanel";
            avatarPanel.Size = new Size(362, 556);
            avatarPanel.TabIndex = 8;
            avatarPanel.Paint += avatarPanel_Paint;
            // 
            // pictureBox26
            // 
            pictureBox26.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox26.Image = (Image)resources.GetObject("pictureBox26.Image");
            pictureBox26.Location = new Point(19, 34);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(324, 506);
            pictureBox26.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox26.TabIndex = 0;
            pictureBox26.TabStop = false;
            pictureBox26.Click += pictureBox26_Click;
            // 
            // greetingsUser
            // 
            greetingsUser.AutoSize = true;
            greetingsUser.Font = new Font("Pixelify Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greetingsUser.ForeColor = Color.White;
            greetingsUser.Location = new Point(24, 27);
            greetingsUser.Name = "greetingsUser";
            greetingsUser.Size = new Size(171, 37);
            greetingsUser.TabIndex = 9;
            greetingsUser.Text = "My Avatar";
            // 
            // avtrItempanel
            // 
            avtrItempanel.Controls.Add(panel2);
            avtrItempanel.Controls.Add(pictureBox4);
            avtrItempanel.Controls.Add(label1);
            avtrItempanel.Controls.Add(pictureBox3);
            avtrItempanel.Controls.Add(pictureBox2);
            avtrItempanel.Controls.Add(pictureBox1);
            avtrItempanel.Location = new Point(405, 98);
            avtrItempanel.Name = "avtrItempanel";
            avtrItempanel.Size = new Size(584, 556);
            avtrItempanel.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(14, 328);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(183, 212);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pixelify Sans", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(231, 29);
            label1.TabIndex = 12;
            label1.Text = "Avatar Collections";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 110);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 180);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(389, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 256);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(186, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // applyButton
            // 
            applyButton.FlatStyle = FlatStyle.Flat;
            applyButton.Font = new Font("Pixelify Sans", 12F);
            applyButton.ForeColor = Color.White;
            applyButton.ImageAlign = ContentAlignment.MiddleLeft;
            applyButton.Location = new Point(681, 672);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(125, 38);
            applyButton.TabIndex = 11;
            applyButton.Text = "Apply Avatar";
            applyButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            applyButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pixelify Sans", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 674);
            label2.Name = "label2";
            label2.Size = new Size(128, 24);
            label2.TabIndex = 12;
            label2.Text = "Pet's Name: ";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(15, 23, 42);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Pixelify Sans", 12F);
            textBox1.Location = new Point(152, 672);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 31);
            textBox1.TabIndex = 13;
            // 
            // totalXPText
            // 
            totalXPText.AutoSize = true;
            totalXPText.Font = new Font("Pixelify Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalXPText.Location = new Point(3, 14);
            totalXPText.Name = "totalXPText";
            totalXPText.Size = new Size(94, 24);
            totalXPText.TabIndex = 0;
            totalXPText.Text = "Total XP:";
            // 
            // numTotalXP
            // 
            numTotalXP.AutoSize = true;
            numTotalXP.Font = new Font("Pixelify Sans", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numTotalXP.Location = new Point(164, 9);
            numTotalXP.Name = "numTotalXP";
            numTotalXP.Size = new Size(98, 30);
            numTotalXP.TabIndex = 1;
            numTotalXP.Text = "1170 XP";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(numTotalXP);
            panel1.Controls.Add(totalXPText);
            panel1.Font = new Font("Urbanist", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(708, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 57);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Location = new Point(225, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 212);
            panel2.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Pixelify Sans", 15F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(78, 95);
            label5.Name = "label5";
            label5.Size = new Size(159, 30);
            label5.TabIndex = 0;
            label5.Text = "More soon...";
            label5.Click += label5_Click;
            // 
            // sidebar_avatar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1011, 744);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(applyButton);
            Controls.Add(avtrItempanel);
            Controls.Add(greetingsUser);
            Controls.Add(avatarPanel);
            Controls.Add(unlockButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sidebar_avatar";
            Text = "sidebar_avatar";
            avatarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox26).EndInit();
            avtrItempanel.ResumeLayout(false);
            avtrItempanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label numTotalXP;
        private Label totalXPText;
        private Button unlockButton;
        private Panel avatarPanel;
        private Label greetingsUser;
        private Panel avtrItempanel;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button applyButton;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox26;
        private Panel panel2;
        private Label label5;
    }
}