using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juegoZomb
{
    public partial class Splas : Form
    {
        public Splas()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel4.Width < 489)
            {
                panel4.Width += 10;
                label2.Text = "Cargando " + (panel4.Width * 0.2) + "%";
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;

                Form1 ventana = new Form1();
                ventana.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
