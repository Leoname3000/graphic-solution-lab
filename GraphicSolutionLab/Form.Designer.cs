
namespace GraphicSolutionLab
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.equationsGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.secondConstField = new System.Windows.Forms.TextBox();
            this.secondLinearField = new System.Windows.Forms.TextBox();
            this.firstConstField = new System.Windows.Forms.TextBox();
            this.firstLinearField = new System.Windows.Forms.TextBox();
            this.firstSquareField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.noSolutionLabel = new System.Windows.Forms.Label();
            this.firstSolutionGroupBox = new System.Windows.Forms.GroupBox();
            this.firstSolutionLabelY = new System.Windows.Forms.Label();
            this.firstSolutionLabelX = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.secondSolutionGroupBox = new System.Windows.Forms.GroupBox();
            this.secondSolutionLabelY = new System.Windows.Forms.Label();
            this.secondSolutionLabelX = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.equationsGroupBox.SuspendLayout();
            this.firstSolutionGroupBox.SuspendLayout();
            this.secondSolutionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // equationsGroupBox
            // 
            this.equationsGroupBox.Controls.Add(this.label7);
            this.equationsGroupBox.Controls.Add(this.label5);
            this.equationsGroupBox.Controls.Add(this.label3);
            this.equationsGroupBox.Controls.Add(this.label6);
            this.equationsGroupBox.Controls.Add(this.label4);
            this.equationsGroupBox.Controls.Add(this.solveButton);
            this.equationsGroupBox.Controls.Add(this.label13);
            this.equationsGroupBox.Controls.Add(this.label12);
            this.equationsGroupBox.Controls.Add(this.label1);
            this.equationsGroupBox.Controls.Add(this.secondConstField);
            this.equationsGroupBox.Controls.Add(this.secondLinearField);
            this.equationsGroupBox.Controls.Add(this.firstConstField);
            this.equationsGroupBox.Controls.Add(this.firstLinearField);
            this.equationsGroupBox.Controls.Add(this.firstSquareField);
            this.equationsGroupBox.Controls.Add(this.label2);
            this.equationsGroupBox.Location = new System.Drawing.Point(42, 25);
            this.equationsGroupBox.Name = "equationsGroupBox";
            this.equationsGroupBox.Size = new System.Drawing.Size(289, 178);
            this.equationsGroupBox.TabIndex = 0;
            this.equationsGroupBox.TabStop = false;
            this.equationsGroupBox.Text = "Система уравнений";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(69, 126);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(146, 37);
            this.solveButton.TabIndex = 1;
            this.solveButton.Text = "Получить решения";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(102, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Y   = ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Y   = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // secondConstField
            // 
            this.secondConstField.Location = new System.Drawing.Point(215, 83);
            this.secondConstField.Name = "secondConstField";
            this.secondConstField.Size = new System.Drawing.Size(33, 20);
            this.secondConstField.TabIndex = 0;
            // 
            // secondLinearField
            // 
            this.secondLinearField.Location = new System.Drawing.Point(138, 83);
            this.secondLinearField.Name = "secondLinearField";
            this.secondLinearField.Size = new System.Drawing.Size(33, 20);
            this.secondLinearField.TabIndex = 0;
            // 
            // firstConstField
            // 
            this.firstConstField.Location = new System.Drawing.Point(215, 38);
            this.firstConstField.Name = "firstConstField";
            this.firstConstField.Size = new System.Drawing.Size(33, 20);
            this.firstConstField.TabIndex = 0;
            // 
            // firstLinearField
            // 
            this.firstLinearField.Location = new System.Drawing.Point(138, 38);
            this.firstLinearField.Name = "firstLinearField";
            this.firstLinearField.Size = new System.Drawing.Size(33, 20);
            this.firstLinearField.TabIndex = 0;
            // 
            // firstSquareField
            // 
            this.firstSquareField.Location = new System.Drawing.Point(57, 38);
            this.firstSquareField.Name = "firstSquareField";
            this.firstSquareField.Size = new System.Drawing.Size(33, 20);
            this.firstSquareField.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2";
            // 
            // noSolutionLabel
            // 
            this.noSolutionLabel.AutoSize = true;
            this.noSolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noSolutionLabel.Location = new System.Drawing.Point(519, 98);
            this.noSolutionLabel.Name = "noSolutionLabel";
            this.noSolutionLabel.Size = new System.Drawing.Size(108, 20);
            this.noSolutionLabel.TabIndex = 2;
            this.noSolutionLabel.Text = "Решений нет";
            this.noSolutionLabel.Visible = false;
            // 
            // firstSolutionGroupBox
            // 
            this.firstSolutionGroupBox.Controls.Add(this.firstSolutionLabelY);
            this.firstSolutionGroupBox.Controls.Add(this.firstSolutionLabelX);
            this.firstSolutionGroupBox.Controls.Add(this.label9);
            this.firstSolutionGroupBox.Controls.Add(this.label8);
            this.firstSolutionGroupBox.Location = new System.Drawing.Point(389, 25);
            this.firstSolutionGroupBox.Name = "firstSolutionGroupBox";
            this.firstSolutionGroupBox.Size = new System.Drawing.Size(162, 178);
            this.firstSolutionGroupBox.TabIndex = 3;
            this.firstSolutionGroupBox.TabStop = false;
            this.firstSolutionGroupBox.Text = "Решение 1";
            this.firstSolutionGroupBox.Visible = false;
            // 
            // firstSolutionLabelY
            // 
            this.firstSolutionLabelY.AutoSize = true;
            this.firstSolutionLabelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstSolutionLabelY.Location = new System.Drawing.Point(79, 98);
            this.firstSolutionLabelY.Name = "firstSolutionLabelY";
            this.firstSolutionLabelY.Size = new System.Drawing.Size(36, 17);
            this.firstSolutionLabelY.TabIndex = 3;
            this.firstSolutionLabelY.Text = "0,00";
            // 
            // firstSolutionLabelX
            // 
            this.firstSolutionLabelX.AutoSize = true;
            this.firstSolutionLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstSolutionLabelX.Location = new System.Drawing.Point(79, 58);
            this.firstSolutionLabelX.Name = "firstSolutionLabelX";
            this.firstSolutionLabelX.Size = new System.Drawing.Size(36, 17);
            this.firstSolutionLabelX.TabIndex = 3;
            this.firstSolutionLabelX.Text = "0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(45, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Y  =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(45, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Х  =";
            // 
            // secondSolutionGroupBox
            // 
            this.secondSolutionGroupBox.Controls.Add(this.secondSolutionLabelY);
            this.secondSolutionGroupBox.Controls.Add(this.secondSolutionLabelX);
            this.secondSolutionGroupBox.Controls.Add(this.label11);
            this.secondSolutionGroupBox.Controls.Add(this.label10);
            this.secondSolutionGroupBox.Location = new System.Drawing.Point(588, 25);
            this.secondSolutionGroupBox.Name = "secondSolutionGroupBox";
            this.secondSolutionGroupBox.Size = new System.Drawing.Size(162, 178);
            this.secondSolutionGroupBox.TabIndex = 3;
            this.secondSolutionGroupBox.TabStop = false;
            this.secondSolutionGroupBox.Text = "Решение 2";
            this.secondSolutionGroupBox.Visible = false;
            // 
            // secondSolutionLabelY
            // 
            this.secondSolutionLabelY.AutoSize = true;
            this.secondSolutionLabelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondSolutionLabelY.Location = new System.Drawing.Point(80, 98);
            this.secondSolutionLabelY.Name = "secondSolutionLabelY";
            this.secondSolutionLabelY.Size = new System.Drawing.Size(36, 17);
            this.secondSolutionLabelY.TabIndex = 3;
            this.secondSolutionLabelY.Text = "0,00";
            // 
            // secondSolutionLabelX
            // 
            this.secondSolutionLabelX.AutoSize = true;
            this.secondSolutionLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondSolutionLabelX.Location = new System.Drawing.Point(80, 58);
            this.secondSolutionLabelX.Name = "secondSolutionLabelX";
            this.secondSolutionLabelX.Size = new System.Drawing.Size(36, 17);
            this.secondSolutionLabelX.TabIndex = 3;
            this.secondSolutionLabelX.Text = "0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(47, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Y  =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(47, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Х  =";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(29, 240);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(768, 416);
            this.panel.TabIndex = 4;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 682);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.noSolutionLabel);
            this.Controls.Add(this.secondSolutionGroupBox);
            this.Controls.Add(this.firstSolutionGroupBox);
            this.Controls.Add(this.equationsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Решение системы уравнений";
            this.Load += new System.EventHandler(this.Form_Load);
            this.equationsGroupBox.ResumeLayout(false);
            this.equationsGroupBox.PerformLayout();
            this.firstSolutionGroupBox.ResumeLayout(false);
            this.firstSolutionGroupBox.PerformLayout();
            this.secondSolutionGroupBox.ResumeLayout(false);
            this.secondSolutionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox equationsGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secondConstField;
        private System.Windows.Forms.TextBox secondLinearField;
        private System.Windows.Forms.TextBox firstConstField;
        private System.Windows.Forms.TextBox firstLinearField;
        private System.Windows.Forms.TextBox firstSquareField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label noSolutionLabel;
        private System.Windows.Forms.GroupBox firstSolutionGroupBox;
        private System.Windows.Forms.Label firstSolutionLabelY;
        private System.Windows.Forms.Label firstSolutionLabelX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox secondSolutionGroupBox;
        private System.Windows.Forms.Label secondSolutionLabelY;
        private System.Windows.Forms.Label secondSolutionLabelX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

