using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unium_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }
        static class Constants
        {
            public const int pixPlace = 12;
            public const int createSizeCell = 25;
            public const int countObj = 2500; 

        }

        List<Group> Units = new List<Group>();
        List<Place> Terra = new List<Place>();
        List<Cell> Cells = new List<Cell>();
        static Random rndLoc = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            Units.Clear();
            Group.id = 0;
            Group.quantity = 0;
            Random rnd = new Random();

            int setNumGroup = rnd.Next(3, 6);
            //int setNumUnit = rnd.Next(10, 15);
            int[] setNumUnits = new int[setNumGroup];

            for (int i = 0; i < setNumGroup; i++)
            {
                Group.quantity++;
                setNumUnits[i] = rnd.Next(10, 15);
                for (int j = 0; j < setNumUnits[i]; j++)
                {
                    Group.id++;
                    Group unit = new Group();
                    Units.Add(unit);
                }
            }
            textBoxTest.Text = Group.id.ToString();
            textBoxTest2.Text = Units.Count.ToString();

            DataTable dt = new DataTable();
            dt.Columns.Add("Team");
            dt.Columns.Add("Units");

            for (int i = 0; i < setNumGroup; i++)
            {
                DataRow r = dt.NewRow();
                int j = i;
                r["Team"] = ++j;
                r["Units"] = setNumUnits[i];
                dt.Rows.Add(r);
            }

            dataGridView1.DataSource = dt;



        }

        private void btn_place_Click(object sender, EventArgs e)
        {

            Place.countPlace = 0;
            progressBarLoad.Maximum = Constants.countObj;
            while (Place.countPlace < Constants.countObj)
            {
                Place place = new Place();
                switch (place.element)
                {
                    case 'H':
                        place.BackColor = Color.Brown;
                        break;
                    case 'C':
                        place.BackColor = Color.Yellow;
                        break;
                    case 'N':
                        place.BackColor = Color.Gray;
                        break;
                    case 'S':
                        place.BackColor = Color.Orange;
                        break;
                    case 'P':
                        place.BackColor = Color.Black;
                        break;
                    case 'O':
                        place.BackColor = Color.Blue;
                        break;
                    case 'E':
                        place.BackColor = Color.LightBlue;
                        break;
                }
                place.Location = new Point(place.x * Constants.pixPlace, place.y * Constants.pixPlace);
                place.Size = new Size(Constants.pixPlace, Constants.pixPlace);
                Place.countPlace++;
                this.Controls.Add(place);
                Terra.Add(place);
                progressBarLoad.Value++;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Cell.countCell = 0;
            int hydrohen = 0;
            int carbon = 0;
            int nytrogen = 0;
            int oxygen = 0;
            foreach (var t in Terra)
            {
                //////////////////////////////////////////CREATE CELLS//////////////////////////////////////////
                if (t.idPlace % Constants.createSizeCell == 0)
                {
                    if (carbon >= 3 && oxygen >= 2 && hydrohen >= 3)
                    {
                        Cell c = new Cell();
                        Cell.countCell++;
                        Cells.Add(c);
                        c.BackColor = Color.Indigo;

                        c.Location = new Point((t.x + rndLoc.Next(0, 2)) * Constants.pixPlace, (t.y + rndLoc.Next(0, 2)) * Constants.pixPlace); //in center 5x5
                        c.Size = new Size(Constants.pixPlace*3, Constants.pixPlace*3);

                        this.Controls.Add(c);
                        c.BringToFront();

                        progressBarCells.Value++;
                        labelCell.Text ="count cells " + progressBarCells.Value.ToString();
                    }

                    else if (carbon >= 1 && oxygen >= 2 && hydrohen >= 3 && nytrogen >=2)
                    {
                        Cell c = new Cell();
                        Cell.countCell++;
                        Cells.Add(c);
                        c.BackColor = Color.Green;

                        c.Location = new Point((t.x + rndLoc.Next(0, 2)) * Constants.pixPlace, (t.y + rndLoc.Next(0, 2)) * Constants.pixPlace); //in center 5x5
                        c.Size = new Size(Constants.pixPlace*3, Constants.pixPlace*3);

                        this.Controls.Add(c);
                        c.BringToFront();

                         progressBarFood.Value++;
                         labelFood.Text = "cout food "+ progressBarFood.Value.ToString();

                    }

                    hydrohen = 0;
                    carbon = 0;
                    nytrogen = 0;
                    oxygen = 0;
                }

                switch (t.element)
                {
                    case 'H':
                        hydrohen++;

                        break;
                    case 'C':
                        carbon++;
                        break;
                    case 'N':
                        nytrogen++;
                        break;
                    case 'S':

                        break;
                    case 'P':

                        break;
                    case 'O':
                        oxygen++;

                        break;
                    case 'E':

                        break;
                }

                t.element = 'E';
                t.BackColor = Color.LightBlue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var t in Terra)
            {
                t.Dispose();
            }

            Terra.Clear();

            foreach (var c in Cells)
            {
                c.Dispose();
            }

            Cells.Clear();
            progressBarCells.Value = 0;
            labelCell.Text = "count cells";
            progressBarFood.Value = 0;
            labelFood.Text = "count food";
            progressBarLoad.Value = 0;
        }
    }
}
