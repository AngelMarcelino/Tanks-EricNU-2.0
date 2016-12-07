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
    public partial class Iniciarjuego : Form
    {
        public Iniciarjuego()
        {
            InitializeComponent();
        }
        private void Iniciarjuego_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Iniciarjuego_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbj1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbj2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbj3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbj4.DropDownStyle = ComboBoxStyle.DropDownList;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = Image.FromFile("img/map1.jpg");
            comboBox2.Items.Add("Duelo");
            comboBox2.Items.Add("Hordas");
            picj1.Image = Image.FromFile("img/" + "t1.gif");
            picj2.Image = Image.FromFile("img/" + "bat.gif");
            picj3.Image = Image.FromFile("img/" + "bote.gif");
            picj4.Image = Image.FromFile("img/" + "bob.gif");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuP a = new MenuP();
            this.Hide();
            a.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString()) { 
                case "1":
                    comboBox2.Items.Clear();
                    comboBox2.Text = "Hordas";
                    comboBox2.Items.Add("Duelo");
                    comboBox2.Items.Add("Hordas");

                    chbj2.Visible = false;
                    chbj3.Visible = false;
                    chbj4.Visible = false;
                    lblj2.Visible = false;
                    lblj3.Visible = false;
                    lblj4.Visible = false;
                    cmbj2.Visible = false;
                    cmbj3.Visible = false;
                    cmbj4.Visible = false;
                    picj2.Visible = false;
                    picj3.Visible = false;
                    picj4.Visible = false;
                    break;
                case "2":
                    comboBox2.Items.Clear();
                    comboBox2.Text = "Hordas";
                    comboBox2.Items.Add("Duelo");
                    comboBox2.Items.Add("Destruye la base enemiga");
                    comboBox2.Items.Add("Hordas");
                    chbj2.Visible = false;
                    chbj3.Visible = false;
                    chbj4.Visible = false;
                    lblj2.Visible = true;
                    lblj3.Visible = false;
                    lblj4.Visible = false;
                    cmbj2.Visible = true;
                    cmbj3.Visible = false;
                    cmbj4.Visible = false;
                    picj2.Visible = true;
                    picj3.Visible = false;
                    picj4.Visible = false;
                    break;
                case "4":
                    comboBox2.Items.Clear();
                    comboBox2.Text = "Hordas";
                    comboBox2.Items.Add("Free for all");
                    comboBox2.Items.Add("Destruye la base enemiga");
                    comboBox2.Items.Add("2 vs 2");
                    comboBox2.Items.Add("Hordas");
                    chbj2.Visible = true;
                    chbj3.Visible = true;
                    chbj4.Visible = true;
                    lblj2.Visible = true;
                    lblj3.Visible = true;
                    lblj4.Visible = true;
                    cmbj2.Visible = true;
                    cmbj3.Visible = true;
                    cmbj4.Visible = true;
                    picj2.Visible = true;
                    picj3.Visible = true;
                    picj4.Visible = true;
                    break;
            }
        }

        private void cmbj1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbj1.Text)
            {
                case "Halcon":
                    picj1.Image = Image.FromFile("img/" + "t1.gif");
                    break;
                case "Lechuga":
                    picj1.Image = Image.FromFile("img/" + "t3.gif");
                    break;
                case "Mariposa":
                    picj1.Image = Image.FromFile("img/" + "t2.gif");
                    break;
                case "Vieja confiable":
                    picj1.Image = Image.FromFile("img/" + "t4.gif");
                    break;
                case "Batimovil":
                    picj1.Image = Image.FromFile("img/" + "bat.gif");
                    break;
                case "Cangremovil":
                    picj1.Image = Image.FromFile("img/" + "bob.gif");
                    break;
                case "McQueen":
                    picj1.Image = Image.FromFile("img/" + "mc.gif");
                    break;
                case "Diep":
                    picj1.Image = Image.FromFile("img/" + "diep.gif");
                    break;
                case "DeLorean":
                    picj1.Image = Image.FromFile("img/" + "delorean.gif");
                    break;
                case "Botemovil invisible":
                    picj1.Image = Image.FromFile("img/" + "bote.gif");
                    break;
            }
        }

        private void cmbj2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbj2.Text)
            {
                case "Halcon":
                    picj2.Image = Image.FromFile("img/" + "t1.gif");
                    break;
                case "Lechuga":
                    picj2.Image = Image.FromFile("img/" + "t3.gif");
                    break;
                case "Mariposa":
                    picj2.Image = Image.FromFile("img/" + "t2.gif");
                    break;
                case "Vieja confiable":
                    picj2.Image = Image.FromFile("img/" + "t4.gif");
                    break;
                case "Batimovil":
                    picj2.Image = Image.FromFile("img/" + "bat.gif");
                    break;
                case "Cangremovil":
                    picj2.Image = Image.FromFile("img/" + "bob.gif");
                    break;
                case "McQueen":
                    picj2.Image = Image.FromFile("img/" + "mc.gif");
                    break;
                case "Diep":
                    picj2.Image = Image.FromFile("img/" + "diep.gif");
                    break;
                case "DeLorean":
                    picj2.Image = Image.FromFile("img/" + "delorean.gif");
                    break;
                case "Botemovil invisible":
                    picj2.Image = Image.FromFile("img/" + "bote.gif");
                    break;
            }
        }

        private void cmbj3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbj3.Text)
            {
                case "Halcon":
                    picj3.Image = Image.FromFile("img/" + "t1.gif");
                    break;
                case "Lechuga":
                    picj3.Image = Image.FromFile("img/" + "t3.gif");
                    break;
                case "Mariposa":
                    picj3.Image = Image.FromFile("img/" + "t2.gif");
                    break;
                case "Vieja confiable":
                    picj3.Image = Image.FromFile("img/" + "t4.gif");
                    break;
                case "Batimovil":
                    picj3.Image = Image.FromFile("img/" + "bat.gif");
                    break;
                case "Cangremovil":
                    picj3.Image = Image.FromFile("img/" + "bob.gif");
                    break;
                case "McQueen":
                    picj3.Image = Image.FromFile("img/" + "mc.gif");
                    break;
                case "Diep":
                    picj3.Image = Image.FromFile("img/" + "diep.gif");
                    break;
                case "DeLorean":
                    picj3.Image = Image.FromFile("img/" + "delorean.gif");
                    break;
                case "Botemovil invisible":
                    picj3.Image = Image.FromFile("img/" + "bote.gif");
                    break;
            }
        }

        private void cmbj4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbj4.Text)
            {
                case "Halcon":
                    picj4.Image = Image.FromFile("img/" + "t1.gif");
                    break;
                case "Lechuga":
                    picj4.Image = Image.FromFile("img/" + "t3.gif");
                    break;
                case "Mariposa":
                    picj4.Image = Image.FromFile("img/" + "t2.gif");
                    break;
                case "Vieja confiable":
                    picj4.Image = Image.FromFile("img/" + "t4.gif");
                    break;
                case "Batimovil":
                    picj4.Image = Image.FromFile("img/" + "bat.gif");
                    break;
                case "Cangremovil":
                    picj4.Image = Image.FromFile("img/" + "bob.gif");
                    break;
                case "McQueen":
                    picj4.Image = Image.FromFile("img/" + "mc.gif");
                    break;
                case "Diep":
                    picj4.Image = Image.FromFile("img/" + "diep.gif");
                    break;
                case "DeLorean":
                    picj4.Image = Image.FromFile("img/" + "delorean.gif");
                    break;
                case "Botemovil invisible":
                    picj4.Image = Image.FromFile("img/" + "bote.gif");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
                switch (comboBox1.Text)
                {
                    case "1":
                        if (comboBox2.Text!=""){
                            WindowsFormsApplication1.juego xd = new WindowsFormsApplication1.juego();
                        switch (comboBox2.Text)
                        {
                                
                            case "Duelo":
                                xd.modojuego = "Duelo";
                                xd.numeroj = 1;
                                xd.nummap = int.Parse(comboBox3.Text);
                                xd.tipotnk = new string[1];
                                xd.tipotnk[0] = cmbj1.Text;
                                xd.ShowDialog();
                                break;
                            case "Hordas":
                                xd.modojuego = "Hordas";
                                xd.numeroj = 1;
                                xd.nummap = int.Parse(comboBox3.Text);
                                xd.tipotnk = new string[1];
                                xd.tipotnk[0] = cmbj1.Text;
                                xd.ShowDialog();
                                break;
                        }
                        }
                        else
                            MessageBox.Show("No hay modo de juego");
                        break;
                    case "2":
                        if (comboBox2.Text != ""){
                            WindowsFormsApplication1.juego xd = new WindowsFormsApplication1.juego();
                            switch (comboBox2.Text)
                            {
                                case "Duelo":
                                xd.modojuego = "Duelo";
                                xd.numeroj = 2;
                                xd.nummap = int.Parse(comboBox3.Text);
                                xd.tipotnk = new string[2];
                                xd.tipotnk[0] = cmbj1.Text;
                                xd.tipotnk[1] = cmbj2.Text;
                                xd.ShowDialog();
                                    break;
                                case "Destruye la base enemiga":
                                xd.modojuego = "Destruye la base enemiga";
                                xd.numeroj = 2;
                                xd.nummap = int.Parse(comboBox3.Text);
                                xd.tipotnk = new string[2];
                                xd.tipotnk[0] = cmbj1.Text;
                                xd.tipotnk[1] = cmbj2.Text;
                                xd.ShowDialog();
                                    break;
                                case "Hordas":
                                    xd.modojuego = "Hordas";
                                xd.numeroj = 2;
                                xd.nummap = int.Parse(comboBox3.Text);
                                xd.tipotnk = new string[2];
                                xd.tipotnk[0] = cmbj1.Text;
                                xd.tipotnk[1] = cmbj2.Text;
                                xd.ShowDialog();
                                    break;
                            }
                }
                        else
                            MessageBox.Show("No hay modo de juego");
                        break;
                    case "4":
                        if (comboBox2.Text != ""){
                            WindowsFormsApplication1.juego xd = new WindowsFormsApplication1.juego();
                            switch (comboBox2.Text)
                            {
                                case "Free for all":
                                xd.modojuego = "Free for all";
                                xd.numeroj = 4;
                                xd.nummap = int.Parse(comboBox3.Text);
                                xd.tipotnk = new string[4];
                                xd.tipotnk[0] = cmbj1.Text;
                                xd.tipotnk[1] = cmbj2.Text;
                                xd.tipotnk[2] = cmbj3.Text;
                                xd.tipotnk[3] = cmbj4.Text;
                                xd.maquinolas = new bool[3];
                                xd.maquinolas[0] = chbj2.Checked;
                                xd.maquinolas[1] = chbj3.Checked;
                                xd.maquinolas[2] = chbj4.Checked;
                                xd.ShowDialog();
                                    break;
                                case "Destruye la base enemiga":
                                xd.modojuego = "Destruye la base enemiga";
                                xd.numeroj = 4;
                                xd.nummap = int.Parse(comboBox3.Text);
                                xd.tipotnk = new string[4];
                                xd.tipotnk[0] = cmbj1.Text;
                                xd.tipotnk[1] = cmbj2.Text;
                                xd.tipotnk[2] = cmbj3.Text;
                                xd.tipotnk[3] = cmbj4.Text;
                                xd.maquinolas = new bool[3];
                                xd.maquinolas[0] = chbj2.Checked;
                                xd.maquinolas[1] = chbj3.Checked;
                                xd.maquinolas[2] = chbj4.Checked;
                                xd.ShowDialog();
                                    break;
                                case "2 vs 2":
                                xd.modojuego = "2 vs 2";
                                xd.numeroj = 4;
                                xd.nummap = int.Parse(comboBox3.Text);
                                xd.tipotnk = new string[4];
                                xd.tipotnk[0] = cmbj1.Text;
                                xd.tipotnk[1] = cmbj2.Text;
                                xd.tipotnk[2] = cmbj3.Text;
                                xd.tipotnk[3] = cmbj4.Text;
                                xd.maquinolas = new bool[3];
                                xd.maquinolas[0] = chbj2.Checked;
                                xd.maquinolas[1] = chbj3.Checked;
                                xd.maquinolas[2] = chbj4.Checked;
                                xd.ShowDialog();
                                    break;
                                case "Hordas":
                                xd.modojuego = "Hordas";
                                xd.numeroj = 4;
                                xd.nummap = int.Parse(comboBox3.Text);
                                xd.tipotnk = new string[4];
                                xd.tipotnk[0] = cmbj1.Text;
                                xd.tipotnk[1] = cmbj2.Text;
                                xd.tipotnk[2] = cmbj3.Text;
                                xd.tipotnk[3] = cmbj4.Text;
                                xd.maquinolas = new bool[3];
                                xd.maquinolas[0] = chbj2.Checked;
                                xd.maquinolas[1] = chbj3.Checked;
                                xd.maquinolas[2] = chbj4.Checked;
                                xd.ShowDialog();
                                    break;
                            }
                        }
                        else
                            MessageBox.Show("No hay modo de juego");
                        break;

                }
            else
                MessageBox.Show("No hay numero de jugadores");



            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox3.Text){
                case "1":
                    pictureBox2.BackgroundImage = Image.FromFile("img/" + "map1.jpg");
                    break;
                case "2":
                    pictureBox2.BackgroundImage = Image.FromFile("img/" + "map2.jpg");
                    break;
                case "3":
                    pictureBox2.BackgroundImage = Image.FromFile("img/" + "map3.jpg");
                    break;
                case "4":
                    pictureBox2.BackgroundImage = Image.FromFile("img/" + "map4.jpg");
                    break;
                case "5":
                    pictureBox2.BackgroundImage = Image.FromFile("img/" + "map5.jpg");
                    break;
                case "6":
                    pictureBox2.BackgroundImage = Image.FromFile("img/" + "map6.jpg");
                    break;
                case "7":
                    pictureBox2.BackgroundImage = Image.FromFile("img/" + "map7.jpg");
                    break;
                case "8":
                    pictureBox2.BackgroundImage = Image.FromFile("img/" + "map8.jpg");
                    break;


            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
