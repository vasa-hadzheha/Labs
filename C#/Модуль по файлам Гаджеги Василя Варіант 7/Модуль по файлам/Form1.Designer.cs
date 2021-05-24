
namespace Модуль_по_файлам
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.згенеруватиЕлементиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.знайтиСумуЗаУмовоюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.знайтиСкалярнийДобутокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.побудуватиГрафікToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.визначитиЧиФункціяЄВємноВизначеноюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Rows = new System.Windows.Forms.NumericUpDown();
            this.Columns = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.операціїToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1242, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завантажитиToolStripMenuItem,
            this.зберегтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // завантажитиToolStripMenuItem
            // 
            this.завантажитиToolStripMenuItem.Name = "завантажитиToolStripMenuItem";
            this.завантажитиToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.завантажитиToolStripMenuItem.Text = "завантажити";
            this.завантажитиToolStripMenuItem.Click += new System.EventHandler(this.завантажитиToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.зберегтиToolStripMenuItem.Text = "зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // операціїToolStripMenuItem
            // 
            this.операціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.згенеруватиЕлементиToolStripMenuItem,
            this.знайтиСумуЗаУмовоюToolStripMenuItem,
            this.знайтиСкалярнийДобутокToolStripMenuItem,
            this.побудуватиГрафікToolStripMenuItem});
            this.операціїToolStripMenuItem.Name = "операціїToolStripMenuItem";
            this.операціїToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.операціїToolStripMenuItem.Text = "Операції";
            // 
            // згенеруватиЕлементиToolStripMenuItem
            // 
            this.згенеруватиЕлементиToolStripMenuItem.Name = "згенеруватиЕлементиToolStripMenuItem";
            this.згенеруватиЕлементиToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.згенеруватиЕлементиToolStripMenuItem.Text = "згенерувати елементи";
            this.згенеруватиЕлементиToolStripMenuItem.Click += new System.EventHandler(this.згенеруватиЕлементиToolStripMenuItem_Click);
            // 
            // знайтиСумуЗаУмовоюToolStripMenuItem
            // 
            this.знайтиСумуЗаУмовоюToolStripMenuItem.Name = "знайтиСумуЗаУмовоюToolStripMenuItem";
            this.знайтиСумуЗаУмовоюToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.знайтиСумуЗаУмовоюToolStripMenuItem.Text = "знайти суму за умовою";
            this.знайтиСумуЗаУмовоюToolStripMenuItem.Click += new System.EventHandler(this.знайтиСумуЗаУмовоюToolStripMenuItem_Click);
            // 
            // знайтиСкалярнийДобутокToolStripMenuItem
            // 
            this.знайтиСкалярнийДобутокToolStripMenuItem.Name = "знайтиСкалярнийДобутокToolStripMenuItem";
            this.знайтиСкалярнийДобутокToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.знайтиСкалярнийДобутокToolStripMenuItem.Text = "знайти скалярний добуток";
            this.знайтиСкалярнийДобутокToolStripMenuItem.Click += new System.EventHandler(this.знайтиСкалярнийДобутокToolStripMenuItem_Click);
            // 
            // побудуватиГрафікToolStripMenuItem
            // 
            this.побудуватиГрафікToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.визначитиЧиФункціяЄВємноВизначеноюToolStripMenuItem});
            this.побудуватиГрафікToolStripMenuItem.Name = "побудуватиГрафікToolStripMenuItem";
            this.побудуватиГрафікToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.побудуватиГрафікToolStripMenuItem.Text = "побудувати графік";
            this.побудуватиГрафікToolStripMenuItem.Click += new System.EventHandler(this.побудуватиГрафікToolStripMenuItem_Click);
            // 
            // визначитиЧиФункціяЄВємноВизначеноюToolStripMenuItem
            // 
            this.визначитиЧиФункціяЄВємноВизначеноюToolStripMenuItem.Name = "визначитиЧиФункціяЄВємноВизначеноюToolStripMenuItem";
            this.визначитиЧиФункціяЄВємноВизначеноюToolStripMenuItem.Size = new System.Drawing.Size(413, 26);
            this.визначитиЧиФункціяЄВємноВизначеноюToolStripMenuItem.Text = "визначити чи функція є від\'ємно визначеною ";
            this.визначитиЧиФункціяЄВємноВизначеноюToolStripMenuItem.Click += new System.EventHandler(this.визначитиЧиФункціяЄВємноВизначеноюToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(129, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 105);
            this.dataGridView1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Rows
            // 
            this.Rows.Location = new System.Drawing.Point(288, 46);
            this.Rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(120, 22);
            this.Rows.TabIndex = 2;
            this.Rows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Rows.ValueChanged += new System.EventHandler(this.Rows_ValueChanged);
            // 
            // Columns
            // 
            this.Columns.Location = new System.Drawing.Point(288, 98);
            this.Columns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(120, 22);
            this.Columns.TabIndex = 3;
            this.Columns.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Columns.ValueChanged += new System.EventHandler(this.Columns_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кількість рядків";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Кількість стовпців";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сума за умовою";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 456);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(830, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(830, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Задає координати проміжка та номер i-го рядка ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Задає координати проміжка та номер j-го стовпця";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Скалярний добуток";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(674, 456);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 13;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(819, 243);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(411, 300);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 697);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завантажитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem згенеруватиЕлементиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem знайтиСумуЗаУмовоюToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown Rows;
        private System.Windows.Forms.NumericUpDown Columns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem знайтиСкалярнийДобутокToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ToolStripMenuItem побудуватиГрафікToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem визначитиЧиФункціяЄВємноВизначеноюToolStripMenuItem;
    }
}

