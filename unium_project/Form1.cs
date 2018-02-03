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
        List<Item> Items = new List<Item>();
        static Random rnd = new Random();
        DataTable dt = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("Group");
            dt.Columns.Add("HP");
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
                        Cell c = new Cell(carbon);
                        Cell.countCell++;
                        Cells.Add(c);
                       // c.BackColor = Color.Indigo;

                        c.Location = new Point((t.x + rnd.Next(0, 2)) * Constants.pixPlace, (t.y + rnd.Next(0, 2)) * Constants.pixPlace); //in center 5x5
                        
                        c.SizeMode = PictureBoxSizeMode.StretchImage;

                        //Bitmap image = new Bitmap("W://!git//evolution_unium//Cell.png");
                        
                        //c.SizeMode = PictureBoxSizeMode.StretchImage;
                        //c.Size = new Size(Constants.pixPlace * 3, Constants.pixPlace * 3);
                        //c.BackColor = Color.Transparent;
                       // c.Image = image;


                        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                        path.AddEllipse(0, 0, Constants.pixPlace * 3, Constants.pixPlace * 3);
                        Region rgn = new Region(path);
                        c.Region = rgn;
                        c.BackColor = Color.Indigo;
                        this.Controls.Add(c);
                        c.BringToFront();

                        progressBarCells.Value++;
                        labelCell.Text = "count cells " + progressBarCells.Value.ToString();

                        DataRow r = dt.NewRow();
                        r["Id"] = c.idCell;
                        r["Group"] =c.group;
                        r["HP"] = c.hp;
                        dt.Rows.Add(r);


                        dataGridView1.DataSource = dt;
                    }

                    else if (carbon >= 1 && oxygen >= 2 && hydrohen >= 3 && nytrogen >= 2)
                    {
                        Item i = new Item();
                        //Cell.countCell++;
                        Items.Add(i);
                        i.BackColor = Color.Green;

                        i.Location = new Point((t.x + rnd.Next(0, 2)) * Constants.pixPlace, (t.y + rnd.Next(0, 2)) * Constants.pixPlace); //in center 5x5
                        i.Size = new Size(Constants.pixPlace * 3, Constants.pixPlace * 3);

                        this.Controls.Add(i);
                        i.BringToFront();

                        progressBarFood.Value++;
                        labelFood.Text = "cout food " + progressBarFood.Value.ToString();

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

            if (!timerTurn.Enabled)
            {
                timerTurn.Enabled = true;
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

            foreach (var i in Items)
            {
                i.Dispose();
            }

            Items.Clear();

            progressBarCells.Value = 0;
            labelCell.Text = "count cells";
            progressBarFood.Value = 0;
            labelFood.Text = "count food";
            progressBarLoad.Value = 0;
            dt.Rows.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
            // textBoxTest.Text = Group.id.ToString();
            // textBoxTest2.Text = Units.Count.ToString();



            /*  dt.Rows.Clear();
              for (int i = 0; i < setNumGroup; i++)
              {
                  DataRow r = dt.NewRow();
                  int j = i;
                  r["Team"] = ++j;
                  r["Units"] = setNumUnits[i];
                  dt.Rows.Add(r);
              }

              dataGridView1.DataSource = dt;*/

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (var v in Cells)
            {
                v.Location = new Point(v.Location.X + 10, v.Location.Y + 10); //in center 5x5


            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < rnd.Next(1, 5);i++) {
                int rndElement = rnd.Next(0, 2500);
                if (Terra[rndElement].element == 'E')
                {
                    CreateElement(rndElement);
                    CreateCell(rndElement);
                }
            }
        }

        void CreateElement (int setRndElement)
        {
            int setElement = rnd.Next(0, 5);

            switch (setElement)
            {
                case 0:
                    Terra[setRndElement].element = 'H';
                    Terra[setRndElement].BackColor = Color.Brown;
                    break;
                case 1:
                    Terra[setRndElement].element = 'C';
                    Terra[setRndElement].BackColor = Color.Yellow;
                    break;
                case 2:
                    Terra[setRndElement].element = 'N';
                    Terra[setRndElement].BackColor = Color.Gray;
                    break;
                case 3:
                    Terra[setRndElement].element = 'O';
                    Terra[setRndElement].BackColor = Color.Blue;
                    break;
                case 4:
                    Terra[setRndElement].element = 'S';
                    Terra[setRndElement].BackColor = Color.Orange;
                    break;
                case 5:
                    Terra[setRndElement].element = 'P';
                    Terra[setRndElement].BackColor = Color.Black;
                    break;

            }
        }

        void CreateCell(int setRndElement)
        {
            int numArr = setRndElement - setRndElement % 25;
            int hydrohen = 0;
            int carbon = 0;
            int nytrogen = 0;
            int oxygen = 0;
            for (int i = 0; i<25; i++)
            {
                switch (Terra[numArr].element)
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

                    default:
                        break;
                }
                numArr++;

            }

            if (carbon >= 3 && oxygen >= 2 && hydrohen >= 3)
            {
                Cell c = new Cell(carbon);
                Cell.countCell++;
                Cells.Add(c);
                // c.BackColor = Color.Indigo;

                c.Location = new Point((Terra[numArr].x + rnd.Next(0, 2)) * Constants.pixPlace, (Terra[numArr].y + rnd.Next(0, 2)) * Constants.pixPlace); //in center 5x5

                c.SizeMode = PictureBoxSizeMode.StretchImage;

                //Bitmap image = new Bitmap("W://!git//evolution_unium//Cell.png");

                //c.SizeMode = PictureBoxSizeMode.StretchImage;
                //c.Size = new Size(Constants.pixPlace * 3, Constants.pixPlace * 3);
                //c.BackColor = Color.Transparent;
                // c.Image = image;


                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddEllipse(0, 0, Constants.pixPlace * 3, Constants.pixPlace * 3);
                Region rgn = new Region(path);
                c.Region = rgn;
                c.BackColor = Color.Indigo;
                this.Controls.Add(c);
                c.BringToFront();

                progressBarCells.Value++;
                labelCell.Text = "count cells " + progressBarCells.Value.ToString();

                DataRow r = dt.NewRow();
                r["Id"] = c.idCell;
                r["Group"] = c.group;
                r["HP"] = c.hp;
                dt.Rows.Add(r);


                dataGridView1.DataSource = dt;
            }

            else if (carbon >= 1 && oxygen >= 2 && hydrohen >= 3 && nytrogen >= 2)
            {
                Item i = new Item();
                //Cell.countCell++;
                Items.Add(i);
                i.BackColor = Color.Green;

                i.Location = new Point((Terra[numArr].x + rnd.Next(0, 2)) * Constants.pixPlace, (Terra[numArr].y + rnd.Next(0, 2)) * Constants.pixPlace); //in center 5x5
                i.Size = new Size(Constants.pixPlace * 3, Constants.pixPlace * 3);

                this.Controls.Add(i);
                i.BringToFront();

                progressBarFood.Value++;
                labelFood.Text = "cout food " + progressBarFood.Value.ToString();

            }




        }
        
    }
}
