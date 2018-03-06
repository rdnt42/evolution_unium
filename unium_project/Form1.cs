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

        public class Constants
        {
            public const int pixPlace = 12;
            public const int createSizeCell = 25;
            public const int countObj = 75*50;

        }

        List<Group> Units = new List<Group>();
        List<Place> Terra = new List<Place>();
        List<Place> Elements = new List<Place>();
        List<Cell> Cells = new List<Cell>();
        List<Item> Items = new List<Item>();
        
        static Random rnd = new Random();
        DataTable dt = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("Group");
            dt.Columns.Add("HP");
            dt.Columns.Add("Color");
            progressBarLoad.Maximum = Constants.countObj;
        }

        private void btn_place_Click(object sender, EventArgs e)
        {

            Place.countPlace = 0;
            progressBarLoad.Maximum = Constants.countObj;
            while (Place.countPlace < Constants.countObj)
            {
                Place place = new Place();
                switch (place.status)
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
                progressBarLoad.Value = Terra.Count;

            }
            progressBarLoad.Visible = false;
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
                if ((t.idPlace) % Constants.createSizeCell == 0)
                {
                    
                    if (carbon >= 3 && oxygen >= 3 && hydrohen >= 4)
                    {
                        Cell c = new Cell(carbon);
                        Cell.countCell++;
                        Cells.Add(c);


                        c.Location = new Point((t.x + rnd.Next(0, 3)) * Constants.pixPlace, (t.y + rnd.Next(0, 3)) * Constants.pixPlace); //in center 5x5

                        c.SizeMode = PictureBoxSizeMode.StretchImage;

                        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                        path.AddEllipse(0, 0, Constants.pixPlace * 3, Constants.pixPlace * 3);
                        Region rgn = new Region(path);
                        c.Region = rgn;
                        
                        
                        this.Controls.Add(c);
                        c.BringToFront();


                        DataRow r = dt.NewRow();
                        r["Id"] = c.idCell;
                        r["Group"] = c.group;
                        r["HP"] = c.hp;
                        r["Color"] = c.BackColor;
                        
                        dt.Rows.Add(r);


                        dataGridView1.DataSource = dt;
                    }

                    else if (carbon >= 1 && oxygen >= 3 && hydrohen >= 3 && nytrogen >= 2)
                    {
                        Item i = new Item();
                        //Cell.countCell++;
                        Items.Add(i);
                        i.BackColor = Color.OrangeRed;

                        i.Location = new Point((t.x + rnd.Next(0, 3)) * Constants.pixPlace, (t.y + rnd.Next(0, 3)) * Constants.pixPlace); //in center 5x5
                        i.Size = new Size(Constants.pixPlace * 3, Constants.pixPlace * 3);

                        this.Controls.Add(i);
                        i.BringToFront();

                    }

                    hydrohen = 0;
                    carbon = 0;
                    nytrogen = 0;
                    oxygen = 0;

                }

                switch (t.status)
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

                t.status = 'E';
                t.BackColor = Color.LightBlue;
            }

            if (!timerTurn.Enabled)
            {
                timerTurn.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerTurn.Enabled = false;
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

            int setNumGroup = rnd.Next(3, 7);
            //int setNumUnit = rnd.Next(10, 15);
            int[] setNumUnits = new int[setNumGroup];

            for (int i = 0; i < setNumGroup; i++)
            {
                Group.quantity++;
                setNumUnits[i] = rnd.Next(10, 16);
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


/// <summary>
/// ///////////////////////////////////////////////////////////////////////////////////////////////////////////
/// ///////////////////////////////////////////////////////////////////////////////////////////////////////////
/// /////////////////////////////////////////T U R N///////////////////////////////////////////////////////////
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < rnd.Next(1, 6); i++)
            {
                int rndElement = rnd.Next(0, Constants.countObj);
                if (Terra[rndElement].status == 'E')
                {
                    CreateElement(rndElement);
                    try
                    {
                        CreateCell(rndElement);
                    }
                    catch
                    {
                        textBoxErr.Text = rndElement.ToString();
                    }
                }
            }

            checkAge();

            foreach (var c in Cells)
            {
                c.Search(Items, Constants.pixPlace);
                c.Update();
            }

            Elements.RemoveAll(EmptyElement);
            Items.RemoveAll(EmptyFood);



            foreach (var c in Cells)
            {
                
                
                dt.AsEnumerable().Where(p => Convert.ToInt32(p["Id"]) == c.idCell).ToList().ForEach( //обновление таблицы
                    k =>
                    {
                        k.BeginEdit();
                        k["HP"] = c.maxHp;
                        k["Color"] = c.BackColor;
                        k.EndEdit();
                    });

            }

            progressBarFood.Value= Items.Count;
            labelFood.Text = "count food " + Items.Count;

            progressBarCells.Value = Cells.Count;
            labelCell.Text = "count cells " + Cells.Count;


        }

        void CreateElement(int setRndElement)
        {
            int setElement = rnd.Next(0, 6);

            switch (setElement)
            {
                case 0:
                    Terra[setRndElement].status = 'H';
                    Terra[setRndElement].BackColor = Color.Brown;
                    break;
                case 1:
                    Terra[setRndElement].status = 'C';
                    Terra[setRndElement].BackColor = Color.Yellow;
                    break;
                case 2:
                    Terra[setRndElement].status = 'N';
                    Terra[setRndElement].BackColor = Color.Gray;
                    break;
                case 3:
                    Terra[setRndElement].status = 'O';
                    Terra[setRndElement].BackColor = Color.Blue;
                    break;
                case 4:
                    Terra[setRndElement].status = 'S';
                    Terra[setRndElement].BackColor = Color.Orange;
                    break;
                case 5:
                    Terra[setRndElement].status = 'P';
                    Terra[setRndElement].BackColor = Color.Black;
                    break;
            }

            Elements.Add(Terra[setRndElement]);
        }



        void CreateCell(int setRndElement)
        {
            int numArr = setRndElement - setRndElement % 25;
            int hydrohen = 0;
            int carbon = 0;
            int nytrogen = 0;
            int oxygen = 0;
            for (int i = 0; i < 25; i++)
            {
                switch (Terra[numArr].status)
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



            if (carbon >= 3 && oxygen >= 1 && hydrohen >= 1)
            {

                Cell c = new Cell(carbon);
                Cell.countCell++;
                Cells.Add(c);


                c.Location = new Point((Terra[numArr].x + rnd.Next(0, 3)) * Constants.pixPlace, (Terra[numArr].y + rnd.Next(0, 3)) * Constants.pixPlace); //in center 5x5

                c.SizeMode = PictureBoxSizeMode.StretchImage;


                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddEllipse(0, 0, Constants.pixPlace * 3, Constants.pixPlace * 3);
                Region rgn = new Region(path);
                c.Region = rgn;
                switch (c.group)
                {
                    case 1:
                        c.BackColor = Color.WhiteSmoke;
                        break;
                    case 2:
                        c.BackColor = Color.Yellow;
                        break;
                    case 3:
                        c.BackColor = Color.GreenYellow;
                        break;

                    case 4:
                        c.BackColor = Color.Green;
                        break;

                    case 5:
                        c.BackColor = Color.DarkGreen;
                        break;

                    case 6:
                        c.BackColor = Color.Indigo; ;
                        break;

                    default:
                        c.BackColor = Color.HotPink;
                        break;
                }
                this.Controls.Add(c);
                c.BringToFront();

                progressBarCells.Value++;
                labelCell.Text = "count cells " + progressBarCells.Value.ToString();

                DataRow r = dt.NewRow();
                r["Id"] = c.idCell;
                r["Group"] = c.group;
                r["HP"] = c.hp;
                r["Color"] = c.BackColor;
                dt.Rows.Add(r);
                // dataGridView1.AutoResizeRows();
                // dataGridView1.AutoResizeColumns();

               // dataGridView1.Columns[0].Width = 100;
              //  dataGridView1.DataSource = dt;
                



                for (int k = 0; k < 25; k++)
                {
                    if (Terra[numArr].status != 'E')
                    {
                        Terra[numArr].status = 'E';
                        Terra[numArr].BackColor = Color.LightBlue;
                        //Elements.Remove(Terra[numArr]);
                    }
                    numArr--;
                }
            }

            else if (carbon >= 1 && hydrohen >= 1 && nytrogen >= 1)
            {
                Item i = new Item();
                //Cell.countCell++;
                Items.Add(i);
                i.BackColor = Color.OrangeRed;
                
                i.Location = new Point((Terra[numArr].x + rnd.Next(0, 3)) * Constants.pixPlace, (Terra[numArr].y + rnd.Next(0, 3)) * Constants.pixPlace); //in center 5x5
                i.Size = new Size(Constants.pixPlace * 3, Constants.pixPlace * 3);

                this.Controls.Add(i);
                i.BringToFront();

                progressBarFood.Value++;
                labelFood.Text = "cout food " + progressBarFood.Value.ToString();
                for (int k = 0; k < 25; k++)
                {
                    if (Terra[numArr].status != 'E')
                    {
                        Terra[numArr].status = 'E';
                        Terra[numArr].BackColor = Color.LightBlue;
                        //Elements.Remove(Terra[numArr]);
                    }
                    numArr--;
                }

            }
        }

        private static bool EmptyElement(Place element) //предикат для работы с RemoveAll
        {
            if (element.status == 'E')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool EmptyFood (Item food) //предикат для работы с RemoveAll
        {
            if (food.status == 'E')
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        void checkAge()
        {
            label2.Text = Elements.Count.ToString();

            foreach (var e in Elements)
            {
                e.aging++;
                if (e.aging > 50)
                {
                    e.status = 'E';
                    e.BackColor = Color.LightBlue;
                    e.aging = 0;
                }
            }

            
 

            int empt = 0;
            foreach (var e in Elements)
            {
                if (e.status == 'E')
                {
                    empt++;
                }
            }
            label3.Text = empt.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxErr_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBarFood_Click(object sender, EventArgs e)
        {

        }

        private void labelFood_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void progressBarLoad_Click(object sender, EventArgs e)
        {

        }

        private void progressBarCells_Click(object sender, EventArgs e)
        {

        }

        private void labelCell_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}