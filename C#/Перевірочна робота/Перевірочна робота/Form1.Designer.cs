
namespace Перевірочна_робота
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиБінарнийФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.знайтиКількістьПарнихЕлементівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.згенеруватиЕлементиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.знайтиКількістьНулівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1165, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завантажитиToolStripMenuItem,
            this.зберегиToolStripMenuItem,
            this.зберегтиБінарнийФайлToolStripMenuItem,
            this.зToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // завантажитиToolStripMenuItem
            // 
            this.завантажитиToolStripMenuItem.Name = "завантажитиToolStripMenuItem";
            this.завантажитиToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.завантажитиToolStripMenuItem.Text = "завантажити";
            this.завантажитиToolStripMenuItem.Click += new System.EventHandler(this.завантажитиToolStripMenuItem_Click);
            // 
            // зберегиToolStripMenuItem
            // 
            this.зберегиToolStripMenuItem.Name = "зберегиToolStripMenuItem";
            this.зберегиToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.зберегиToolStripMenuItem.Text = "збереги";
            this.зберегиToolStripMenuItem.Click += new System.EventHandler(this.зберегиToolStripMenuItem_Click);
            // 
            // зберегтиБінарнийФайлToolStripMenuItem
            // 
            this.зберегтиБінарнийФайлToolStripMenuItem.Name = "зберегтиБінарнийФайлToolStripMenuItem";
            this.зберегтиБінарнийФайлToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.зберегтиБінарнийФайлToolStripMenuItem.Text = "зберегти бінарний файл";
            this.зберегтиБінарнийФайлToolStripMenuItem.Click += new System.EventHandler(this.зберегтиБінарнийФайлToolStripMenuItem_Click);
            // 
            // зToolStripMenuItem
            // 
            this.зToolStripMenuItem.Name = "зToolStripMenuItem";
            this.зToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.зToolStripMenuItem.Text = "завантажити бінарний файл";
            this.зToolStripMenuItem.Click += new System.EventHandler(this.зToolStripMenuItem_Click);
            // 
            // операціїToolStripMenuItem
            // 
            this.операціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.знайтиКількістьПарнихЕлементівToolStripMenuItem,
            this.згенеруватиЕлементиToolStripMenuItem,
            this.знайтиКількістьНулівToolStripMenuItem});
            this.операціїToolStripMenuItem.Name = "операціїToolStripMenuItem";
            this.операціїToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.операціїToolStripMenuItem.Text = "Операції";
            // 
            // знайтиКількістьПарнихЕлементівToolStripMenuItem
            // 
            this.знайтиКількістьПарнихЕлементівToolStripMenuItem.Name = "знайтиКількістьПарнихЕлементівToolStripMenuItem";
            this.знайтиКількістьПарнихЕлементівToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.знайтиКількістьПарнихЕлементівToolStripMenuItem.Text = "знайти кількість парних елементів";
            this.знайтиКількістьПарнихЕлементівToolStripMenuItem.Click += new System.EventHandler(this.знайтиКількістьПарнихЕлементівToolStripMenuItem_Click);
            // 
            // згенеруватиЕлементиToolStripMenuItem
            // 
            this.згенеруватиЕлементиToolStripMenuItem.Name = "згенеруватиЕлементиToolStripMenuItem";
            this.згенеруватиЕлементиToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.згенеруватиЕлементиToolStripMenuItem.Text = "згенерувати елементи";
            this.згенеруватиЕлементиToolStripMenuItem.Click += new System.EventHandler(this.згенеруватиЕлементиToolStripMenuItem_Click);
            // 
            // знайтиКількістьНулівToolStripMenuItem
            // 
            this.знайтиКількістьНулівToolStripMenuItem.Name = "знайтиКількістьНулівToolStripMenuItem";
            this.знайтиКількістьНулівToolStripMenuItem.Size = new System.Drawing.Size(332, 26);
            this.знайтиКількістьНулівToolStripMenuItem.Text = "знайти кількість нулів";
            this.знайтиКількістьНулівToolStripMenuItem.Click += new System.EventHandler(this.знайтиКількістьНулівToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(100, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(958, 149);
            this.dataGridView1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(370, 77);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кількість рядків та стовпців";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кількість парних елементів";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 596);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 728);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завантажитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem знайтиКількістьПарнихЕлементівToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem згенеруватиЕлементиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem знайтиКількістьНулівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиБінарнийФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зToolStripMenuItem;
    }
}

