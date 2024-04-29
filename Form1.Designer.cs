namespace CalculatorApp
{
    partial class Form1
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
            label1 = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            process = new ComboBox();
            calculateButton = new Button();
            label2 = new Label();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(295, 37);
            label1.Name = "label1";
            label1.Size = new Size(211, 38);
            label1.TabIndex = 0;
            label1.Text = "Calculator App";
            // 
            // num1
            // 
            num1.Location = new Point(126, 135);
            num1.Name = "num1";
            num1.PlaceholderText = "Enter Num1";
            num1.Size = new Size(125, 27);
            num1.TabIndex = 1;
            num1.TextChanged += num1_TextChanged;
            // 
            // num2
            // 
            num2.Location = new Point(499, 135);
            num2.Name = "num2";
            num2.PlaceholderText = "Enter Num2";
            num2.Size = new Size(125, 27);
            num2.TabIndex = 2;
            // 
            // process
            // 
            process.FormattingEnabled = true;
            process.Items.AddRange(new object[] { "+", "-", "x", "÷" });
            process.Location = new Point(295, 134);
            process.Name = "process";
            process.Size = new Size(151, 28);
            process.TabIndex = 3;
            process.Text = "Select calculation";
            process.SelectedIndexChanged += process_SelectedIndexChanged;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(340, 236);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(94, 29);
            calculateButton.TabIndex = 4;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 341);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 5;
            label2.Text = "Result =";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(358, 341);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 28);
            resultLabel.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(label2);
            Controls.Add(calculateButton);
            Controls.Add(process);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox num1;
        private TextBox num2;
        private ComboBox process;
        private Button calculateButton;
        private Label label2;
        private Label resultLabel;
    }
}
