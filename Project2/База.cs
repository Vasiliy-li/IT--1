using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project2
{
    public partial class База : Form
    {
        public База()
        {
            InitializeComponent();
            //установка значения в combobox по умолчанию
            comboBox1.SelectedIndex = 0;

        }
        //вызов и загрузка данных из бд при помощи запросов
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        void GetList()
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS1; Initial Catalog=DBSmeta; Integrated Security=True");
            da = new SqlDataAdapter("select Обоснование, Наименование, Расход_ресурсов_Ед_изм as 'Ед.изм', Прямые_затраты as 'Прямые затраты', Затраты_труда_рабочих as 'Затраты труда рабочих', Затраты_труда_маш_стов as 'Затраты труда машинистов', Сметная_цена as 'Сметная цена', Оптовая_цена as 'Оптовая цена' from[Нормативная база]", con);
            ds = new DataSet();
            if (comboBox1.SelectedIndex == 1)
            {
                da = new SqlDataAdapter("select Обоснование, Наименование, Расход_ресурсов_Ед_изм as 'Ед.изм', Прямые_затраты as 'Прямые затраты', Затраты_труда_рабочих as 'Затраты труда рабочих', Затраты_труда_маш_стов as 'Затраты труда машинистов', Сметная_цена as 'Сметная цена', Оптовая_цена as 'Оптовая цена' from[Нормативная база] where Группа = 'Строительные работы'", con);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                da = new SqlDataAdapter("select Обоснование, Наименование, Расход_ресурсов_Ед_изм as 'Ед.изм', Прямые_затраты as 'Прямые затраты', Затраты_труда_рабочих as 'Затраты труда рабочих', Затраты_труда_маш_стов as 'Затраты труда машинистов', Сметная_цена as 'Сметная цена', Оптовая_цена as 'Оптовая цена' from[Нормативная база] where Группа = 'Ремонтно-строительные работы'", con);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                da = new SqlDataAdapter("select Обоснование, Наименование, Расход_ресурсов_Ед_изм as 'Ед.изм', Прямые_затраты as 'Прямые затраты', Затраты_труда_рабочих as 'Затраты труда рабочих', Затраты_труда_маш_стов as 'Затраты труда машинистов', Сметная_цена as 'Сметная цена', Оптовая_цена as 'Оптовая цена' from[Нормативная база] where Группа = 'Монтаж оборудования'", con);
            }
            if (comboBox1.SelectedIndex == 4)
            {
                da = new SqlDataAdapter("select Обоснование, Наименование, Расход_ресурсов_Ед_изм as 'Ед.изм', Прямые_затраты as 'Прямые затраты', Затраты_труда_рабочих as 'Затраты труда рабочих', Затраты_труда_маш_стов as 'Затраты труда машинистов', Сметная_цена as 'Сметная цена', Оптовая_цена as 'Оптовая цена' from[Нормативная база] where Группа = 'Капремонт оборудования'", con);
            }
            if (comboBox1.SelectedIndex == 5)
            {
                da = new SqlDataAdapter("select Обоснование, Наименование, Расход_ресурсов_Ед_изм as 'Ед.изм', Прямые_затраты as 'Прямые затраты', Затраты_труда_рабочих as 'Затраты труда рабочих', Затраты_труда_маш_стов as 'Затраты труда машинистов', Сметная_цена as 'Сметная цена', Оптовая_цена as 'Оптовая цена' from[Нормативная база] where Группа = 'Пусконаладочные работы'", con);
            }
            if (comboBox1.SelectedIndex == 6)
            {
                da = new SqlDataAdapter("select Обоснование, Наименование, Расход_ресурсов_Ед_изм as 'Ед.изм', Прямые_затраты as 'Прямые затраты', Затраты_труда_рабочих as 'Затраты труда рабочих', Затраты_труда_маш_стов as 'Затраты труда машинистов', Сметная_цена as 'Сметная цена', Оптовая_цена as 'Оптовая цена' from[Нормативная база] where Группа = 'Погрузо-разгрузочные работы'", con);
            }
            if (comboBox1.SelectedIndex == 7)
            {
                da = new SqlDataAdapter("select Обоснование, Наименование, Расход_ресурсов_Ед_изм as 'Ед.изм', Прямые_затраты as 'Прямые затраты', Затраты_труда_рабочих as 'Затраты труда рабочих', Затраты_труда_маш_стов as 'Затраты труда машинистов', Сметная_цена as 'Сметная цена', Оптовая_цена as 'Оптовая цена' from[Нормативная база] where Группа = 'Перевозка грузов автомобильным транспортом'", con);
            }
            if (comboBox1.SelectedIndex == 8)
            {
                da = new SqlDataAdapter("select Обоснование, Наименование, Расход_ресурсов_Ед_изм as 'Ед.изм', Прямые_затраты as 'Прямые затраты', Затраты_труда_рабочих as 'Затраты труда рабочих', Затраты_труда_маш_стов as 'Затраты труда машинистов', Сметная_цена as 'Сметная цена', Оптовая_цена as 'Оптовая цена' from[Нормативная база] where Группа = 'Сборник цен на материалы, иделия, конструкции'", con);
            }

            con.Open();
            da.Fill(ds, "Нормативная база");
            dataGridView1.DataSource = ds.Tables["Нормативная база"];
            con.Close();
        }

        //вызов и обновление окна с данными
        private void База_Load(object sender, EventArgs e)
        {
            GetList();
        }
        //вызов и обновление данных в combobox
        private void combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        //поиск через textbox
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text != "")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string s = row.Cells[0].Value.ToString();
                    if (!s.StartsWith(textBox1.Text, true, null)) 
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        row.Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                    else
                    {
                        row.Visible = true;
                    }
                }
            }
        }
    }
}