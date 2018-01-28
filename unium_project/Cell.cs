using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unium_project
{
    class Cell : PictureBox
    {
        public static int countCell;
        public int idCell;
        public int hydrohen;
        public int oxygen;
        public int carbon;
        public int nytrogen;

        public Cell()
        {
            idCell = countCell;
            nytrogen = 0;
            carbon = 0;
            oxygen = 0;
            hydrohen = 0;
        }



    }
}
