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
using Tyuiu.IlyinME.Sprint7.Project.V4.Lib;

namespace Tyuiu.IlyinME.Sprint7.Project.V4
{
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();
            openFileDialogTask_IME.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            //saveFileDialogMatrix_IME.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFilePath;
        DataService ds = new DataService();
        static string[,] array;
        Point lastPoint;
        private void panelUpStats_IME_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelUpStats_IME_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelAllStats_IME_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelAllStats_IME_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelChatr1_IME_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelChatr1_IME_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelChart2_IME_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelChart2_IME_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void buttonDone_IME_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_IME.ShowDialog();
                openFilePath = openFileDialogTask_IME.FileName;
                array = ds.LoadFromFileData(openFilePath);
                int rows = array.GetUpperBound(0) + 1;
                int columns = array.Length / rows;

                dataGridViewBooks_IME.ColumnCount = columns;
                dataGridViewBooks_IME.RowCount = rows;

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        if (int.TryParse(array[r, c], out int n))
                        {
                            dataGridViewBooks_IME.Rows[r].Cells[c].Value = n;
                        }
                        else
                        {
                            dataGridViewBooks_IME.Rows[r].Cells[c].Value = array[r, c];
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChart1_IME_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewBooks_IME.RowCount; i++)
                {
                    string xValue = dataGridViewBooks_IME.Rows[i].Cells[1].Value.ToString();
                    int yValue = Convert.ToInt32(dataGridViewBooks_IME.Rows[i].Cells[3].Value);
                    // Добавляем данные в график
                    chartPrice_IME.Series[0].Points.AddXY(xValue, yValue);
                }
                // Обновляем график
                chartPrice_IME.Update();
            
            }
            catch
            {
                MessageBox.Show("Выведите таблицу!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChart2_IME_Click(object sender, EventArgs e)
        {
            int columnIndex = 3;
            int maxCellValue = int.MinValue;
            int minCellValue = int.MaxValue;
            double sum = 0;
            int count = 0;
            foreach (DataGridViewRow row in dataGridViewBooks_IME.Rows)
            {
                int cellValue = Convert.ToInt32(row.Cells[columnIndex].Value);

                if (cellValue > maxCellValue)
                {
                    maxCellValue = cellValue;
                }
                if (cellValue < minCellValue)
                {
                    minCellValue = cellValue;
                }
                if (row.Cells[columnIndex].Value != null)
                {
                    double cellValueDouble;
                    if (double.TryParse(row.Cells[columnIndex].Value.ToString(), out cellValueDouble))
                    {
                        sum += cellValueDouble;
                        count++;
                    }
                }
            }

            double average = sum / count;
            int xValue = maxCellValue;
            int yValue = minCellValue;
            double zValue = average;
            // Добавляем данные в график
            chartMaxMinAvg_IME.Series[0].Points.AddXY("Max(700)", maxCellValue);
            chartMaxMinAvg_IME.Series[0].Points.AddXY("Min(200)", minCellValue);
            chartMaxMinAvg_IME.Series[0].Points.AddXY("Avg(400)", average);
            
            // Обновляем график
            chartMaxMinAvg_IME.Update();
        }

        private void buttonDone_IME_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_IME.ToolTipTitle = "Вывод таблицы";
        }

        private void buttonChart1_IME_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_IME.ToolTipTitle = "График цена и название";
        }

        private void buttonChart2_IME_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_IME.ToolTipTitle = "График max, min и avg цена";
        }
    }
}
