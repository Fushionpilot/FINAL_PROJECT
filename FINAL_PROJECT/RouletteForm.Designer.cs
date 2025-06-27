namespace FINAL_PROJECT
{
    partial class RouletteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouletteForm));
            label4 = new Label();
            pictureBox1 = new PictureBox();
            spin_button = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            listBox1 = new ListBox();
            InventoryList = new ListBox();
            sell_button = new Button();
            label2 = new Label();
            balance_label = new Label();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(68, 23);
            label4.Name = "label4";
            label4.Size = new Size(135, 26);
            label4.TabIndex = 14;
            label4.Text = "Casino Royal";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // spin_button
            // 
            spin_button.BackColor = Color.SeaGreen;
            spin_button.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            spin_button.Location = new Point(220, 357);
            spin_button.Name = "spin_button";
            spin_button.Size = new Size(163, 54);
            spin_button.TabIndex = 15;
            spin_button.Text = "SPIN";
            spin_button.UseVisualStyleBackColor = false;
            spin_button.Click += spin_button_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(68, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 179);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(28, 371);
            label1.Name = "label1";
            label1.Size = new Size(99, 26);
            label1.TabIndex = 17;
            label1.Text = "Balance: ";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.HighlightText;
            listBox1.Font = new Font("Sitka Small", 9.163636F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "gold watch - 500 UAN", "diamond - 1500 UAN", "gold - 1000 UAN", "emerald - 250 UAN", "killer - reset", "man - 100 UAN", "laptop - 15000 UAN", "mouse - 300 UAN", "ring - 800 UAN", "car - 20000 UAN", "phone - 7000 UAN", "headphones - 1200 UAN", "painting - 5000 UAN", "silver coin - 400 UAN", "watch - 600 UAN", "tablet - 5500 UAN", "assasin - reset" });
            listBox1.Location = new Point(339, 23);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(248, 104);
            listBox1.TabIndex = 18;
            // 
            // InventoryList
            // 
            InventoryList.FormattingEnabled = true;
            InventoryList.Location = new Point(449, 316);
            InventoryList.Name = "InventoryList";
            InventoryList.Size = new Size(138, 99);
            InventoryList.TabIndex = 19;
            // 
            // sell_button
            // 
            sell_button.BackColor = Color.Sienna;
            sell_button.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sell_button.Location = new Point(464, 194);
            sell_button.Name = "sell_button";
            sell_button.Size = new Size(123, 54);
            sell_button.TabIndex = 20;
            sell_button.Text = "SELL ALL";
            sell_button.UseVisualStyleBackColor = false;
            sell_button.Click += sell_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(449, 282);
            label2.Name = "label2";
            label2.Size = new Size(133, 31);
            label2.TabIndex = 21;
            label2.Text = "Inventory:";
            // 
            // balance_label
            // 
            balance_label.AutoSize = true;
            balance_label.BackColor = Color.Transparent;
            balance_label.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold);
            balance_label.ForeColor = SystemColors.Control;
            balance_label.Location = new Point(133, 371);
            balance_label.Name = "balance_label";
            balance_label.Size = new Size(24, 26);
            balance_label.TabIndex = 22;
            balance_label.Text = "0";
            // 
            // backButton
            // 
            backButton.BackColor = Color.Brown;
            backButton.Font = new Font("Sitka Small", 18.3272724F, FontStyle.Bold, GraphicsUnit.Point, 204);
            backButton.Location = new Point(1, 207);
            backButton.Name = "backButton";
            backButton.Size = new Size(61, 54);
            backButton.TabIndex = 23;
            backButton.Text = "⬅";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // RouletteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(613, 450);
            Controls.Add(backButton);
            Controls.Add(balance_label);
            Controls.Add(label2);
            Controls.Add(sell_button);
            Controls.Add(InventoryList);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(spin_button);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RouletteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RouletteForm";
            Load += RouletteForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private PictureBox pictureBox1;
        private Button spin_button;
        private PictureBox pictureBox2;
        private Label label1;
        private ListBox listBox1;
        private ListBox InventoryList;
        private Button sell_button;
        private Label label2;
        private Label balance_label;
        private Button backButton;
    }
}