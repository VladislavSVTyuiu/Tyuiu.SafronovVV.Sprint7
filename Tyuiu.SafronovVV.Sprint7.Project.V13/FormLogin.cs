using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SafronovVV.Sprint7.Project.V13
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "12345")
                {
                    FormMain f1 = new FormMain();
                    f1.ShowDialog();
                }
            }

            else
                MessageBox.Show("Неправильно введён логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSecret formSecret = new FormSecret();
            formSecret.ShowDialog();
        }
    }
}
