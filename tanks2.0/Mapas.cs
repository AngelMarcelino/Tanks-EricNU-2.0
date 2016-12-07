using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Mapas
    {
        public bool[,] map1 = new bool[18, 14] { //A     B      C      D      E      F      G      H      I      J      K      L      M      N
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //1
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //2
        { false, false, false, false, true, false, false, false, false, true, false, false, false, false }, //3
        { false, true, false, false, true, true, true, true, true, true, false, false, true, false }, //4
        { false, true, false, false, false, false, false, false, false, false, false, false, true, false }, //5
        { false, true, false, false, false, false, false, false, false, false, false, false, true, false }, //6
        { false, false, false, false, true, true, false, false, true, true, false, false, false, false }, //7
        { false, false, false, false, true, false, false, false, false, true, false, false, false, false }, //8
        { true, false, false, false, false, false, false, false, false, false, false, false, false, true }, //9
        { true, false, false, false, false, false, false, false, false, false, false, false, false, true }, //10
        { false, false, false, false, true, false, false, false, false, true, false, false, false, false }, //11
        { false, false, false, false, true, true, false, false, true, true, false, false, false, false }, //12
        { false, true, false, false, false, false, false, false, false, false, false, false, true, false }, //13
        { false, true, false, false, false, false, false, false, false, false, false, false, true, false }, //14
        { false, true, false, false, true, true, true, true, true, true, false, false, true, false }, //15
        { false, false, false, false, true, false, false, false, false, true, false, false, false, false }, //16
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //17
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }};

        public bool[,] map2 = new bool[18, 14] { 
            //A     B      C      D      E      F      G      H      I      J      K      L      M      N
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //1
        { false, false, true, false, false, false, false, false, false, false, false, true, false, false }, //2
        { false, true, false, false, false, true, false, false, true, false, false, false, true, false }, //3
        { false, false, false, false, true, false, false, false, false, true, false, false, false, false }, //4
        { false, false, false, true, false, false, false, false, false, false, true, false, false, false }, //5
        { false, false, true, false, false, false, false, false, false, false, false, true, false, false }, //6
        { false, true, false, false, false, false, false, false, false, false, false, false, true, false }, //7
        { false, false, false, false, false, false, true, true, false, false, false, false, false, false }, //8
        { false, false, false, false, false, true, true, true, true, false, false, false, false, false }, //9
        { false, false, false, false, false, true, true, true, true, false, false, false, false, false }, //10
        { false, false, false, false, false, false, true, true, false, false, false, false, false, false }, //11
        { false, true, false, false, false, false, false, false, false, false, false, false, true, false }, //12
        { false, false, true, false, false, false, false, false, false, false, false, true, false, false }, //13
        { false, false, false, true, false, false, false, false, false, false, true, false, false, false }, //14
        { false, false, false, false, true, false, false, false, false, true, false, false, false, false }, //15
        { false, true, false, false, false, true, false, false, true, false, false, false, true, false }, //16
        { false, false, true, false, false, false, false, false, false, false, false, true, false, false }, //17
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, };//18
        
        public bool[,] map3 = new bool[18, 14] { 
            //A     B      C      D      E      F      G      H      I      J      K      L      M      N
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //1
        { false, true, false, true, false, true, false, true, false, true, false, true, false, false }, //2
        { false, false, false, false, false, false, false, false, false, false, false, false, false, true }, //3
        { false, true, false, true, false, true, false, true, false, true, false, true, false, false }, //4
        { false, false, false, false, false, false, false, false, false, false, false, false, false, true }, //5
        { false, true, false, true, false, true, false, true, false, true, false, true, false, false }, //6
        { false, false, false, false, false, false, false, false, false, false, false, false, false, true }, //7
        { false, true, false, true, false, true, false, true, false, true, false, true, false, false }, //8
        { false, false, false, false, false, false, false, false, false, false, false, false, false, true }, //9
        { false, true, false, true, false, true, false, true, false, true, false, true, false, false }, //10
        { false, false, false, false, false, false, false, false, false, false, false, false, false, true }, //11
        { false, true, false, true, false, true, false, true, false, true, false, true, false, false }, //12
        { false, false, false, false, false, false, false, false, false, false, false, false, false, true }, //13
        { false, true, false, true, false, true, false, true, false, true, false, true, false, false }, //14
        { false, false, false, false, false, false, false, false, false, false, false, false, false, true }, //15
        { false, true, false, true, false, true, false, true, false, true, false, true, false, false }, //16
        { false, false, false, false, false, false, false, false, false, false, false, false, false, true }, //17
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, };//18

        public bool[,] map4 = new bool[18, 14] { 
            //A     B      C      D      E      F      G      H      I      J      K      L      M      N
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //1
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //2
        { false, false, true, true, true, false, false, false, true, true, true, false, false, false }, //3
        { false, false, true, true, true, false, false, false, true, true, true, false, false, false }, //4
        { false, false, true, true, true, false, false, false, true, true, true, false, false, false }, //5
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //6
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //7
        { false, false, true, true, false, false, false, false, false, false, false, false, false, false }, //8
        { false, false, true, true, true, true, false, false, false, false, false, false, false, false }, //9
        { false, false, false, false, true, true, true, true, false, false, false, false, false, false }, //10
        { false, false, false, false, false, false, true, true, true, true, false, false, false, false }, //11
        { false, false, false, false, false, false, false, false, true, true, true, false, false, false }, //12
        { false, false, false, false, false, false, false, false, true, true, true, false, false, false }, //13
        { false, false, false, false, false, false, true, true, true, true, false, false, false, false }, //14
        { false, false, false, false, true, true, true, true, false, false, false, false, false, false }, //15
        { false, false, true, true, true, true, false, false, false, false, false, false, false, false }, //16
        { false, false, true, true, false, false, false, false, false, false, false, false, false, false }, //17
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, };//18

        public bool[,] map5 = new bool[18, 14] { 
            //A     B      C      D      E      F      G      H      I      J      K      L      M      N
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //1
        { false, false, true, false, false, false, false, false, false, false, false, true, false, false }, //2
        { false, false, true, false, false, false, false, false, false, false, false, true, false, false }, //3
        { false, false, false, true, false, false, false, false, false, false, true, false, false, false }, //4
        { false, false, false, false, true, false, false, false, false, true, false, false, false, false }, //5
        { false, false, false, false, false, true,  true,  true,  true,  false, false, false, false, false }, //6
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //7
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //8
        { true,  true,  true,  true,  false, false, true,   true, false, false,  true,  true,  true,  true }, //9
        { true,  true,  true,  true,  false, false, true,   true, false, false,  true,  true,  true,  true }, //10
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //11
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //12
        { false, false, false, false, false,  true,  true,  true,  true, false, false, false, false, false }, //13
        { false, false, false, false, true, false, false, false, false, true, false, false, false, false }, //14
        { false, false, false, true, false, false, false, false, false, false, true, false, false, false }, //15
        { false, false, true, false, false, false, false, false, false, false, false, true, false, false }, //16
        { false, false, true, false, false, false, false, false, false, false, false, true, false, false }, //17
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, };//18
        
        public bool[,] map6 = new bool[18, 14] { 
            //A     B      C      D      E      F      G      H      I      J      K      L      M      N
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //1
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //2
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //3
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //4
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //5
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //6
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //7
        { false, false, false, false, false, true, true, true, true, false, false, false, false, false }, //8
        { false, false, false, false, false, true, true, true, true, false, false, false, false, false }, //9
        { false, false, false, false, false, true, true, true, true, false, false, false, false, false }, //10
        { false, false, false, false, false, true, true, true, true, false, false, false, false, false }, //11
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //12
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //13
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //14
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //15
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //16
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //17
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, };//18
        public bool[,] map7 = new bool[18, 14] { 
            //A     B      C      D      E      F      G      H      I      J      K      L      M      N
        { true, true, false, false, false, false, false, false, false, false, false, false, true, true }, //1
        { true, true, false, false, false, false, false, false, false, false, false, false, true, true }, //2
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //3
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //4
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //5
        { false, false, false, true, true, false, false, false, false, true, true, false, false, false }, //6
        { false, false, false, true, true, false, false, false, false, true, true, false, false, false }, //7
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //8
        { false, false, false, false, false, false, true, true, false, false, false, false, false, false }, //9
        { false, false, false, false, false, false, true, true, false, false, false, false, false, false }, //10
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //11
        { false, false, false, true, true, false, false, false, false, true, true, false, false, false }, //12
        { false, false, false, true, true, false, false, false, false, true, true, false, false, false }, //13
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //14
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //15
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //16
        { true, true, false, false, false, false, false, false, false, false, false, false, true, true }, //17
        { true, true, false, false, false, false, false, false, false, false, false, false, true, true }, };//18

        public bool[,] map8 = new bool[18, 14] { 
            //A     B      C      D      E      F      G      H      I      J      K      L      M      N
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //1
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //2
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //3
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //4
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //5
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //6
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //7
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //8
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //9
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //10
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //11
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //12
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //13
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //14
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //15
        { false, false, true, true, false, false, true, true, false, false, true, true, false, false }, //16
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, //17
        { false, false, false, false, false, false, false, false, false, false, false, false, false, false }, };//18


    }
}
