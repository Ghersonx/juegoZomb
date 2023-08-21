
namespace juegoZomb
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.goku = new System.Windows.Forms.PictureBox();
            this.z = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.poder = new System.Windows.Forms.PictureBox();
            this.zomb = new System.Windows.Forms.PictureBox();
            this.zo = new System.Windows.Forms.PictureBox();
            this.perdio = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perdio)).BeginInit();
            this.SuspendLayout();
            // 
            // goku
            // 
            this.goku.BackColor = System.Drawing.Color.Transparent;
            this.goku.Image = global::juegoZomb.Properties.Resources.joan;
            this.goku.Location = new System.Drawing.Point(364, 197);
            this.goku.Name = "goku";
            this.goku.Size = new System.Drawing.Size(112, 110);
            this.goku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goku.TabIndex = 1;
            this.goku.TabStop = false;
            this.goku.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // z
            // 
            this.z.BackColor = System.Drawing.Color.Transparent;
            this.z.Image = global::juegoZomb.Properties.Resources._1zombiegif1;
            this.z.Location = new System.Drawing.Point(982, 82);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(61, 82);
            this.z.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.z.TabIndex = 2;
            this.z.TabStop = false;
            this.z.Tag = "zombie";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // poder
            // 
            this.poder.BackColor = System.Drawing.Color.Transparent;
            this.poder.Image = global::juegoZomb.Properties.Resources.poder3;
            this.poder.Location = new System.Drawing.Point(436, 233);
            this.poder.Name = "poder";
            this.poder.Size = new System.Drawing.Size(40, 31);
            this.poder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poder.TabIndex = 3;
            this.poder.TabStop = false;
            this.poder.Tag = "bala";
            // 
            // zomb
            // 
            this.zomb.BackColor = System.Drawing.Color.Transparent;
            this.zomb.Image = global::juegoZomb.Properties.Resources._1zombiegif2;
            this.zomb.Location = new System.Drawing.Point(1001, 330);
            this.zomb.Name = "zomb";
            this.zomb.Size = new System.Drawing.Size(63, 100);
            this.zomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zomb.TabIndex = 4;
            this.zomb.TabStop = false;
            this.zomb.Tag = "zombie";
            // 
            // zo
            // 
            this.zo.BackColor = System.Drawing.Color.Transparent;
            this.zo.Image = global::juegoZomb.Properties.Resources._1zombiegif;
            this.zo.Location = new System.Drawing.Point(1006, 197);
            this.zo.Name = "zo";
            this.zo.Size = new System.Drawing.Size(58, 93);
            this.zo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zo.TabIndex = 5;
            this.zo.TabStop = false;
            this.zo.Tag = "zombie";
            this.zo.Click += new System.EventHandler(this.vegeta_Click);
            // 
            // perdio
            // 
            this.perdio.BackColor = System.Drawing.SystemColors.ControlText;
            this.perdio.Image = global::juegoZomb.Properties.Resources.fondo;
            this.perdio.Location = new System.Drawing.Point(353, -6);
            this.perdio.Name = "perdio";
            this.perdio.Size = new System.Drawing.Size(10, 515);
            this.perdio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.perdio.TabIndex = 6;
            this.perdio.TabStop = false;
            this.perdio.Tag = "barra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::juegoZomb.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.perdio);
            this.Controls.Add(this.zo);
            this.Controls.Add(this.zomb);
            this.Controls.Add(this.poder);
            this.Controls.Add(this.z);
            this.Controls.Add(this.goku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.goku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perdio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox goku;
        private System.Windows.Forms.PictureBox z;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox poder;
        private System.Windows.Forms.PictureBox zomb;
        private System.Windows.Forms.PictureBox zo;
        private System.Windows.Forms.PictureBox perdio;
        private System.Windows.Forms.Label label1;
    }
}

