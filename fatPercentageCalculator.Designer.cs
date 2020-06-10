namespace FatPercentageCalculator_October_2019
{
    partial class Form
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.lofFatCheckBox = new System.Windows.Forms.CheckBox();
            this.caloriesNoticeLabel = new System.Windows.Forms.Label();
            this.fatNoticeLabel = new System.Windows.Forms.Label();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.caloriesNoticeCalcLabel = new System.Windows.Forms.Label();
            this.fatNoticeCalcLabel = new System.Windows.Forms.Label();
            this.caloriesNumLabel = new System.Windows.Forms.Label();
            this.fatPercentageLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(14, 130);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(82, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(208, 130);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lofFatCheckBox
            // 
            this.lofFatCheckBox.AutoSize = true;
            this.lofFatCheckBox.Location = new System.Drawing.Point(15, 107);
            this.lofFatCheckBox.Name = "lofFatCheckBox";
            this.lofFatCheckBox.Size = new System.Drawing.Size(141, 17);
            this.lofFatCheckBox.TabIndex = 2;
            this.lofFatCheckBox.Text = "Notify if Low Fat content";
            this.lofFatCheckBox.UseVisualStyleBackColor = true;
            // 
            // caloriesNoticeLabel
            // 
            this.caloriesNoticeLabel.AutoSize = true;
            this.caloriesNoticeLabel.Location = new System.Drawing.Point(12, 9);
            this.caloriesNoticeLabel.Name = "caloriesNoticeLabel";
            this.caloriesNoticeLabel.Size = new System.Drawing.Size(194, 13);
            this.caloriesNoticeLabel.TabIndex = 3;
            this.caloriesNoticeLabel.Text = "Enter number of calories for a food item:";
            // 
            // fatNoticeLabel
            // 
            this.fatNoticeLabel.AutoSize = true;
            this.fatNoticeLabel.Location = new System.Drawing.Point(12, 31);
            this.fatNoticeLabel.Name = "fatNoticeLabel";
            this.fatNoticeLabel.Size = new System.Drawing.Size(201, 13);
            this.fatNoticeLabel.TabIndex = 4;
            this.fatNoticeLabel.Text = "Enter number of fat grams for a food item:";
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Location = new System.Drawing.Point(212, 6);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(79, 20);
            this.caloriesTextBox.TabIndex = 5;
            // 
            // fatTextBox
            // 
            this.fatTextBox.Location = new System.Drawing.Point(212, 28);
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(79, 20);
            this.fatTextBox.TabIndex = 6;
            // 
            // caloriesNoticeCalcLabel
            // 
            this.caloriesNoticeCalcLabel.AutoSize = true;
            this.caloriesNoticeCalcLabel.Location = new System.Drawing.Point(12, 52);
            this.caloriesNoticeCalcLabel.Name = "caloriesNoticeCalcLabel";
            this.caloriesNoticeCalcLabel.Size = new System.Drawing.Size(111, 13);
            this.caloriesNoticeCalcLabel.TabIndex = 7;
            this.caloriesNoticeCalcLabel.Text = "number of fat calories:";
            // 
            // fatNoticeCalcLabel
            // 
            this.fatNoticeCalcLabel.AutoSize = true;
            this.fatNoticeCalcLabel.Location = new System.Drawing.Point(12, 77);
            this.fatNoticeCalcLabel.Name = "fatNoticeCalcLabel";
            this.fatNoticeCalcLabel.Size = new System.Drawing.Size(84, 13);
            this.fatNoticeCalcLabel.TabIndex = 8;
            this.fatNoticeCalcLabel.Text = "% of fat calories:";
            // 
            // caloriesNumLabel
            // 
            this.caloriesNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesNumLabel.Location = new System.Drawing.Point(212, 51);
            this.caloriesNumLabel.Name = "caloriesNumLabel";
            this.caloriesNumLabel.Size = new System.Drawing.Size(79, 24);
            this.caloriesNumLabel.TabIndex = 9;
            // 
            // fatPercentageLabel
            // 
            this.fatPercentageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fatPercentageLabel.Location = new System.Drawing.Point(212, 76);
            this.fatPercentageLabel.Name = "fatPercentageLabel";
            this.fatPercentageLabel.Size = new System.Drawing.Size(79, 24);
            this.fatPercentageLabel.TabIndex = 10;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(111, 130);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(82, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 162);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fatPercentageLabel);
            this.Controls.Add(this.caloriesNumLabel);
            this.Controls.Add(this.fatNoticeCalcLabel);
            this.Controls.Add(this.caloriesNoticeCalcLabel);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.caloriesTextBox);
            this.Controls.Add(this.fatNoticeLabel);
            this.Controls.Add(this.caloriesNoticeLabel);
            this.Controls.Add(this.lofFatCheckBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form";
            this.Text = "Fat % Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox lofFatCheckBox;
        private System.Windows.Forms.Label caloriesNoticeLabel;
        private System.Windows.Forms.Label fatNoticeLabel;
        private System.Windows.Forms.TextBox caloriesTextBox;
        private System.Windows.Forms.TextBox fatTextBox;
        private System.Windows.Forms.Label caloriesNoticeCalcLabel;
        private System.Windows.Forms.Label fatNoticeCalcLabel;
        private System.Windows.Forms.Label caloriesNumLabel;
        private System.Windows.Forms.Label fatPercentageLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

