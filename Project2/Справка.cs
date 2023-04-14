using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project2
{
    public partial class Справка : Form
    {
        public Справка()
        {
            InitializeComponent();

            treeView1.Nodes[0].ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (Convert.ToInt32(e.Node.Tag))
            {
                case 0:
                    label1.Text = "Введение";
                    textBox1.TextAlign = HorizontalAlignment.Left;
                    textBox1.Lines = (File.ReadAllLines(@"D:\1 Практика\2 Декабрь\Проект\1.txt"));
                    break;
                case 1:
                    label1.Text = "Общая информация";
                    textBox1.TextAlign = HorizontalAlignment.Left;
                    textBox1.Lines = (File.ReadAllLines(@"D:\1 Практика\2 Декабрь\Проект\2.txt"));
                    break;
                case 2:
                    label1.Text = "Пользователю";
                    textBox1.TextAlign = HorizontalAlignment.Left;
                    textBox1.Lines = (File.ReadAllLines(@"D:\1 Практика\2 Декабрь\Проект\3.txt"));
                    break;
                case 3:
                    label1.Text = "Руководство к пользователю";
                    textBox1.TextAlign = HorizontalAlignment.Left;
                    textBox1.Lines = (File.ReadAllLines(@"D:\1 Практика\2 Декабрь\Проект\4.txt"));
                    break;
                case 4:
                    label1.Text = "Общие сведения";
                    textBox1.TextAlign = HorizontalAlignment.Left;
                    textBox1.Lines = (File.ReadAllLines(@"D:\1 Практика\2 Декабрь\Проект\5.txt"));
                    break;
                case 5:
                    label1.Text = "О приложении";
                    textBox1.TextAlign = HorizontalAlignment.Center;
                    textBox1.Lines = (File.ReadAllLines(@"D:\1 Практика\2 Декабрь\Проект\6.txt"));
                    break;
                case 6:
                    label1.Text = "Об авторе";
                    textBox1.TextAlign = HorizontalAlignment.Center;
                    textBox1.Lines = (File.ReadAllLines(@"D:\1 Практика\2 Декабрь\Проект\7.txt"));
                    break;
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
    }
}
