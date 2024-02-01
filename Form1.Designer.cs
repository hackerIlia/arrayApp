namespace Lab_7_arrays
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelPosEl = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelMinValue = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonFindElement = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.buttonSum = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButtonDecrease = new System.Windows.Forms.RadioButton();
            this.radioButtonIncrease = new System.Windows.Forms.RadioButton();
            this.buttonAddColumn = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            this.buttonMaxRow = new System.Windows.Forms.Button();
            this.buttonMultiple = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labelMultiple = new System.Windows.Forms.Label();
            this.buttonCreateMatrix = new System.Windows.Forms.Button();
            this.labelNumColumns = new System.Windows.Forms.Label();
            this.labelNumRows = new System.Windows.Forms.Label();
            this.numericUpDown2Columns = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2Rows = new System.Windows.Forms.NumericUpDown();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelPosEl);
            this.tabPage1.Controls.Add(this.labelCount);
            this.tabPage1.Controls.Add(this.labelMinValue);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.buttonFindElement);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.labelSum);
            this.tabPage1.Controls.Add(this.buttonSum);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Одномерные массивы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelPosEl
            // 
            this.labelPosEl.AutoSize = true;
            this.labelPosEl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPosEl.Location = new System.Drawing.Point(184, 350);
            this.labelPosEl.Name = "labelPosEl";
            this.labelPosEl.Size = new System.Drawing.Size(136, 28);
            this.labelPosEl.TabIndex = 12;
            this.labelPosEl.Text = "Позиция эл-а";
            this.labelPosEl.Visible = false;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCount.Location = new System.Drawing.Point(184, 260);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(78, 28);
            this.labelCount.TabIndex = 11;
            this.labelCount.Text = "Кол-во";
            this.labelCount.Visible = false;
            // 
            // labelMinValue
            // 
            this.labelMinValue.AutoSize = true;
            this.labelMinValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinValue.Location = new System.Drawing.Point(184, 215);
            this.labelMinValue.Name = "labelMinValue";
            this.labelMinValue.Size = new System.Drawing.Size(87, 28);
            this.labelMinValue.TabIndex = 10;
            this.labelMinValue.Text = "Мин. эл.";
            this.labelMinValue.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PeachPuff;
            this.button5.Location = new System.Drawing.Point(4, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 39);
            this.button5.TabIndex = 9;
            this.button5.Text = "Кол-во 0,>0,<0";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonAdd.Location = new System.Drawing.Point(3, 303);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(154, 39);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить элемент";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonFindElement
            // 
            this.buttonFindElement.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonFindElement.Location = new System.Drawing.Point(3, 348);
            this.buttonFindElement.Name = "buttonFindElement";
            this.buttonFindElement.Size = new System.Drawing.Size(154, 39);
            this.buttonFindElement.TabIndex = 7;
            this.buttonFindElement.Text = "Найти элемент";
            this.buttonFindElement.UseVisualStyleBackColor = false;
            this.buttonFindElement.Click += new System.EventHandler(this.buttonFindElement_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Location = new System.Drawing.Point(3, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Миним. элем-т";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSum.Location = new System.Drawing.Point(184, 170);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(72, 28);
            this.labelSum.TabIndex = 5;
            this.labelSum.Text = "Сумма";
            this.labelSum.Visible = false;
            // 
            // buttonSum
            // 
            this.buttonSum.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonSum.Location = new System.Drawing.Point(4, 168);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(154, 39);
            this.buttonSum.TabIndex = 4;
            this.buttonSum.Text = "Сумма эл-ов";
            this.buttonSum.UseVisualStyleBackColor = false;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(272, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Создать массив";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "n=";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(43, 114);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(756, 95);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButtonDecrease);
            this.tabPage2.Controls.Add(this.radioButtonIncrease);
            this.tabPage2.Controls.Add(this.buttonAddColumn);
            this.tabPage2.Controls.Add(this.buttonSort);
            this.tabPage2.Controls.Add(this.buttonDeleteRow);
            this.tabPage2.Controls.Add(this.buttonMaxRow);
            this.tabPage2.Controls.Add(this.buttonMultiple);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.labelMultiple);
            this.tabPage2.Controls.Add(this.buttonCreateMatrix);
            this.tabPage2.Controls.Add(this.labelNumColumns);
            this.tabPage2.Controls.Add(this.labelNumRows);
            this.tabPage2.Controls.Add(this.numericUpDown2Columns);
            this.tabPage2.Controls.Add(this.numericUpDown2Rows);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Матрицы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButtonDecrease
            // 
            this.radioButtonDecrease.AutoSize = true;
            this.radioButtonDecrease.Location = new System.Drawing.Point(645, 358);
            this.radioButtonDecrease.Name = "radioButtonDecrease";
            this.radioButtonDecrease.Size = new System.Drawing.Size(117, 24);
            this.radioButtonDecrease.TabIndex = 15;
            this.radioButtonDecrease.Text = "Убывающий";
            this.radioButtonDecrease.UseVisualStyleBackColor = true;
            // 
            // radioButtonIncrease
            // 
            this.radioButtonIncrease.AutoSize = true;
            this.radioButtonIncrease.Checked = true;
            this.radioButtonIncrease.Location = new System.Drawing.Point(645, 328);
            this.radioButtonIncrease.Name = "radioButtonIncrease";
            this.radioButtonIncrease.Size = new System.Drawing.Size(135, 24);
            this.radioButtonIncrease.TabIndex = 14;
            this.radioButtonIncrease.TabStop = true;
            this.radioButtonIncrease.Text = "Возрастающий";
            this.radioButtonIncrease.UseVisualStyleBackColor = true;
            // 
            // buttonAddColumn
            // 
            this.buttonAddColumn.BackColor = System.Drawing.Color.Khaki;
            this.buttonAddColumn.Location = new System.Drawing.Point(458, 280);
            this.buttonAddColumn.Name = "buttonAddColumn";
            this.buttonAddColumn.Size = new System.Drawing.Size(168, 40);
            this.buttonAddColumn.TabIndex = 13;
            this.buttonAddColumn.Text = "Добавить столбец";
            this.buttonAddColumn.UseVisualStyleBackColor = false;
            this.buttonAddColumn.Click += new System.EventHandler(this.buttonAddColumn_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.Khaki;
            this.buttonSort.Location = new System.Drawing.Point(458, 337);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(168, 40);
            this.buttonSort.TabIndex = 12;
            this.buttonSort.Text = "Упорядочить эл-ты";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.BackColor = System.Drawing.Color.Khaki;
            this.buttonDeleteRow.Location = new System.Drawing.Point(458, 224);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Size = new System.Drawing.Size(168, 40);
            this.buttonDeleteRow.TabIndex = 11;
            this.buttonDeleteRow.Text = "Удалить строку";
            this.buttonDeleteRow.UseVisualStyleBackColor = false;
            this.buttonDeleteRow.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonMaxRow
            // 
            this.buttonMaxRow.BackColor = System.Drawing.Color.Khaki;
            this.buttonMaxRow.Location = new System.Drawing.Point(6, 280);
            this.buttonMaxRow.Name = "buttonMaxRow";
            this.buttonMaxRow.Size = new System.Drawing.Size(168, 40);
            this.buttonMaxRow.TabIndex = 10;
            this.buttonMaxRow.Text = "Макс. каждой строки";
            this.buttonMaxRow.UseVisualStyleBackColor = false;
            this.buttonMaxRow.Click += new System.EventHandler(this.buttonMaxRow_Click);
            // 
            // buttonMultiple
            // 
            this.buttonMultiple.BackColor = System.Drawing.Color.Khaki;
            this.buttonMultiple.Location = new System.Drawing.Point(6, 224);
            this.buttonMultiple.Name = "buttonMultiple";
            this.buttonMultiple.Size = new System.Drawing.Size(168, 40);
            this.buttonMultiple.TabIndex = 9;
            this.buttonMultiple.Text = "Произв-е эл-ов";
            this.buttonMultiple.UseVisualStyleBackColor = false;
            this.buttonMultiple.Click += new System.EventHandler(this.buttonMultiple_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Khaki;
            this.button4.Location = new System.Drawing.Point(6, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Четн/нечетн";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelMultiple
            // 
            this.labelMultiple.AutoSize = true;
            this.labelMultiple.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMultiple.Location = new System.Drawing.Point(180, 227);
            this.labelMultiple.Name = "labelMultiple";
            this.labelMultiple.Size = new System.Drawing.Size(169, 28);
            this.labelMultiple.TabIndex = 7;
            this.labelMultiple.Text = "Произведение";
            this.labelMultiple.Visible = false;
            // 
            // buttonCreateMatrix
            // 
            this.buttonCreateMatrix.BackColor = System.Drawing.Color.LightGreen;
            this.buttonCreateMatrix.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateMatrix.Location = new System.Drawing.Point(31, 137);
            this.buttonCreateMatrix.Name = "buttonCreateMatrix";
            this.buttonCreateMatrix.Size = new System.Drawing.Size(300, 47);
            this.buttonCreateMatrix.TabIndex = 5;
            this.buttonCreateMatrix.Text = "Создать матрицу";
            this.buttonCreateMatrix.UseVisualStyleBackColor = false;
            this.buttonCreateMatrix.Click += new System.EventHandler(this.buttonCreateMatrix_Click);
            // 
            // labelNumColumns
            // 
            this.labelNumColumns.AutoSize = true;
            this.labelNumColumns.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumColumns.Location = new System.Drawing.Point(31, 59);
            this.labelNumColumns.Name = "labelNumColumns";
            this.labelNumColumns.Size = new System.Drawing.Size(96, 25);
            this.labelNumColumns.TabIndex = 4;
            this.labelNumColumns.Text = "Столбцов:";
            // 
            // labelNumRows
            // 
            this.labelNumRows.AutoSize = true;
            this.labelNumRows.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumRows.Location = new System.Drawing.Point(31, 13);
            this.labelNumRows.Name = "labelNumRows";
            this.labelNumRows.Size = new System.Drawing.Size(65, 25);
            this.labelNumRows.TabIndex = 3;
            this.labelNumRows.Text = "Строк:";
            // 
            // numericUpDown2Columns
            // 
            this.numericUpDown2Columns.Location = new System.Drawing.Point(133, 61);
            this.numericUpDown2Columns.Name = "numericUpDown2Columns";
            this.numericUpDown2Columns.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown2Columns.TabIndex = 2;
            // 
            // numericUpDown2Rows
            // 
            this.numericUpDown2Rows.Location = new System.Drawing.Point(133, 13);
            this.numericUpDown2Rows.Name = "numericUpDown2Rows";
            this.numericUpDown2Rows.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown2Rows.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(362, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(400, 188);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Массивы";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Label labelSum;
        private Button buttonSum;
        private Label labelMinValue;
        private Button button5;
        private Button buttonAdd;
        private Button buttonFindElement;
        private Button button2;
        private Label labelCount;
        private Label labelPosEl;
        private Button buttonCreateMatrix;
        private Label labelNumColumns;
        private Label labelNumRows;
        private NumericUpDown numericUpDown2Columns;
        private NumericUpDown numericUpDown2Rows;
        private DataGridView dataGridView2;
        private Button buttonMaxRow;
        private Button buttonMultiple;
        private Button button4;
        private Label labelMultiple;
        private Button buttonAddColumn;
        private Button buttonSort;
        private Button buttonDeleteRow;
        private RadioButton radioButtonDecrease;
        private RadioButton radioButtonIncrease;
    }
}