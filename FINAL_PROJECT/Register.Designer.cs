namespace FINAL_PROJECT
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            label2 = new Label();
            registerText_box = new TextBox();
            password_regtextBox = new TextBox();
            yearsCheckBox = new CheckBox();
            label3 = new Label();
            register_button = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.7090912F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(72, 108);
            label1.Name = "label1";
            label1.Size = new Size(97, 35);
            label1.TabIndex = 1;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 15.7090912F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(72, 169);
            label2.Name = "label2";
            label2.Size = new Size(147, 35);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // registerText_box
            // 
            registerText_box.Font = new Font("Segoe UI", 15.7090912F);
            registerText_box.Location = new Point(245, 108);
            registerText_box.Name = "registerText_box";
            registerText_box.Size = new Size(213, 39);
            registerText_box.TabIndex = 4;
            // 
            // password_regtextBox
            // 
            password_regtextBox.Font = new Font("Segoe UI", 15.7090912F);
            password_regtextBox.Location = new Point(245, 169);
            password_regtextBox.Name = "password_regtextBox";
            password_regtextBox.PasswordChar = '*';
            password_regtextBox.Size = new Size(213, 39);
            password_regtextBox.TabIndex = 5;
            // 
            // yearsCheckBox
            // 
            yearsCheckBox.AutoSize = true;
            yearsCheckBox.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            yearsCheckBox.ForeColor = SystemColors.Control;
            yearsCheckBox.Location = new Point(245, 264);
            yearsCheckBox.Name = "yearsCheckBox";
            yearsCheckBox.Size = new Size(110, 30);
            yearsCheckBox.TabIndex = 11;
            yearsCheckBox.Text = "21 years";
            yearsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 15.7090912F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(73, 264);
            label3.Name = "label3";
            label3.Size = new Size(96, 35);
            label3.TabIndex = 10;
            label3.Text = "Years:";
            // 
            // register_button
            // 
            register_button.BackColor = Color.Yellow;
            register_button.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            register_button.ForeColor = SystemColors.ActiveCaptionText;
            register_button.Location = new Point(180, 379);
            register_button.Name = "register_button";
            register_button.Size = new Size(152, 58);
            register_button.TabIndex = 12;
            register_button.Text = "Register";
            register_button.UseVisualStyleBackColor = false;
            register_button.Click += register_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(69, 24);
            label4.Name = "label4";
            label4.Size = new Size(135, 26);
            label4.TabIndex = 16;
            label4.Text = "Casino Royal";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(507, 517);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(register_button);
            Controls.Add(yearsCheckBox);
            Controls.Add(label3);
            Controls.Add(password_regtextBox);
            Controls.Add(registerText_box);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox registerText_box;
        private TextBox password_regtextBox;
        private CheckBox yearsCheckBox;
        private Label label3;
        private Button register_button;
        private Label label4;
        private PictureBox pictureBox1;
    }
}