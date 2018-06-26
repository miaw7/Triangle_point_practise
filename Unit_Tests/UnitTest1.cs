using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle_point_practise;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 frm1 = new Form1();
            EventArgs e = new EventArgs();
            frm1.textBox_point_X.Text = "45";
            frm1.textBox_point_Y.Text = "36";
            frm1.textBox_tr_AX.Text = "52";
            frm1.textBox_tr_AY.Text = "39";
            frm1.textBox_tr_BX.Text = "22";
            frm1.textBox_tr_BY.Text = "45";
            frm1.textBox_tr_CX.Text = "33";
            frm1.textBox_tr_CY.Text = "21";
            frm1.button_CheckPoint_Click(this,e);
            Assert.AreEqual(true, frm1.flag);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Form1 frm1 = new Form1();
            EventArgs e = new EventArgs();
            frm1.textBox_point_X.Text = "52";
            frm1.textBox_point_Y.Text = "39";
            frm1.textBox_tr_AX.Text = "22";
            frm1.textBox_tr_AY.Text = "45";
            frm1.textBox_tr_BX.Text = "33";
            frm1.textBox_tr_BY.Text = "21";
            frm1.textBox_tr_CX.Text = "45";
            frm1.textBox_tr_CY.Text = "36";
            frm1.button_CheckPoint_Click(this, e);
            Assert.AreEqual(false, frm1.flag);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Form1 frm1 = new Form1();
            EventArgs e = new EventArgs();
            frm1.textBox_point_X.Text = "";
            frm1.textBox_point_Y.Text = "39";
            frm1.textBox_tr_AX.Text = "22";
            frm1.textBox_tr_AY.Text = "45";
            frm1.textBox_tr_BX.Text = "33";
            frm1.textBox_tr_BY.Text = "";
            frm1.textBox_tr_CX.Text = "45";
            frm1.textBox_tr_CY.Text = "36";
            frm1.button_CheckPoint_Click(this, e);
            Assert.AreEqual(false, frm1.flag);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Form1 frm1 = new Form1();
            EventArgs e = new EventArgs();
            frm1.textBox_point_X.Text = "22";
            frm1.textBox_point_Y.Text = "39";
            frm1.textBox_tr_AX.Text = "22";
            frm1.textBox_tr_AY.Text = "45";
            frm1.textBox_tr_BX.Text = "33";
            frm1.textBox_tr_BY.Text = "23";
            frm1.textBox_tr_CX.Text = "45";
            frm1.textBox_tr_CY.Text = "36";
            frm1.button_CheckPoint_Click(this, e);
            frm1.button_Clear_Click(this, e);
            Assert.AreEqual("Не пройдена", frm1.label_check_status.Text);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Form1 frm1 = new Form1();
            EventArgs e = new EventArgs();
            frm1.textBox_point_X.Text = "22";
            frm1.textBox_point_Y.Text = "39";
            frm1.textBox_tr_AX.Text = "22";
            frm1.textBox_tr_AY.Text = "45";
            frm1.textBox_tr_BX.Text = "33";
            frm1.textBox_tr_BY.Text = "23";
            frm1.textBox_tr_CX.Text = "45";
            frm1.textBox_tr_CY.Text = "36";
            frm1.button_CheckPoint_Click(this, e);
            Assert.AreEqual("Точка находится за треугольником", frm1.label_check_status.Text);
        }

    }
}
