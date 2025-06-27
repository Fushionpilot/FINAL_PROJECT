namespace FINAL_PROJECT
{
    partial class BlackjackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackjackForm));
            backButton = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            balance_label = new Label();
            label1 = new Label();
            label2 = new Label();
            BettextBox = new TextBox();
            place_bet_button = new Button();
            label3 = new Label();
            hit_button = new Button();
            new_game_button = new Button();
            double_button = new Button();
            stand_button = new Button();
            label6 = new Label();
            result_label = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            label5 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            dealer_points = new Label();
            your_points = new Label();
            current_bet = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.Brown;
            backButton.Font = new Font("Sitka Small", 18.3272724F, FontStyle.Bold, GraphicsUnit.Point, 204);
            backButton.Location = new Point(569, 15);
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
            label4.Location = new Point(66, 30);
            label4.Name = "label4";
            label4.Size = new Size(135, 26);
            label4.TabIndex = 27;
            label4.Text = "Casino Royal";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // balance_label
            // 
            balance_label.AutoSize = true;
            balance_label.BackColor = Color.Transparent;
            balance_label.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold);
            balance_label.ForeColor = SystemColors.Control;
            balance_label.Location = new Point(449, 33);
            balance_label.Name = "balance_label";
            balance_label.Size = new Size(24, 26);
            balance_label.TabIndex = 29;
            balance_label.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(344, 33);
            label1.Name = "label1";
            label1.Size = new Size(99, 26);
            label1.TabIndex = 28;
            label1.Text = "Balance: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(89, 96);
            label2.Name = "label2";
            label2.Size = new Size(181, 26);
            label2.TabIndex = 30;
            label2.Text = "Place your bet:  $";
            // 
            // BettextBox
            // 
            BettextBox.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BettextBox.Location = new Point(276, 93);
            BettextBox.Multiline = true;
            BettextBox.Name = "BettextBox";
            BettextBox.Size = new Size(69, 30);
            BettextBox.TabIndex = 31;
            // 
            // place_bet_button
            // 
            place_bet_button.BackColor = Color.YellowGreen;
            place_bet_button.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            place_bet_button.Location = new Point(413, 93);
            place_bet_button.Name = "place_bet_button";
            place_bet_button.Size = new Size(120, 34);
            place_bet_button.TabIndex = 32;
            place_bet_button.Text = "Place Bet";
            place_bet_button.UseVisualStyleBackColor = false;
            place_bet_button.Click += place_bet_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(254, 260);
            label3.Name = "label3";
            label3.Size = new Size(124, 26);
            label3.TabIndex = 33;
            label3.Text = "Dealer card";
            // 
            // hit_button
            // 
            hit_button.BackColor = Color.YellowGreen;
            hit_button.Font = new Font("Sitka Small", 11.1272726F, FontStyle.Bold);
            hit_button.Location = new Point(66, 472);
            hit_button.Name = "hit_button";
            hit_button.Size = new Size(114, 48);
            hit_button.TabIndex = 35;
            hit_button.Text = "Hit";
            hit_button.UseVisualStyleBackColor = false;
            hit_button.Click += hit_button_Click;
            // 
            // new_game_button
            // 
            new_game_button.BackColor = Color.Teal;
            new_game_button.Font = new Font("Sitka Small", 11.1272726F, FontStyle.Bold);
            new_game_button.Location = new Point(466, 472);
            new_game_button.Name = "new_game_button";
            new_game_button.Size = new Size(114, 48);
            new_game_button.TabIndex = 38;
            new_game_button.Text = "New game";
            new_game_button.UseVisualStyleBackColor = false;
            new_game_button.Click += new_game_button_Click;
            // 
            // double_button
            // 
            double_button.BackColor = Color.Gold;
            double_button.Font = new Font("Sitka Small", 11.1272726F, FontStyle.Bold);
            double_button.Location = new Point(329, 472);
            double_button.Name = "double_button";
            double_button.Size = new Size(114, 48);
            double_button.TabIndex = 37;
            double_button.Text = "Double";
            double_button.UseVisualStyleBackColor = false;
            double_button.Click += double_button_Click_1;
            // 
            // stand_button
            // 
            stand_button.BackColor = Color.Red;
            stand_button.Font = new Font("Sitka Small", 11.1272726F, FontStyle.Bold);
            stand_button.Location = new Point(194, 472);
            stand_button.Name = "stand_button";
            stand_button.Size = new Size(114, 48);
            stand_button.TabIndex = 36;
            stand_button.Text = "Stand";
            stand_button.UseVisualStyleBackColor = false;
            stand_button.Click += stand_button_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(10, 291);
            label6.Name = "label6";
            label6.Size = new Size(144, 26);
            label6.TabIndex = 39;
            label6.Text = "Result game: ";
            // 
            // result_label
            // 
            result_label.AutoSize = true;
            result_label.BackColor = Color.Transparent;
            result_label.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            result_label.ForeColor = SystemColors.Control;
            result_label.Location = new Point(10, 331);
            result_label.Name = "result_label";
            result_label.Size = new Size(24, 26);
            result_label.TabIndex = 40;
            result_label.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(194, 171);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(229, 115);
            flowLayoutPanel1.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Sitka Small", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(89, 122);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 42;
            label9.Text = "Current bet:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(214, 142);
            label10.Name = "label10";
            label10.Size = new Size(149, 26);
            label10.TabIndex = 43;
            label10.Text = "Dealer points:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(216, 302);
            label5.Name = "label5";
            label5.Size = new Size(130, 26);
            label5.TabIndex = 34;
            label5.Text = "Your points:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(197, 331);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(229, 115);
            flowLayoutPanel2.TabIndex = 44;
            // 
            // dealer_points
            // 
            dealer_points.AutoSize = true;
            dealer_points.BackColor = Color.Transparent;
            dealer_points.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold);
            dealer_points.ForeColor = SystemColors.Control;
            dealer_points.Location = new Point(369, 142);
            dealer_points.Name = "dealer_points";
            dealer_points.Size = new Size(24, 26);
            dealer_points.TabIndex = 45;
            dealer_points.Text = "0";
            // 
            // your_points
            // 
            your_points.AutoSize = true;
            your_points.BackColor = Color.Transparent;
            your_points.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold);
            your_points.ForeColor = SystemColors.Control;
            your_points.Location = new Point(352, 302);
            your_points.Name = "your_points";
            your_points.Size = new Size(24, 26);
            your_points.TabIndex = 46;
            your_points.Text = "0";
            // 
            // current_bet
            // 
            current_bet.AutoSize = true;
            current_bet.BackColor = Color.Transparent;
            current_bet.Font = new Font("Sitka Small", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 204);
            current_bet.ForeColor = SystemColors.Control;
            current_bet.Location = new Point(188, 122);
            current_bet.Name = "current_bet";
            current_bet.Size = new Size(44, 20);
            current_bet.TabIndex = 47;
            current_bet.Text = "100$";
            // 
            // BlackjackForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(642, 592);
            Controls.Add(current_bet);
            Controls.Add(your_points);
            Controls.Add(dealer_points);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(result_label);
            Controls.Add(label6);
            Controls.Add(new_game_button);
            Controls.Add(double_button);
            Controls.Add(stand_button);
            Controls.Add(hit_button);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(place_bet_button);
            Controls.Add(BettextBox);
            Controls.Add(label2);
            Controls.Add(balance_label);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BlackjackForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BlackjackForm";
            Load += BlackjackForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Label label4;
        private PictureBox pictureBox1;
        private Label balance_label;
        private Label label1;
        private Label label2;
        private TextBox BettextBox;
        private Button place_bet_button;
        private Label label3;
        private Button hit_button;
        private Button new_game_button;
        private Button double_button;
        private Button stand_button;
        private Label label6;
        private Label result_label;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label9;
        private Label label10;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label dealer_points;
        private Label your_points;
        private Label current_bet;
    }
}