namespace WinFormsApp1
{
    partial class 숫자맞추기
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
            display = new Label();
            textBox = new TextBox();
            ButtonInput = new Button();
            ButtonStart = new Button();
            HINT = new Label();
            SuspendLayout();
            // 
            // display
            // 
            display.Dock = DockStyle.Top;
            display.Font = new Font("굴림", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            display.Location = new Point(0, 0);
            display.Name = "display";
            display.Size = new Size(536, 50);
            display.TabIndex = 0;
            display.Text = "게임을 시작합니다.";
            display.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox
            // 
            textBox.Font = new Font("굴림", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox.Location = new Point(56, 69);
            textBox.Name = "textBox";
            textBox.Size = new Size(167, 32);
            textBox.TabIndex = 1;
            // 
            // ButtonInput
            // 
            ButtonInput.AutoSize = true;
            ButtonInput.Font = new Font("굴림", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonInput.Location = new Point(281, 69);
            ButtonInput.Name = "ButtonInput";
            ButtonInput.Size = new Size(183, 31);
            ButtonInput.TabIndex = 2;
            ButtonInput.Text = "입력";
            ButtonInput.UseVisualStyleBackColor = true;
            ButtonInput.Click += ButtonInput_Click;
            // 
            // ButtonStart
            // 
            ButtonStart.AutoSize = true;
            ButtonStart.Dock = DockStyle.Bottom;
            ButtonStart.Font = new Font("굴림", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonStart.Location = new Point(0, 129);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(536, 31);
            ButtonStart.TabIndex = 3;
            ButtonStart.Text = "게임 시작";
            ButtonStart.UseVisualStyleBackColor = true;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // HINT
            // 
            HINT.AutoSize = true;
            HINT.Location = new Point(231, 111);
            HINT.Name = "HINT";
            HINT.Size = new Size(34, 15);
            HINT.TabIndex = 4;
            HINT.Text = "HINT";
            HINT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 160);
            Controls.Add(HINT);
            Controls.Add(ButtonStart);
            Controls.Add(ButtonInput);
            Controls.Add(textBox);
            Controls.Add(display);
            Name = "Form3";
            Text = "Form3";
            TextChanged += Form3_TextChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label display;
        private TextBox textBox;
        private Button ButtonInput;
        private Button ButtonStart;
        private Label HINT;
    }
}