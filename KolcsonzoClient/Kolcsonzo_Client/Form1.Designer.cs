
namespace Kolcsonzo_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CarsList = new System.Windows.Forms.ListBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.KmLabel = new System.Windows.Forms.Label();
            this.PricePerKmLabel = new System.Windows.Forms.Label();
            this.LicPlNumLabel = new System.Windows.Forms.Label();
            this.IsRentedLabel = new System.Windows.Forms.Label();
            this.RenterLabel = new System.Windows.Forms.Label();
            this.rentButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.SedanBox = new System.Windows.Forms.CheckBox();
            this.KombiBox = new System.Windows.Forms.CheckBox();
            this.FerdehBox = new System.Windows.Forms.CheckBox();
            this.CabrioBox = new System.Windows.Forms.CheckBox();
            this.CoupeBox = new System.Windows.Forms.CheckBox();
            this.EgyteruBox = new System.Windows.Forms.CheckBox();
            this.SportBox = new System.Windows.Forms.CheckBox();
            this.CrossoverBox = new System.Windows.Forms.CheckBox();
            this.ListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarsList
            // 
            this.CarsList.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarsList.FormattingEnabled = true;
            this.CarsList.ItemHeight = 15;
            this.CarsList.Location = new System.Drawing.Point(410, 70);
            this.CarsList.Name = "CarsList";
            this.CarsList.Size = new System.Drawing.Size(533, 289);
            this.CarsList.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.Location = new System.Drawing.Point(904, 319);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(38, 39);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(821, 365);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(122, 35);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrandLabel.Location = new System.Drawing.Point(449, 52);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(40, 15);
            this.BrandLabel.TabIndex = 3;
            this.BrandLabel.Text = "Márka";
            this.BrandLabel.Click += new System.EventHandler(this.BrandLabel_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TypeLabel.Location = new System.Drawing.Point(531, 52);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(35, 15);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Típus";
            this.TypeLabel.Click += new System.EventHandler(this.TypeLabel_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YearLabel.Location = new System.Drawing.Point(598, 52);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(19, 15);
            this.YearLabel.TabIndex = 5;
            this.YearLabel.Text = "Év";
            this.YearLabel.Click += new System.EventHandler(this.YearLabel_Click);
            // 
            // KmLabel
            // 
            this.KmLabel.AutoSize = true;
            this.KmLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KmLabel.Location = new System.Drawing.Point(650, 52);
            this.KmLabel.Name = "KmLabel";
            this.KmLabel.Size = new System.Drawing.Size(25, 15);
            this.KmLabel.TabIndex = 6;
            this.KmLabel.Text = "Km";
            this.KmLabel.Click += new System.EventHandler(this.KmLabel_Click);
            // 
            // PricePerKmLabel
            // 
            this.PricePerKmLabel.AutoSize = true;
            this.PricePerKmLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PricePerKmLabel.Location = new System.Drawing.Point(691, 52);
            this.PricePerKmLabel.Name = "PricePerKmLabel";
            this.PricePerKmLabel.Size = new System.Drawing.Size(42, 15);
            this.PricePerKmLabel.TabIndex = 7;
            this.PricePerKmLabel.Text = "Ár/Km";
            this.PricePerKmLabel.Click += new System.EventHandler(this.PricePerKmLabel_Click);
            // 
            // LicPlNumLabel
            // 
            this.LicPlNumLabel.AutoSize = true;
            this.LicPlNumLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LicPlNumLabel.Location = new System.Drawing.Point(748, 52);
            this.LicPlNumLabel.Name = "LicPlNumLabel";
            this.LicPlNumLabel.Size = new System.Drawing.Size(61, 15);
            this.LicPlNumLabel.TabIndex = 8;
            this.LicPlNumLabel.Text = "Rendszám";
            this.LicPlNumLabel.Click += new System.EventHandler(this.LicPlNumLabel_Click);
            // 
            // IsRentedLabel
            // 
            this.IsRentedLabel.AutoSize = true;
            this.IsRentedLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IsRentedLabel.Location = new System.Drawing.Point(817, 52);
            this.IsRentedLabel.Name = "IsRentedLabel";
            this.IsRentedLabel.Size = new System.Drawing.Size(44, 15);
            this.IsRentedLabel.TabIndex = 9;
            this.IsRentedLabel.Text = "Szabad";
            this.IsRentedLabel.Click += new System.EventHandler(this.IsRentedLabel_Click);
            // 
            // RenterLabel
            // 
            this.RenterLabel.AutoSize = true;
            this.RenterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RenterLabel.Location = new System.Drawing.Point(883, 52);
            this.RenterLabel.Name = "RenterLabel";
            this.RenterLabel.Size = new System.Drawing.Size(30, 15);
            this.RenterLabel.TabIndex = 10;
            this.RenterLabel.Text = "User";
            this.RenterLabel.Click += new System.EventHandler(this.RenterLabel_Click);
            // 
            // rentButton
            // 
            this.rentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentButton.Location = new System.Drawing.Point(410, 365);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(122, 35);
            this.rentButton.TabIndex = 11;
            this.rentButton.Text = "Kölcsönöz";
            this.rentButton.UseVisualStyleBackColor = false;
            this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(611, 365);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(122, 35);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Visszavisz";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(99, 364);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(188, 35);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Új autó hozzáadása";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteLabel.Location = new System.Drawing.Point(412, 339);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(52, 19);
            this.deleteLabel.TabIndex = 14;
            this.deleteLabel.Text = "Törlés";
            this.deleteLabel.Visible = false;
            this.deleteLabel.Click += new System.EventHandler(this.deleteLabel_Click);
            // 
            // SedanBox
            // 
            this.SedanBox.AutoSize = true;
            this.SedanBox.Location = new System.Drawing.Point(28, 116);
            this.SedanBox.Name = "SedanBox";
            this.SedanBox.Size = new System.Drawing.Size(58, 19);
            this.SedanBox.TabIndex = 15;
            this.SedanBox.Text = "Sedan";
            this.SedanBox.UseVisualStyleBackColor = true;
            // 
            // KombiBox
            // 
            this.KombiBox.AutoSize = true;
            this.KombiBox.Location = new System.Drawing.Point(28, 141);
            this.KombiBox.Name = "KombiBox";
            this.KombiBox.Size = new System.Drawing.Size(61, 19);
            this.KombiBox.TabIndex = 16;
            this.KombiBox.Text = "Kombi";
            this.KombiBox.UseVisualStyleBackColor = true;
            // 
            // FerdehBox
            // 
            this.FerdehBox.AutoSize = true;
            this.FerdehBox.Location = new System.Drawing.Point(28, 166);
            this.FerdehBox.Name = "FerdehBox";
            this.FerdehBox.Size = new System.Drawing.Size(79, 19);
            this.FerdehBox.TabIndex = 17;
            this.FerdehBox.Text = "Ferdehátú";
            this.FerdehBox.UseVisualStyleBackColor = true;
            // 
            // CabrioBox
            // 
            this.CabrioBox.AutoSize = true;
            this.CabrioBox.Location = new System.Drawing.Point(28, 191);
            this.CabrioBox.Name = "CabrioBox";
            this.CabrioBox.Size = new System.Drawing.Size(61, 19);
            this.CabrioBox.TabIndex = 18;
            this.CabrioBox.Text = "Cabrio";
            this.CabrioBox.UseVisualStyleBackColor = true;
            // 
            // CoupeBox
            // 
            this.CoupeBox.AutoSize = true;
            this.CoupeBox.Location = new System.Drawing.Point(28, 216);
            this.CoupeBox.Name = "CoupeBox";
            this.CoupeBox.Size = new System.Drawing.Size(61, 19);
            this.CoupeBox.TabIndex = 19;
            this.CoupeBox.Text = "Coupe";
            this.CoupeBox.UseVisualStyleBackColor = true;
            // 
            // EgyteruBox
            // 
            this.EgyteruBox.AutoSize = true;
            this.EgyteruBox.Location = new System.Drawing.Point(28, 241);
            this.EgyteruBox.Name = "EgyteruBox";
            this.EgyteruBox.Size = new System.Drawing.Size(66, 19);
            this.EgyteruBox.TabIndex = 20;
            this.EgyteruBox.Text = "Egyterű";
            this.EgyteruBox.UseVisualStyleBackColor = true;
            // 
            // SportBox
            // 
            this.SportBox.AutoSize = true;
            this.SportBox.Location = new System.Drawing.Point(28, 266);
            this.SportBox.Name = "SportBox";
            this.SportBox.Size = new System.Drawing.Size(54, 19);
            this.SportBox.TabIndex = 21;
            this.SportBox.Text = "Sport";
            this.SportBox.UseVisualStyleBackColor = true;
            // 
            // CrossoverBox
            // 
            this.CrossoverBox.AutoSize = true;
            this.CrossoverBox.Location = new System.Drawing.Point(28, 291);
            this.CrossoverBox.Name = "CrossoverBox";
            this.CrossoverBox.Size = new System.Drawing.Size(78, 19);
            this.CrossoverBox.TabIndex = 22;
            this.CrossoverBox.Text = "Crossover";
            this.CrossoverBox.UseVisualStyleBackColor = true;
            // 
            // ListButton
            // 
            this.ListButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ListButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListButton.Location = new System.Drawing.Point(12, 319);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(102, 35);
            this.ListButton.TabIndex = 23;
            this.ListButton.Text = "Keresés";
            this.ListButton.UseVisualStyleBackColor = false;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 411);
            this.Controls.Add(this.ListButton);
            this.Controls.Add(this.CrossoverBox);
            this.Controls.Add(this.SportBox);
            this.Controls.Add(this.EgyteruBox);
            this.Controls.Add(this.CoupeBox);
            this.Controls.Add(this.CabrioBox);
            this.Controls.Add(this.FerdehBox);
            this.Controls.Add(this.KombiBox);
            this.Controls.Add(this.SedanBox);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.rentButton);
            this.Controls.Add(this.RenterLabel);
            this.Controls.Add(this.IsRentedLabel);
            this.Controls.Add(this.LicPlNumLabel);
            this.Controls.Add(this.PricePerKmLabel);
            this.Controls.Add(this.KmLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.CarsList);
            this.Name = "Form1";
            this.Text = "Kolcsonzo Kliens";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CarsList;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label KmLabel;
        private System.Windows.Forms.Label PricePerKmLabel;
        private System.Windows.Forms.Label LicPlNumLabel;
        private System.Windows.Forms.Label IsRentedLabel;
        private System.Windows.Forms.Label RenterLabel;
        public System.Windows.Forms.Button LoginButton;
        public System.Windows.Forms.Button rentButton;
        public System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.CheckBox SedanBox;
        private System.Windows.Forms.CheckBox KombiBox;
        private System.Windows.Forms.CheckBox FerdehBox;
        private System.Windows.Forms.CheckBox CabrioBox;
        private System.Windows.Forms.CheckBox CoupeBox;
        private System.Windows.Forms.CheckBox EgyteruBox;
        private System.Windows.Forms.CheckBox SportBox;
        private System.Windows.Forms.CheckBox CrossoverBox;
        public System.Windows.Forms.Button ListButton;
    }
}

