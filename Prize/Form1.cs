using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Collections;

namespace Prize
{
    public partial class Form1 : Form
    {
        private Boolean togglerClicked;
        private String angkaAcak;
        private List<List<string>> numbers;

        private int randUser;
        private int randUserNumber;
        private int steps;

        private List<int> userQueue;
        
        public Form1()
        {
            InitializeComponent();
            this.togglerClicked = false;
            this.angkaAcak = "0 0 0 0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.numbers = new List<List<string>>();
            this.userQueue = new List<int>();
            this.steps = 1;

            this._initForm();
            this._readData();
            this.randTimer.Enabled = false;
            this.lblRandomNumber.Text = this.angkaAcak;

            this.initQueue();
        }

        private void initQueue ()
        {
            int totalUser = this.numbers.Count();
            for(int i=1; i<totalUser; i++)
            {
                userQueue.Add(i);
            }
        }

        private void _readData ()
        {
            var path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "prize\\data.txt");
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                List<string> temp = new List<string>();
                while ((line = streamReader.ReadLine()) != null)
                {
                    if(line.Contains("#"))
                    {
                        this.numbers.Add(temp);
                        temp = new List<string>();
                    }
                    else
                    {
                        temp.Add(line);
                    }
                }
                this.numbers.RemoveAt(0);
            }
        }

        private void _initForm ()
        {
            this.lblEventName.Left = (this.ClientSize.Width - this.lblEventName.Width) / 2;
            this.lblCompanyName.Left = (this.ClientSize.Width - this.lblCompanyName.Width) / 2;
            this.lblRandomNumber.Left = (this.ClientSize.Width - this.lblRandomNumber.Width) / 2;
            this.btnRandToggler.Left = (this.ClientSize.Width - this.btnRandToggler.Width) / 2;
        }

        private void btnRandToggler_Click(object sender, EventArgs e)
        {
            if(this.togglerClicked)
            {
                this.btnRandToggler.Text = "Mulai Acak";
                this.togglerClicked = false;
                this.randTimer.Enabled = false;

                parser(this.numbers[randUser][randUserNumber]);
            }
            else
            {
                this.btnRandToggler.Text = "Berhenti";
                this.togglerClicked = true;
                this.randTimer.Enabled = true;

                this.getTheLuckyUser();
                cok.Text = String.Format("{0} {1}", randUser, randUserNumber);
                
            }
            
        }

        private void getTheLuckyUser ()
        {
            Random rand = new Random();

            if(userQueue.Count > 0)
            {
                this.randUser = rand.Next(1, userQueue.Count());
                this.userQueue.RemoveAt(this.randUser);
            }
            else
            {
                this.randUser = 0;
            }
            
            this.randUserNumber = rand.Next(0, this.numbers[randUser].Count());
        }

        private void parser(String angka)
        {
            angka = String.Format("{0:0000}", Convert.ToInt32(angka));
            this.angkaAcak = String.Format("{0} {1} {2} {3}",
                angka[0],
                angka[1],
                angka[2],
                angka[3]);

            this.lblRandomNumber.Text = this.angkaAcak;
        }

        private void randTimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 1000);
            String angkaFormat = String.Format("{0:0000}", rndNumber);

            parser(angkaFormat);
            
            this.lblRandomNumber.Text = this.angkaAcak;
        }
    }
}
