using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Diagnostics;
using System.IO;

namespace NotificationApplication
{
    public partial class Form1 : Form
    {

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "qlDUgLSDUYM1OqcOnlecbAEDhbFWJI8MCMUtZpYU",
            BasePath = "https://kkfldatabase-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                client = new FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("There was an error");
            }

            //  this.Hide();


            StreamReader sr = new StreamReader("C:\\Users\\LENOVO\\OneDrive\\Masaüstü\\test.txt");

            string girisno = sr.ReadLine();


            txt_girisSife.Text = girisno;


        }

        private void txt_girisSife_TextChanged(object sender, EventArgs e)
        {

            string girisno = txt_girisSife.Text;

            if (girisno=="1")
            {
                MessageBox.Show("Yadin Çelik(Müdür) olarak giriş yaptınız.");
            }
            else if (girisno == "2")
            {
                MessageBox.Show("Şenay Öztürk(Müdür Başyardımcısı) olarak giriş yaptınız.");
            }
            else if (girisno == "3")
            {
                MessageBox.Show("Galip Yavuz(Müdür Yardımcısı) olarak giriş yaptınız.");
            }
            else if (girisno == "4")
            {
                MessageBox.Show("İsa Tevfik Kurşun(Müdür Yardımcısı) olarak giriş yaptınız.");
            }
            else if (girisno == "5")
            {
                MessageBox.Show("Fikri Etem(Rehber Öğretmeni) olarak giriş yaptınız.");
            }



        }
    }
}
