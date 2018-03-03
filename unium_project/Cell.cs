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
        static Random rnd = new Random();

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

        public void Moving(int directionX, int directionY)
        {

            Location = new Point(Location.X + directionX, Location.Y + directionY);
        }

        public void Search(List<Item> Items, int pixPlace)
        {

            bool isFood = false;

            foreach (Item i in Items)
            {
                double h = Location.X - i.Location.X;
                double w = Location.Y - i.Location.Y;
                if (Math.Pow(h, 2) + Math.Pow(w, 2) <= Math.Pow(100, 2))
                {
                    int deltaX = i.Location.X - Location.X;
                    if (deltaX!=0)
                    deltaX = deltaX / deltaX;

                    int deltaY = i.Location.Y - Location.Y;
                    if (deltaY != 0)
                        deltaY = deltaY / deltaY;
                    Location = new Point(Location.X + deltaX*10, Location.Y + deltaY*10);
                    isFood = true;
                    break;
                }
            }

            if (!isFood) {
                int x = rnd.Next(-1, 2);
                int y = rnd.Next(-1, 2);
                if (Location.Y < (pixPlace * 50 - 35 - y * 10) && Location.Y > -y * 10
                    && Location.X < (pixPlace * 50 - 35 - x * 10) && Location.X > -x * 10)
                {
                    Location = new Point(Location.X + x*10, Location.Y + y*10);
                }

                }



        }

    }
}
