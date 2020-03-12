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
    public partial class Form2 : Form
    {
        Timer TimerPrincipal = new Timer();
        public Form2()
        {
            InitializeComponent();

            TimerPrincipal.Tick += TimerPrincipal_Tick;
            TimerPrincipal.Interval = 1;
            TimerPrincipal.Start();

        }

        private void TimerPrincipal_Tick(object sender, EventArgs e)
        {
            var fechaYHora = DateTime.Now;
            label1.Text = fechaYHora.ToString("dd/MM/yyyy hh:mm:ss.fff");
            if ((fechaYHora.Second % 2) == 0)
            {
                label1.ForeColor = Color.Black;
            }
            else
            {
                label1.ForeColor = Color.Red;
            }
        }
    }
}
