using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace juegoZomb
{
    public partial class Form1 : Form


    {

        SoundPlayer musicafondo = new SoundPlayer(@"C:\musica\monde.wav");

        PictureBox imgPictureBox = new PictureBox();

        Boolean dispar;
        int con = 0;
        int pasbalax = 0;
        int pasbalay = 0;
        int velocidadbala = 10;
        bool visible = false;


        public Form1()
        {
           
            
            InitializeComponent();
            musicafondo.Play();

            perdio.SendToBack();


          

        }
        int puntaje = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void crearpicturBox()
        {
            imgPictureBox = new PictureBox();
            imgPictureBox.Location = new System.Drawing.Point(goku.Location.X, goku.Location.Y);
            imgPictureBox.Size = new System.Drawing.Size(64, 61);
            imgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPictureBox.BackColor = Color.Transparent;
            imgPictureBox.Image = Properties.Resources.poder3;
            Controls.Add(imgPictureBox);
            imgPictureBox.Visible = true;




        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                poder.Top -= 6;
                goku.Top -= 10;

            }
            if(e.KeyCode == Keys.Down) 
            {
                poder.Top += 6;
                goku.Top += 10;

            }
            if (e.KeyCode == Keys.Space)
            {
                visible = true;
                // zombie1.Location = new Point(aleatorio.Next(1000),200);
              //  musica_fondo.Stop();

              //  poder.Play();


                disparo();
                // MessageBox.Show("hola");
            }


            if (e.KeyCode == Keys.A)
            {
                crearpicturBox();

            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            movimiento();
            //colicion();


            foreach (Control x in this.Controls)
            {


                    if (x is PictureBox && (String)x.Tag == "barra")
                {


                    if (zomb.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        DialogResult respuesta = MessageBox.Show("Continuar ", "F", MessageBoxButtons.OKCancel);
                        if (respuesta == DialogResult.OK)
                        {

                            timer1.Start();
                            z.Location = new Point(982, 82);
                            zo.Location = new Point(1006, 197);
                            zomb.Location = new Point(980, 391);

                        }
                    }
                    else if (z.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        DialogResult respuesta = MessageBox.Show("Continuar ", "F", MessageBoxButtons.OKCancel);
                        if (respuesta == DialogResult.OK)
                        {

                            timer1.Start();
                            z.Location = new Point(982, 82);
                            zo.Location = new Point(1006, 197);
                            zomb.Location = new Point(980, 391);

                        }
                    }
                    else if (zo.Bounds.IntersectsWith(x.Bounds))
                    {
                       timer1.Stop();
                        DialogResult respuesta = MessageBox.Show("Continuar ", "F", MessageBoxButtons.OKCancel);
                        if (respuesta == DialogResult.OK)
                        {

                            timer1.Start();
                            z.Location = new Point(982, 82);
                            zo.Location = new Point(1006, 197);
                            zomb.Location = new Point(980, 391);

                        }
                    }
                }
                if (x is PictureBox && (String)x.Tag == "bala")
                {
                   
                    x.Left += 25;
                    if (x.Left > 1000)
                    {
                        //quitarbala(((PictureBox)poder));
                    }

                    else if (zo.Bounds.IntersectsWith(x.Bounds))
                    {
                        con = con + 5;
                        label1.Text = "puntaje: " + con;
                        zo.Location = new Point(1006, 197);
                    }
                    else if (z.Bounds.IntersectsWith(x.Bounds))
                    {
                       

                        con = con + 5;
                        label1.Text = "puntaje: " + con;
                        z.Location = new Point(982, 82);
                    }
                    else if (zomb.Bounds.IntersectsWith(x.Bounds))
                    {
                    

                        con = con + 5;
                        label1.Text = "puntaje: " + con;
                        zomb.Location = new Point(980, 391);
                       
                    }
                    else if (con >= 30)
                    {
                        zomb.Left -= 10;
                        z.Left -= 12;
                        zo.Left -= 15;


                        BackgroundImage = juegoZomb.Properties.Resources.agua;
                        perdio.Image = juegoZomb.Properties.Resources.agua;
                    }
                }

                
                /* if (x is PictureBox && (String)x.Tag == "bala")
         {
             if (z.Bounds.IntersectsWith(x.Bounds))
             {
                 con = con + 10;
                 label1.Text = "puntaje: " + con;
                 z.Dispose();

                  BackgroundImage = juegoZomb.Properties.Resources.agua;
                 perdio.Image = juegoZomb.Properties.Resources.agua;



             }


         }
         if (x is PictureBox && (String)x.Tag == "bala")
         {
             if (zomb.Bounds.IntersectsWith(x.Bounds))
             {
                 con = con + 10;
                 label1.Text = "puntaje: " + con;
                 zomb.Dispose();
                 BackgroundImage = juegoZomb.Properties.Resources.agua;
                 perdio.Image = juegoZomb.Properties.Resources.agua;
             }
         }*/



                if (puntaje == 30)
                {
                    timer1.Stop();
                    timer2.Stop();
                    DialogResult respuesta = MessageBox.Show("GANASTE \n PRESIONA <SI> PARA SALIR ", "GANASTE", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        this.Close();

                    }
                }
               

            }
        }
        private void quitarbala(PictureBox poder)
        {
            this.Controls.Remove(poder);
            poder.Dispose();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            iniciar();

            if (visible == true)
            {

                if (pasbalax <= 50)
                {
                    // MessageBox.Show("hola");
                    pasbalax += velocidadbala;
                    poder.Left += pasbalax;
                }
                else
                {
                    //  PosBalaX = micolta.Location.X;
                    //   PosBalaY = micolta.Location.Y;
                    visible = false;
                    // bala.Location = new Point(PosBalaX,PosBalaY);
                    timer2.Stop();
                }
            }
            else
            {
                pasbalax = goku.Location.X;
                pasbalay = goku.Location.Y;
            }
 

        }
        public void iniciar()
        {
          

        }

        public void reiniciar()
        {
            

        }

        private void vegeta_Click(object sender, EventArgs e)
        {

        }


      /*  public void colicion ()
        {
        if (zom.Bounds.IntersectsWith(zo.Bounds))
            {

                zom.Image = juegoZomb.Properties.Resources.splas;
                timer1.Stop();
                DialogResult respuesta = MessageBox.Show ("Continuar ", "F", MessageBoxButtons.OKCancel);
                if (respuesta == DialogResult.OK)
                {

                    timer1.Start();


                    zom.Location = new Point(550, 496);

                }
                else
                {
                    Close();

                }

             
            }


        }*/
        public void movimiento()
        {
            zomb.Left -=3;
            z.Left -= 5;
            zo.Left -=4;
        
        }

        public void disparo()
        {

            pasbalax = goku.Location.X +0; 
            pasbalay = goku.Location.Y +0;
            poder.Location = new Point(pasbalax, pasbalay);

            if (Visible == true)
            {
                timer2.Enabled = true;

            }

        }

    }
}






