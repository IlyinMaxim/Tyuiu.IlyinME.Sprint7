﻿
namespace Tyuiu.IlyinME.Sprint7.Project.V4
{
    partial class FormStats
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStats));
            this.panelUpStats_IME = new System.Windows.Forms.Panel();
            this.panelAllStats_IME = new System.Windows.Forms.Panel();
            this.dataGridViewBooks_IME = new System.Windows.Forms.DataGridView();
            this.panelChart2_IME = new System.Windows.Forms.Panel();
            this.chartMaxMinAvg_IME = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelChatr1_IME = new System.Windows.Forms.Panel();
            this.chartPrice_IME = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialogTask_IME = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_IME = new System.Windows.Forms.ToolTip(this.components);
            this.buttonChart2_IME = new System.Windows.Forms.Button();
            this.buttonChart1_IME = new System.Windows.Forms.Button();
            this.buttonDone_IME = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelUpStats_IME.SuspendLayout();
            this.panelAllStats_IME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks_IME)).BeginInit();
            this.panelChart2_IME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxMinAvg_IME)).BeginInit();
            this.panelChatr1_IME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice_IME)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUpStats_IME
            // 
            this.panelUpStats_IME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelUpStats_IME.Controls.Add(this.buttonChart2_IME);
            this.panelUpStats_IME.Controls.Add(this.buttonChart1_IME);
            this.panelUpStats_IME.Controls.Add(this.buttonDone_IME);
            this.panelUpStats_IME.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpStats_IME.Location = new System.Drawing.Point(0, 0);
            this.panelUpStats_IME.Name = "panelUpStats_IME";
            this.panelUpStats_IME.Size = new System.Drawing.Size(1451, 100);
            this.panelUpStats_IME.TabIndex = 0;
            this.panelUpStats_IME.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUpStats_IME_MouseDown);
            this.panelUpStats_IME.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUpStats_IME_MouseMove);
            // 
            // panelAllStats_IME
            // 
            this.panelAllStats_IME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelAllStats_IME.Controls.Add(this.dataGridViewBooks_IME);
            this.panelAllStats_IME.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAllStats_IME.Location = new System.Drawing.Point(0, 100);
            this.panelAllStats_IME.Name = "panelAllStats_IME";
            this.panelAllStats_IME.Size = new System.Drawing.Size(554, 466);
            this.panelAllStats_IME.TabIndex = 1;
            this.panelAllStats_IME.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAllStats_IME_MouseDown);
            this.panelAllStats_IME.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAllStats_IME_MouseMove);
            // 
            // dataGridViewBooks_IME
            // 
            this.dataGridViewBooks_IME.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewBooks_IME.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewBooks_IME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks_IME.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewBooks_IME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBooks_IME.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBooks_IME.Name = "dataGridViewBooks_IME";
            this.dataGridViewBooks_IME.ReadOnly = true;
            this.dataGridViewBooks_IME.RowHeadersVisible = false;
            this.dataGridViewBooks_IME.Size = new System.Drawing.Size(554, 466);
            this.dataGridViewBooks_IME.TabIndex = 0;
            this.dataGridViewBooks_IME.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewBooks_IME_MouseDown);
            this.dataGridViewBooks_IME.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridViewBooks_IME_MouseMove);
            // 
            // panelChart2_IME
            // 
            this.panelChart2_IME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelChart2_IME.Controls.Add(this.chartMaxMinAvg_IME);
            this.panelChart2_IME.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelChart2_IME.Location = new System.Drawing.Point(1022, 100);
            this.panelChart2_IME.Name = "panelChart2_IME";
            this.panelChart2_IME.Size = new System.Drawing.Size(429, 466);
            this.panelChart2_IME.TabIndex = 2;
            this.panelChart2_IME.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelChart2_IME_MouseDown);
            this.panelChart2_IME.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelChart2_IME_MouseMove);
            // 
            // chartMaxMinAvg_IME
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMaxMinAvg_IME.ChartAreas.Add(chartArea1);
            this.chartMaxMinAvg_IME.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartMaxMinAvg_IME.Legends.Add(legend1);
            this.chartMaxMinAvg_IME.Location = new System.Drawing.Point(0, 0);
            this.chartMaxMinAvg_IME.Name = "chartMaxMinAvg_IME";
            this.chartMaxMinAvg_IME.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMaxMinAvg_IME.Series.Add(series1);
            this.chartMaxMinAvg_IME.Size = new System.Drawing.Size(429, 466);
            this.chartMaxMinAvg_IME.TabIndex = 0;
            this.chartMaxMinAvg_IME.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            title1.Name = "Title1";
            title1.Text = "Max, min и средняя цена";
            this.chartMaxMinAvg_IME.Titles.Add(title1);
            this.chartMaxMinAvg_IME.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chartMaxMinAvg_IME_MouseDown);
            this.chartMaxMinAvg_IME.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartMaxMinAvg_IME_MouseMove);
            // 
            // panelChatr1_IME
            // 
            this.panelChatr1_IME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelChatr1_IME.Controls.Add(this.chartPrice_IME);
            this.panelChatr1_IME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChatr1_IME.Location = new System.Drawing.Point(554, 100);
            this.panelChatr1_IME.Name = "panelChatr1_IME";
            this.panelChatr1_IME.Size = new System.Drawing.Size(468, 466);
            this.panelChatr1_IME.TabIndex = 3;
            this.panelChatr1_IME.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelChatr1_IME_MouseDown);
            this.panelChatr1_IME.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelChatr1_IME_MouseMove);
            // 
            // chartPrice_IME
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPrice_IME.ChartAreas.Add(chartArea2);
            this.chartPrice_IME.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartPrice_IME.Legends.Add(legend2);
            this.chartPrice_IME.Location = new System.Drawing.Point(0, 0);
            this.chartPrice_IME.Name = "chartPrice_IME";
            this.chartPrice_IME.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPrice_IME.Series.Add(series2);
            this.chartPrice_IME.Size = new System.Drawing.Size(468, 466);
            this.chartPrice_IME.TabIndex = 0;
            this.chartPrice_IME.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            title2.ForeColor = System.Drawing.Color.Green;
            title2.Name = "Title1";
            title2.Text = "Название книги и её цена";
            this.chartPrice_IME.Titles.Add(title2);
            this.chartPrice_IME.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chartPrice_IME_MouseDown);
            this.chartPrice_IME.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartPrice_IME_MouseMove);
            // 
            // openFileDialogTask_IME
            // 
            this.openFileDialogTask_IME.FileName = "openFileDialog1";
            // 
            // toolTipButton_IME
            // 
            this.toolTipButton_IME.IsBalloon = true;
            this.toolTipButton_IME.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_IME.ToolTipTitle = "Подсказка";
            // 
            // buttonChart2_IME
            // 
            this.buttonChart2_IME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonChart2_IME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChart2_IME.FlatAppearance.BorderSize = 0;
            this.buttonChart2_IME.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonChart2_IME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChart2_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChart2_IME.Image = global::Tyuiu.IlyinME.Sprint7.Project.V4.Properties.Resources.Chartmaxminavg;
            this.buttonChart2_IME.Location = new System.Drawing.Point(291, 3);
            this.buttonChart2_IME.Name = "buttonChart2_IME";
            this.buttonChart2_IME.Size = new System.Drawing.Size(110, 95);
            this.buttonChart2_IME.TabIndex = 1;
            this.toolTipButton_IME.SetToolTip(this.buttonChart2_IME, "Создает график \"Max, min и средняя цена\"\r\nИспоьлуя данные из таблицы -_-\r\n");
            this.buttonChart2_IME.UseVisualStyleBackColor = false;
            this.buttonChart2_IME.Click += new System.EventHandler(this.buttonChart2_IME_Click);
            this.buttonChart2_IME.MouseEnter += new System.EventHandler(this.buttonChart2_IME_MouseEnter);
            // 
            // buttonChart1_IME
            // 
            this.buttonChart1_IME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonChart1_IME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChart1_IME.FlatAppearance.BorderSize = 0;
            this.buttonChart1_IME.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonChart1_IME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChart1_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChart1_IME.Image = global::Tyuiu.IlyinME.Sprint7.Project.V4.Properties.Resources.ChartnamePrice;
            this.buttonChart1_IME.Location = new System.Drawing.Point(142, 4);
            this.buttonChart1_IME.Name = "buttonChart1_IME";
            this.buttonChart1_IME.Size = new System.Drawing.Size(115, 94);
            this.buttonChart1_IME.TabIndex = 1;
            this.toolTipButton_IME.SetToolTip(this.buttonChart1_IME, "Создает график \"Название книги и её цена\"\r\nИспоьлуя данные из таблицы :)");
            this.buttonChart1_IME.UseVisualStyleBackColor = false;
            this.buttonChart1_IME.Click += new System.EventHandler(this.buttonChart1_IME_Click);
            this.buttonChart1_IME.MouseEnter += new System.EventHandler(this.buttonChart1_IME_MouseEnter);
            // 
            // buttonDone_IME
            // 
            this.buttonDone_IME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDone_IME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_IME.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDone_IME.FlatAppearance.BorderSize = 0;
            this.buttonDone_IME.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDone_IME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_IME.ForeColor = System.Drawing.Color.White;
            this.buttonDone_IME.Image = global::Tyuiu.IlyinME.Sprint7.Project.V4.Properties.Resources.table;
            this.buttonDone_IME.Location = new System.Drawing.Point(3, 4);
            this.buttonDone_IME.Name = "buttonDone_IME";
            this.buttonDone_IME.Size = new System.Drawing.Size(102, 93);
            this.buttonDone_IME.TabIndex = 0;
            this.toolTipButton_IME.SetToolTip(this.buttonDone_IME, "Выводит данные из файла в таблицу\r\n");
            this.buttonDone_IME.UseVisualStyleBackColor = false;
            this.buttonDone_IME.Click += new System.EventHandler(this.buttonDone_IME_Click);
            this.buttonDone_IME.MouseEnter += new System.EventHandler(this.buttonDone_IME_MouseEnter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Автор";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 62;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 82;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Год";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Цена ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 61;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Издание";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 76;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Аннотация";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 86;
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 566);
            this.Controls.Add(this.panelChatr1_IME);
            this.Controls.Add(this.panelChart2_IME);
            this.Controls.Add(this.panelAllStats_IME);
            this.Controls.Add(this.panelUpStats_IME);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.panelUpStats_IME.ResumeLayout(false);
            this.panelAllStats_IME.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks_IME)).EndInit();
            this.panelChart2_IME.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxMinAvg_IME)).EndInit();
            this.panelChatr1_IME.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice_IME)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpStats_IME;
        private System.Windows.Forms.Button buttonChart2_IME;
        private System.Windows.Forms.Button buttonChart1_IME;
        private System.Windows.Forms.Button buttonDone_IME;
        private System.Windows.Forms.Panel panelAllStats_IME;
        private System.Windows.Forms.Panel panelChart2_IME;
        private System.Windows.Forms.Panel panelChatr1_IME;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_IME;
        private System.Windows.Forms.ToolTip toolTipButton_IME;
        private System.Windows.Forms.DataGridView dataGridViewBooks_IME;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrice_IME;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMaxMinAvg_IME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}