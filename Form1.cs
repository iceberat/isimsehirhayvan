using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isimsehirhayvan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtisim.Clear();
            txtşehir.Clear();
            txthayvan.Clear();
        }

        void enabledtrue()
        {
            txtisim.Enabled = true;
            txtşehir.Enabled = true;
            txthayvan.Enabled = true; 
        }

        void enabledfalse()
        {
            txtisim.Enabled = false;
            txtşehir.Enabled = false;
            txthayvan.Enabled = false;
        }

        string[] harfler = { "A", "B", "Ç", "D", "E", "a", "b", "ç", "d", "e" };

        string[] kelimeler = { "ali", "ayşe", "ahmet", "avni", "açelya", "adana", "ağrı", "adıyaman", "afyonkarahisar", "aksaray", "at", "aslan", "ayı", "akrep", "anaconda",
                               "berat", "beyza", "büşra", "bilal", "besna", "bursa", "balıkesir", "batman", "bartın", "bitlis", "babun", "bal arısı", "bal porsuğu", "babirussa", "balaban kuşu",
                               "çiğdem", "çağan", "çağatay", "çağdaş", "çağdan", "çanakkale", "çankırı", "çorum", "çaça", "çekirge", "çaylak", "çakal", "çalı kuşu",
                               "derya", "deren", "damla", "deniz", "defne", "denizli", "diyarbakır", "düzce", "deniz atı", "deniz anası", "deve", "deniz yılanı", "deniz kaplumbağası",
                               "efe", "eren", "ebrar", "ebru", "ece", "edirne", "elazığ", "erzurum", "erzincan", "eskişehir", "ebabil kuşu", "eşek", "eşek arısı", "ev faresi", "ev yılanı"
                                };

        Random rnd = new Random();

        int süre = 90;

        int puan = 0;
        private void btnkontrol_Click(object sender, EventArgs e)
        {
            if (txtisim.Text.Trim() == "" || txtşehir.Text.Trim() == "" || txthayvan.Text.Trim() == "")
            {
                MessageBox.Show("Boş alan bırakmayın");
            }

            else
            {

                if (txtisim.Text.Trim().Substring(0,1).ToUpper() != lblharf.Text || txtşehir.Text.Trim().Substring(0, 1).ToUpper() != lblharf.Text || txthayvan.Text.Trim().Substring(0, 1).ToUpper() != lblharf.Text)
                {

                    timer1.Stop();
                    MessageBox.Show("Kaybettiniz Sebeb : Harfler uyuşmuyor");
                    lblsüre.Text = "SÜRE : 90";

                    süre = 90;

                    clear();

                    enabledfalse();
                }


                else if (!kelimeler.Contains(txtisim.Text.Trim().ToLower()) || !kelimeler.Contains(txtşehir.Text.Trim().ToLower()) || !kelimeler.Contains(txthayvan.Text.Trim().ToLower()))
                {

                    timer1.Stop();
                    MessageBox.Show("Kaybettiniz Sebeb : Girdiğiniz kelimeler geçersizdir");
                    lblsüre.Text = "SÜRE : 90";
                    süre = 90;

                    clear();

                    enabledfalse();
                }

                else
                {

                    timer1.Stop();
                    puan += 10;
                    MessageBox.Show("Kazandınız");
                    lblsüre.Text = "SÜRE : 90";
                    süre = 90;

                    lblpuan.Text = "PUAN : " + puan.ToString();

                    clear();

                    enabledfalse();

                    
                }


            }
        }

        private void btnharfal_Click(object sender, EventArgs e)
        {

            if (süre == 90)
            {
                int random = rnd.Next(0, harfler.Length - 5);

                string harf = (harfler[random]);

                lblharf.Text = harf;

                timer1.Start();

                enabledtrue();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblharf.Text = "";

            lblpuan.Text = "PUAN : " + puan.ToString();

            enabledfalse();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;

            lblsüre.Text = "SÜRE : " + süre.ToString();

            if (süre == 0)
            {
                timer1.Stop();

                lblsüre.Text = "SÜRE : 90";

                süre = 90;

                

                if (txtisim.Text.Trim() == "" || txtşehir.Text.Trim() == "" || txthayvan.Text.Trim() == "")
                {
                    MessageBox.Show("Kaybettiniz Sebeb : Süre bittiği esnada boş alan vardı");
                    
                    
                }

                else if (txtisim.Text.Trim().Substring(0, 1).ToUpper() != lblharf.Text || txtşehir.Text.Trim().Substring(0, 1).ToUpper() != lblharf.Text || txthayvan.Text.Trim().Substring(0, 1).ToUpper() != lblharf.Text)
                {
                    MessageBox.Show("Kaybettiniz Sebeb : Harfler uyuşmuyor");
                    
                }

                else if (!kelimeler.Contains(txtisim.Text.Trim().ToLower()) || !kelimeler.Contains(txtşehir.Text.Trim().ToLower()) || !kelimeler.Contains(txthayvan.Text.Trim().ToLower()))
                {
                    MessageBox.Show("Kaybettiniz Sebeb : Girdiğiniz kelimeler geçersizdir");
                    

                }

                clear();

                enabledfalse();

            }
        }
    }
}
