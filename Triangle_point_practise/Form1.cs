using System;
using System.Windows.Forms;

namespace Triangle_point_practise
{
    public partial class Form1 : Form
    {
        public Form1() //констуктор первой формы
        {
            InitializeComponent();
        }

        Operations func = new Operations(); //экземпляр основного класса операций
        public bool flag = false; //флаг вывода результата

        public void button_CheckPoint_Click(object sender, EventArgs e) //обработчик нажатия клавиши "проверить"
        {
            if(textBox_point_X.Text == ""||textBox_tr_CY.Text==""|| //проверяем данные текстбоксы на пустоту
                textBox_tr_CX.Text==""||textBox_tr_BY.Text==""||
                textBox_tr_BX.Text==""||textBox_tr_AY.Text==""||
                textBox_tr_AX.Text==""||textBox_point_Y.Text=="")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); //если есть пустое поле - сообщаем об этом
                return; //выходим из обработчика
            }
            if(textBox_tr_CY.Text == textBox_tr_BY.Text  && textBox_tr_BY.Text == textBox_tr_AY.Text 
                && textBox_tr_AX.Text == textBox_tr_BX.Text && textBox_tr_BX.Text == textBox_tr_CX.Text) //проверяем, одинаковы ли координаты вершин
            {
                MessageBox.Show("Координаты вершин треугольника не могут быть одинаковыми", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); //если координаты одинаковы
                return;
            }
            double[] a = { Convert.ToDouble(textBox_tr_AX.Text), Convert.ToDouble(textBox_tr_AY.Text) };//конвертируем координаты точки А из текстбоксов
            double[] b = { Convert.ToDouble(textBox_tr_BX.Text), Convert.ToDouble(textBox_tr_BY.Text) };//конвертируем координаты точки B из текстбоксов
            double[] c = { Convert.ToDouble(textBox_tr_CX.Text), Convert.ToDouble(textBox_tr_CY.Text) };//конвертируем координаты точки C из текстбоксов
            double[] point = { Convert.ToDouble(textBox_point_X.Text), Convert.ToDouble(textBox_point_Y.Text) }; //конвертируем координаты произвольной точки из текстбоксов
            flag = func.Check_points_location(a, b, c, point); //определяем, находится ли точка в треугольнике и получаем результат
            if (flag) //если находится
                label_check_status.Text = "Точка находится в треугольнике"; //выводим инфо о том, что да
            else //если нет
                label_check_status.Text = "Точка находится за треугольником";//выводим инфо о том, что нет
        }

        private void textBox_tr_AX_KeyPress(object sender, KeyPressEventArgs e) //обработчик нажатия клавиши для всех текстбоксов
        {
            TextBox thisTextBox = (sender as TextBox);//создание экземпляра textBox и определение его как sender
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.') //проверяем входные данных на правильность
            {
                e.Handled = true; //если неверные - блокируем ввод
                return; //выходим
            }
            if (e.KeyChar == '.'&&thisTextBox.Text.LastIndexOf('.') != -1) //проверяем на наличие одной точки
            {
                e.Handled = true; //если есть - блокируем
                return; //выходим
            }
            if (thisTextBox.SelectionStart == 0 && e.KeyChar == '.') //проверяем на ввод точки вначале
                e.Handled = true; //если да - блокируем
           
                
        }
    }

    public class Operations //класс основных операций расчета
    {
        public bool Check_points_location(double[] a, double[] b, double[] c, double[] point) //проверяем, лежит ли точка в треугольнике
        {
            double[] results = new double[3]; //массив результата для 3-х точек
            results[0] = (a[0] - point[0]) * (b[1] - a[1]) - (b[0] - a[0]) * (a[1] - point[1]);
            results[1] = (b[0] - point[0]) * (c[1] - b[1]) - (c[0] - b[0]) * (b[1] - point[1]); //считаем коэффициент для каждой вершины
            results[2] = (c[0] - point[0]) * (a[1] - c[1]) - (a[0] - c[0]) * (c[1] - point[1]);
            return Compare_results(results); //сравниваем полученные коэффициенты
        }

        public bool Compare_results(double[] results) //метод сравнения результатов
        {
            int check = 0; //счетчик определения, сколько переменных больше нуля
            bool flag = false; //флаг результата
            if (results[0] >= 0) //если больше нуля коэффициент первой
                check++; //увеличиваем счетчик
            if (results[1] >= 0)//если больше нуля коэффициент второй
                check++; //увеличиваем счетчик
            if (results[2] >= 0)//если больше нуля коэффициент третей
                check++; //увеличиваем счетчик
            if (check == 3) //если все 3 больше нуля
                flag = true; //устанавливаем результат правильный
            else //иначе
                flag = false; //устанавливаем результат ложный
            return flag; //возвращаем сам результат
        }
    }
}
