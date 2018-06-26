using System;
using System.Windows.Forms;

namespace Triangle_point_practise
{
    public partial class Author_Form : Form //класс второй формы
    {
        public Author_Form()
        {
            InitializeComponent();
        }

        //кнопка закрытия формы
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close(); //закрываем
        }
    }
}
