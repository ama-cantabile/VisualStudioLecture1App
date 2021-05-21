using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("첫번째 버튼을 누르셨습니다.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("두번쨰 버튼을 누르셨습니다.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "모타싸이클";
            button1.Text = "이름 바뀐 버튼";
            button2.Text = "이름 바뀐 두번째 버튼";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "치킨 사진";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "비빔밥 사진";
        }
    }
}
