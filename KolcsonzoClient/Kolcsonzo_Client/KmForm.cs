using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kolcsonzo_Client
{
    public partial class KmForm : Form
    {
        public KmForm()
        {
            InitializeComponent();
        }

        public int Km { get; set; }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (this.KmBox.Value>0)
            {
                this.Km = Convert.ToInt32(this.KmBox.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("You have to give the km!");
            }
        }
    }
}
