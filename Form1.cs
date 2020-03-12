using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Timer TimerPrincipal = new Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            if (checkBox1.Checked)
            {
                MessageBox.Show("La cajita esta activada");
            }
            else
            {
                MessageBox.Show("La cajita esta desactivada");
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
                button1.Top = button1.Top + button1.Height;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = ":(";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.MouseEnter += button1_MouseEnter;
            }
            else
            {
                button1.MouseEnter -= button1_MouseEnter;
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formulario = new Form2();
            formulario.Show();
            formulario.Text = $"Formulario creado en {DateTime.Now}";
        }
    }
}
