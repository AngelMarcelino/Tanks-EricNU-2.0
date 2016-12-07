using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Tank
    {
    public Tank(int tipo,int jugador,string nom,Point locin,bool es_base_bool,int equip,bool ia){
        
        //auxiliares de ia
        es_ia = ia;
        target = false;
        loc = loc_inicial = locin;
        //parametros generales
        retardo = 0;
        proy = new Point[1];
        proy[0] = new Point(-30, -30);
        proydirdisp = new String[1];
        equipo=equip;
        nombre = nom;
        vidas = 3;
        minas = 3;
        vive = true;
        dirdisp = "u";
        dirmovX="n";///lnr
        dirmovY = "n";/////und
        es_base = es_base_bool;
        ataque_en_proceso = false;
        puede_esp = true;
        kcon = new Keys[6];
        kpress = new bool[6];
        for (int tmp = 0; tmp < kpress.Length; tmp++){kpress[tmp] = false;}
        kills=basekills= 0;
        veloc_proyect = 1;
        //parametros particulares
        int resistmp=0,daño=0,veltmp=0;
        tip = tipo;
        switch (tipo) {
            case 1://base
                img = System.Drawing.Image.FromFile("img/tba.gif");
                mimg = System.Drawing.Image.FromFile("img/tba.gif");
                peimg = System.Drawing.Image.FromFile("img/tba.gif");
                pimg = System.Drawing.Image.FromFile("img/tba.gif");
                veltmp=0;
                daño=20;
                resistmp=20;
                break;
            case 2://halcon
                img = System.Drawing.Image.FromFile("img/t1n.gif");
                mimg = System.Drawing.Image.FromFile("img/t1bomb.gif");
                peimg = System.Drawing.Image.FromFile("img/t1red.gif");
                pimg = System.Drawing.Image.FromFile("img/t1green.gif");
                veltmp=4;
                daño=1;
                resistmp=1;
                break;
            case 3://lechuga
                img = System.Drawing.Image.FromFile("img/t3v.gif");
                mimg = System.Drawing.Image.FromFile("img/t3col.gif");
                peimg = System.Drawing.Image.FromFile("img/t3repollo.gif");
                pimg = System.Drawing.Image.FromFile("img/t3lechu.gif");
                veltmp=2;
                daño=3;
                resistmp=3;
                break;
            case 4://mariposa
                img = System.Drawing.Image.FromFile("img/t2r.gif");
                mimg = System.Drawing.Image.FromFile("img/t2mar3.gif");
                peimg = System.Drawing.Image.FromFile("img/t2mar2.gif");
                pimg = System.Drawing.Image.FromFile("img/t2mar1.gif");
                veltmp=3;
                daño=2;
                resistmp=2;
                break;
            case 5://tortuga
                img = System.Drawing.Image.FromFile("img/t4a.gif");
                mimg = System.Drawing.Image.FromFile("img/t4min.gif");
                peimg = System.Drawing.Image.FromFile("img/t4mis.gif");
                pimg = System.Drawing.Image.FromFile("img/t4bala.gif");
                veltmp=1;
                daño=4;
                resistmp=4;
                break;
            case 6://batimovil
                img = System.Drawing.Image.FromFile("img/bat.gif");
                mimg = System.Drawing.Image.FromFile("img/batmin.gif");
                peimg = System.Drawing.Image.FromFile("img/bata.gif");
                pimg = System.Drawing.Image.FromFile("img/batibal.gif");
                veltmp=2;
                daño=2;
                resistmp=2;
                break;
            case 7://cangremovil
                img = System.Drawing.Image.FromFile("img/bob.gif");
                mimg = System.Drawing.Image.FromFile("img/bobbald.gif");
                peimg = System.Drawing.Image.FromFile("img/bobburg2.gif");
                pimg = System.Drawing.Image.FromFile("img/bobburg.gif");
                veltmp=3;
                daño=3;
                resistmp=2;
                break;
            case 8://delorean
                img = System.Drawing.Image.FromFile("img/delorean.gif");
                mimg = System.Drawing.Image.FromFile("img/delorfire.gif");
                peimg = System.Drawing.Image.FromFile("img/inv2.gif");
                pimg = System.Drawing.Image.FromFile("img/delrel.gif");
                veltmp=3;
                daño=2;
                resistmp=3;
                break;
            case 9://diep
                img = System.Drawing.Image.FromFile("img/diep.gif");
                mimg = System.Drawing.Image.FromFile("img/diep3.gif");
                peimg = System.Drawing.Image.FromFile("img/diep2.gif");
                pimg = System.Drawing.Image.FromFile("img/diep1.gif");
                veltmp=2;
                daño=3;
                resistmp=2;
                break;
            case 10://mcqueen
                img = System.Drawing.Image.FromFile("img/mc.gif");
                mimg = System.Drawing.Image.FromFile("img/mccop.gif");
                peimg = System.Drawing.Image.FromFile("img/mcray.gif");
                pimg = System.Drawing.Image.FromFile("img/mcllan.gif");
                veltmp=4;
                daño=3;
                resistmp=1;
                break;
            case 11://botemovil invisible
                img = System.Drawing.Image.FromFile("img/inv.gif");
                mimg = System.Drawing.Image.FromFile("img/inv2.gif");
                peimg = System.Drawing.Image.FromFile("img/inv3.gif");
                pimg = System.Drawing.Image.FromFile("img/inv1.gif");
                veltmp=3;
                daño=1;
                resistmp=1;
                break;
        }
        vidamax=vida=20+3*resistmp;
        atak=2*daño;
        atakmin=Convert.ToInt32( Math.Round(1.5*daño));
        atakesp=daño*4;
        veloc=veltmp;
        
        switch (equipo)
        {case 1:
                col_morada = Color.Blue;
                break;
            case 2:
                col_morada=Color.Red;
                break;
                
            case 3: col_morada=Color.Purple;
                break;
            case 4: col_morada = Color.Gold;
                break;
        }
        switch (jugador)
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
    }
    public bool es_base;
    public bool es_ia;
    public bool target;
    public bool[,] secuencia;
    public string nombre;
    public Image img;
    public int equipo;
    public Keys[] kcon;//6 teclas, en orden   ↑  ←  ↓  →  Mina  Disparo
    public int vidas;
    public int minas;
    public int vida, vidamax;
    public Color col_morada;
    public Point loc_inicial;
    public int tip;

    public int veloc,veloc_proyect;
    public string dirdisp;//udlrn
    public string dirmovX, dirmovY;
    public bool[] kpress;//6 teclas
    public int kills;
    public int basekills;


    public bool vive;
    public Point loc;

    public Image pimg;
    public int atak;
        /*al colisionar se debe remover el proyectil junto con su direccion usando el indice de la coordenada, despues de provocar daño
        se debe realizar la comparacion con cada elemento de la lista para las colisiones y el movimiento, tomando en cuenta tambien la direccion de cada proyectil
        importante, que el proyectil solo dañe a miembros de otros equipos
        dibujar cada proyectil*/

    public Point[] proy;
    public int retardo;
    public string[] proydirdisp;

    public Image mimg;
    public int atakmin;
    public Point[] minasloc;
    public Image peimg;
    public Point locproyesp;
    public bool puede_esp;//debe desactivarse al chocar con algo
    public bool ataque_en_proceso;//determina si debe comparar su posicion en colisiones,dibujarla y moverla,desactivar al colisionar
    public int atakesp;
    public string dirdispesp;


    public void dispara(){
        try
        {
            if (vive)
            if (proy.Length >= 1)
            {
                Array.Resize<Point>(ref proy, proy.Length + 1);
                proy[proy.Length - 1] = new Point(loc.X + (img.Size.Width - mimg.Size.Width) / 2, loc.Y + (img.Size.Height - mimg.Size.Height) / 2);
                Array.Resize<String>(ref proydirdisp, proydirdisp.Length + 1);
                proydirdisp[proydirdisp.Length - 1] = dirdisp;
                retardo=atak*5;
            }
            else
            {
                proy = new Point[1];
                proy[proy.Length - 1] = new Point(loc.X + (img.Size.Width - mimg.Size.Width) / 2, loc.Y + (img.Size.Height - mimg.Size.Height) / 2);
                proydirdisp = new String[1];
                proydirdisp[proydirdisp.Length - 1] = dirdisp;
                retardo = atak * 5;
            }
        }
        catch (Exception) { }
    }
    public void mina(){if (vive){
        if (minas > 0)
        {   minas--;
            if (minasloc!=null)
            {
                Array.Resize<Point>(ref minasloc, minasloc.Length + 1);
                minasloc[minasloc.Length - 1] = new Point(loc.X + (img.Size.Width - mimg.Size.Width) / 2, loc.Y + (img.Size.Height - mimg.Size.Height) / 2);

            }
            else
            {
                minasloc = new Point[1];
                minasloc[minasloc.Length - 1] = new Point(loc.X + (img.Size.Width - mimg.Size.Width) / 2, loc.Y + (img.Size.Height - mimg.Size.Height) / 2);

            }
        }
    }}
    public void especial(){if (vive&& puede_esp) {
        if (tip == 8) {
            loc = loc_inicial;
        }
        else
        {
            locproyesp = new Point(loc.X + (img.Size.Width - mimg.Size.Width) / 2, loc.Y + (img.Size.Height - mimg.Size.Height) / 2);
            ataque_en_proceso = true;
            dirdispesp = dirdisp;
        }
    }}
    public bool daña(int daño){if (vive) {
        if (daño >= vida && vidas > 0) { vidas--;  vida = vidamax; return true; }
        else if (daño >= vida && vidas == 0) { vida = 0;  vive = false; return true; }
        else { vida -= daño;}
    } return false;
    }
    public void elimina_proy(int index)
    {
        if (proy.Length > 1)
        {
            for (int i = index; i < proy.Length-1; i++)
            {
                if (i < proy.Length - 1 && i < proydirdisp.Length - 1 && proydirdisp.Length > 0 && proy.Length > 0)
                {
                    proy[i] = proy[i + 1];
                    proydirdisp[i] = proydirdisp[i + 1];
                }
            }
            Array.Resize<Point>(ref proy, proy.Length - 1);
            Array.Resize<String>(ref proydirdisp, proydirdisp.Length - 1);
        }
        else if (proy.Length == 1) proy = new Point[0];
    
    }
    public void elimina_min(int index)
    {
        minas++;
        if (minasloc.Length > 1)
        {
            
            for (int i = index; i < minasloc.Length - 1; i++)
            {
                if (i < minasloc.Length && minasloc.Length > 0)
                    minasloc[i] = minasloc[i + 1];
            }
            Array.Resize<Point>(ref minasloc, minasloc.Length - 1);
        }
        else if (minasloc.Length == 1) minasloc = new Point[0];

    }
    }

    }


