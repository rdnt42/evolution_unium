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

        
    }
}
