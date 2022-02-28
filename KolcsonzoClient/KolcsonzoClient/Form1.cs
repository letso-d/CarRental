using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grpc.Net.Client;
using Kolcsonzo;
using KolcsonzoClient;

namespace KolcsonzoClient
{
    public partial class Form1 : Form
    {
        GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:5001");
        Kolcsonzo.Kolcsonzo.KolcsonzoClient client;
        string uid = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new Kolcsonzo.Kolcsonzo.KolcsonzoClient(channel);
            
            client.Login(new LoginData { Username="admin", Passwd="admin" });
            MessageBox.Show("KÉSZ!");
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

    }
}
