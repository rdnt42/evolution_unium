using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unium_project 
{
    class Group : PictureBox
    {
        private int groupNum;
        
        private int hp;
        private int maxHp;

        public static int quantity;
        public static int id;

        public Group()
        {
            hp = 100;
            maxHp = 100;
          //  id++;
        }

        public Group(int setHp, int setMaxHp)
        {
            hp = setHp;
            maxHp = setMaxHp;
           // id++;
        }

        /*public static void Id (int setId)
        {
            id = setId;
        }
        public static void Quantity(int setQuantity)
        {
            quantity = setQuantity;
        }*/
    }
}
