using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationApplication
{
    public partial class Geridönüt : Form
    {


        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "qlDUgLSDUYM1OqcOnlecbAEDhbFWJI8MCMUtZpYU",
            BasePath = "https://kkfldatabase-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public Geridönüt()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc2 = new FirebaseConfig()
        {
            AuthSecret = "2inVCykQM5Pd7bwsaCbMYh38tXU8WcQkMSs1qRhl",
            BasePath = "https://privatedata-506ba-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client2;

        private void Geridönüt_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(ifc);
                client2 = new FirebaseClient(ifc2);
            }
            catch
            {
                MessageBox.Show("There was an error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTimeConverter dtc = new DateTimeConverter();

            string gün = dtc.ConvertToInvariantString(DateTime.Now.Day);
            string ay = dtc.ConvertToInvariantString(DateTime.Now.Month);
            string yıl = dtc.ConvertToInvariantString(DateTime.Now.Year);
            string saat = dtc.ConvertToInvariantString(DateTime.Now.Hour);
            string dakika = dtc.ConvertToInvariantString(DateTime.Now.Minute);
            string saniye = dtc.ConvertToInvariantString(DateTime.Now.Second);

            StreamReader sr = new StreamReader("C:\\Users\\Public\\test.txt");

            client.Set("Feedback/"+sr, rtxt_feedback.Text);
            client2.Set($"Feedback/{(gün + " " + ay + " " + yıl)}" + ("/" + saat + " " + dakika + " " + saniye)+sr, rtxt_feedback.Text);
        }
    }
}
