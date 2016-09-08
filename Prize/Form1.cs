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
        private List<List<string>> numbersGold;
        private List<List<string>> numbersPlatinum;

        private int randUser;
        private int randUserNumber;
        private int steps;

        private bool activeStatus = false;

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
            this.numbersPlatinum = new List<List<string>>();
            this.numbersGold = new List<List<string>>();

            this.userQueue = new List<int>();
            this.steps = 7;

            this._initForm();
            this._initData();
            this._readData();
            this.randTimer.Enabled = false;
            this.lblRandomNumber.Text = this.angkaAcak;

            this.initQueue();
        }

        private void _initData ()
        {
            string platinum = "platinum";

            _addData(1, 111, platinum);
            _addData(112, 157, platinum);

            _addData(158, 183);
            _addData(184, 197);
            _addData(198, 212);
            _addData(213, 225);
            _addData(226, 238);
            _addData(239, 251);
            _addData(252, 264);
            _addData(265, 276);
            _addData(277, 286);
            _addData(287, 295);
            _addData(296, 305);
            _addData(306, 314);
            _addData(315, 323);
            _addData(324, 332);
            _addData(333, 341);
            _addData(342, 349);
            _addData(350, 356);
            _addData(357, 364);

            _addData(525, 584, platinum);
            _addData(585, 636, platinum);
            _addData(637, 677, platinum);
            _addData(678, 716, platinum);
            _addData(717, 754, platinum);
            _addData(755, 787, platinum);
            _addData(788, 818, platinum);
            _addData(819, 846, platinum);
            _addData(847, 873, platinum);

            _addData(874, 891);
            _addData(892, 906);
            _addData(907, 920);
            _addData(921, 932);
            _addData(933, 944);
            _addData(945, 955);
            _addData(956, 964);
            _addData(965, 967);
            _addData(968, 997);
            _addData(998, 1000);

        }

        private void _addData(int from, int to, string jenis = "gold")
        {
            List<string> temp = new List<string>();
            for(; from <= to; from++)
            {
                temp.Add(from.ToString());
            }

            if(jenis == "platinum")
            {
                numbersPlatinum.Add(temp);
            }
            else
            {
                numbersGold.Add(temp);
            }
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
            this.lblRandomNumber.Left = (this.ClientSize.Width - this.lblRandomNumber.Width) / 2;
            this.btnRandToggler.Left = (this.ClientSize.Width - this.btnRandToggler.Width) / 2;
            this.arisanType.Left = (this.ClientSize.Width - this.arisanType.Width) - 30;
            this.arisanNumber.Left = (this.ClientSize.Width - this.arisanNumber.Width) - 40;
            this.btnRandToggler.BackColor = Color.DeepSkyBlue;
            this.lblRandomNumber.BackColor = Color.Transparent;

            this.arisanType.BackColor = Color.Gold;
            this.arisanType.ForeColor = Color.WhiteSmoke;
            this.arisanNumber.Text = String.Format("# {0}", steps);
            this.arisanNumber.BackColor = Color.Transparent;
        }

        private void btnRandToggler_Click(object sender, EventArgs e)
        {
            if(this.togglerClicked)
            {
                this.btnRandToggler.BackColor = Color.DeepSkyBlue;
                this.btnRandToggler.Text = "Mulai Acak";
                this.togglerClicked = false;
                this.randTimer.Enabled = false;

                parser(this.numbers[randUser][randUserNumber]);
                cok.Text = String.Format("{0} {1}", randUser, randUserNumber);

                if(steps == 1)
                {
                    this.btnRandToggler.Text = "Selamat";
                    this.btnRandToggler.Enabled = false;
                    this.btnRandToggler.BackColor = Color.Transparent;
                }
                
            }
            else
            {
                this.btnRandToggler.BackColor = Color.PaleVioletRed;
                this.btnRandToggler.Text = "Berhenti";
                this.togglerClicked = true;
                this.randTimer.Enabled = true;

                this.getTheLuckyUser();

                if (activeStatus) { steps--; }
                activeStatus = true;
                this.arisanNumber.Text = String.Format("# {0}", steps);

                if (steps < 4)
                {
                    this.arisanType.BackColor = Color.LightGray;
                    this.arisanType.ForeColor = Color.DarkSlateGray;
                    this.arisanType.Text = "Platinum";
                }

            }
            
        }

        private void getTheLuckyUser ()
        {
            Random rand = new Random();

            if(userQueue.Count > 0)
            {
                int r = rand.Next(0, userQueue.Count());
                this.randUser = userQueue[r];
                this.userQueue.RemoveAt(userQueue.BinarySearch(randUser));
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
