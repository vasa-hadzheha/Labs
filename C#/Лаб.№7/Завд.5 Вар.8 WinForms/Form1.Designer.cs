
namespace Завд._5_Вар._8_WinForms
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.опціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.згенеруватиЕлементиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатиХарактеристикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посортуватиСтовпціЗаХарактеристикоюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowCount = new System.Windows.Forms.NumericUpDown();
            this.columnCount = new System.Windows.Forms.NumericUpDown();
            this.lable1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.matrix = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.characteristic = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characteristic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1146, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опціїToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1146, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // опціїToolStripMenuItem
            // 
            this.опціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.згенеруватиЕлементиToolStripMenuItem,
            this.задатиХарактеристикиToolStripMenuItem,
            this.посортуватиСтовпціЗаХарактеристикоюToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.опціїToolStripMenuItem.Name = "опціїToolStripMenuItem";
            this.опціїToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.опціїToolStripMenuItem.Text = "Опції";
            // 
            // згенеруватиЕлементиToolStripMenuItem
            // 
            this.згенеруватиЕлементиToolStripMenuItem.Name = "згенеруватиЕлементиToolStripMenuItem";
            this.згенеруватиЕлементиToolStripMenuItem.Size = new System.Drawing.Size(381, 26);
            this.згенеруватиЕлементиToolStripMenuItem.Text = "Згенерувати елементи";
            this.згенеруватиЕлементиToolStripMenuItem.Click += new System.EventHandler(this.згенеруватиЕлементиToolStripMenuItem_Click);
            // 
            // задатиХарактеристикиToolStripMenuItem
            // 
            this.задатиХарактеристикиToolStripMenuItem.Name = "задатиХарактеристикиToolStripMenuItem";
            this.задатиХарактеристикиToolStripMenuItem.Size = new System.Drawing.Size(381, 26);
            this.задатиХарактеристикиToolStripMenuItem.Text = "Задати характеристики";
            this.задатиХарактеристикиToolStripMenuItem.Click += new System.EventHandler(this.задатиХарактеристикиToolStripMenuItem_Click);
            // 
            // посортуватиСтовпціЗаХарактеристикоюToolStripMenuItem
            // 
            this.посортуватиСтовпціЗаХарактеристикоюToolStripMenuItem.Name = "посортуватиСтовпціЗаХарактеристикоюToolStripMenuItem";
            this.посортуватиСтовпціЗаХарактеристикоюToolStripMenuItem.Size = new System.Drawing.Size(381, 26);
            this.посортуватиСтовпціЗаХарактеристикоюToolStripMenuItem.Text = "Посортувати стовпці за характеристикою";
            this.посортуватиСтовпціЗаХарактеристикоюToolStripMenuItem.Click += new System.EventHandler(this.посортуватиСтовпціЗаХарактеристикоюToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(381, 26);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // rowCount
            // 
            this.rowCount.Location = new System.Drawing.Point(187, 55);
            this.rowCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowCount.Name = "rowCount";
            this.rowCount.Size = new System.Drawing.Size(120, 22);
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
            this.columnCount.Location = new System.Drawing.Point(187, 105);
            this.columnCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnCount.Name = "columnCount";
            this.columnCount.Size = new System.Drawing.Size(120, 22);
            this.columnCount.TabIndex = 3;
            this.columnCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnCount.ValueChanged += new System.EventHandler(this.columnCount_ValueChanged);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(40, 55);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(111, 17);
            this.lable1.TabIndex = 4;
            this.lable1.Text = "Кількість рядків";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(40, 110);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(125, 17);
            this.lable2.TabIndex = 5;
            this.lable2.Text = "Кількість стовпців";
            // 
            // matrix
            // 
            this.matrix.AllowUserToOrderColumns = true;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.ColumnHeadersVisible = false;
            this.matrix.Location = new System.Drawing.Point(110, 331);
            this.matrix.Name = "matrix";
            this.matrix.RowHeadersVisible = false;
            this.matrix.RowHeadersWidth = 51;
            this.matrix.RowTemplate.Height = 24;
            this.matrix.Size = new System.Drawing.Size(738, 217);
            this.matrix.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 675);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1146, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // characteristic
            // 
            this.characteristic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.characteristic.ColumnHeadersVisible = false;
            this.characteristic.Location = new System.Drawing.Point(97, 570);
            this.characteristic.Name = "characteristic";
            this.characteristic.RowHeadersVisible = false;
            this.characteristic.RowHeadersWidth = 51;
            this.characteristic.RowTemplate.Height = 24;
            this.characteristic.Size = new System.Drawing.Size(737, 81);
            this.characteristic.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 282);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 701);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.characteristic);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.columnCount);
            this.Controls.Add(this.rowCount);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characteristic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem опціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem згенеруватиЕлементиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатиХарактеристикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посортуватиСтовпціЗаХарактеристикоюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown rowCount;
        private System.Windows.Forms.NumericUpDown columnCount;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView characteristic;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

