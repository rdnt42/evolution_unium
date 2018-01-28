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

        List<Group> Units = new List<Group>();
        List<Place> Terra = new List<Place>();
        List<Cell> Cells = new List<Cell>();

        private void button1_Click(object sender, EventArgs e)
        {
            Units.Clear();
            Group.id = 0;
            Group.quantity = 0;
            Random rnd = new Random();

            int setNumGroup = rnd.Next(3, 6);
            //int setNumUnit = rnd.Next(10, 15);
            int[] setNumUnits = new int[setNumGroup];

            for (int i = 0; i< setNumGroup; i++)
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
            while (Place.countPlace < 2500)
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
                        place.BackColor = Color.White;
                        break;
                }
                place.Location = new Point(place.x*12, place.y * 12);
                place.Size = new Size(12, 12);
                Place.countPlace++;
                this.Controls.Add(place);
                Terra.Add(place);
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cell.countCell = 0;
            for (int i =0;i<100;i++)
            {
                Cell c = new Cell();
                Cell.countCell ++;
                Cells.Add(c);
            }

            Cell.countCell = 0;
            Place.countPlace = 0;
            foreach (var v in Cells)
            {
               
                for(int i =0;i<25;i++) {

                    switch (Terra[Place.countPlace].element)
                    {
                        case 'H':
                            v.hydrohen++;

                            break;
                        case 'C':
                            v.carbon++;
                            break;
                        case 'N':
                            v.nytrogen++;
                            break;
                        case 'S':

                            break;
                        case 'P':

                            break;
                        case 'O':
                            v.oxygen++;

                            break;
                        case 'E':

                            break;
                    }

                    Terra[Place.countPlace].element = 'E';
                    Terra[Place.countPlace].BackColor = Color.White;

                    Place.countPlace++;
                }

                if (v.carbon>=3 && v.oxygen >= 2 && v.hydrohen >= 3)
                {
                    v.BackColor = Color.Crimson;
                    v.Location = new Point(Terra[Place.countPlace-18].x*12, Terra[Place.countPlace - 18].y*12 );
                    v.Size = new Size(36, 36);
                    
                    this.Controls.Add(v);
                    v.BringToFront();

                    progressBar1.Value++;
                    labelCell.Text = progressBar1.Value.ToString();
                }
            }




        }
    }
}
