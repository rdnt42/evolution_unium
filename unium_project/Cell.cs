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
        public int range;
        static public int height = 50;
        static public int width = 75;
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
            range = 100;
            switch (carbon)
            {
                case 1:
                    maxHp = 150;
                    BackColor = Color.WhiteSmoke;
                    break;
                case 2:
                    maxHp = 200;
                    BackColor = Color.Yellow;
                    break;
                case 3:
                    maxHp = 250;
                    BackColor = Color.GreenYellow;
                    break;

                case 4:
                    maxHp = 300;
                    BackColor = Color.LawnGreen;
                    break;

                case 5:
                    maxHp = 350;
                    BackColor = Color.DarkGreen;
                    break;

                case 6:
                    maxHp = 400;
                    BackColor = Color.Indigo; ;
                    break;

                default:
                    maxHp = 800;
                    BackColor = Color.HotPink;
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

            double prewSum = 100 * 100 + 1;
            int countFood = 0;
            int catchFood = -1;
            foreach (Item i in Items)
            {
                double h = Location.X - i.Location.X;
                double w = Location.Y - i.Location.Y;
                double sum = Math.Pow(h, 2) + Math.Pow(w, 2);
                if (sum <= Math.Pow(range, 2) && sum < prewSum)
                {
                    prewSum = sum;
                    catchFood = countFood;
                }
                countFood++;
            }

            if (catchFood != -1)
            {
                int deltaX = Items[catchFood].Location.X - Location.X;
                if (deltaX < 10 && deltaX > -10)
                    deltaX = 0;
                else if (deltaX != 0)
                    deltaX = deltaX / Math.Abs(deltaX);


                int deltaY = Items[catchFood].Location.Y - Location.Y;
                if (deltaY < 10 && deltaY > -10)
                    deltaY = 0;
                else if (deltaY != 0)
                    deltaY = deltaY / Math.Abs(deltaY);


                if (deltaX == 0 && deltaY == 0)   //здесь клетка съедает еду
                {
                    Items[catchFood].status = 'E';
                    Items[catchFood].Dispose();

                    int upHp = 10;
                    maxHp += upHp;
                    if (hp <= maxHp - upHp)
                        hp += upHp;
                    else
                        hp = maxHp;
                }

                Location = new Point(Location.X + deltaX * 10, Location.Y + deltaY * 10);
            }

            else
            {
                int x = rnd.Next(-1, 2);
                int y = rnd.Next(-1, 2);
                if (Location.Y < (pixPlace * height - 35 - y * 10) && Location.Y > -y * 10
                    && Location.X < (pixPlace * width - 35 - x * 10) && Location.X > -x * 10)
                {
                    Location = new Point(Location.X + x * 10, Location.Y + y * 10);
                }

            }
        }


        public new void Update()
        {
            if (maxHp >= 150 && maxHp < 200)
                BackColor = Color.WhiteSmoke;
            else if (maxHp >= 200 && maxHp < 250)
                BackColor = Color.Yellow;
            else if (maxHp >= 250 && maxHp < 300)
                BackColor = Color.GreenYellow;
            else if (maxHp >= 300 && maxHp < 350)
                BackColor = Color.LawnGreen;
            else if (maxHp >= 350 && maxHp < 400)
                BackColor = Color.DarkGreen;
            else if (maxHp >= 400 && maxHp < 800)
                BackColor = Color.Indigo;
            else if (maxHp >= 800)
                BackColor = Color.HotPink;

        }
    }
}
