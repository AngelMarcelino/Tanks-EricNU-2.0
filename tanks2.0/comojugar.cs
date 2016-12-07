using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tanks2._0
{
    public partial class comojugar : Form
    {
        RichTextBox des = new RichTextBox();
        PictureBox xd = new PictureBox();
        public comojugar()
        {
            InitializeComponent();
        }

        private void comojugar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void controlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 7);
            xd.Image = null;
            des.Text = null;
        Keys[] kcon=new Keys[6];
            for (int i = 1; i < 5; i++) { 
                switch (i)
        {
            case 1:
                kcon[0] = Keys.W;
                kcon[1] = Keys.A;
                kcon[2] = Keys.S;
                kcon[3] = Keys.D;
                kcon[4] = Keys.Q;
                kcon[5] = Keys.E;
                break;
            case 2:
                kcon[0] = Keys.T;
                kcon[1] = Keys.F;
                kcon[2] = Keys.G;
                kcon[3] = Keys.H;
                kcon[4] = Keys.R;
                kcon[5] = Keys.Y;
                break;
            case 3:
                kcon[0] = Keys.I;
                kcon[1] = Keys.J;
                kcon[2] = Keys.K;
                kcon[3] = Keys.L;
                kcon[4] = Keys.U;
                kcon[5] = Keys.O;
                break;
            case 4:
                kcon[0] = Keys.NumPad8;
                kcon[1] = Keys.NumPad4;
                kcon[2] = Keys.NumPad5;
                kcon[3] = Keys.NumPad6;
                kcon[4] = Keys.NumPad7;
                kcon[5] = Keys.NumPad9;
                break;
        }
                des.Text += "Jugador "+i + Environment.NewLine;
                des.Text += "Tecla " + kcon[0].ToString() + " para movimiento hacia arriba" + Environment.NewLine
                    + "Tecla " + kcon[1].ToString() + " para movimiento hacia la izquierda" + Environment.NewLine
                + "Tecla " + kcon[2].ToString() + " para movimiento hacia abajo" + Environment.NewLine
                + "Tecla " + kcon[3].ToString() + " para movimiento hacia la derecha" + Environment.NewLine
                

                + "Tecla " + kcon[4].ToString() + " para dejar mina" + Environment.NewLine
                + "Tecla " + kcon[5].ToString() + " para disparar" + Environment.NewLine
                +"Tecla " + kcon[4].ToString() + "+" + kcon[5].ToString() + " para lanzar disparo especial (uno por vida)" + Environment.NewLine + Environment.NewLine;
            }
        }

        private void comojugar_Load(object sender, EventArgs e)
        {
        des.Location = new Point(50,25);
        des.Width = 220;
        des.Height = 600;
        des.BackColor = Color.Black;
        des.ForeColor = Color.White;
        des.BorderStyle = BorderStyle.None;
        des.ReadOnly = true;
        des.Visible = true;
        des.ForeColor = menuStrip1.BackColor;
        
        this.Controls.Add(des);
        


        xd.Location = new Point(570, 30);
        xd.Width = 300;
        xd.Height = 300;
        
        xd.BackColor = Color.Transparent;
        xd.BorderStyle = BorderStyle.None;
        xd.Visible = true;
        
        this.Controls.Add(xd);

        }

        private void destruyeLaBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 12);
            des.Text = "Destruye la base enemiga" + Environment.NewLine + Environment.NewLine + "En este modo de juego cada equipo debe disparar a la base enemiga hasta conseguir destruirla, a la vez debe cuidar que su propia base no sea eliminada al intentar llegar al objetivo." + Environment.NewLine + "En este modo de juego los equipos deben ser equilibrados ya sea 2-2 o 1-1, la victoria se logra con la eliminacion del equipo enemigo y su base";
            xd.Image = Image.FromFile("img/" + "base.gif");
            
        }

        private void asesinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 12);
            xd.Image = Image.FromFile("img/" + "tnk.gif"); ;
            des.Text = "Asesino" + Environment.NewLine + Environment.NewLine + "En este modo de juego deberás asesinar a todos tus enemigos; puede jugarse por equipos o de forma individual. Tendras ser cuidadoso ya que tendras un numero limitado de vidas que te haran perder si llegan a 0;en este modo gana el ultimo que quede en pie.";
        }

        private void halconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 30);
            des.Text = "Descripcion:" + Environment.NewLine + Environment.NewLine + "Ataque: 1" + Environment.NewLine + "Velocidad: 4" + Environment.NewLine + "Vida: 10";
            xd.Image = Image.FromFile("img/" + "t1.gif");
       
        }

        private void lechugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 30);
            des.Text = "Descripcion:" + Environment.NewLine + Environment.NewLine + "Ataque: 3" + Environment.NewLine + "Velocidad: 2" + Environment.NewLine + "Vida: 12";
            xd.Image = Image.FromFile("img/" + "t3.gif");
        }

        private void laViejaConfiableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 30);
            des.Text = "Descripcion:" + Environment.NewLine + Environment.NewLine + "Ataque: 4" + Environment.NewLine + "Velocidad: 1" + Environment.NewLine + "Vida: 13";
            xd.Image = Image.FromFile("img/" + "t4.gif");
        }

        private void mariposaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 30);
            des.Text = "Descripcion:" + Environment.NewLine + Environment.NewLine + "Ataque: 2" + Environment.NewLine + "Velocidad: 3" + Environment.NewLine + "Vida: 11";
            xd.Image = Image.FromFile("img/" + "t2.gif");
        }

        private void batimovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 30);
            des.Text = "Descripcion:" + Environment.NewLine + Environment.NewLine + "Ataque: 2" + Environment.NewLine + "Velocidad: 4" + Environment.NewLine + "Vida: 12";
            xd.Image = Image.FromFile("img/" + "bat.gif");
        }

        private void cangremovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 30);
            des.Text = "Descripcion:" + Environment.NewLine + Environment.NewLine + "Ataque: 3" + Environment.NewLine + "Velocidad: 3" + Environment.NewLine + "Vida: 11";
            xd.Image = Image.FromFile("img/" + "bob.gif");
        }

        private void deLoreanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 30);
            des.Text = "Descripcion:" + Environment.NewLine + Environment.NewLine + "Ataque: 2" + Environment.NewLine + "Velocidad: 3" + Environment.NewLine + "Vida: 11";
            xd.Image = Image.FromFile("img/" + "delorean.gif");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuP a = new MenuP();
            this.Hide();
            a.ShowDialog();
            
            
        }

        private void diepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 30);
            des.Text = "Descripcion:" + Environment.NewLine + Environment.NewLine + "Ataque: 3" + Environment.NewLine + "Velocidad: 2" + Environment.NewLine + "Vida: 12";
            xd.Image = Image.FromFile("img/" + "diep.gif");
        }

        private void mcQueenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 30);
            des.Text = "Descripcion:" + Environment.NewLine + Environment.NewLine + "Ataque: 3" + Environment.NewLine + "Velocidad: 4" + Environment.NewLine + "Vida: 10";
            xd.Image = Image.FromFile("img/" + "mc.gif");
        }

        private void botemovilInvisileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 30);
            des.Text = "Descripcion:" + Environment.NewLine + Environment.NewLine + "Ataque: 1" + Environment.NewLine + "Velocidad: 3" + Environment.NewLine + "Vida: 10";
            xd.Image = Image.FromFile("img/" + "bote.gif");
        }

        private void modosDeJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hordasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            des.Font = new Font("Arial", 12);
            xd.Image = Image.FromFile("img/" + "tnk.gif"); ;
            des.Text = "Hordas" + Environment.NewLine + Environment.NewLine + "En este modo de juego tanques enemigos saldran controlados por la computadora los cuales trataran de destruirte, el objetivo es destruir a tantos como te sea posible antes de perder las vidas de tu tanque.";
        
        }
    }
}
