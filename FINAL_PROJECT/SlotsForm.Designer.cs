namespace FINAL_PROJECT
{
    partial class SlotsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotsForm));
            backButton = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            balance_lbl = new Label();
            Bet_lbl = new Label();
            result_lbl = new Label();
            spin_button = new Button();
            bet_plus_button = new Button();
            bet_minys_button = new Button();
            max_button = new Button();
            new_game_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.Brown;
            backButton.Font = new Font("Sitka Small", 18.3272724F, FontStyle.Bold, GraphicsUnit.Point, 204);
            backButton.Location = new Point(569, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(61, 54);
            backButton.TabIndex = 24;
            backButton.Text = "⬅";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(63, 18);
            label4.Name = "label4";
            label4.Size = new Size(135, 26);
            label4.TabIndex = 26;
            label4.Text = "Casino Royal";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(86, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(148, 114);
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Location = new Point(252, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(148, 114);
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Location = new Point(416, 94);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(148, 114);
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 13.7454548F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(140, 237);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 30;
            label1.Text = "Balance:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 13.7454548F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(140, 277);
            label2.Name = "label2";
            label2.Size = new Size(59, 31);
            label2.TabIndex = 31;
            label2.Text = "Bet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Small", 13.7454548F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(140, 316);
            label3.Name = "label3";
            label3.Size = new Size(94, 31);
            label3.TabIndex = 32;
            label3.Text = "Result:";
            // 
            // balance_lbl
            // 
            balance_lbl.AutoSize = true;
            balance_lbl.BackColor = Color.Transparent;
            balance_lbl.Font = new Font("Sitka Small", 13.7454548F, FontStyle.Bold);
            balance_lbl.ForeColor = SystemColors.Control;
            balance_lbl.Location = new Point(256, 237);
            balance_lbl.Name = "balance_lbl";
            balance_lbl.Size = new Size(29, 31);
            balance_lbl.TabIndex = 33;
            balance_lbl.Text = "0";
            // 
            // Bet_lbl
            // 
            Bet_lbl.AutoSize = true;
            Bet_lbl.BackColor = Color.Transparent;
            Bet_lbl.Font = new Font("Sitka Small", 13.7454548F, FontStyle.Bold);
            Bet_lbl.ForeColor = SystemColors.Control;
            Bet_lbl.Location = new Point(205, 277);
            Bet_lbl.Name = "Bet_lbl";
            Bet_lbl.Size = new Size(29, 31);
            Bet_lbl.TabIndex = 34;
            Bet_lbl.Text = "0";
            // 
            // result_lbl
            // 
            result_lbl.AutoSize = true;
            result_lbl.BackColor = Color.Transparent;
            result_lbl.Font = new Font("Sitka Small", 13.7454548F, FontStyle.Bold);
            result_lbl.ForeColor = SystemColors.Control;
            result_lbl.Location = new Point(240, 316);
            result_lbl.Name = "result_lbl";
            result_lbl.Size = new Size(29, 31);
            result_lbl.TabIndex = 35;
            result_lbl.Text = "0";
            // 
            // spin_button
            // 
            spin_button.BackColor = Color.Violet;
            spin_button.Font = new Font("Sitka Small", 11.1272726F, FontStyle.Bold);
            spin_button.Location = new Point(34, 401);
            spin_button.Name = "spin_button";
            spin_button.Size = new Size(132, 38);
            spin_button.TabIndex = 36;
            spin_button.Text = "Spin";
            spin_button.UseVisualStyleBackColor = false;
            spin_button.Click += spin_button_Click;
            // 
            // bet_plus_button
            // 
            bet_plus_button.BackColor = Color.YellowGreen;
            bet_plus_button.Font = new Font("Sitka Small", 11.1272726F, FontStyle.Bold);
            bet_plus_button.Location = new Point(181, 401);
            bet_plus_button.Name = "bet_plus_button";
            bet_plus_button.Size = new Size(132, 38);
            bet_plus_button.TabIndex = 37;
            bet_plus_button.Text = "Bet +";
            bet_plus_button.UseVisualStyleBackColor = false;
            bet_plus_button.Click += bet_plus_button_Click;
            // 
            // bet_minys_button
            // 
            bet_minys_button.BackColor = Color.Red;
            bet_minys_button.Font = new Font("Sitka Small", 11.1272726F, FontStyle.Bold);
            bet_minys_button.Location = new Point(337, 401);
            bet_minys_button.Name = "bet_minys_button";
            bet_minys_button.Size = new Size(132, 38);
            bet_minys_button.TabIndex = 38;
            bet_minys_button.Text = "Bet -";
            bet_minys_button.UseVisualStyleBackColor = false;
            bet_minys_button.Click += bet_minys_button_Click;
            // 
            // max_button
            // 
            max_button.BackColor = Color.Gold;
            max_button.Font = new Font("Sitka Small", 11.1272726F, FontStyle.Bold);
            max_button.Location = new Point(484, 401);
            max_button.Name = "max_button";
            max_button.Size = new Size(132, 38);
            max_button.TabIndex = 39;
            max_button.Text = "Max";
            max_button.UseVisualStyleBackColor = false;
            max_button.Click += max_button_Click;
            // 
            // new_game_button
            // 
            new_game_button.BackColor = Color.Teal;
            new_game_button.Font = new Font("Sitka Small", 11.1272726F, FontStyle.Bold);
            new_game_button.Location = new Point(256, 484);
            new_game_button.Name = "new_game_button";
            new_game_button.Size = new Size(132, 38);
            new_game_button.TabIndex = 40;
            new_game_button.Text = "New game";
            new_game_button.UseVisualStyleBackColor = false;
            new_game_button.Click += new_game_button_Click;
            // 
            // SlotsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(642, 556);
            Controls.Add(new_game_button);
            Controls.Add(max_button);
            Controls.Add(bet_minys_button);
            Controls.Add(bet_plus_button);
            Controls.Add(spin_button);
            Controls.Add(result_lbl);
            Controls.Add(Bet_lbl);
            Controls.Add(balance_lbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SlotsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SlotsForm";
            Load += SlotsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label balance_lbl;
        private Label Bet_lbl;
        private Label result_lbl;
        private Button spin_button;
        private Button bet_plus_button;
        private Button bet_minys_button;
        private Button max_button;
        private Button new_game_button;
    }
}