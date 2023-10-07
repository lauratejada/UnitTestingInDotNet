namespace CalculatorProject
{
    partial class CalculatorForm
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
            DisplayResults = new TextBox();
            ButtonNumber7 = new Button();
            ButtonNumber8 = new Button();
            ButtonNumber9 = new Button();
            ButtonMultiply = new Button();
            ButtonSubstract = new Button();
            ButtonNumber6 = new Button();
            ButtonNumber5 = new Button();
            ButtonNumber4 = new Button();
            ButtonAdd = new Button();
            ButtonNumber3 = new Button();
            ButtonNumber2 = new Button();
            ButtonNumber1 = new Button();
            ButtonEquals = new Button();
            ButtonDot = new Button();
            ButtonNumber0 = new Button();
            ButtonDivide = new Button();
            ButtonClear = new Button();
            ToBinaryLabel = new Label();
            ToHexaDecimalLabel = new Label();
            ToBinaryDisplayValue = new Label();
            ToHexaDecimalDisplayValue = new Label();
            DisplayOperationLabel = new Label();
            SuspendLayout();
            // 
            // DisplayResults
            // 
            DisplayResults.AccessibleName = "DisplayResults";
            DisplayResults.BackColor = SystemColors.Menu;
            DisplayResults.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayResults.Location = new Point(38, 45);
            DisplayResults.Margin = new Padding(5);
            DisplayResults.Name = "DisplayResults";
            DisplayResults.PlaceholderText = "0";
            DisplayResults.RightToLeft = RightToLeft.No;
            DisplayResults.Size = new Size(283, 47);
            DisplayResults.TabIndex = 0;
            DisplayResults.TextAlign = HorizontalAlignment.Right;
            DisplayResults.TextChanged += DisplayResults_TextChanged;
            // 
            // ButtonNumber7
            // 
            ButtonNumber7.AccessibleName = "ButtonNumber7";
            ButtonNumber7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNumber7.Location = new Point(38, 166);
            ButtonNumber7.Name = "ButtonNumber7";
            ButtonNumber7.Size = new Size(69, 60);
            ButtonNumber7.TabIndex = 1;
            ButtonNumber7.Text = "7";
            ButtonNumber7.UseVisualStyleBackColor = true;
            ButtonNumber7.Click += ButtonNumber7_Click;
            // 
            // ButtonNumber8
            // 
            ButtonNumber8.AccessibleName = "ButtonNumber8";
            ButtonNumber8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNumber8.Location = new Point(109, 166);
            ButtonNumber8.Name = "ButtonNumber8";
            ButtonNumber8.Size = new Size(69, 60);
            ButtonNumber8.TabIndex = 2;
            ButtonNumber8.Text = "8";
            ButtonNumber8.UseVisualStyleBackColor = true;
            ButtonNumber8.Click += ButtonNumber8_Click;
            // 
            // ButtonNumber9
            // 
            ButtonNumber9.AccessibleName = "ButtonNumber9";
            ButtonNumber9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNumber9.Location = new Point(180, 166);
            ButtonNumber9.Name = "ButtonNumber9";
            ButtonNumber9.Size = new Size(69, 60);
            ButtonNumber9.TabIndex = 3;
            ButtonNumber9.Text = "9";
            ButtonNumber9.UseVisualStyleBackColor = true;
            ButtonNumber9.Click += ButtonNumber9_Click;
            // 
            // ButtonMultiply
            // 
            ButtonMultiply.AccessibleName = "ButtonMultiply";
            ButtonMultiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMultiply.Location = new Point(252, 166);
            ButtonMultiply.Name = "ButtonMultiply";
            ButtonMultiply.Size = new Size(69, 60);
            ButtonMultiply.TabIndex = 4;
            ButtonMultiply.Text = "*";
            ButtonMultiply.UseVisualStyleBackColor = true;
            ButtonMultiply.Click += ButtonMultiply_Click;
            // 
            // ButtonSubstract
            // 
            ButtonSubstract.AccessibleName = "ButtonSubstract";
            ButtonSubstract.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSubstract.Location = new Point(252, 228);
            ButtonSubstract.Name = "ButtonSubstract";
            ButtonSubstract.Size = new Size(69, 60);
            ButtonSubstract.TabIndex = 8;
            ButtonSubstract.Text = "-";
            ButtonSubstract.UseVisualStyleBackColor = true;
            ButtonSubstract.Click += ButtonSubstract_Click;
            // 
            // ButtonNumber6
            // 
            ButtonNumber6.AccessibleName = "ButtonNumber6";
            ButtonNumber6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNumber6.Location = new Point(181, 228);
            ButtonNumber6.Name = "ButtonNumber6";
            ButtonNumber6.Size = new Size(69, 60);
            ButtonNumber6.TabIndex = 7;
            ButtonNumber6.Text = "6";
            ButtonNumber6.UseVisualStyleBackColor = true;
            ButtonNumber6.Click += ButtonNumber6_Click;
            // 
            // ButtonNumber5
            // 
            ButtonNumber5.AccessibleName = "ButtonNumber5";
            ButtonNumber5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNumber5.Location = new Point(109, 228);
            ButtonNumber5.Name = "ButtonNumber5";
            ButtonNumber5.Size = new Size(69, 60);
            ButtonNumber5.TabIndex = 6;
            ButtonNumber5.Text = "5";
            ButtonNumber5.UseVisualStyleBackColor = true;
            ButtonNumber5.Click += ButtonNumber5_Click;
            // 
            // ButtonNumber4
            // 
            ButtonNumber4.AccessibleName = "ButtonNumber4";
            ButtonNumber4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNumber4.Location = new Point(38, 228);
            ButtonNumber4.Name = "ButtonNumber4";
            ButtonNumber4.Size = new Size(69, 60);
            ButtonNumber4.TabIndex = 5;
            ButtonNumber4.Text = "4";
            ButtonNumber4.UseVisualStyleBackColor = true;
            ButtonNumber4.Click += ButtonNumber4_Click;
            // 
            // ButtonAdd
            // 
            ButtonAdd.AccessibleName = "ButtonAdd";
            ButtonAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAdd.Location = new Point(252, 290);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(69, 60);
            ButtonAdd.TabIndex = 12;
            ButtonAdd.Text = "+";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonNumber3
            // 
            ButtonNumber3.AccessibleName = "ButtonNumber3";
            ButtonNumber3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNumber3.Location = new Point(181, 290);
            ButtonNumber3.Name = "ButtonNumber3";
            ButtonNumber3.Size = new Size(69, 60);
            ButtonNumber3.TabIndex = 11;
            ButtonNumber3.Text = "3";
            ButtonNumber3.UseVisualStyleBackColor = true;
            ButtonNumber3.Click += ButtonNumber3_Click;
            // 
            // ButtonNumber2
            // 
            ButtonNumber2.AccessibleName = "ButtonNumber2";
            ButtonNumber2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNumber2.Location = new Point(109, 290);
            ButtonNumber2.Name = "ButtonNumber2";
            ButtonNumber2.Size = new Size(69, 60);
            ButtonNumber2.TabIndex = 10;
            ButtonNumber2.Text = "2";
            ButtonNumber2.UseVisualStyleBackColor = true;
            ButtonNumber2.Click += ButtonNumber2_Click;
            // 
            // ButtonNumber1
            // 
            ButtonNumber1.AccessibleName = "ButtonNumber1";
            ButtonNumber1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNumber1.Location = new Point(38, 290);
            ButtonNumber1.Name = "ButtonNumber1";
            ButtonNumber1.Size = new Size(69, 60);
            ButtonNumber1.TabIndex = 9;
            ButtonNumber1.Text = "1";
            ButtonNumber1.UseVisualStyleBackColor = true;
            ButtonNumber1.Click += ButtonNumber1_Click;
            // 
            // ButtonEquals
            // 
            ButtonEquals.AccessibleName = "ButtonEquals";
            ButtonEquals.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEquals.Location = new Point(252, 352);
            ButtonEquals.Name = "ButtonEquals";
            ButtonEquals.Size = new Size(69, 60);
            ButtonEquals.TabIndex = 16;
            ButtonEquals.Text = "=";
            ButtonEquals.UseVisualStyleBackColor = true;
            ButtonEquals.Click += ButtonEquals_Click;
            // 
            // ButtonDot
            // 
            ButtonDot.AccessibleName = "ButtonDot";
            ButtonDot.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDot.Location = new Point(181, 352);
            ButtonDot.Name = "ButtonDot";
            ButtonDot.Size = new Size(69, 60);
            ButtonDot.TabIndex = 15;
            ButtonDot.Text = ".";
            ButtonDot.UseVisualStyleBackColor = true;
            ButtonDot.Click += ButtonDot_Click;
            // 
            // ButtonNumber0
            // 
            ButtonNumber0.AccessibleName = "ButtonNumber0";
            ButtonNumber0.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNumber0.Location = new Point(38, 353);
            ButtonNumber0.Name = "ButtonNumber0";
            ButtonNumber0.Size = new Size(140, 59);
            ButtonNumber0.TabIndex = 13;
            ButtonNumber0.Text = "0";
            ButtonNumber0.UseVisualStyleBackColor = true;
            ButtonNumber0.Click += ButtonNumber0_Click;
            // 
            // ButtonDivide
            // 
            ButtonDivide.AccessibleName = "ButtonDivide";
            ButtonDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDivide.Location = new Point(253, 104);
            ButtonDivide.Name = "ButtonDivide";
            ButtonDivide.Size = new Size(69, 60);
            ButtonDivide.TabIndex = 20;
            ButtonDivide.Text = "/";
            ButtonDivide.UseVisualStyleBackColor = true;
            ButtonDivide.Click += ButtonDivide_Click;
            // 
            // ButtonClear
            // 
            ButtonClear.AccessibleName = "ButtonClear";
            ButtonClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonClear.Location = new Point(39, 104);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(211, 60);
            ButtonClear.TabIndex = 18;
            ButtonClear.Text = "Clear";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            ButtonClear.KeyPress += ButtonClear_Click;
            // 
            // ToBinaryLabel
            // 
            ToBinaryLabel.AccessibleName = "ToBinaryLabel";
            ToBinaryLabel.AutoSize = true;
            ToBinaryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ToBinaryLabel.Location = new Point(344, 45);
            ToBinaryLabel.Name = "ToBinaryLabel";
            ToBinaryLabel.Size = new Size(73, 21);
            ToBinaryLabel.TabIndex = 21;
            ToBinaryLabel.Text = "To Binary";
            // 
            // ToHexaDecimalLabel
            // 
            ToHexaDecimalLabel.AccessibleName = "ToHexaDecimalLabel";
            ToHexaDecimalLabel.AutoSize = true;
            ToHexaDecimalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ToHexaDecimalLabel.Location = new Point(344, 71);
            ToHexaDecimalLabel.Name = "ToHexaDecimalLabel";
            ToHexaDecimalLabel.Size = new Size(119, 21);
            ToHexaDecimalLabel.TabIndex = 22;
            ToHexaDecimalLabel.Text = "To HexaDecimal";
            // 
            // ToBinaryDisplayValue
            // 
            ToBinaryDisplayValue.AccessibleName = "ToBinaryDisplayValue";
            ToBinaryDisplayValue.AutoSize = true;
            ToBinaryDisplayValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ToBinaryDisplayValue.Location = new Point(478, 45);
            ToBinaryDisplayValue.Name = "ToBinaryDisplayValue";
            ToBinaryDisplayValue.Size = new Size(82, 21);
            ToBinaryDisplayValue.TabIndex = 23;
            ToBinaryDisplayValue.Text = "00000000";
            // 
            // ToHexaDecimalDisplayValue
            // 
            ToHexaDecimalDisplayValue.AccessibleName = "ToHexaDecimalDisplayValue";
            ToHexaDecimalDisplayValue.AutoSize = true;
            ToHexaDecimalDisplayValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ToHexaDecimalDisplayValue.Location = new Point(478, 71);
            ToHexaDecimalDisplayValue.Name = "ToHexaDecimalDisplayValue";
            ToHexaDecimalDisplayValue.Size = new Size(82, 21);
            ToHexaDecimalDisplayValue.TabIndex = 24;
            ToHexaDecimalDisplayValue.Text = "00000000";
            // 
            // DisplayOperationLabel
            // 
            DisplayOperationLabel.AccessibleName = "DisplayOperationLabel";
            DisplayOperationLabel.AutoSize = true;
            DisplayOperationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayOperationLabel.Location = new Point(302, 19);
            DisplayOperationLabel.Name = "DisplayOperationLabel";
            DisplayOperationLabel.RightToLeft = RightToLeft.Yes;
            DisplayOperationLabel.Size = new Size(19, 21);
            DisplayOperationLabel.TabIndex = 25;
            DisplayOperationLabel.Text = "0";
            DisplayOperationLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayOperationLabel);
            Controls.Add(ToHexaDecimalDisplayValue);
            Controls.Add(ToBinaryDisplayValue);
            Controls.Add(ToHexaDecimalLabel);
            Controls.Add(ToBinaryLabel);
            Controls.Add(ButtonDivide);
            Controls.Add(ButtonClear);
            Controls.Add(ButtonEquals);
            Controls.Add(ButtonDot);
            Controls.Add(ButtonNumber0);
            Controls.Add(ButtonAdd);
            Controls.Add(ButtonNumber3);
            Controls.Add(ButtonNumber2);
            Controls.Add(ButtonNumber1);
            Controls.Add(ButtonSubstract);
            Controls.Add(ButtonNumber6);
            Controls.Add(ButtonNumber5);
            Controls.Add(ButtonNumber4);
            Controls.Add(ButtonMultiply);
            Controls.Add(ButtonNumber9);
            Controls.Add(ButtonNumber8);
            Controls.Add(ButtonNumber7);
            Controls.Add(DisplayResults);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            KeyDown += Calculator_KeyDown;
            KeyPress += Calculator_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DisplayResults;
        private Button ButtonNumber7;
        private Button ButtonNumber8;
        private Button ButtonNumber9;
        private Button ButtonMultiply;
        private Button ButtonSubstract;
        private Button ButtonNumber6;
        private Button ButtonNumber5;
        private Button ButtonNumber4;
        private Button ButtonAdd;
        private Button ButtonNumber3;
        private Button ButtonNumber2;
        private Button ButtonNumber1;
        private Button ButtonEquals;
        private Button ButtonDot;
        private Button ButtonNumber0;
        private Button ButtonDivide;
        private Button ButtonClear;
        private Label ToBinaryLabel;
        private Label ToHexaDecimalLabel;
        private Label ToBinaryDisplayValue;
        private Label ToHexaDecimalDisplayValue;
        private Label DisplayOperationLabel;
    }
}