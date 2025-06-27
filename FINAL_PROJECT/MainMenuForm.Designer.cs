namespace FINAL_PROJECT
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuSpin = new Button();
            menuBlackJack = new Button();
            menuSlots = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(68, 23);
            label4.Name = "label4";
            label4.Size = new Size(135, 26);
            label4.TabIndex = 14;
            label4.Text = "Casino Royal";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18.3272724F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(212, 90);
            label1.Name = "label1";
            label1.Size = new Size(267, 42);
            label1.TabIndex = 15;
            label1.Text = "Choose the game";
            // 
            // menuSpin
            // 
            menuSpin.BackColor = Color.Crimson;
            menuSpin.Font = new Font("Sitka Small", 9.818182F, FontStyle.Bold);
            menuSpin.Location = new Point(70, 326);
            menuSpin.Name = "menuSpin";
            menuSpin.Size = new Size(135, 51);
            menuSpin.TabIndex = 16;
            menuSpin.Text = "SPIN";
            menuSpin.UseVisualStyleBackColor = false;
            menuSpin.Click += menuSpin_Click;
            // 
            // menuBlackJack
            // 
            menuBlackJack.BackColor = Color.Crimson;
            menuBlackJack.Font = new Font("Sitka Small", 9.818182F, FontStyle.Bold);
            menuBlackJack.Location = new Point(272, 326);
            menuBlackJack.Name = "menuBlackJack";
            menuBlackJack.Size = new Size(135, 51);
            menuBlackJack.TabIndex = 17;
            menuBlackJack.Text = "BLACKJACK";
            menuBlackJack.UseVisualStyleBackColor = false;
            menuBlackJack.Click += menuBlackJack_Click_1;
            // 
            // menuSlots
            // 
            menuSlots.BackColor = Color.Crimson;
            menuSlots.Font = new Font("Sitka Small", 9.818182F, FontStyle.Bold);
            menuSlots.Location = new Point(478, 326);
            menuSlots.Name = "menuSlots";
            menuSlots.Size = new Size(135, 51);
            menuSlots.TabIndex = 18;
            menuSlots.Text = "SLOTS";
            menuSlots.UseVisualStyleBackColor = false;
            menuSlots.Click += menuSlots_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(91, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(288, 199);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(492, 199);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(695, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(menuSlots);
            Controls.Add(menuBlackJack);
            Controls.Add(menuSpin);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenuForm";
            Load += MainMenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private PictureBox pictureBox1;
        private Label label1;
        private Button menuSpin;
        private Button menuBlackJack;
        private Button menuSlots;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}