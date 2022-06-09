namespace Kirby_Final_Game
{
    partial class Form1
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
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.pointLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.kirbyHealthBar = new System.Windows.Forms.ProgressBar();
            this.bossHealthBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // gametimer
            // 
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointLabel.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.pointLabel.ForeColor = System.Drawing.Color.White;
            this.pointLabel.Location = new System.Drawing.Point(25, 352);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(50, 17);
            this.pointLabel.TabIndex = 0;
            this.pointLabel.Text = "Points:";
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(226, 212);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 23);
            this.outputLabel.TabIndex = 1;
            // 
            // warningLabel
            // 
            this.warningLabel.BackColor = System.Drawing.Color.Transparent;
            this.warningLabel.Font = new System.Drawing.Font("Candara Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.White;
            this.warningLabel.Location = new System.Drawing.Point(392, 354);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(100, 23);
            this.warningLabel.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Showcard Gothic", 30F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.titleLabel.Location = new System.Drawing.Point(176, 135);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(203, 56);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.subtitleLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.subtitleLabel.Location = new System.Drawing.Point(113, 235);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(344, 23);
            this.subtitleLabel.TabIndex = 4;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.Color.Transparent;
            this.healthLabel.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(25, 407);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(52, 17);
            this.healthLabel.TabIndex = 5;
            this.healthLabel.Text = "Health:";
            // 
            // kirbyHealthBar
            // 
            this.kirbyHealthBar.ForeColor = System.Drawing.Color.Chartreuse;
            this.kirbyHealthBar.Location = new System.Drawing.Point(84, 401);
            this.kirbyHealthBar.Name = "kirbyHealthBar";
            this.kirbyHealthBar.Size = new System.Drawing.Size(100, 23);
            this.kirbyHealthBar.TabIndex = 6;
            // 
            // bossHealthBar
            // 
            this.bossHealthBar.ForeColor = System.Drawing.Color.Chartreuse;
            this.bossHealthBar.Location = new System.Drawing.Point(395, 401);
            this.bossHealthBar.Name = "bossHealthBar";
            this.bossHealthBar.Size = new System.Drawing.Size(100, 23);
            this.bossHealthBar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Kirby_Final_Game.Properties.Resources.kirbyBackground2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.bossHealthBar);
            this.Controls.Add(this.kirbyHealthBar);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.pointLabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.ProgressBar kirbyHealthBar;
        private System.Windows.Forms.ProgressBar bossHealthBar;
    }
}

