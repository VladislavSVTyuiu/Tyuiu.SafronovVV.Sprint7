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
using Tyuiu.SafronovVV.Sprint7.Project.V13.Lib;

namespace Tyuiu.SafronovVV.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_SVV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_SVV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        public string openFilePath;
        DataService ds = new DataService();
        public string FolderContr = @"C:\Users\Black_Reaper\source\repos\Tyuiu.SafronovVV.Sprint7\Tyuiu.SafronovVV.Sprint7.Project.V13\bin\Debug\Countries";
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddCountry_SVV_Click(object sender, EventArgs e)
        {
            string countryName = textBoxCountryName_SVV.Text;
            string capital = textBoxCapital_SVV.Text;
            double area;
            if (!double.TryParse(textBoxSquare_SVV.Text, out area))
            {
                MessageBox.Show("Введите число в поле Площадь!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double GDP;
            if (!double.TryParse(textBoxEconomic_SVV.Text, out GDP))
            {
                MessageBox.Show("Введите число в поле Экономика!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double population;
            if (!double.TryParse(textBoxPopulation_SVV.Text, out population))
            {
                MessageBox.Show("Введите число в поле Население!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nationality = textBoxNations_SVV.Text;
            string currency = textBoxCurrency_SVV.Text;
            string language = textBoxLang_SVV.Text;
            string continent = textBoxContinent_SVV.Text;
            string religion = textBoxReligion_SVV.Text;
            if (string.IsNullOrWhiteSpace(countryName) || string.IsNullOrWhiteSpace(capital) ||
    string.IsNullOrWhiteSpace(textBoxSquare_SVV.Text) || string.IsNullOrWhiteSpace(textBoxEconomic_SVV.Text) ||
    string.IsNullOrWhiteSpace(textBoxPopulation_SVV.Text) || string.IsNullOrWhiteSpace(nationality) ||
    string.IsNullOrWhiteSpace(currency) || string.IsNullOrWhiteSpace(language) || string.IsNullOrWhiteSpace(continent) || string.IsNullOrWhiteSpace(religion))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string data = $"{countryName};{capital};{area};{GDP};{currency};{population};{nationality};{language};{continent};{religion}";
                string fileName = $"{countryName}.csv";
                string filePath = Path.Combine("Countries", fileName);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(data);
                }
                textBoxCountryName_SVV.Clear();
                textBoxCapital_SVV.Clear();
                textBoxSquare_SVV.Clear();
                textBoxEconomic_SVV.Clear();
                textBoxPopulation_SVV.Clear();
                textBoxNations_SVV.Clear();
                textBoxCurrency_SVV.Clear();
                textBoxContinent_SVV.Clear();
                textBoxLang_SVV.Clear();
                textBoxReligion_SVV.Clear();
                if (File.Exists(filePath))
                {
                    MessageBox.Show($"Файл с именем {countryName} был создан", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDeleteCountry_SVV_Click(object sender, EventArgs e)
        {
            openFileDialog_SVV.ShowDialog();
            openFilePath = openFileDialog_SVV.FileName;
            if (File.Exists(openFilePath))
            {
                File.Delete(openFilePath);
                MessageBox.Show("Файл удален", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSquare_SVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonSearch_SVV_Click(object sender, EventArgs e)
        {
            openFileDialog_SVV.ShowDialog();
            openFilePath = openFileDialog_SVV.FileName;
            textBoxWriteCountry_SVV.Text = Path.GetFileNameWithoutExtension(openFileDialog_SVV.FileName);
            string[,] matrix = ds.GetMatrix(openFilePath);
            int rows = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            dataGridViewInfo_SVV.RowCount = rows;
            dataGridViewInfo_SVV.ColumnCount = column;
            for (int i = 0; i < column; i++)
            {
                dataGridViewInfo_SVV.Columns[i].Width = 130;
            }
            dataGridViewInfo_SVV.RowHeadersWidth = 250;
            dataGridViewInfo_SVV.Rows[0].HeaderCell.Value = "Название страны";
            dataGridViewInfo_SVV.Rows[1].HeaderCell.Value = "Столица";
            dataGridViewInfo_SVV.Rows[2].HeaderCell.Value = "Площадь страны";
            dataGridViewInfo_SVV.Rows[3].HeaderCell.Value = "Экономика";
            dataGridViewInfo_SVV.Rows[4].HeaderCell.Value = "Валюта:";
            dataGridViewInfo_SVV.Rows[5].HeaderCell.Value = "Население :";
            dataGridViewInfo_SVV.Rows[6].HeaderCell.Value = "Национальность:";
            dataGridViewInfo_SVV.Rows[7].HeaderCell.Value = "Язык народа:";
            dataGridViewInfo_SVV.Rows[8].HeaderCell.Value = "Континент:";
            dataGridViewInfo_SVV.Rows[9].HeaderCell.Value = "Религия:";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    dataGridViewInfo_SVV.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonEnterCountry_SVV_Click(object sender, EventArgs e)
        {
            string countryname = textBoxWriteCountry_SVV.Text;
            string filename = $"{countryname}.csv";
            string filePath = Path.Combine("Countries", filename);
            if (File.Exists(filePath))
            {
                string[,] matrix = ds.GetMatrix(filePath);
                int rows = matrix.GetLength(0);
                int column = matrix.GetLength(1);
                dataGridViewInfo_SVV.RowCount = rows;
                dataGridViewInfo_SVV.ColumnCount = column;
                for (int i = 0; i < column; i++)
                {
                    dataGridViewInfo_SVV.Columns[i].Width = 130;
                }
                dataGridViewInfo_SVV.RowHeadersWidth = 250;
                dataGridViewInfo_SVV.Rows[0].HeaderCell.Value = "Название страны:";
                dataGridViewInfo_SVV.Rows[1].HeaderCell.Value = "Столица:";
                dataGridViewInfo_SVV.Rows[2].HeaderCell.Value = "Площадь страны";
                dataGridViewInfo_SVV.Rows[3].HeaderCell.Value = "Экономика";
                dataGridViewInfo_SVV.Rows[4].HeaderCell.Value = "Валюта:";
                dataGridViewInfo_SVV.Rows[5].HeaderCell.Value = "Население:";
                dataGridViewInfo_SVV.Rows[6].HeaderCell.Value = "Национальность:";
                dataGridViewInfo_SVV.Rows[7].HeaderCell.Value = "Язык:";
                dataGridViewInfo_SVV.Rows[8].HeaderCell.Value = "Континент:";
                dataGridViewInfo_SVV.Rows[9].HeaderCell.Value = "Религия:";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        dataGridViewInfo_SVV.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
            }
            else
            {
                MessageBox.Show($"Файл {countryname} не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_SVV_Click(object sender, EventArgs e)
        {
            textBoxCountryName_SVV.Clear();
            textBoxCapital_SVV.Clear();
            textBoxSquare_SVV.Clear();
            textBoxEconomic_SVV.Clear();
            textBoxPopulation_SVV.Clear();
            textBoxNations_SVV.Clear();
            textBoxCurrency_SVV.Clear();
            textBoxContinent_SVV.Clear();
            textBoxLang_SVV.Clear();
            textBoxReligion_SVV.Clear();
        }

        private void buttonInformation_SVV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void groupBoxInPut_SVV_Enter(object sender, EventArgs e)
        {

        }

        private void buttonStatistics_SVV_Click(object sender, EventArgs e)
        {
            FormStatic formStatic = new FormStatic();
            formStatic.ShowDialog();
        }
    }
}
