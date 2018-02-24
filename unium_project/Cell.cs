using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace unium_project
{
    class Cell : PictureBox
    {
        public static int countCell;
        public int idCell;
        public int group;
        public int hp;
        public int maxHp;
        

        public Cell()
        {
            idCell = countCell;
            group = 0;
            maxHp = 100;
            hp = maxHp;
        }

        public Cell(int carbon)
        {
            idCell = countCell;
            group = carbon;

            switch (carbon)
            {
                case 1:
                    maxHp = 150;
                    break;
                case 2:
                    maxHp = 150;
                    break;
                case 3:
                    maxHp = 150;
                    break;

                case 4:
                    maxHp = 200;
                    break;

                case 5:
                    maxHp = 250;
                    break;

                case 6:
                    maxHp = 300;
                    break;

                default:
                    maxHp = 500;
                    break;
            }

            hp = maxHp;
        }

        public void Moving (int directionX, int directionY)
        {
            // if ((Location.Y + 20 < this.ClientSize.Height) && (Location.Y - 20 > 0 ))
            // Location = new Point(Location.X + 5*(random.Next(-2,2)), Location.Y + 5* (random.Next(-2, 2)));
            Location = new Point(Location.X + 5 * directionX, Location.Y + 5 * directionY);
        }
        //(rnd.Next(-1,1))


    }
}
