namespace WinFormsApp1
{
    partial class 계산기
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(계산기));
            display = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ButtonAdd = new Button();
            ButtonPoint = new Button();
            ButtonZero = new Button();
            ButtonAllClear = new Button();
            ButtonSubtract = new Button();
            ButtonThree = new Button();
            ButtonTwo = new Button();
            ButtonOne = new Button();
            ButtonMultiply = new Button();
            ButtonSix = new Button();
            ButtonFive = new Button();
            ButtonFour = new Button();
            ButtonDivide = new Button();
            ButtonNine = new Button();
            ButtonEight = new Button();
            ButtonSeven = new Button();
            ButtonResult = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            resources.ApplyResources(display, "display");
            display.Name = "display";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(ButtonAdd, 3, 3);
            tableLayoutPanel1.Controls.Add(ButtonPoint, 2, 3);
            tableLayoutPanel1.Controls.Add(ButtonZero, 1, 3);
            tableLayoutPanel1.Controls.Add(ButtonAllClear, 0, 3);
            tableLayoutPanel1.Controls.Add(ButtonSubtract, 3, 2);
            tableLayoutPanel1.Controls.Add(ButtonThree, 2, 2);
            tableLayoutPanel1.Controls.Add(ButtonTwo, 1, 2);
            tableLayoutPanel1.Controls.Add(ButtonOne, 0, 2);
            tableLayoutPanel1.Controls.Add(ButtonMultiply, 3, 1);
            tableLayoutPanel1.Controls.Add(ButtonSix, 2, 1);
            tableLayoutPanel1.Controls.Add(ButtonFive, 1, 1);
            tableLayoutPanel1.Controls.Add(ButtonFour, 0, 1);
            tableLayoutPanel1.Controls.Add(ButtonDivide, 3, 0);
            tableLayoutPanel1.Controls.Add(ButtonNine, 2, 0);
            tableLayoutPanel1.Controls.Add(ButtonEight, 1, 0);
            tableLayoutPanel1.Controls.Add(ButtonSeven, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // ButtonAdd
            // 
            resources.ApplyResources(ButtonAdd, "ButtonAdd");
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonPoint
            // 
            resources.ApplyResources(ButtonPoint, "ButtonPoint");
            ButtonPoint.Name = "ButtonPoint";
            ButtonPoint.UseVisualStyleBackColor = true;
            ButtonPoint.Click += ButtonPoint_Click;
            // 
            // ButtonZero
            // 
            resources.ApplyResources(ButtonZero, "ButtonZero");
            ButtonZero.Name = "ButtonZero";
            ButtonZero.UseVisualStyleBackColor = true;
            ButtonZero.Click += ButtonZero_Click;
            // 
            // ButtonAllClear
            // 
            resources.ApplyResources(ButtonAllClear, "ButtonAllClear");
            ButtonAllClear.Name = "ButtonAllClear";
            ButtonAllClear.UseVisualStyleBackColor = true;
            ButtonAllClear.Click += ButtonAllClear_Click;
            // 
            // ButtonSubtract
            // 
            resources.ApplyResources(ButtonSubtract, "ButtonSubtract");
            ButtonSubtract.Name = "ButtonSubtract";
            ButtonSubtract.UseVisualStyleBackColor = true;
            ButtonSubtract.Click += ButtonSubtract_Click;
            // 
            // ButtonThree
            // 
            resources.ApplyResources(ButtonThree, "ButtonThree");
            ButtonThree.Name = "ButtonThree";
            ButtonThree.UseVisualStyleBackColor = true;
            ButtonThree.Click += ButtonThree_Click;
            // 
            // ButtonTwo
            // 
            resources.ApplyResources(ButtonTwo, "ButtonTwo");
            ButtonTwo.Name = "ButtonTwo";
            ButtonTwo.UseVisualStyleBackColor = true;
            ButtonTwo.Click += ButtonTwo_Click;
            // 
            // ButtonOne
            // 
            resources.ApplyResources(ButtonOne, "ButtonOne");
            ButtonOne.Name = "ButtonOne";
            ButtonOne.UseVisualStyleBackColor = true;
            ButtonOne.Click += ButtonOne_Click;
            // 
            // ButtonMultiply
            // 
            resources.ApplyResources(ButtonMultiply, "ButtonMultiply");
            ButtonMultiply.Name = "ButtonMultiply";
            ButtonMultiply.UseVisualStyleBackColor = true;
            ButtonMultiply.Click += ButtonMultiply_Click;
            // 
            // ButtonSix
            // 
            resources.ApplyResources(ButtonSix, "ButtonSix");
            ButtonSix.Name = "ButtonSix";
            ButtonSix.UseVisualStyleBackColor = true;
            ButtonSix.Click += ButtonSix_Click;
            // 
            // ButtonFive
            // 
            resources.ApplyResources(ButtonFive, "ButtonFive");
            ButtonFive.Name = "ButtonFive";
            ButtonFive.UseVisualStyleBackColor = true;
            ButtonFive.Click += ButtonFive_Click;
            // 
            // ButtonFour
            // 
            resources.ApplyResources(ButtonFour, "ButtonFour");
            ButtonFour.Name = "ButtonFour";
            ButtonFour.UseVisualStyleBackColor = true;
            ButtonFour.Click += ButtonFour_Click;
            // 
            // ButtonDivide
            // 
            resources.ApplyResources(ButtonDivide, "ButtonDivide");
            ButtonDivide.Name = "ButtonDivide";
            ButtonDivide.UseVisualStyleBackColor = true;
            ButtonDivide.Click += ButtonDivide_Click;
            // 
            // ButtonNine
            // 
            resources.ApplyResources(ButtonNine, "ButtonNine");
            ButtonNine.Name = "ButtonNine";
            ButtonNine.UseVisualStyleBackColor = true;
            ButtonNine.Click += ButtonNine_Click;
            // 
            // ButtonEight
            // 
            resources.ApplyResources(ButtonEight, "ButtonEight");
            ButtonEight.Name = "ButtonEight";
            ButtonEight.UseVisualStyleBackColor = true;
            ButtonEight.Click += ButtonEight_Click;
            // 
            // ButtonSeven
            // 
            resources.ApplyResources(ButtonSeven, "ButtonSeven");
            ButtonSeven.Name = "ButtonSeven";
            ButtonSeven.UseVisualStyleBackColor = true;
            ButtonSeven.Click += ButtonSeven_Click;
            // 
            // ButtonResult
            // 
            resources.ApplyResources(ButtonResult, "ButtonResult");
            ButtonResult.Name = "ButtonResult";
            ButtonResult.UseVisualStyleBackColor = true;
            ButtonResult.Click += ButtonResult_Click;
            // 
            // 계산기
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonResult);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(display);
            Name = "계산기";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label display;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ButtonAdd;
        private Button ButtonPoint;
        private Button ButtonZero;
        private Button ButtonAllClear;
        private Button ButtonSubtract;
        private Button ButtonThree;
        private Button ButtonTwo;
        private Button ButtonOne;
        private Button ButtonMultiply;
        private Button ButtonSix;
        private Button ButtonFive;
        private Button ButtonFour;
        private Button ButtonDivide;
        private Button ButtonNine;
        private Button ButtonEight;
        private Button ButtonSeven;
        private Button ButtonResult;
    }
}