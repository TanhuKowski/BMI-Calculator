namespace BMI_Calculator
{
    partial class BMIforum
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
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.Height_Label = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.Weight_Label = new System.Windows.Forms.Label();
            this.Calc_button = new System.Windows.Forms.Button();
            this.BMI_Label = new System.Windows.Forms.Label();
            this.Category_Label = new System.Windows.Forms.Label();
            this.Result_Label = new System.Windows.Forms.Label();
            this.WeightC_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHeight.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxHeight.ForeColor = System.Drawing.Color.Black;
            this.textBoxHeight.Location = new System.Drawing.Point(145, 73);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(55, 30);
            this.textBoxHeight.TabIndex = 3;
            // 
            // Height_Label
            // 
            this.Height_Label.AutoSize = true;
            this.Height_Label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Height_Label.Location = new System.Drawing.Point(12, 75);
            this.Height_Label.Name = "Height_Label";
            this.Height_Label.Size = new System.Drawing.Size(136, 23);
            this.Height_Label.TabIndex = 2;
            this.Height_Label.Text = "Hündürlük(sm):";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeight.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxWeight.ForeColor = System.Drawing.Color.Black;
            this.textBoxWeight.Location = new System.Drawing.Point(92, 122);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(56, 30);
            this.textBoxWeight.TabIndex = 5;
            // 
            // Weight_Label
            // 
            this.Weight_Label.AutoSize = true;
            this.Weight_Label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Weight_Label.Location = new System.Drawing.Point(12, 124);
            this.Weight_Label.Name = "Weight_Label";
            this.Weight_Label.Size = new System.Drawing.Size(83, 23);
            this.Weight_Label.TabIndex = 4;
            this.Weight_Label.Text = "Çəki(kq):";
            // 
            // Calc_button
            // 
            this.Calc_button.BackColor = System.Drawing.Color.Red;
            this.Calc_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Calc_button.ForeColor = System.Drawing.Color.White;
            this.Calc_button.Location = new System.Drawing.Point(289, 26);
            this.Calc_button.Name = "Calc_button";
            this.Calc_button.Size = new System.Drawing.Size(116, 39);
            this.Calc_button.TabIndex = 6;
            this.Calc_button.Text = "Hesabla";
            this.Calc_button.UseVisualStyleBackColor = false;
            this.Calc_button.Click += new System.EventHandler(this.Calc_button_Click);
            // 
            // BMI_Label
            // 
            this.BMI_Label.AutoSize = true;
            this.BMI_Label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BMI_Label.Location = new System.Drawing.Point(449, 73);
            this.BMI_Label.Name = "BMI_Label";
            this.BMI_Label.Size = new System.Drawing.Size(90, 23);
            this.BMI_Label.TabIndex = 7;
            this.BMI_Label.Text = "Sizin BMI:";
            // 
            // Category_Label
            // 
            this.Category_Label.AutoSize = true;
            this.Category_Label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Category_Label.Location = new System.Drawing.Point(449, 122);
            this.Category_Label.Name = "Category_Label";
            this.Category_Label.Size = new System.Drawing.Size(165, 23);
            this.Category_Label.TabIndex = 9;
            this.Category_Label.Text = "Çəki Kateqoriyanız:";
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.BackColor = System.Drawing.Color.Moccasin;
            this.Result_Label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Result_Label.ForeColor = System.Drawing.Color.Black;
            this.Result_Label.Location = new System.Drawing.Point(545, 73);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(0, 23);
            this.Result_Label.TabIndex = 10;
            // 
            // WeightC_Label
            // 
            this.WeightC_Label.AutoSize = true;
            this.WeightC_Label.BackColor = System.Drawing.Color.Moccasin;
            this.WeightC_Label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WeightC_Label.ForeColor = System.Drawing.Color.Black;
            this.WeightC_Label.Location = new System.Drawing.Point(620, 122);
            this.WeightC_Label.Name = "WeightC_Label";
            this.WeightC_Label.Size = new System.Drawing.Size(0, 23);
            this.WeightC_Label.TabIndex = 11;
            // 
            // BMIforum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(870, 174);
            this.Controls.Add(this.WeightC_Label);
            this.Controls.Add(this.Result_Label);
            this.Controls.Add(this.Category_Label);
            this.Controls.Add(this.BMI_Label);
            this.Controls.Add(this.Calc_button);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.Weight_Label);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.Height_Label);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BMIforum";
            this.Text = "The Body Mass Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxHeight;
        private Label Height_Label;
        private TextBox textBoxWeight;
        private Label Weight_Label;
        private Button Calc_button;
        private Label BMI_Label;
        private Label Category_Label;
        private Label Result_Label;
        private Label WeightC_Label;
    }
}