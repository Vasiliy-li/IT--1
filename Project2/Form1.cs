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
    public partial class Form1 : Form
    {
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        Timer timer;

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();

            //дата и время
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
            //дата и время
        }
        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        private void нормативнаяБазаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form База = new База();
            База.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Справка = new Справка();
            Справка.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSmetaDataSet.Дата". При необходимости она может быть перемещена или удалена.
            this.датаTableAdapter.Fill(this.dBSmetaDataSet.Дата);

        }

        
        void GetList()
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS1; Initial Catalog=DBSmeta; Integrated Security=True");
            
            ds = new DataSet();
            con.Open();
            if (label1.Text != "")
            {
                da = new SqlDataAdapter("select Cast(Ном_сметы as nvarchar)+'.' from Дата where Ном_сметы = 1", con);
                SqlCommand com = new SqlCommand("select Cast(Ном_сметы as nvarchar)+'.' from Дата where Ном_сметы = 1", con);
                string res = com.ExecuteScalar().ToString();
                label1.Text = res;

            }
            if (label2.Text != "")
            {
                da = new SqlDataAdapter("select Ном_сметы as 'Номер сметы' from Дата where Ном_сметы = 1", con);
                SqlCommand com = new SqlCommand("select Название_сметы as 'Название сметы' from Дата where Ном_сметы = 1", con);
                string res = com.ExecuteScalar().ToString();
                label2.Text = res;
            }
            if (label3.Text != "")
            {
                da = new SqlDataAdapter("select Ном_сметы as 'Номер сметы' from Дата where Ном_сметы = 1", con);
                SqlCommand com = new SqlCommand("select DATENAME(d,Дата_согласования)+' '+DATENAME(m,Дата_согласования)+' '+DATENAME(yyyy,Дата_согласования) as 'Дата согласования' from Дата where Ном_сметы = 1", con);
                string res = com.ExecuteScalar().ToString();
                
                label3.Text = res;
            }
            if (label4.Text != "")
            {
                da = new SqlDataAdapter("select Ном_сметы as 'Номер сметы' from Дата where Ном_сметы = 1", con);
                SqlCommand com = new SqlCommand("select DATENAME(d,Дата_утверждения)+' '+DATENAME(m,Дата_утверждения)+' '+DATENAME(yyyy,Дата_утверждения) as 'Дата утверждения' from Дата where Ном_сметы = 1", con);
                string res = com.ExecuteScalar().ToString();
                label4.Text = res;
            }

            if (label12.Text != "")
            {
                da = new SqlDataAdapter("select Cast(Ном_сметы as nvarchar)+'.' from Дата where Ном_сметы = 2", con);
                SqlCommand com = new SqlCommand("select Cast(Ном_сметы as nvarchar)+'.' from Дата where Ном_сметы = 2", con);
                string res = com.ExecuteScalar().ToString();
                label12.Text = res;

            }
            if (label11.Text != "")
            {
                da = new SqlDataAdapter("select Cast(Ном_сметы as nvarchar)+'.' from Дата where Ном_сметы = 2", con);
                SqlCommand com = new SqlCommand("select Название_сметы as 'Название сметы' from Дата where Ном_сметы = 2", con);
                string res = com.ExecuteScalar().ToString();
                label11.Text = res;
            }
            if (label10.Text != "")
            {
                da = new SqlDataAdapter("select НCast(Ном_сметы as nvarchar)+'.' from Дата where Ном_сметы = 2", con);
                SqlCommand com = new SqlCommand("select DATENAME(d,Дата_согласования)+' '+DATENAME(m,Дата_согласования)+' '+DATENAME(yyyy,Дата_согласования) as 'Дата согласования' from Дата where Ном_сметы = 2", con);
                string res = com.ExecuteScalar().ToString();

                label10.Text = res;
            }
            if (label9.Text != "")
            {
                da = new SqlDataAdapter("select Cast(Ном_сметы as nvarchar)+'.' from Дата where Ном_сметы = 2", con);
                SqlCommand com = new SqlCommand("select DATENAME(d,Дата_утверждения)+' '+DATENAME(m,Дата_утверждения)+' '+DATENAME(yyyy,Дата_утверждения) as 'Дата утверждения' from Дата where Ном_сметы = 2", con);
                string res = com.ExecuteScalar().ToString();
                label9.Text = res;
            }
            da.Fill(ds, "Дата");
            con.Close();
        }

        private void NomSmBind(object sender, EventArgs e)
        {
            GetList();
        }

        private void SmBtnClick(object sender, EventArgs e)
        {

        }

        private void SmBtnLeave(object sender, EventArgs e)
        {

        }

        private void panel1_Leave(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
