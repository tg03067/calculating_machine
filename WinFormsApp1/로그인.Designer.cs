namespace WinFormsApp1
{
    partial class 로그인
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
            label1 = new Label();
            id = new TextBox();
            password = new TextBox();
            SignInButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("굴림", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(337, 124);
            label1.Name = "label1";
            label1.Size = new Size(119, 24);
            label1.TabIndex = 0;
            label1.Text = "로그인 창";
            // 
            // id
            // 
            id.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            id.Location = new Point(234, 200);
            id.Name = "id";
            id.Size = new Size(346, 39);
            id.TabIndex = 1;
            id.Text = "아이디";
            id.TextChanged += id_TextChanged;
            // 
            // password
            // 
            password.Font = new Font("굴림", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            password.Location = new Point(234, 249);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(346, 39);
            password.TabIndex = 2;
            password.Text = "비밀번호";
            // 
            // SignInButton
            // 
            SignInButton.AutoSize = true;
            SignInButton.Font = new Font("굴림", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            SignInButton.Location = new Point(234, 327);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(346, 34);
            SignInButton.TabIndex = 3;
            SignInButton.Text = "로그인";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SignInButton);
            Controls.Add(password);
            Controls.Add(id);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox id;
        private TextBox password;
        private Button SignInButton;
    }
}