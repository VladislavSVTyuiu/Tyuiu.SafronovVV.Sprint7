
namespace Tyuiu.SafronovVV.Sprint7.Project.V13
{
    partial class FormStatic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewInfo_SVV = new System.Windows.Forms.DataGridView();
            this.buttonSearch_SVV = new System.Windows.Forms.Button();
            this.textBoxWriteCountry_SVV = new System.Windows.Forms.TextBox();
            this.openFileDialog_SVV = new System.Windows.Forms.OpenFileDialog();
            this.buttonEnter_SVV = new System.Windows.Forms.Button();
            this.chartDiag_SVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxSquare_SVV = new System.Windows.Forms.TextBox();
            this.textBoxPopulation_SVV = new System.Windows.Forms.TextBox();
            this.labelSquare_SVV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo_SVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SVV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInfo_SVV
            // 
            this.dataGridViewInfo_SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo_SVV.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewInfo_SVV.Name = "dataGridViewInfo_SVV";
            this.dataGridViewInfo_SVV.Size = new System.Drawing.Size(376, 302);
            this.dataGridViewInfo_SVV.TabIndex = 0;
            // 
            // buttonSearch_SVV
            // 
            this.buttonSearch_SVV.Location = new System.Drawing.Point(287, 326);
            this.buttonSearch_SVV.Name = "buttonSearch_SVV";
            this.buttonSearch_SVV.Size = new System.Drawing.Size(101, 40);
            this.buttonSearch_SVV.TabIndex = 1;
            this.buttonSearch_SVV.Text = "Найти";
            this.buttonSearch_SVV.UseVisualStyleBackColor = true;
            this.buttonSearch_SVV.Click += new System.EventHandler(this.buttonSearch_SVV_Click);
            // 
            // textBoxWriteCountry_SVV
            // 
            this.textBoxWriteCountry_SVV.Location = new System.Drawing.Point(181, 337);
            this.textBoxWriteCountry_SVV.Name = "textBoxWriteCountry_SVV";
            this.textBoxWriteCountry_SVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxWriteCountry_SVV.TabIndex = 2;
            // 
            // openFileDialog_SVV
            // 
            this.openFileDialog_SVV.FileName = "openFileDialog1";
            // 
            // buttonEnter_SVV
            // 
            this.buttonEnter_SVV.Location = new System.Drawing.Point(732, 326);
            this.buttonEnter_SVV.Name = "buttonEnter_SVV";
            this.buttonEnter_SVV.Size = new System.Drawing.Size(101, 40);
            this.buttonEnter_SVV.TabIndex = 3;
            this.buttonEnter_SVV.Text = "Выполнить";
            this.buttonEnter_SVV.UseVisualStyleBackColor = true;
            this.buttonEnter_SVV.Click += new System.EventHandler(this.buttonEnter_SVV_Click);
            // 
            // chartDiag_SVV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDiag_SVV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDiag_SVV.Legends.Add(legend1);
            this.chartDiag_SVV.Location = new System.Drawing.Point(394, 12);
            this.chartDiag_SVV.Name = "chartDiag_SVV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag_SVV.Series.Add(series1);
            this.chartDiag_SVV.Size = new System.Drawing.Size(439, 300);
            this.chartDiag_SVV.TabIndex = 4;
            this.chartDiag_SVV.Text = "chart1";
            // 
            // textBoxSquare_SVV
            // 
            this.textBoxSquare_SVV.Location = new System.Drawing.Point(468, 337);
            this.textBoxSquare_SVV.Name = "textBoxSquare_SVV";
            this.textBoxSquare_SVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxSquare_SVV.TabIndex = 5;
            // 
            // textBoxPopulation_SVV
            // 
            this.textBoxPopulation_SVV.Location = new System.Drawing.Point(588, 337);
            this.textBoxPopulation_SVV.Name = "textBoxPopulation_SVV";
            this.textBoxPopulation_SVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxPopulation_SVV.TabIndex = 6;
            // 
            // labelSquare_SVV
            // 
            this.labelSquare_SVV.AutoSize = true;
            this.labelSquare_SVV.Location = new System.Drawing.Point(465, 321);
            this.labelSquare_SVV.Name = "labelSquare_SVV";
            this.labelSquare_SVV.Size = new System.Drawing.Size(97, 13);
            this.labelSquare_SVV.TabIndex = 7;
            this.labelSquare_SVV.Text = "Площадь страны:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Население:";
            // 
            // FormStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSquare_SVV);
            this.Controls.Add(this.textBoxPopulation_SVV);
            this.Controls.Add(this.textBoxSquare_SVV);
            this.Controls.Add(this.chartDiag_SVV);
            this.Controls.Add(this.buttonEnter_SVV);
            this.Controls.Add(this.textBoxWriteCountry_SVV);
            this.Controls.Add(this.buttonSearch_SVV);
            this.Controls.Add(this.dataGridViewInfo_SVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика стран";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo_SVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SVV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInfo_SVV;
        private System.Windows.Forms.Button buttonSearch_SVV;
        private System.Windows.Forms.TextBox textBoxWriteCountry_SVV;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SVV;
        private System.Windows.Forms.Button buttonEnter_SVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SVV;
        private System.Windows.Forms.TextBox textBoxSquare_SVV;
        private System.Windows.Forms.TextBox textBoxPopulation_SVV;
        private System.Windows.Forms.Label labelSquare_SVV;
        private System.Windows.Forms.Label label1;
    }
}