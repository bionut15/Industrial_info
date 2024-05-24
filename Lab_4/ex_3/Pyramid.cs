using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    public class Pyramid
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
        

        // Constructor
        public Pyramid(int length, int width, int heigth)
        {
            Length = length;
            Width = width;
            Heigth = heigth;
        }
        public int BaseArea(int width, int length)
        {
            return width * length;
        }
        public int PyramidVol(int width, int heigth, int length)
        {
            return (width*length*heigth)/3;
        }
    }
}
