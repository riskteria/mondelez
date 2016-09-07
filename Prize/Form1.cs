using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prize
{
    public partial class Form1 : Form
    {
        private Label formLabel = new Label();
        private Label randNumber = new Label();
        private Button toggleBtn = new Button();

        private void _initializeForm ()
        {

        }

        private void _initalizeControls ()
        {
            this.Controls.Add(formLabel);
            this.Controls.Add(randNumber);
            this.Controls.Add(toggleBtn);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
