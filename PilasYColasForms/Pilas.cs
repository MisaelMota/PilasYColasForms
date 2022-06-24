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
    public partial class Pilas : Form
    {
       public Stack<string> PilaB = new Stack<string>();
        


        public Pilas()
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
            
            PilaB.Pop();
            MostrarElementos();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PilaB.Push(textBox1.Text);
            MostrarElementos();
        }

        private void Pilas_Load(object sender, EventArgs e)
        {

        }

        public void MostrarElementos()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < PilaB.Count; i++)
            {
                listBox1.Items.Add(PilaB.ElementAt(i));
            }
        }

        


    }
}
