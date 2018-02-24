using System;

public class Class1
{
    //на форме добавь DataGridView/, дальше идет код, раскидай в нужные части у себя

    DataTable dt = new DataTable();

    private void Form1_Load(object sender, EventArgs e)
    {
        dt.Columns.Add("Id");  //здесь добавляются названия столбцов
        dt.Columns.Add("Group");
        dt.Columns.Add("HP");
    }


    void example()
    {
        DataRow r = dt.NewRow(); //здесь заполняется таблица на основе каких то данных
        r["Id"] = c.idCell;
        r["Group"] = c.group;
        r["HP"] = c.hp;
        dt.Rows.Add(r);        //построчно
        dataGridView1.DataSource = dt;


        dt.Rows.Clear(); //очищает таблицу (например чтобы каждый раз ее обновлять,я пока все стираю и рисую заново)

    }
    public Class1()
    {

    }
}
