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
        public char status;
        public int x;
        public int y;
        public int aging;
        static Random rnd = new Random();
        static public int height = 50;
        static public int width = 75; //по ширине, если одинак - то квадрат
        public Place()
        {
            idPlace = countPlace;

            x = idPlace % 5 + (idPlace / 25) * 5 - (idPlace / (width * 5)) * width;
            y = (idPlace / 5) - (idPlace / 25) * 5 + (idPlace / (width * 5)) * 5;
            //x = idPlace % 50;
            //y = idPlace / 50;

            int setElement = rnd.Next(0, 11);
            switch (setElement)
            {
                case 0:
                    status = 'H';
                    break;
                case 1:
                    status = 'C';
                    break;
                case 2:
                    status = 'N';
                    break;
                case 3:
                    status = 'O';
                    break;
                case 4:
                    status = 'S';
                    break;
                case 5:
                    status = 'P';
                    break;
                case 6:
                    status = 'C';
                    break;
                case 7:
                    status = 'E';
                    break;
                case 8:
                    status = 'E';
                    break;
                case 9:
                    status = 'E';
                    break;
                case 10:
                    status = 'E';
                    break;
              
            }
            aging = 1;
        }

    }
}
