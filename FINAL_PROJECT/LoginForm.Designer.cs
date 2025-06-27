namespace FINAL_PROJECT
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            loginText_box = new TextBox();
            register_button = new Button();
            label2 = new Label();
            passwordTextBox = new TextBox();
            Login_button = new Button();
            label3 = new Label();
            yearsCheckBox = new CheckBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.7090912F, FontStyle.Bold);
            label1.Location = new Point(42, 146);
            label1.Name = "label1";
            label1.Size = new Size(97, 35);
            label1.TabIndex = 0;
            label1.Text = "Login:";
            // 
            // loginText_box
            // 
            loginText_box.Font = new Font("Segoe UI", 15.7090912F);
            loginText_box.Location = new Point(220, 146);
            loginText_box.Name = "loginText_box";
            loginText_box.Size = new Size(213, 39);
            loginText_box.TabIndex = 1;
            // 
            // register_button
            // 
            register_button.BackColor = Color.LimeGreen;
            register_button.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold);
            register_button.ForeColor = SystemColors.ActiveCaptionText;
            register_button.Location = new Point(340, 23);
            register_button.Name = "register_button";
            register_button.Size = new Size(109, 35);
            register_button.TabIndex = 3;
            register_button.Text = "Register";
            register_button.UseVisualStyleBackColor = false;
            register_button.Click += register_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 15.7090912F, FontStyle.Bold);
            label2.Location = new Point(42, 206);
            label2.Name = "label2";
            label2.Size = new Size(147, 35);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 15.7090912F);
            passwordTextBox.Location = new Point(220, 205);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(213, 39);
            passwordTextBox.TabIndex = 5;
            // 
            // Login_button
            // 
            Login_button.BackColor = Color.Yellow;
            Login_button.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Login_button.ForeColor = SystemColors.ActiveCaptionText;
            Login_button.Location = new Point(163, 356);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(152, 58);
            Login_button.TabIndex = 6;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = false;
            Login_button.Click += Login_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 15.7090912F, FontStyle.Bold);
            label3.Location = new Point(43, 271);
            label3.Name = "label3";
            label3.Size = new Size(96, 35);
            label3.TabIndex = 7;
            label3.Text = "Years:";
            // 
            // yearsCheckBox
            // 
            yearsCheckBox.AutoSize = true;
            yearsCheckBox.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            yearsCheckBox.Location = new Point(220, 277);
            yearsCheckBox.Name = "yearsCheckBox";
            yearsCheckBox.Size = new Size(110, 30);
            yearsCheckBox.TabIndex = 9;
            yearsCheckBox.Text = "21 years";
            yearsCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(68, 23);
            label4.Name = "label4";
            label4.Size = new Size(135, 26);
            label4.TabIndex = 12;
            label4.Text = "Casino Royal";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(472, 450);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(yearsCheckBox);
            Controls.Add(label3);
            Controls.Add(Login_button);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(register_button);
            Controls.Add(loginText_box);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginText_box;
        private Button register_button;
        private Label label2;
        private TextBox passwordTextBox;
        private Button Login_button;
        private Label label3;
        private CheckBox yearsCheckBox;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
