using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasYColasForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Colas colas = new Colas();
            this.Hide();
            colas.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pilas pilas = new Pilas();
            this.Hide();
            pilas.Show();
        }
    }
}
