using System;
using System.Collections;
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
    public partial class Colas : Form
    {
        Queue<string> ColaB = new Queue<string>();

        public Colas()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            btnBack.Click += BtnBack_Click;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ColaB.Dequeue();
            MostrarElementos();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ColaB.Enqueue(textBox1.Text);
            MostrarElementos();
        }

        public void MostrarElementos()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ColaB.Count; i++)
            {
                listBox1.Items.Add(ColaB.ElementAt(i));
            }
        }
    }
}
