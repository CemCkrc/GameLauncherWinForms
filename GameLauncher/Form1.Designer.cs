
namespace GameLauncher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.animatedPicture_0 = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.eventLabel = new System.Windows.Forms.Label();
            this.pictureTimer = new System.Windows.Forms.Timer(this.components);
            this.englishButton = new System.Windows.Forms.Button();
            this.gameTitle = new System.Windows.Forms.Label();
            this.turkishButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.updateLogText = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.updateBox = new System.Windows.Forms.RichTextBox();
            this.animatedPicture_1 = new System.Windows.Forms.PictureBox();
            this.gifCreator = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animatedPicture_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animatedPicture_1)).BeginInit();
            this.SuspendLayout();
            // 
            // animatedPicture_0
            // 
            this.animatedPicture_0.BackgroundImage = global::GameLauncher.Properties.Resources.marshmallow_earphone_01;
            this.animatedPicture_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animatedPicture_0.Location = new System.Drawing.Point(647, 349);
            this.animatedPicture_0.Name = "animatedPicture_0";
            this.animatedPicture_0.Size = new System.Drawing.Size(141, 120);
            this.animatedPicture_0.TabIndex = 0;
            this.animatedPicture_0.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.progressBar.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar.Location = new System.Drawing.Point(12, 450);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(629, 38);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 2;
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.BackColor = System.Drawing.Color.Transparent;
            this.eventLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eventLabel.Location = new System.Drawing.Point(299, 412);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(122, 22);
            this.eventLabel.TabIndex = 3;
            this.eventLabel.Text = "Game Event";
            // 
            // pictureTimer
            // 
            this.pictureTimer.Interval = 1000;
            // 
            // englishButton
            // 
            this.englishButton.BackgroundImage = global::GameLauncher.Properties.Resources.EN_Flag;
            this.englishButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.englishButton.Location = new System.Drawing.Point(647, 293);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(50, 50);
            this.englishButton.TabIndex = 4;
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click);
            // 
            // gameTitle
            // 
            this.gameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameTitle.AutoSize = true;
            this.gameTitle.BackColor = System.Drawing.Color.Tan;
            this.gameTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameTitle.Location = new System.Drawing.Point(289, 19);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(180, 32);
            this.gameTitle.TabIndex = 5;
            this.gameTitle.Text = "GAME TITLE";
            this.gameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turkishButton
            // 
            this.turkishButton.BackgroundImage = global::GameLauncher.Properties.Resources.TR_Flag;
            this.turkishButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.turkishButton.Location = new System.Drawing.Point(738, 293);
            this.turkishButton.Name = "turkishButton";
            this.turkishButton.Size = new System.Drawing.Size(50, 50);
            this.turkishButton.TabIndex = 6;
            this.turkishButton.UseVisualStyleBackColor = true;
            this.turkishButton.Click += new System.EventHandler(this.turkishButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Tan;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(803, 75);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // updateLogText
            // 
            this.updateLogText.AutoSize = true;
            this.updateLogText.BackColor = System.Drawing.Color.AntiqueWhite;
            this.updateLogText.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateLogText.Location = new System.Drawing.Point(266, 97);
            this.updateLogText.Name = "updateLogText";
            this.updateLogText.Size = new System.Drawing.Size(119, 22);
            this.updateLogText.TabIndex = 10;
            this.updateLogText.Text = "UPDATE LOG";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.BurlyWood;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playButton.Location = new System.Drawing.Point(647, 122);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(141, 38);
            this.playButton.TabIndex = 11;
            this.playButton.Text = "PLAY GAME";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitGameButton
            // 
            this.exitGameButton.BackColor = System.Drawing.Color.BurlyWood;
            this.exitGameButton.FlatAppearance.BorderSize = 0;
            this.exitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitGameButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitGameButton.Location = new System.Drawing.Point(647, 166);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(141, 38);
            this.exitGameButton.TabIndex = 12;
            this.exitGameButton.Text = "EXIT GAME";
            this.exitGameButton.UseVisualStyleBackColor = false;
            this.exitGameButton.Click += new System.EventHandler(this.exitGameButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.BurlyWood;
            this.flowLayoutPanel1.Controls.Add(this.updateBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 122);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(629, 273);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // updateBox
            // 
            this.updateBox.BackColor = System.Drawing.Color.PeachPuff;
            this.updateBox.Location = new System.Drawing.Point(3, 3);
            this.updateBox.Name = "updateBox";
            this.updateBox.ReadOnly = true;
            this.updateBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.updateBox.Size = new System.Drawing.Size(605, 319);
            this.updateBox.TabIndex = 0;
            this.updateBox.Text = "Example Update Log";
            this.updateBox.WordWrap = false;
            // 
            // animatedPicture_1
            // 
            this.animatedPicture_1.BackgroundImage = global::GameLauncher.Properties.Resources.marshmallow_earphone_02;
            this.animatedPicture_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animatedPicture_1.Location = new System.Drawing.Point(647, 349);
            this.animatedPicture_1.Name = "animatedPicture_1";
            this.animatedPicture_1.Size = new System.Drawing.Size(141, 120);
            this.animatedPicture_1.TabIndex = 14;
            this.animatedPicture_1.TabStop = false;
            // 
            // gifCreator
            // 
            this.gifCreator.AutoSize = true;
            this.gifCreator.Location = new System.Drawing.Point(680, 476);
            this.gifCreator.Name = "gifCreator";
            this.gifCreator.Size = new System.Drawing.Size(81, 15);
            this.gifCreator.TabIndex = 15;
            this.gifCreator.Text = "Gif : Bevouliin";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Tan;
            this.versionLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versionLabel.ForeColor = System.Drawing.Color.Black;
            this.versionLabel.Location = new System.Drawing.Point(688, 9);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(100, 17);
            this.versionLabel.TabIndex = 16;
            this.versionLabel.Text = "Version : 0.0.1";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.gifCreator);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.updateLogText);
            this.Controls.Add(this.turkishButton);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.englishButton);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.animatedPicture_0);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.animatedPicture_1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.animatedPicture_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.animatedPicture_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox animatedPicture_0;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.Timer pictureTimer;
        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Button turkishButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label updateLogText;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitGameButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox updateBox;
        private System.Windows.Forms.PictureBox animatedPicture_1;
        private System.Windows.Forms.Label gifCreator;
        private System.Windows.Forms.Label versionLabel;
    }
}

