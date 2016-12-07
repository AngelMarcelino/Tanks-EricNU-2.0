using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class juego : Form
    {
        Thread shilo;
        public string modojuego;
        public int numeroj,nummap;
        public string[] tipotnk;
        public bool[] maquinolas;
        Tank[] Tanks;
        Bitmap tmpimg;
        bool[,] map = new bool[18, 14];
        Point[] cy;
        System.Drawing.Rectangle[] rec2;
        Mapas datos_de_mapas = new Mapas();
        Random ran = new Random();
        public juego()  
        {
            InitializeComponent();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int contador = 0; contador < numeroj; contador++) {
                
            switch(tipotnk[contador]){
                case "Halcon":
                    tipotnk[contador] = "2";
                    break;
                case "Lechuga":
                    tipotnk[contador] = "3";
                    break;
                case "Mariposa":
                    tipotnk[contador] = "4";
                    break;
                case "Vieja confiable":
                    tipotnk[contador] = "5";
                    break;
                case "Batimovil":
                    tipotnk[contador] = "6";
                    break;
                case "Cangremovil":
                    tipotnk[contador] = "7";
                    break;
                case "DeLorean":
                    tipotnk[contador] = "8";
                    break;
                case "Diep":
                    tipotnk[contador] = "9";
                    break;
                case "McQueen":
                    tipotnk[contador] = "10";
                    break;
                case "Botemovil invisible":
                    tipotnk[contador] = "11";
                    break;
            }
            
            }
                switch (numeroj)
                {
                    case 1:
                        switch (modojuego)
                        {
                            case "Duelo":
                                Tanks = new Tank[2];
                                Tanks[0] = new Tank(int.Parse(tipotnk[0]), 1, "Jugador 1", new Point(1, 370), false, 1, false);
                                Tanks[1] = new Tank(ran.Next(2, 11), 2, "Maquinola 1", new Point(840, 370), false, 2, true);
                                break;
                            case "Horda":
                                Tanks = new Tank[2];
                                Tanks[0] = new Tank(int.Parse(tipotnk[0]), 1, "Jugador 1", new Point(1, 370), false, 1, false);
                                Tanks[1] = new Tank(ran.Next(2, 11), 2, "Maquinola ", new Point(840, 370), false, 2, true);
                                break;
                        }
                        break;
                    case 2:
                        switch (modojuego)
                        {
                            case "Duelo":
                                Tanks = new Tank[2];
                                Tanks[0] = new Tank(int.Parse(tipotnk[0]), 1, "Jugador 1", new Point(1, 370), false, 1, false);
                                Tanks[1] = new Tank(int.Parse(tipotnk[1]), 2, "Jugador 2", new Point(840, 370), false, 2, false);
                                break;
                            case "Destruye la base enemiga":
                                Tanks = new Tank[4];
                                Tanks[0] = new Tank(int.Parse(tipotnk[0]), 1, "Jugador 1", new Point(1, 370), false, 1, false);
                                Tanks[1] = new Tank(1, 5, "Base equipo 1", new Point(1, 350), true, 1, false);
                                Tanks[2] = new Tank(int.Parse(tipotnk[1]), 2, "Jugador 2", new Point(840, 370), false, 2, false);
                                Tanks[3] = new Tank(1, 6, "Base equipo 2", new Point(840, 350), true, 2, false);
                                break;
                            case "Hordas":
                                Tanks = new Tank[4];
                                Tanks[0] = new Tank(int.Parse(tipotnk[0]), 1, "Jugador 1", new Point(1, 370), false, 1, false);
                                Tanks[1] = new Tank(int.Parse(tipotnk[1]), 2, "Jugador 2", new Point(1, 370), false, 1, false);
                                Tanks[2] = new Tank(ran.Next(2, 11), 3, "Maquinola 1", new Point(840, 370), false, 2, true);
                                Tanks[3] = new Tank(ran.Next(2, 11), 4, "Maquinola 2", new Point(840, 370), false, 2, true);
                                break;
                        }
                        break;
                    case 4:
                        switch (modojuego)
                        {
                            case "Free for all":
                                Tanks = new Tank[4];
                                if (nummap == 7)
                                {
                                    Tanks[0] = new Tank(int.Parse(tipotnk[0]), 1, "Jugador 1", new Point(1, 155), false, 1, false);
                                    Tanks[1] = new Tank(int.Parse(tipotnk[1]), 2, "Jugador 2", new Point(700, 1), false, 2, maquinolas[0]);
                                    Tanks[2] = new Tank(int.Parse(tipotnk[2]), 3, "Jugador 3", new Point(750, 599), false, 3, maquinolas[1]);
                                    Tanks[3] = new Tank(int.Parse(tipotnk[3]), 4, "Jugador 4", new Point(151, 630), false, 4, maquinolas[2]);
                                }
                                else
                                {
                                    Tanks[0] = new Tank(int.Parse(tipotnk[0]), 1, "Jugador 1", new Point(1, 155), false, 1, false);
                                    Tanks[1] = new Tank(int.Parse(tipotnk[1]), 2, "Jugador 2", new Point(795, 1), false, 2, maquinolas[0]);
                                    Tanks[2] = new Tank(int.Parse(tipotnk[2]), 3, "Jugador 3", new Point(850, 599), false, 3, maquinolas[1]);
                                    Tanks[3] = new Tank(int.Parse(tipotnk[3]), 4, "Jugador 4", new Point(151, 649), false, 4, maquinolas[2]);
                                }
                                break;
                            case "Destruye la base enemiga":
                                Tanks = new Tank[6];
                                Tanks[0] = new Tank(int.Parse(tipotnk[0]), 1, "Jugador 1", new Point(1, 350), false, 1, false);
                                Tanks[1] = new Tank(int.Parse(tipotnk[1]), 2, "Jugador 2", new Point(1, 350), false, 1, maquinolas[0]);
                                Tanks[2] = new Tank(1, 5, "Base equipo 1", new Point(1, 350), true, 1, false);
                                Tanks[3] = new Tank(int.Parse(tipotnk[2]), 3, "Jugador 3", new Point(840, 350), false, 2, maquinolas[1]);
                                Tanks[4] = new Tank(int.Parse(tipotnk[3]), 4, "Jugador 4", new Point(840, 350), false, 2, maquinolas[2]);
                                Tanks[5] = new Tank(1, 5, "Base equipo 2", new Point(840, 350), true, 2, false);
                                break;
                            case "2 vs 2":
                                Tanks = new Tank[4];
                                Tanks[0] = new Tank(int.Parse(tipotnk[0]), 1, "Jugador 1", new Point(1, 370), false, 1, false);
                                Tanks[1] = new Tank(int.Parse(tipotnk[1]), 2, "Jugador 2", new Point(1, 370), false, 1, maquinolas[0]);
                                Tanks[2] = new Tank(int.Parse(tipotnk[2]), 3, "Jugador 3", new Point(840, 370), false, 2, maquinolas[1]);
                                Tanks[3] = new Tank(int.Parse(tipotnk[3]), 4, "Jugador 4", new Point(840, 370), false, 2, maquinolas[2]);
                                break;
                            case "Hordas":
                                Tanks = new Tank[8];
                                Tanks[0] = new Tank(int.Parse(tipotnk[0]), 1, "Jugador 1", new Point(1, 370), false, 1, false);
                                Tanks[1] = new Tank(int.Parse(tipotnk[1]), 2, "Jugador 2", new Point(1, 370), false, 1, maquinolas[0]);
                                Tanks[2] = new Tank(int.Parse(tipotnk[2]), 3, "Jugador 3", new Point(1, 370), false, 1, maquinolas[1]);
                                Tanks[3] = new Tank(int.Parse(tipotnk[3]), 4, "Jugador 4", new Point(1, 370), false, 1, maquinolas[2]);
                                Tanks[4] = new Tank(ran.Next(2, 11), 5, "Maquinola 1", new Point(840, 370), false, 2, true);
                                Tanks[5] = new Tank(ran.Next(2, 11), 6, "Maquinola 2", new Point(840, 370), false, 2, true);
                                Tanks[6] = new Tank(ran.Next(2, 11), 7, "Maquinola 3", new Point(840, 370), false, 2, true);
                                Tanks[7] = new Tank(ran.Next(2, 11), 8, "Maquinola 4", new Point(840, 370), false, 2, true);
                                break;
                        }
                        break;
                }


            switch(nummap){
                case 1:
                    map = datos_de_mapas.map1;
                    break;
                case 2:
                    map = datos_de_mapas.map2;
                    break;
                case 3:
                    map = datos_de_mapas.map3;
                    break;
                case 4: 
                    map = datos_de_mapas.map4;
                    break;
                case 5:
                    map = datos_de_mapas.map5;
                    break;
                case 6:
                    map = datos_de_mapas.map6;
                    break;
                case 7:
                    map = datos_de_mapas.map7;
                    break;
                case 8:
                    map = datos_de_mapas.map8;
                    break;

            }

            //configuracion de mapa
            
            int i = 0, s = 0;
            cy = new Point[1];
            for (i = 0; i < 18; i++)
                for (int j = 0; j < 14; j++)
                {
                    if (map[i, j])
                    {
                        cy[s] = new Point(i * 50, j * 50);
                        Array.Resize<Point>(ref cy, cy.Length + 1);
                        s++;
                    }
                }
            Array.Resize<Point>(ref cy, cy.Length - 1);
            rec2 = new Rectangle[cy.Length + 5];
            for (i = 0; i < cy.Length; i++) rec2[i] = new Rectangle(cy[i], new Size(50, 50));
            //crea bordes del mapa///////////////////////////
            Point pa = new Point(-2, 0);
            Point pb = new Point(900, 0);
            Point pc = new Point(0, -2);
            Point pd = new Point(0, 691);
            //posiciones de borde////////////////////////////
            rec2[i + 1] = new Rectangle(pa, new Size(2, 731));
            rec2[i + 2] = new Rectangle(pb, new Size(2, 731));
            rec2[i + 3] = new Rectangle(pc, new Size(914, 2));
            rec2[i + 4] = new Rectangle(pd, new Size(914, 2));
            //graficos e hilos de control
            tmpimg = new Bitmap(this.Width, this.Height);
            this.DoubleBuffered = true;
            shilo = new Thread(new ThreadStart(this.hilo_supremo));
            shilo.Start();
        }
        private void mueve_tankes()
        {

            for (int t = 0; t < Tanks.Length; t++)
            {
                bool despup = true, despdo = true, desple = true, despri = true;
                for (int i = 0; i < rec2.Length; i++)
                {
                    if (new Rectangle(new Point(Tanks[t].loc.X, Tanks[t].loc.Y - Tanks[t].veloc), new Size(48, 48)).IntersectsWith(rec2[i])) { despup = false; }
                    if (new Rectangle(new Point(Tanks[t].loc.X, Tanks[t].loc.Y + Tanks[t].veloc), new Size(48, 48)).IntersectsWith(rec2[i])) { despdo = false; }
                    if (new Rectangle(new Point(Tanks[t].loc.X + Tanks[t].veloc, Tanks[t].loc.Y), new Size(48, 48)).IntersectsWith(rec2[i])) { despri = false; }
                    if (new Rectangle(new Point(Tanks[t].loc.X - Tanks[t].veloc, Tanks[t].loc.Y), new Size(48, 48)).IntersectsWith(rec2[i])) { desple = false; }
                }
                switch (Tanks[t].dirmovY)
                {
                    case "u":
                        if (despup)
                        {
                            if (Tanks[t].dirmovX == "r" || Tanks[t].dirmovX == "l") Tanks[t].loc = new Point(Tanks[t].loc.X, Convert.ToInt32(Tanks[t].loc.Y - Tanks[t].veloc / 1.414));
                            else
                                Tanks[t].loc = new Point(Tanks[t].loc.X, Tanks[t].loc.Y - Tanks[t].veloc);
                        }
                        break;
                    case "d":
                        if (despdo)
                        {
                            if (Tanks[t].dirmovX == "r" || Tanks[t].dirmovX == "l") Tanks[t].loc = new Point(Tanks[t].loc.X, Convert.ToInt32(Tanks[t].loc.Y + Tanks[t].veloc / 1.414));
                            else
                                Tanks[t].loc = new Point(Tanks[t].loc.X, Tanks[t].loc.Y + Tanks[t].veloc);
                        }
                        break;
                    case "n": break;
                }
                switch (Tanks[t].dirmovX)
                {
                    case "r":
                        if (despri)
                        {
                            if (Tanks[t].dirmovX == "u" || Tanks[t].dirmovX == "d") Tanks[t].loc = new Point(Convert.ToInt32(Tanks[t].loc.X + Tanks[t].veloc / 1.414), Tanks[t].loc.Y);
                            else Tanks[t].loc = new Point(Tanks[t].loc.X + Tanks[t].veloc, Tanks[t].loc.Y);
                        }
                        break;
                    case "l":
                        if (desple)
                        {
                            if (Tanks[t].dirmovX == "u" || Tanks[t].dirmovX == "d") Tanks[t].loc = new Point(Convert.ToInt32(Tanks[t].loc.X - Tanks[t].veloc / 1.414), Tanks[t].loc.Y);
                            else Tanks[t].loc = new Point(Tanks[t].loc.X - Tanks[t].veloc, Tanks[t].loc.Y);
                        }
                        break;
                    case "n": break;
                }
            }
        }
        void keydown_booleador(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
            for (int t = 0; t < Tanks.Length; t++)
            {
                if (e.KeyCode == Tanks[t].kcon[4])
                {
                    Tanks[t].kpress[4] = true;
                    Tanks[t].mina();
                }
                if (e.KeyCode == Tanks[t].kcon[5])
                {
                    Tanks[t].kpress[5] = true;
                    if (Tanks[t].kpress[4]) { Tanks[t].especial(); }
                    else { if (Tanks[t].retardo == 0) Tanks[t].dispara(); }
                }
                if (e.KeyCode == Tanks[t].kcon[0])
                {
                    Tanks[t].dirdisp = "u";
                    Tanks[t].kpress[0] = true;
                    if (Tanks[t].kpress[2]) { Tanks[t].dirmovY = "n"; } else { Tanks[t].dirmovY = "u"; }
                }
                else if (e.KeyCode == Tanks[t].kcon[2])
                {
                    Tanks[t].dirdisp = "d";
                    Tanks[t].kpress[2] = true;
                    if (Tanks[t].kpress[0]) { Tanks[t].dirmovY = "n"; } else { Tanks[t].dirmovY = "d"; }
                }
                else if (e.KeyCode == Tanks[t].kcon[1])
                {
                    Tanks[t].dirdisp = "l";
                    Tanks[t].kpress[1] = true;
                    if (Tanks[t].kpress[3]) { Tanks[t].dirmovX = "n"; } else { Tanks[t].dirmovX = "l"; }
                }
                else if (e.KeyCode == Tanks[t].kcon[3])
                {
                    Tanks[t].dirdisp = "r";
                    Tanks[t].kpress[3] = true;
                    if (Tanks[t].kpress[1]) { Tanks[t].dirmovX = "n"; } else { Tanks[t].dirmovX = "r"; }
                }
            }

        }
        void keyup_booleador(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            for (int t = 0; t < this.Tanks.Length; t++)
            {
                if (e.KeyCode == Tanks[t].kcon[0])
                {
                    Tanks[t].kpress[0] = false;
                    if (Tanks[t].kpress[2]) { Tanks[t].dirmovY = "d"; } else { Tanks[t].dirmovY = "n"; }
                }
                else if (e.KeyCode == Tanks[t].kcon[2])
                {
                    Tanks[t].kpress[2] = false;
                    if (Tanks[t].kpress[0]) { Tanks[t].dirmovY = "u"; } else { Tanks[t].dirmovY = "n"; }
                }
                else if (e.KeyCode == Tanks[t].kcon[1])
                {
                    Tanks[t].kpress[1] = false;
                    if (Tanks[t].kpress[3]) { Tanks[t].dirmovX = "r"; } else { Tanks[t].dirmovX = "n"; }
                }
                else if (e.KeyCode == Tanks[t].kcon[3])
                {
                    Tanks[t].kpress[3] = false;
                    if (Tanks[t].kpress[1]) { Tanks[t].dirmovX = "l"; } else { Tanks[t].dirmovX = "n"; }
                }
                else if (e.KeyCode == Tanks[t].kcon[4])
                {
                    Tanks[t].kpress[4] = false;
                }
                else if (e.KeyCode == Tanks[t].kcon[5])
                {
                    Tanks[t].kpress[5] = false;
                }
            }

        }
        void colisionador()
        {
            mueve_tankes();
            for (int i = 0; i < Tanks.Length; i++)
            {
                if (Tanks[i].retardo > 0) { Tanks[i].retardo--; }
                for (int j = 0; j < rec2.Length; j++)
                {
                    for (int l = 0; l < Tanks[i].proy.Length; l++)
                    {// mueve proyectiles  proy,proydirdisp
                        if (l < Tanks[i].proydirdisp.Length)
                        {
                            if (Tanks[i].proydirdisp[l] == "u") Tanks[i].proy[l].Y -= Tanks[i].veloc_proyect;
                            else if (Tanks[i].proydirdisp[l] == "d") Tanks[i].proy[l].Y += Tanks[i].veloc_proyect;
                            else if (Tanks[i].proydirdisp[l] == "l") Tanks[i].proy[l].X -= Tanks[i].veloc_proyect;
                            else if (Tanks[i].proydirdisp[l] == "r") Tanks[i].proy[l].X += Tanks[i].veloc_proyect;

                        }
                    }
                    if (Tanks[i].ataque_en_proceso)
                    {//mueve proyesp
                        if (Tanks[i].dirdispesp == "u") Tanks[i].locproyesp.Y -= (Tanks[i].veloc_proyect);
                        else if (Tanks[i].dirdispesp == "d") Tanks[i].locproyesp.Y += (Tanks[i].veloc_proyect);
                        else if (Tanks[i].dirdispesp == "l") Tanks[i].locproyesp.X -= (Tanks[i].veloc_proyect);
                        else if (Tanks[i].dirdispesp == "r") Tanks[i].locproyesp.X += (Tanks[i].veloc_proyect);
                    }
                    for (int k = 0; k < Tanks.Length; k++)
                    {
                        if (Tanks[i].proydirdisp.Length > 0)
                        {
                            for (int l = 0; l < Tanks[i].proy.Length; l++)
                            {// verifica colisiones de proyectiles
                                // si el proyectil colisiona con una pared
                                if (new Rectangle(Tanks[i].proy[l], new Size(15, 15)).IntersectsWith(rec2[j]) || !new Rectangle(Tanks[i].proy[l], new Size(48, 48)).IntersectsWith(new Rectangle(new Point(0, 0), this.Size)))
                                {
                                    Tanks[i].elimina_proy(l);
                                }
                                //si el proyectil intersecta con un tanque enemigo y este esta vivo
                                else if (new Rectangle(Tanks[i].proy[l], new Size(20, 20)).IntersectsWith(new Rectangle(Tanks[k].loc, new Size(48, 48))) && Tanks[k].vive && (Tanks[i].equipo != Tanks[k].equipo))
                                {
                                    if (Tanks[k].daña(Tanks[i].atak))
                                    {// si el ataque mata al atacado
                                        Tanks[k].puede_esp = true;
                                        Tanks[k].loc = Tanks[k].loc_inicial;
                                        if (Tanks[k].es_base) Tanks[i].basekills++;
                                        else Tanks[i].kills++;
                                    }
                                    Tanks[i].elimina_proy(l);
                                }
                            }
                        }
                        //si un tanque enemigo pisa una mina
                        if (Tanks[i].minasloc != null)
                            for (int m = 0; m < Tanks[i].minasloc.Length; m++)
                                if (new Rectangle(Tanks[i].minasloc[m], new Size(25, 25)).IntersectsWith(new Rectangle(Tanks[k].loc, new Size(48, 48))) && (Tanks[i].equipo != Tanks[k].equipo) && Tanks[k].vive)
                                {
                                    Tanks[i].elimina_min(m);
                                    if (Tanks[k].daña(Convert.ToInt32(Math.Ceiling(Tanks[k].vidamax / 1.5))))
                                    {// si el ataque mata al atacado
                                        Tanks[k].puede_esp = true;
                                        Tanks[k].loc = Tanks[k].loc_inicial;
                                        if (Tanks[k].es_base) Tanks[i].basekills++;
                                        else Tanks[i].kills++;
                                    }
                                }
                        if (Tanks[i].ataque_en_proceso && (Tanks[i].equipo != Tanks[k].equipo) && Tanks[k].vive && new Rectangle(Tanks[i].locproyesp, new Size(25, 25)).IntersectsWith(new Rectangle(Tanks[k].loc, new Size(48, 48))))
                        {
                            Tanks[i].ataque_en_proceso = false;
                            Tanks[i].puede_esp = false;
                            if (Tanks[k].daña(Tanks[k].vida))
                            {// si el ataque mata al atacado
                                Tanks[k].puede_esp = true;
                                Tanks[k].loc = Tanks[k].loc_inicial;
                                if (Tanks[k].es_base) Tanks[i].basekills++;
                                else Tanks[i].kills++;
                            }
                        }
                        else if (Tanks[i].ataque_en_proceso && new Rectangle(Tanks[i].locproyesp, new Size(25, 25)).IntersectsWith(rec2[j]) && Tanks[i].puede_esp)
                        {
                            Tanks[i].ataque_en_proceso = false;
                            Tanks[i].puede_esp = false;
                        }
                    }
                }
            }
        }
        void picasso()
        {
            try
            {
                Graphics g = Graphics.FromImage(tmpimg);
                for (int j = 0; j < rec2.Length - 4; j++)
                {
                    g.FillRectangle(new SolidBrush(Color.Black), rec2[j]);
                }
                for (int i = 0; i < Tanks.Length; i++)
                {
                    if (Tanks[i].minas < 3)
                        for (int m = 0; m < Tanks[i].minasloc.Length; m++) { g.DrawImage(Tanks[i].mimg, Tanks[i].minasloc[m]); }
                    if (Tanks[i].vive)
                    {
                        Image tmp2 = (Image)Tanks[i].img.Clone();
                        if (Tanks[i].dirdisp == "d") tmp2.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        else if (Tanks[i].dirdisp == "l") tmp2.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        else if (Tanks[i].dirdisp == "r") tmp2.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        g.DrawImage(tmp2, Tanks[i].loc);
                        g.FillRectangle(new SolidBrush(Tanks[i].col_morada), new Rectangle(new Point(Tanks[i].loc.X, Tanks[i].loc.Y - 7), new Size(Tanks[i].vida * Tanks[i].img.Width / Tanks[i].vidamax, 7)));
                        TextRenderer.DrawText(g, Tanks[i].nombre, new System.Drawing.Font("Constantia", 11f, FontStyle.Regular, GraphicsUnit.Pixel), new Point(Tanks[i].loc.X, Tanks[i].loc.Y + Tanks[i].img.Height), Color.Black);

                        if (Tanks[i].proy.Length > 0)
                            for (int l = 0; l < Tanks[i].proy.Length; l++)
                            {
                                Image tmp3 = (Image)Tanks[i].pimg.Clone();
                                if (Tanks[i].proydirdisp[l] == "d") tmp3.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                else if (Tanks[i].proydirdisp[l] == "l") tmp3.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                else if (Tanks[i].proydirdisp[l] == "r") tmp3.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                g.DrawImage(tmp3, Tanks[i].proy[l]);
                            }
                        if (Tanks[i].ataque_en_proceso)
                        {
                            Image tmp = (Image)Tanks[i].peimg.Clone();
                            if (Tanks[i].dirdisp == "d") tmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            else if (Tanks[i].dirdisp == "l") tmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            else if (Tanks[i].dirdisp == "r") tmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            g.DrawImage(tmp, Tanks[i].locproyesp);
                        }
                        //dibuja ruta de IA
                        //for (int x = 0; x < 18; x++)
                        //    for (int y = 0; y < 14; y++)
                        //        if (Tanks[i].secuencia != null)
                        //            if (Tanks[i].secuencia[x, y]) { g.FillRectangle(new SolidBrush(Color.Orange), new Rectangle(new Point(x * 50, y * 50), new Size(20, 20))); }
                    }
                }
            }
            catch { 
            
            
            }
        }
        void hilo_supremo()
        {
            int contador = 0;
            while (true)
            {
                GC.Collect();  
                contador++;
                colisionador();
                picasso();
                try
                {
                    this.Invoke((Action)delegate { this.BackgroundImage = tmpimg; tmpimg = new Bitmap(this.Width, this.Height); });
                }
                catch
                {
                    
                    shilo.Abort();
                }
                controlador(contador);
                if (contador == 800)
                {
                    contador = 0;
                    fin();
                }
            }
            
        }
        void fin()
        {
            //modo horda poner vidas esupidamente altas a las ias
            //en modo horda, solo hay dos equipos
            if (numeroj == 1)
            {
                if (modojuego == "Duelo")
                {
                    for (int chk = 0; chk < Tanks.Length; chk++)
                    {

                        if (!Tanks[chk].vive)
                        {
                            if (Tanks[chk].es_ia)
                            {
                                MessageBox.Show("Le ganaste a la maquinola, maquinola :v");
                                this.Invoke((Action)delegate { this.Close(); });
                            }
                            else
                            {
                                MessageBox.Show("Manco perdiste contra la maquinola :v");
                                this.Invoke((Action)delegate { this.Close(); });
                            }
                        }
                    }
                }
                else if (modojuego == "Hordas")
                {
                    for (int chk = 0; chk < Tanks.Length; chk++)
                    {
                        if (!Tanks[chk].vive)
                        {
                            if (!Tanks[chk].es_ia)
                            {
                                MessageBox.Show("Mataste a " + Tanks[chk].kills.ToString());
                                this.Invoke((Action)delegate { this.Close(); });
                            }
                            else
                            {
                                //esto no deberia pasar
                            }
                        }
                    }
                }
            }
            else if (numeroj == 2)
            {
                if (modojuego == "Duelo")
                {
                    for (int chk = 0; chk < Tanks.Length; chk++)
                    {
                        if (!Tanks[chk].vive)
                        {
                            for (int xd = 0; xd < Tanks.Length; xd++)
                            {
                                if (xd != chk)
                                {
                                    MessageBox.Show("Gana " + Tanks[xd].nombre);
                                    this.Invoke((Action)delegate { this.Close(); });
                                }
                            }
                        }
                    }
                }
                else if (modojuego == "Destruye la base enemiga")
                {
                    for (int chk = 0; chk < Tanks.Length; chk++)
                    {
                        if (!Tanks[chk].vive && Tanks[chk].es_base)
                        {
                            for (int xd = 0; xd < Tanks.Length; xd++)
                            {
                                if (Tanks[xd].equipo != Tanks[chk].equipo)
                                {
                                    MessageBox.Show("Gana equipo " + Tanks[xd].equipo);
                                    this.Invoke((Action)delegate { this.Close(); });
                                }
                            }
                        }
                    }
                }
                else if (modojuego == "Hordas")
                {
                    int caidos = 0;
                    int no_ia = 0;
                    for (int chk = 0; chk < Tanks.Length; chk++)
                    {
                        if (!Tanks[chk].vive) caidos++;
                        if (!Tanks[chk].es_ia) no_ia++;
                    }
                    if (caidos == no_ia)
                    {
                        string puntajes = "";
                        for (int chk = 0; chk < Tanks.Length; chk++)
                            puntajes += Tanks[chk].nombre + " mato a " + Tanks[chk].kills + Environment.NewLine;
                        MessageBox.Show(puntajes, "Han sido derrotados por las maquinolas");
                        this.Invoke((Action)delegate { this.Close(); });
                    }
                }
            }
            else if (numeroj == 4)
            {
                if (modojuego == "Free for all")
                {
                    int caidos = 0;
                    for (int chk = 0; chk < Tanks.Length; chk++)
                    {
                        if (!Tanks[chk].vive)
                        {
                            caidos++;
                            if (caidos == 3)
                            {
                                for (int xd = 0; xd < Tanks.Length; xd++)
                                {
                                    if (Tanks[xd].vive)
                                    {
                                        MessageBox.Show("Gana " + Tanks[xd].nombre);
                                        this.Invoke((Action)delegate { this.Close(); });
                                    }
                                }
                            }
                        }
                    }
                }
                else if (modojuego == "Destruye la base enemiga")
                {
                    for (int chk = 0; chk < Tanks.Length; chk++)
                    {
                        if (!Tanks[chk].vive && Tanks[chk].es_base)
                        {
                            for (int xd = 0; xd < Tanks.Length; xd++)
                            {
                                if (Tanks[xd].equipo != Tanks[chk].equipo)
                                {
                                    MessageBox.Show("Gana equipo " + Tanks[xd].equipo);
                                    this.Invoke((Action)delegate { this.Close(); });
                                }
                            }
                        }
                    }
                }
                else if (modojuego == "Hordas")
                {
                    int caidos = 0;
                    int no_ia = 0;
                    for (int chk = 0; chk < Tanks.Length; chk++)
                    {
                        if (!Tanks[chk].vive) caidos++;
                        if (!Tanks[chk].es_ia) no_ia++;
                    }
                    if (caidos == no_ia)
                    {
                        string puntajes = "";
                        for (int chk = 0; chk < Tanks.Length; chk++)
                            puntajes += Tanks[chk].nombre + " mato a " + Tanks[chk].kills + Environment.NewLine;
                        MessageBox.Show(puntajes, "Han sido derrotados por las maquinolas");
                        this.Invoke((Action)delegate { this.Close(); });
                    }
                }
                else if (modojuego == "2 vs 2")
                {
                    int caidos_eq1 = 0, caidos_eq2 = 0;

                    for (int chk = 0; chk < Tanks.Length; chk++)
                    {
                        if (!Tanks[chk].vive && Tanks[chk].equipo == 1)
                        {
                            caidos_eq1++;
                        }
                        if (!Tanks[chk].vive && Tanks[chk].equipo == 2)
                        {
                            caidos_eq2++;
                        }
                    }
                    if (caidos_eq1 == 2)
                    {
                        MessageBox.Show("Gana equipo 2");
                        this.Invoke((Action)delegate { this.Close(); });
                    }
                    else if (caidos_eq2 == 2)
                    {
                        MessageBox.Show("Gana equipo 1");
                        this.Invoke((Action)delegate { this.Close(); });
                    }


                }
            }
        }
        Point maplocobt(int X)
        {
            int x, y;
            for (x = 0; x <= this.Width + 20; x += 50) { if (x + 50 > this.Tanks[X].loc.X) break; }
            for (y = 0; y <= this.Height + 20; y += 50) { if (y + 50 > this.Tanks[X].loc.Y) break; }
            if (new Rectangle(new Point(y, x), new Size(50, 50)).Contains(new Rectangle(new Point(Tanks[X].loc.Y, Tanks[X].loc.Y), new Size(48, 48))))
            {
                x = x / 50; y = y / 50;
                return new Point(x, y);
            }
            x = x / 50; y = y / 50;
            return new Point(x, y);
        }
        void controlador(int busca_ruta)
        {

            for (int t = 0; t < Tanks.Length; t++)
            {
                if (Tanks[t].es_ia)
                {
                    if (modojuego == "Hordas") { if (Tanks[t].vidas < 50) Tanks[t].vidas = 50; }
                    if (Tanks[t].retardo == 0) Tanks[t].dispara();
                    Point orig = maplocobt(t);
                    Point obj = new Point(0, 0);
                    int mas_cercano = 0;
                    double da = 100;
                    for (int nuv = 0; nuv < (Tanks.Length); nuv++)
                    {
                        if (Tanks[nuv].equipo != Tanks[t].equipo && Tanks[nuv].vive)
                        {
                            double d = Math.Sqrt((orig.X - maplocobt(nuv).X)*(orig.X - maplocobt(nuv).X) + (orig.Y - maplocobt(nuv).Y)*(orig.Y - maplocobt(nuv).Y));
                            if (da > d)
                            {
                                da = d;
                                mas_cercano = nuv;
                            }
                        }
                    }
                    obj = maplocobt(mas_cercano);
                    Tanks[t].secuencia = new bool[18, 14];
                    for (int x = 0; x < 18; x++)
                        for (int y = 0; y < 14; y++)
                            Tanks[t].secuencia[x, y] = false;

                    if (busca_ruta % (Convert.ToInt32(100 / Tanks[t].veloc)) == 0)
                    {
                        Tanks[t].mina();
                        dora(orig, obj, ref Tanks[t].secuencia);
                    }
                    if (obj.Y < orig.Y)
                    {
                        if (obj.X < orig.X)
                        {
                            if (!(orig.Y == 0)) { if (!map[orig.X, orig.Y - 1])if (Tanks[t].secuencia[orig.X, orig.Y - 1]) { Tanks[t].dirmovY = "u"; Tanks[t].dirdisp = "u"; } }
                            if (orig.X != 0) { if (!map[orig.X - 1, orig.Y]) if (Tanks[t].secuencia[orig.X - 1, orig.Y]) { Tanks[t].dirmovX = "l"; Tanks[t].dirdisp = "l"; } }
                            if (orig.Y != 13) { if (!map[orig.X, orig.Y + 1]) if (Tanks[t].secuencia[orig.X, orig.Y + 1]) { Tanks[t].dirmovY = "d"; Tanks[t].dirdisp = "d"; } }
                            if ((orig.X != 17)) { if (!map[orig.X + 1, orig.Y])if (Tanks[t].secuencia[orig.X + 1, orig.Y]) { Tanks[t].dirmovX = "r"; Tanks[t].dirdisp = "r"; } }
                        }
                        else if (obj.X > orig.X)
                        {
                            if (!(orig.Y == 0)) { if (!map[orig.X, orig.Y - 1])if (Tanks[t].secuencia[orig.X, orig.Y - 1]) { Tanks[t].dirmovY = "u"; Tanks[t].dirdisp = "u"; } }
                            if ((orig.X != 17)) { if (!map[orig.X + 1, orig.Y])if (Tanks[t].secuencia[orig.X + 1, orig.Y]) { Tanks[t].dirmovX = "r"; Tanks[t].dirdisp = "r"; } }
                            if (orig.Y != 13) { if (!map[orig.X, orig.Y + 1]) if (Tanks[t].secuencia[orig.X, orig.Y + 1]) { Tanks[t].dirmovY = "d"; Tanks[t].dirdisp = "d"; } }
                            if (orig.X != 0) { if (!map[orig.X - 1, orig.Y]) if (Tanks[t].secuencia[orig.X - 1, orig.Y]) { Tanks[t].dirmovX = "l"; Tanks[t].dirdisp = "l"; } }
                        }
                        else
                        {
                            if (!(orig.Y == 0)) { if (!map[orig.X, orig.Y - 1])if (Tanks[t].secuencia[orig.X, orig.Y - 1]) { Tanks[t].dirmovY = "u"; Tanks[t].dirdisp = "u"; } }
                            if (orig.Y != 13) { if (!map[orig.X, orig.Y + 1]) if (Tanks[t].secuencia[orig.X, orig.Y + 1]) { Tanks[t].dirmovY = "d"; Tanks[t].dirdisp = "d"; } }
                            if ((orig.X != 17)) { if (!map[orig.X + 1, orig.Y])if (Tanks[t].secuencia[orig.X + 1, orig.Y]) { Tanks[t].dirmovX = "r"; Tanks[t].dirdisp = "r"; } }
                            if (orig.X != 0) { if (!map[orig.X - 1, orig.Y]) if (Tanks[t].secuencia[orig.X - 1, orig.Y]) { Tanks[t].dirmovX = "l"; Tanks[t].dirdisp = "l"; } }

                        }
                    }
                    else
                        if (obj.Y > orig.Y)
                        {
                            if (obj.X < orig.X)
                            {
                                if (orig.Y != 13) { if (!map[orig.X, orig.Y + 1]) if (Tanks[t].secuencia[orig.X, orig.Y + 1]) { Tanks[t].dirmovY = "d"; Tanks[t].dirdisp = "d"; } }
                                if (orig.X != 0) { if (!map[orig.X - 1, orig.Y]) if (Tanks[t].secuencia[orig.X - 1, orig.Y]) { Tanks[t].dirmovX = "l"; Tanks[t].dirdisp = "l"; } }
                                if ((orig.X != 17)) { if (!map[orig.X + 1, orig.Y])if (Tanks[t].secuencia[orig.X + 1, orig.Y]) { Tanks[t].dirmovX = "r"; Tanks[t].dirdisp = "r"; } }
                                if (!(orig.Y == 0)) { if (!map[orig.X, orig.Y - 1])if (Tanks[t].secuencia[orig.X, orig.Y - 1]) { Tanks[t].dirmovY = "u"; Tanks[t].dirdisp = "u"; } }
                            }
                            else if (obj.X > orig.X)
                            {
                                if (orig.Y != 13) { if (!map[orig.X, orig.Y + 1]) if (Tanks[t].secuencia[orig.X, orig.Y + 1]) { Tanks[t].dirmovY = "d"; Tanks[t].dirdisp = "d"; } }
                                if ((orig.X != 17)) { if (!map[orig.X + 1, orig.Y])if (Tanks[t].secuencia[orig.X + 1, orig.Y]) { Tanks[t].dirmovX = "r"; Tanks[t].dirdisp = "r"; } }
                                if (orig.X != 0) { if (!map[orig.X - 1, orig.Y]) if (Tanks[t].secuencia[orig.X - 1, orig.Y]) { Tanks[t].dirmovX = "l"; Tanks[t].dirdisp = "l"; } }
                                if (!(orig.Y == 0)) { if (!map[orig.X, orig.Y - 1])if (Tanks[t].secuencia[orig.X, orig.Y - 1]) { Tanks[t].dirmovY = "u"; Tanks[t].dirdisp = "u"; } }
                            }
                            else
                            {
                                if (orig.Y != 13) { if (!map[orig.X, orig.Y + 1]) if (Tanks[t].secuencia[orig.X, orig.Y + 1]) { Tanks[t].dirmovY = "d"; Tanks[t].dirdisp = "d"; } }
                                if (!(orig.Y == 0)) { if (!map[orig.X, orig.Y - 1])if (Tanks[t].secuencia[orig.X, orig.Y - 1]) { Tanks[t].dirmovY = "u"; Tanks[t].dirdisp = "u"; } }
                                if ((orig.X != 17)) { if (!map[orig.X + 1, orig.Y])if (Tanks[t].secuencia[orig.X + 1, orig.Y]) { Tanks[t].dirmovX = "r"; Tanks[t].dirdisp = "r"; } }
                                if (orig.X != 0) { if (!map[orig.X - 1, orig.Y]) if (Tanks[t].secuencia[orig.X - 1, orig.Y]) { Tanks[t].dirmovX = "l"; Tanks[t].dirdisp = "l"; } }
                            }
                        }
                        else
                        {
                            if (obj.X < orig.X)
                            {
                                if (orig.X != 0) { if (!map[orig.X - 1, orig.Y]) if (Tanks[t].secuencia[orig.X - 1, orig.Y]) { Tanks[t].dirmovX = "l"; Tanks[t].dirdisp = "l"; } }
                                if ((orig.X != 17)) { if (!map[orig.X + 1, orig.Y])if (Tanks[t].secuencia[orig.X + 1, orig.Y]) { Tanks[t].dirmovX = "r"; Tanks[t].dirdisp = "r"; } }
                                if (orig.Y != 13) { if (!map[orig.X, orig.Y + 1]) if (Tanks[t].secuencia[orig.X, orig.Y + 1]) { Tanks[t].dirmovY = "d"; Tanks[t].dirdisp = "d"; } }
                                if (!(orig.Y == 0)) { if (!map[orig.X, orig.Y - 1])if (Tanks[t].secuencia[orig.X, orig.Y - 1]) { Tanks[t].dirmovY = "u"; Tanks[t].dirdisp = "u"; } }
                            }
                            else if (obj.X > orig.X)
                            {
                                if ((orig.X != 17)) { if (!map[orig.X + 1, orig.Y])if (Tanks[t].secuencia[orig.X + 1, orig.Y]) { Tanks[t].dirmovX = "r"; Tanks[t].dirdisp = "r"; } }
                                if (orig.X != 0) { if (!map[orig.X - 1, orig.Y]) if (Tanks[t].secuencia[orig.X - 1, orig.Y]) { Tanks[t].dirmovX = "l"; Tanks[t].dirdisp = "l"; } }
                                if (orig.Y != 13) { if (!map[orig.X, orig.Y + 1]) if (Tanks[t].secuencia[orig.X, orig.Y + 1]) { Tanks[t].dirmovY = "d"; Tanks[t].dirdisp = "d"; } }
                                if (!(orig.Y == 0)) { if (!map[orig.X, orig.Y - 1])if (Tanks[t].secuencia[orig.X, orig.Y - 1]) { Tanks[t].dirmovY = "u"; Tanks[t].dirdisp = "u"; } }
                            }
                            else
                            {
                                Tanks[t].mina();
                                Tanks[t].especial();
                            }
                        }
                }
            }

        }
        bool dora(Point coordenda, Point obj, ref bool[,] secuenciador)
        {
            //está dentro de la matriz?
            if (coordenda.X > 17 || coordenda.X < 0 || coordenda.Y > 13 || coordenda.Y < 0) return false;
            //es el objetivo?
            if (coordenda.Y == obj.Y && coordenda.X == obj.X) return true;
            //es cerrada?
            if (this.map[coordenda.X, coordenda.Y] || secuenciador[coordenda.X, coordenda.Y]) return false;
            //mark x,y as part of solution path
            secuenciador[coordenda.X, coordenda.Y] = true;
            if (obj.Y < coordenda.Y)
            {
                if (obj.X < coordenda.X)
                {
                    if (dora(new Point(coordenda.X, coordenda.Y - 1), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X - 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X + 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X, coordenda.Y + 1), obj, ref secuenciador)) return true;
                }
                else if (obj.X > coordenda.X)
                {
                    if (dora(new Point(coordenda.X, coordenda.Y - 1), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X + 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X - 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X, coordenda.Y + 1), obj, ref secuenciador)) return true;
                }
                else
                {
                    if (dora(new Point(coordenda.X, coordenda.Y - 1), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X, coordenda.Y + 1), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X + 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X - 1, coordenda.Y), obj, ref secuenciador)) return true;

                }
            }
            else if (obj.Y > coordenda.Y)
            {
                if (obj.X < coordenda.X)
                {
                    if (dora(new Point(coordenda.X, coordenda.Y + 1), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X - 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X + 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X, coordenda.Y - 1), obj, ref secuenciador)) return true;
                }
                else if (obj.X > coordenda.X)
                {
                    if (dora(new Point(coordenda.X, coordenda.Y + 1), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X + 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X - 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X, coordenda.Y - 1), obj, ref secuenciador)) return true;
                }
                else
                {
                    if (dora(new Point(coordenda.X, coordenda.Y + 1), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X, coordenda.Y - 1), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X + 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X - 1, coordenda.Y), obj, ref secuenciador)) return true;

                }
            }
            else
            {
                if (obj.X < coordenda.X)
                {
                    if (dora(new Point(coordenda.X - 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X + 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X, coordenda.Y + 1), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X, coordenda.Y - 1), obj, ref secuenciador)) return true;
                }
                else if (obj.X > coordenda.X)
                {
                    if (dora(new Point(coordenda.X + 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X - 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X, coordenda.Y + 1), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X, coordenda.Y - 1), obj, ref secuenciador)) return true;
                }
                else
                {
                    if (dora(new Point(coordenda.X + 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X - 1, coordenda.Y), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X, coordenda.Y + 1), obj, ref secuenciador)) return true;
                    if (dora(new Point(coordenda.X, coordenda.Y - 1), obj, ref secuenciador)) return true;

                }
            }

            //unmark x,y as part of solution path
            secuenciador[coordenda.X, coordenda.Y] = false;
            return false;
        }

    }

}
