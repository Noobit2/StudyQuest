using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyQuest
{
    public partial class sidebar_badges : Form
    {

        private int unlockedCount = 0;

        private bool _badge1Unlocked = false;
        private bool _badge2Unlocked = false;
        private bool _badge3Unlocked = false;
        private bool _badge4Unlocked = false;
        private bool _badge5Unlocked = false;
        private bool _badge6Unlocked = false;
        private bool _badge7Unlocked = false;
        private bool _badge8Unlocked = false;

        public sidebar_badges()
        {
            InitializeComponent();
            sidebar_task.EXPChanged += OnEXPChanged;
            CheckBadges();
        }

        private void OnEXPChanged()
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(OnEXPChanged));
            else
                CheckBadges();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            sidebar_task.EXPChanged -= OnEXPChanged;
            base.OnFormClosing(e);
        }

        private void CheckBadges()
        {
            unlockedCount = 0;

            int completedTasks = sidebar_task.CompletedCount;
            int totalEarnedEXP = sidebar_task.TotalEarnedEXP;
            int currentLevel = sidebar_task.CurrentLevel;
            int streakDays = GameSession.StreakDays;

            if (completedTasks >= 1) _badge1Unlocked = true;
            if (streakDays >= 7) _badge2Unlocked = true;
            if (streakDays >= 50) _badge3Unlocked = true;
            if (streakDays >= 100) _badge4Unlocked = true;
            if (totalEarnedEXP >= 100) _badge5Unlocked = true;
            if (totalEarnedEXP >= 10000) _badge6Unlocked = true;
            if (currentLevel >= 30) _badge7Unlocked = true;
            if (currentLevel >= 60) _badge8Unlocked = true;

            ApplyBadge(panel3, _badge1Unlocked);
            ApplyBadge(panel1, _badge2Unlocked);
            ApplyBadge(panel2, _badge3Unlocked);
            ApplyBadge(panel4, _badge4Unlocked);
            ApplyBadge(panel8, _badge5Unlocked);
            ApplyBadge(panel7, _badge6Unlocked);
            ApplyBadge(panel6, _badge7Unlocked);
            ApplyBadge(panel5, _badge8Unlocked);

            label2.Text = $"{unlockedCount} out of 8 Badges Unlocked! " +
                          (unlockedCount == 8 ? "Amazing!" : "Keep it up!");
        }

        private void ApplyBadge(Panel panel, bool unlocked)
        {
            if (unlocked)
            {
                unlockedCount++;

                panel.BackColor = Color.FromArgb(40, 35, 10);
                panel.BorderStyle = BorderStyle.Fixed3D;

                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is Label lbl)
                        lbl.ForeColor = Color.Gold;

                    if (ctrl is PictureBox pb)
                        pb.BackColor = Color.FromArgb(80, 70, 0);
                }

                bool alreadyStamped = false;
                foreach (Control ctrl in panel.Controls)
                    if (ctrl is Label l && l.Name == "lblUnlocked")
                        alreadyStamped = true;

                if (!alreadyStamped)
                {
                    var stamp = new Label
                    {
                        Name = "lblUnlocked",
                        Text = "UNLOCKED",
                        Font = new Font("Pixelify Sans", 8F, FontStyle.Bold),
                        ForeColor = Color.LimeGreen,
                        BackColor = Color.Transparent,
                        AutoSize = true,
                        Location = new Point(50, 210)
                    };
                    panel.Controls.Add(stamp);
                }
            }
            else
            {
                panel.BackColor = Color.FromArgb(15, 23, 42);

                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is Label lbl && lbl.Name != "lblUnlocked")
                        lbl.ForeColor = Color.FromArgb(100, 100, 120);

                    if (ctrl is PictureBox pb)
                        pb.BackColor = Color.FromArgb(25, 30, 50);
                }

                Control? toRemove = null;
                foreach (Control ctrl in panel.Controls)
                    if (ctrl is Label l && l.Name == "lblUnlocked")
                        toRemove = ctrl;

                if (toRemove != null)
                    panel.Controls.Remove(toRemove);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void player3Username_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
    }
}