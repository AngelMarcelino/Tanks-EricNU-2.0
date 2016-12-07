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
    public partial class MenuP : Form
    {
        public MenuP()
        {
            InitializeComponent();
        }
        private void MenuP_Load(object sender, EventArgs e)
        {
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Iniciarjuego a = new Iniciarjuego();
            this.Hide();
            a.ShowDialog();
        }
        private void Label2_Click(object sender, EventArgs e)
        {
            comojugar a = new comojugar();
            this.Hide();
            a.ShowDialog();
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Programa hecho por Arturo Y Eric","Acerca de");
        }
    }
}
