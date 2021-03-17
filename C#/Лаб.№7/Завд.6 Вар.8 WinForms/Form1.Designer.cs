
namespace Завд._6_Вар._8_WinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rowCount = new System.Windows.Forms.NumericUpDown();
            this.columnCount = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатиЕлементиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.знайтиСумуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.matrix = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnCount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість рядків";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кількість стовпців";
            // 
            // rowCount
            // 
            this.rowCount.Location = new System.Drawing.Point(296, 53);
            this.rowCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowCount.Name = "rowCount";
            this.rowCount.Size = new System.Drawing.Size(99, 22);
            this.rowCount.TabIndex = 2;
            this.rowCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowCount.ValueChanged += new System.EventHandler(this.rowCount_ValueChanged);
            // 
            // columnCount
            // 
            this.columnCount.Location = new System.Drawing.Point(296, 97);
            this.columnCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnCount.Name = "columnCount";
            this.columnCount.Size = new System.Drawing.Size(99, 22);
            this.columnCount.TabIndex = 3;
            this.columnCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnCount.ValueChanged += new System.EventHandler(this.columnCount_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опціїToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // опціїToolStripMenuItem
            // 
            this.опціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатиЕлементиToolStripMenuItem,
            this.знайтиСумуToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.опціїToolStripMenuItem.Name = "опціїToolStripMenuItem";
            this.опціїToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.опціїToolStripMenuItem.Text = "Опції";
            // 
            // задатиЕлементиToolStripMenuItem
            // 
            this.задатиЕлементиToolStripMenuItem.Name = "задатиЕлементиToolStripMenuItem";
            this.задатиЕлементиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.задатиЕлементиToolStripMenuItem.Text = "Задати елементи ";
            this.задатиЕлементиToolStripMenuItem.Click += new System.EventHandler(this.задатиЕлементиToolStripMenuItem_Click);
            // 
            // знайтиСумуToolStripMenuItem
            // 
            this.знайтиСумуToolStripMenuItem.Name = "знайтиСумуToolStripMenuItem";
            this.знайтиСумуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.знайтиСумуToolStripMenuItem.Text = "Знайти суму ";
            this.знайтиСумуToolStripMenuItem.Click += new System.EventHandler(this.знайтиСумуToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Знайти суму елементів в тих стовпцях,\r\n які містять хоча б один від’ємний елемент" +
    " такі k,\r\n що k-й рядок матриці співпадає з k-м стовбцем";
            // 
            // matrix
            // 
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.Location = new System.Drawing.Point(140, 169);
            this.matrix.Name = "matrix";
            this.matrix.RowHeadersWidth = 51;
            this.matrix.RowTemplate.Height = 24;
            this.matrix.Size = new System.Drawing.Size(625, 210);
            this.matrix.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 7;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 18);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.columnCount);
            this.Controls.Add(this.rowCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnCount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown rowCount;
        private System.Windows.Forms.NumericUpDown columnCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem опціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатиЕлементиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem знайтиСумуToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
    }
}

