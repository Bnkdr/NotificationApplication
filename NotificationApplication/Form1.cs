﻿using System;
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
using Newtonsoft.Json;
using System.Linq.Expressions;

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


        Çağrılan çağrılan = new Çağrılan();
        Çağrılan çağrılan2;
        string girisno = "";
        


        // List<Çağrılan> çağrılanlar = new List<Çağrılan>();
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
            
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\LENOVO\\source\\repos\\NotificationApplication1\\NotificationApplication\\bin\\Debug\\test.txt");

                girisno = sr.ReadLine();

                txt_girisSife.Text = girisno;
            }
            catch{
                MessageBox.Show("Giriş Id dosyası bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LiveData(girisno);


            




        }

        async void LiveData(string girisno)
    {
            while(true)
            {
                FirebaseResponse res2 = client.Get($"CurrentCall/{çağrılan.getÇağrılanNo()}"  );
                Dictionary<string, string> data2 = JsonConvert.DeserializeObject<Dictionary<string, string>>(res2.Body.ToString());
                if (data2 != null)
                {
                    FirebaseResponse res = await client.GetAsync($"CurrentCall/{çağrılan.getÇağrılanNo()}/");
                    Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(res.Body.ToString());

                    

                    if (data.ElementAt(2).Value == çağrılan.getÇağrılanNo())
                    {
                        çağrılan2 = new Çağrılan(data.ElementAt(2).Value, data.ElementAt(1).Value, data.ElementAt(5).Value, data.ElementAt(4).Value, data.ElementAt(3).Value, data.ElementAt(0).Value);

                        if (data.ElementAt(2).Value != null)
                        {
                            for (int i = 1; i <= 6; i++)
                            {
                                if (çağrılan2.çağrılanidarecino == i.ToString())
                                {
                                    MessageBox.Show($"{çağrılan2.çağıranidarecisoyisim} {çağrılan2.çağıranidareciisim + "(" + çağrılan2.çağıranidarecigorev + ")"}: {çağrılan2.acıklama}","Çağrı");
                                    await client.SetAsync($"Feedback/{girisno}", çağrılan2.idareciisimsoyisim);
                                    client.Delete("CurrentCall/" + çağrılan2.çağrılanidarecino);
                                    break;
                                }

                            }
                            if (Convert.ToInt32(çağrılan2.çağrılanidarecino) > 6 &&çağrılan2.çağrılanidarecino==girisno)
                            {
                                MessageBox.Show($"{çağrılan2.çağıranidareciisim} { çağrılan2.çağıranidarecisoyisim + "(" + çağrılan2.çağıranidarecigorev + ")"}, {çağrılan2.idareciisimsoyisim} adlı kişiyi çağırıyor: {çağrılan2.acıklama}");
                                await client.SetAsync($"Feedback/{girisno}", çağrılan2.idareciisimsoyisim);
                                client.Delete("CurrentCall/" + çağrılan2.çağrılanidarecino);

                            }
                        }

                    }
                   
                }
                this.Hide();
            }
           



            



    }


        private string noDegistirme(string no)
        {
          
            if (no == "091")
            {
                no = "9A";
                return no;
            }
            else if (no == "092")
            {
                no = "9B";
                return no;
            }
            else if (no == "093")
            {
                no = "9C";
                return no;
            }
            else if (no == "094")
            {
                no = "9D";
                return no;
            }
            else if (no == "101")
            {
                no = "10A";
                return no;
            }
            else if (no == "102")
            {
                no = "10B";
                return no;
            }
            else if (no == "103")
            {
                no = "10C";
                return no;
            }
            else if (no == "104")
            {
                no = "10D";
                return no;
            }
            else if (no == "111")
            {
                no = "11A";
                return no;
            }
            else if (no == "112")
            {
                no = "11B";
                return no;
            }
            else if (no == "113")
            {
                no = "11C";
                return no;
            }
            else if (no == "114")
            {
                no = "11D";
                return no;
            }
            else if (no == "121")
            {
                no = "12A";
                return no;
            }
            else if (no == "122")
            {
                no = "12B";
                return no;
            }
            else if (no == "123")
            {
                no = "12C";
                return no;
            }
            else if (no == "124")
            {
                no = "12D";
                return no;
            }
            else
            {
                return "No bulunamadı";
            }
        }
        private void txt_girisSife_TextChanged(object sender, EventArgs e)
        {

            string girisno = txt_girisSife.Text;

            if (girisno=="1")
            {
                MessageBox.Show("Yadin Çelik(Müdür) olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "2")
            {
                MessageBox.Show("Şenay Öztürk(Müdür Başyardımcısı) olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "3")
            {
                MessageBox.Show("Galip Yavuz(Müdür Yardımcısı) olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "4")
            {
                MessageBox.Show("İsa Tevfik Kurşun(Müdür Yardımcısı) olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "5")
            {
                MessageBox.Show("Fikri Etem(Rehber Öğretmeni) olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "091")
            {
                MessageBox.Show("9/A olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "092")
            {
                MessageBox.Show("9/B olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "093")
            {
                MessageBox.Show("9/C olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "094")
            {
                MessageBox.Show("9/D olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "101")
            {
                MessageBox.Show("10/A olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "102")
            {
                MessageBox.Show("10/B olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "103")
            {
                MessageBox.Show("10/C olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "104")
            {
                MessageBox.Show("10/D olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "111")
            {
                MessageBox.Show("11/A olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "112")
            {
                MessageBox.Show("11/B olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "113")
            {
                MessageBox.Show("11/C olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "114")
            {
                MessageBox.Show("11/D olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "121")
            {
                MessageBox.Show("12/A olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "122")
            {
                MessageBox.Show("12/B olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "123")
            {
                MessageBox.Show("12/C olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "124")
            {
                MessageBox.Show("12/D olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else if (girisno == "6")
            {
                MessageBox.Show("Formatör olarak giriş yaptınız.");
                this.Hide();
                çağrılan.setÇağrılanNo(girisno);
            }
            else
            {
                MessageBox.Show("Giriş yaptığınız kişi bulunamadı. Çıkış yapılıyor.", "Hata", MessageBoxButtons.OK);
                Application.Exit();
            }


        }



    }
}
