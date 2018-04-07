namespace Races
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dogNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.whoBets = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.AlRadioButton = new System.Windows.Forms.RadioButton();
            this.BobRadioButton = new System.Windows.Forms.RadioButton();
            this.JoeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Races.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 20);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Races.Properties.Resources.dog;
            this.pictureBox2.Location = new System.Drawing.Point(12, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 20);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Races.Properties.Resources.dog;
            this.pictureBox3.Location = new System.Drawing.Point(12, 111);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 22);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Races.Properties.Resources.dog;
            this.pictureBox4.Location = new System.Drawing.Point(12, 165);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 22);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // racetrack
            // 
            this.racetrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.racetrack.Image = global::Races.Properties.Resources.racetrack;
            this.racetrack.Location = new System.Drawing.Point(-1, -1);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(610, 200);
            this.racetrack.TabIndex = 4;
            this.racetrack.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dogNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.betAmount);
            this.groupBox1.Controls.Add(this.whoBets);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.AlRadioButton);
            this.groupBox1.Controls.Add(this.BobRadioButton);
            this.groupBox1.Controls.Add(this.JoeRadioButton);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 81);
            this.button1.TabIndex = 13;
            this.button1.Text = "Race!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(235, 99);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(126, 17);
            this.alBetLabel.TabIndex = 12;
            this.alBetLabel.Text = "Al\'s Bet";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(235, 76);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(126, 17);
            this.bobBetLabel.TabIndex = 11;
            this.bobBetLabel.Text = "Bob\'s Bet";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(235, 53);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(126, 17);
            this.joeBetLabel.TabIndex = 10;
            this.joeBetLabel.Text = "Joe\'s Bet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(232, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bets";
            // 
            // dogNumber
            // 
            this.dogNumber.Location = new System.Drawing.Point(318, 129);
            this.dogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumber.Name = "dogNumber";
            this.dogNumber.Size = new System.Drawing.Size(52, 20);
            this.dogNumber.TabIndex = 8;
            this.dogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "bucks on dog number:";
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(129, 129);
            this.betAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(51, 20);
            this.betAmount.TabIndex = 6;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // whoBets
            // 
            this.whoBets.Location = new System.Drawing.Point(49, 127);
            this.whoBets.Name = "whoBets";
            this.whoBets.Size = new System.Drawing.Size(73, 27);
            this.whoBets.TabIndex = 5;
            this.whoBets.Text = "Bets";
            this.whoBets.UseVisualStyleBackColor = true;
            this.whoBets.Click += new System.EventHandler(this.whoBets_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(7, 137);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 4;
            this.name.Text = "name";
            // 
            // AlRadioButton
            // 
            this.AlRadioButton.AutoSize = true;
            this.AlRadioButton.Location = new System.Drawing.Point(6, 99);
            this.AlRadioButton.Name = "AlRadioButton";
            this.AlRadioButton.Size = new System.Drawing.Size(93, 17);
            this.AlRadioButton.TabIndex = 3;
            this.AlRadioButton.Text = "AlRadioButton";
            this.AlRadioButton.UseVisualStyleBackColor = true;
            this.AlRadioButton.CheckedChanged += new System.EventHandler(this.AlRadioButton_CheckedChanged);
            // 
            // BobRadioButton
            // 
            this.BobRadioButton.AutoSize = true;
            this.BobRadioButton.Location = new System.Drawing.Point(7, 76);
            this.BobRadioButton.Name = "BobRadioButton";
            this.BobRadioButton.Size = new System.Drawing.Size(103, 17);
            this.BobRadioButton.TabIndex = 2;
            this.BobRadioButton.Text = "BobRadioButton";
            this.BobRadioButton.UseVisualStyleBackColor = true;
            this.BobRadioButton.CheckedChanged += new System.EventHandler(this.BobRadioButton_CheckedChanged);
            // 
            // JoeRadioButton
            // 
            this.JoeRadioButton.AutoSize = true;
            this.JoeRadioButton.Checked = true;
            this.JoeRadioButton.Location = new System.Drawing.Point(6, 53);
            this.JoeRadioButton.Name = "JoeRadioButton";
            this.JoeRadioButton.Size = new System.Drawing.Size(101, 17);
            this.JoeRadioButton.TabIndex = 1;
            this.JoeRadioButton.TabStop = true;
            this.JoeRadioButton.Text = "JoeRadioButton";
            this.JoeRadioButton.UseVisualStyleBackColor = true;
            this.JoeRadioButton.CheckedChanged += new System.EventHandler(this.JoeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimumBetLabel.Location = new System.Drawing.Point(6, 28);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(149, 15);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimum Bet: 5 bucks";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racetrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "                                                    A Day At The Races";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown dogNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Button whoBets;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.RadioButton AlRadioButton;
        private System.Windows.Forms.RadioButton BobRadioButton;
        private System.Windows.Forms.RadioButton JoeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

