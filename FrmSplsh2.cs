using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioSplash
{
    public partial class FrmSplsh2 : Form
    {
        public FrmSplsh2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(panel2.Width < 489)
            {
                panel2.Width += 10;
                label1.Text = "Cargando " + (panel2.Width*0.2) + "%";
            }
            else
            {
                timer1.Enabled = false;
                this.Close();

            }
        }
    }
}
