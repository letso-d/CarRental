
namespace Kolcsonzo_Client
{
    partial class AddForm
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
            this.BrandBox = new System.Windows.Forms.ComboBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.LicPlNumText = new System.Windows.Forms.TextBox();
            this.KmBox = new System.Windows.Forms.NumericUpDown();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.LicPlNumLabel = new System.Windows.Forms.Label();
            this.KmLabel = new System.Windows.Forms.Label();
            this.PricePerKmBox = new System.Windows.Forms.NumericUpDown();
            this.PricePerKmLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.YearPicker = new System.Windows.Forms.DateTimePicker();
            this.YearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KmBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PricePerKmBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandBox
            // 
            this.BrandBox.FormattingEnabled = true;
            this.BrandBox.Location = new System.Drawing.Point(195, 39);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(158, 23);
            this.BrandBox.TabIndex = 0;
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(195, 101);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(158, 23);
            this.TypeBox.TabIndex = 1;
            // 
            // LicPlNumText
            // 
            this.LicPlNumText.Location = new System.Drawing.Point(193, 204);
            this.LicPlNumText.Name = "LicPlNumText";
            this.LicPlNumText.Size = new System.Drawing.Size(158, 23);
            this.LicPlNumText.TabIndex = 2;
            // 
            // KmBox
            // 
            this.KmBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KmBox.Location = new System.Drawing.Point(195, 263);
            this.KmBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.KmBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KmBox.Name = "KmBox";
            this.KmBox.Size = new System.Drawing.Size(158, 29);
            this.KmBox.TabIndex = 3;
            this.KmBox.ThousandsSeparator = true;
            this.KmBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Location = new System.Drawing.Point(113, 41);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(43, 15);
            this.BrandLabel.TabIndex = 4;
            this.BrandLabel.Text = "Márka:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(113, 103);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(38, 15);
            this.TypeLabel.TabIndex = 5;
            this.TypeLabel.Text = "Típus:";
            // 
            // LicPlNumLabel
            // 
            this.LicPlNumLabel.AutoSize = true;
            this.LicPlNumLabel.Location = new System.Drawing.Point(111, 206);
            this.LicPlNumLabel.Name = "LicPlNumLabel";
            this.LicPlNumLabel.Size = new System.Drawing.Size(64, 15);
            this.LicPlNumLabel.TabIndex = 6;
            this.LicPlNumLabel.Text = "Rendszám:";
            // 
            // KmLabel
            // 
            this.KmLabel.AutoSize = true;
            this.KmLabel.Location = new System.Drawing.Point(113, 270);
            this.KmLabel.Name = "KmLabel";
            this.KmLabel.Size = new System.Drawing.Size(62, 15);
            this.KmLabel.TabIndex = 7;
            this.KmLabel.Text = "Futott km:";
            // 
            // PricePerKmBox
            // 
            this.PricePerKmBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PricePerKmBox.Location = new System.Drawing.Point(195, 334);
            this.PricePerKmBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.PricePerKmBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PricePerKmBox.Name = "PricePerKmBox";
            this.PricePerKmBox.Size = new System.Drawing.Size(158, 29);
            this.PricePerKmBox.TabIndex = 8;
            this.PricePerKmBox.ThousandsSeparator = true;
            this.PricePerKmBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PricePerKmLabel
            // 
            this.PricePerKmLabel.AutoSize = true;
            this.PricePerKmLabel.Location = new System.Drawing.Point(114, 341);
            this.PricePerKmLabel.Name = "PricePerKmLabel";
            this.PricePerKmLabel.Size = new System.Drawing.Size(44, 15);
            this.PricePerKmLabel.TabIndex = 9;
            this.PricePerKmLabel.Text = "Ár/km:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton.Location = new System.Drawing.Point(182, 403);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(122, 35);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "Hozzáad";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // YearPicker
            // 
            this.YearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.YearPicker.Location = new System.Drawing.Point(217, 156);
            this.YearPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.YearPicker.Name = "YearPicker";
            this.YearPicker.Size = new System.Drawing.Size(104, 23);
            this.YearPicker.TabIndex = 15;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(113, 159);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(67, 15);
            this.YearLabel.TabIndex = 16;
            this.YearLabel.Text = "Gyártási év:";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.YearPicker);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PricePerKmLabel);
            this.Controls.Add(this.PricePerKmBox);
            this.Controls.Add(this.KmLabel);
            this.Controls.Add(this.LicPlNumLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.KmBox);
            this.Controls.Add(this.LicPlNumText);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.BrandBox);
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.KmBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PricePerKmBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BrandBox;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.TextBox LicPlNumText;
        private System.Windows.Forms.NumericUpDown KmBox;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label LicPlNumLabel;
        private System.Windows.Forms.Label KmLabel;
        private System.Windows.Forms.NumericUpDown PricePerKmBox;
        private System.Windows.Forms.Label PricePerKmLabel;
        public System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DateTimePicker YearPicker;
        private System.Windows.Forms.Label YearLabel;
    }
}