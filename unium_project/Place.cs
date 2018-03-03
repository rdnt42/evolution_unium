using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unium_project
{
    // Random rnd = new Random();
    class Place : PictureBox
    {
        public static int countPlace;
        public int idPlace;
        public char element;
        public int x;
        public int y;
        public int aging;
        static Random rnd = new Random();
        public Place()
        {
            idPlace = countPlace;

            x = idPlace % 5 + (idPlace / 25) * 5 - (idPlace / 250) * 50;
            y = (idPlace / 5) - (idPlace / 25) * 5 + (idPlace / 250) * 5;
            //x = idPlace % 50;
            //y = idPlace / 50;

            int setElement = rnd.Next(0, 11);
            switch (setElement)
            {
                case 0:
                    element = 'H';
                    break;
                case 1:
                    element = 'C';
                    break;
                case 2:
                    element = 'N';
                    break;
                case 3:
                    element = 'O';
                    break;
                case 4:
                    element = 'S';
                    break;
                case 5:
                    element = 'P';
                    break;
                case 6:
                    element = 'C';
                    break;
                case 7:
                    element = 'E';
                    break;
                case 8:
                    element = 'E';
                    break;
                case 9:
                    element = 'E';
                    break;
                case 10:
                    element = 'E';
                    break;
              
            }
            aging = 1;
        }

    }
}
