using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Tyuiu.SafronovVV.Sprint7.Project.V13.Lib;

namespace Tyuiu.SafronovVV.Sprint7.Project.V13
{
    public partial class FormStatic : Form
    {
        public FormStatic()
        {
            InitializeComponent();
        }
        public string openFilePath;
        DataService ds = new DataService();
        public string FolderContr = @"C:\Users\Black_Reaper\source\repos\Tyuiu.SafronovVV.Sprint7\Tyuiu.SafronovVV.Sprint7.Project.V13\bin\Debug\Countries";
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

        private void buttonEnter_SVV_Click(object sender, EventArgs e)
        {
            chartDiag_SVV.Series[0].Points.AddXY(Convert.ToDouble(textBoxSquare_SVV.Text), Convert.ToDouble(textBoxPopulation_SVV.Text));
        }
    }
}
