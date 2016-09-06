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

namespace Prize
{
    public partial class Form1 : Form
    {
        private Boolean togglerClicked;
        private String angkaAcak;
        private String[] data;
        
        public Form1()
        {
            InitializeComponent();
            this.togglerClicked = false;
            this.angkaAcak = "0 0 0 0";
        }

        private void _readData ()
        {
            var list = new List<string>();
            var path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "mondelez\\data.txt");
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            data = list.ToArray();
            cok.Text = Convert.ToString(data.GetUpperBound(0));
        }

        private void _initForm ()
        {
            this.lblEventName.Left = (this.ClientSize.Width - this.lblEventName.Width) / 2;
            this.lblCompanyName.Left = (this.ClientSize.Width - this.lblCompanyName.Width) / 2;
            this.lblRandomNumber.Left = (this.ClientSize.Width - this.lblRandomNumber.Width) / 2;
            this.btnRandToggler.Left = (this.ClientSize.Width - this.btnRandToggler.Width) / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._initForm();
            this._readData();
            this.randTimer.Enabled = false;
            this.lblRandomNumber.Text = this.angkaAcak;
        }

        private void btnRandToggler_Click(object sender, EventArgs e)
        {
            if(this.togglerClicked)
            {
                this.btnRandToggler.Text = "Mulai Acak";
                this.togglerClicked = false;
                this.randTimer.Enabled = false;
            }
            else
            {
                this.btnRandToggler.Text = "Berhenti";
                this.togglerClicked = true;
                this.randTimer.Enabled = true;
            }
            
        }

        private void randTimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 1000);
            String angkaFormat = String.Format("{0:0000}", rndNumber);

            this.angkaAcak = String.Format("{0} {1} {2} {3}", 
                angkaFormat[0],
                angkaFormat[1],
                angkaFormat[2],
                angkaFormat[3]);
            this.lblRandomNumber.Text = this.angkaAcak;
        }
    }
}
