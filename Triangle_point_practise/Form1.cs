using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_point_practise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Operations func = new Operations();
        public bool flag = false;

        public void button_CheckPoint_Click(object sender, EventArgs e)
        {
            if(textBox_point_X.Text == ""||textBox_tr_CY.Text==""||
                textBox_tr_CX.Text==""||textBox_tr_BY.Text==""||
                textBox_tr_BX.Text==""||textBox_tr_AY.Text==""||
                textBox_tr_AX.Text==""||textBox_point_Y.Text=="")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double[] a = { Convert.ToDouble(textBox_tr_AX.Text), Convert.ToDouble(textBox_tr_AY.Text) };//
            double[] b = { Convert.ToDouble(textBox_tr_BX.Text), Convert.ToDouble(textBox_tr_BY.Text) };
            double[] c = { Convert.ToDouble(textBox_tr_CX.Text), Convert.ToDouble(textBox_tr_CY.Text) };
            double[] point = { Convert.ToDouble(textBox_point_X.Text), Convert.ToDouble(textBox_point_Y.Text) };
            flag = func.Check_points_location(a, b, c, point);
            if (flag)
                label_check_status.Text = "Точка находится в треугольнике";
            else
                label_check_status.Text = "Точка находится за треугольником";
        }

        private void textBox_tr_AX_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox thisTextBox = (sender as TextBox);//создание экземпляра textBox и определение его как sender
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.'&&thisTextBox.Text.LastIndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (thisTextBox.SelectionStart == 0 && e.KeyChar == '.')
                e.Handled = true;
           
                
        }
    }

    public class Operations
    {
        public bool Check_points_location(double[] a, double[] b, double[] c, double[] point)
        {
            double[] results = new double[3];
            results[0] = (a[0] - point[0]) * (b[1] - a[1]) - (b[0] - a[0]) * (a[1] - point[1]);
            results[1] = (b[0] - point[0]) * (c[1] - b[1]) - (c[0] - b[0]) * (b[1] - point[1]);
            results[2] = (c[0] - point[0]) * (a[1] - c[1]) - (a[0] - c[0]) * (c[1] - point[1]);
            return Compare_results(results);
        }

        public bool Compare_results(double[] results)
        {
            int check = 0;
            bool flag = false;
            if (results[0] >= 0)
                check++;
            if (results[1] >= 0)
                check++;
            if (results[2] >= 0)
                check++;
            if (check == 3)
                flag = true;
            else
                flag = false;
            return flag;
        }
    }
}
