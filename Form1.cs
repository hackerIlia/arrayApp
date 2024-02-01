using Microsoft.VisualBasic;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Security;

namespace Lab_7_arrays
{
    public partial class Form1 : Form
    {
        public int n,numrows,numcolumns;
        public int[] mas;
        public string[] row;

        public int[,] matrix;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if(numericUpDown1.Value==0)
            { 
                MessageBox.Show("Нет ячеек для чисел!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return; 
            }
            dataGridView1.Visible = true;

            Random rand = new Random();
            n = (int)(numericUpDown1.Value);
            mas = new int[n];
            row = new string[n];


            for (int i=0; i<n; i++)
            {
                mas[i]=rand.Next(-99,99);
                row[i] = mas[i].ToString();
            }

            dataGridView1.ColumnCount = mas.Length;
            dataGridView1.Rows.Add(row);

            for(int i=0;i<n;i++)
                dataGridView1.Columns[i].Name=i.ToString();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += mas[i];

            labelSum.Text=Convert.ToString(sum);
            labelSum.Visible=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int min = mas[0];
                for (int i = 0; i < n; i++)
                    if (mas[i] < min) min = mas[i];

                labelMinValue.Text = min.ToString();
                labelMinValue.Visible = true;
            }
            catch
            {
                labelMinValue.Text = "Ошибка";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int zero = 0, poz = 0, neg = 0;
            for(int i = 0; i < n; i++)
            {
                if (mas[i] == 0) zero++;
                else if (mas[i] > 0) poz++;
                else neg++;
            }

            labelCount.Text = "Нулей: " + zero + "  Положительных: " + poz + "  Отрицательных: " + neg;
            labelCount.Visible = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(Interaction.InputBox("Введите число: ", "Ввод числа"));
                Array.Resize(ref mas, ++n);
                Array.Resize(ref row, n);
                mas[n - 1] = num;
                row[n - 1] = num.ToString();
                dataGridView1.Columns.Add(row[n - 1],Convert.ToString(n-1));
                dataGridView1.Columns[n - 1].Visible = true;
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(row);
                dataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFindElement_Click(object sender, EventArgs e)
        {
            for(int i=0;i<n;i++)
                dataGridView1.Rows[0].Cells[i].Style.BackColor=Color.White;

            try
            {
                bool find = false;
                int num = Convert.ToInt32(Interaction.InputBox("Введите число: ", "Ввод числа"));
                for(int i=0;i<n;i++)
                    if (num == mas[i])
                    {
                        labelPosEl.Text=i.ToString();
                        labelPosEl.Visible = true;
                        dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.Green;
                        find = true;
                    }
                if (!find)
                { 
                    labelPosEl.Text = "Элемент не найден"; 
                    labelPosEl.Visible = true; 
                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMaxRow_Click(object sender, EventArgs e)
        {
            try
            {
                int[] maxrows = new int[numrows];
                for (int i = 0; i < numrows; i++)
                {
                    int max = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                    for (int j = 0; j < numcolumns; j++)
                        if (Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value) > max) max = Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value);
                    maxrows[i] = max;
                }
                string message="";
                for (int i = 0; i < numrows; i++)
                    message += maxrows[i] + "\n";

                MessageBox.Show("Максимальные элементы каждой строки: \n" +message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] evenar = new int[numcolumns];
            int[] oddar = new int[numcolumns];

            for (int i=0;i<numcolumns;i++)
            {
                int even = 0, odd = 0;
                for(int j=0;j<numrows;j++)
                {
                    if (Convert.ToInt32(dataGridView2.Rows[j].Cells[i].Value) % 2 != 0) odd++;
                    else even++;
                }

                evenar[i] = even;
                oddar[i] = odd;
            }
                string messageodd = "",messageeven="";
                for(int i=0;i<numcolumns;i++)
                {
                    messageodd += oddar[i] + "\n";
                messageeven += evenar[i] + "\n";
                }
            MessageBox.Show("Кол-во нечетных: \n" + messageodd + "\nКол-во четных: \n" + messageeven);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int userrow = Convert.ToInt32(Interaction.InputBox("Введите номер строки: ", ""));
                if (userrow > numrows-1 || userrow < 0)
                {
                    MessageBox.Show("Нет такой строки!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                for (int i = userrow; i < numrows - 1; i++)
                    for (int j = 0; j < numcolumns; j++)
                    {
                        int x = matrix[i, j];
                        matrix[i, j] = matrix[i + 1, j];
                        matrix[i + 1, j] = x;
                    }
                numrows--;

                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();

                string[] rows = new string[numcolumns];
                dataGridView2.ColumnCount = numcolumns;

                for (int i = 0; i < numrows; i++)
                {
                    for (int j = 0; j < numcolumns; j++)
                    {
                        rows[j] = matrix[i, j].ToString();
                    }
                    dataGridView2.Rows.Add(rows);
                }


                for (int i = 0; i < numcolumns; i++)
                    dataGridView2.Columns[i].Name = i.ToString();

                for (int i = 0; i < numrows; i++)
                    dataGridView2.Rows[i].HeaderCell.Value = i.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddColumn_Click(object sender, EventArgs e)
        {
            try
            {
                int[] uscol=new int[numrows];
                string[] numbers=new string[numrows];
                

                numbers = Interaction.InputBox("Введите значения через запятую:","").Split(',');
                for(int i=0;i<numrows;i++)
                {
                    uscol[i] = Convert.ToInt32(numbers[i]);
                }

                numcolumns++;


                int[,] newmatr = new int[numrows, numcolumns];
                for (int i = 0; i < numrows; i++)
                    for (int j = 0; j < numcolumns - 1; j++)
                        newmatr[i, j] = matrix[i, j];


                        for (int i=0;i<numrows;i++)
                    newmatr[i,numcolumns-1]=uscol[i];

                for (int i = 0; i < numrows; i++)
                    for (int j = 0; j < numcolumns - 1; j++)
                        matrix[i, j] = newmatr[i, j];

                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();

                string[] rows = new string[numcolumns];
                dataGridView2.ColumnCount = numcolumns;

                for (int i = 0; i < numrows; i++)
                {
                    for (int j = 0; j < numcolumns; j++)
                    {
                        rows[j] = newmatr[i, j].ToString();
                    }
                    dataGridView2.Rows.Add(rows);
                }


                for (int i = 0; i < numcolumns; i++)
                    dataGridView2.Columns[i].Name = i.ToString();

                for (int i = 0; i < numrows; i++)
                    dataGridView2.Rows[i].HeaderCell.Value = i.ToString();

                
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (radioButtonIncrease.Checked)
            {
                int[] row;
                try
                {
                    dataGridView2.Rows.Clear();
                    for (int i = 0; i < numrows; i++)
                    {
                        
                        row = new int[numcolumns];
                        for (int k = 0; k < numcolumns; k++)
                            row[k] = matrix[i, k];

                        Array.Sort(row);
                        string[] output = new string[numcolumns];
                        for (int j = 0; j < numcolumns; j++)
                            output[j] = row[j].ToString();
                        dataGridView2.Rows.Add(output);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonDecrease.Checked)
            {
                int[] row;
                try
                {
                    dataGridView2.Rows.Clear();
                    for (int i = 0; i < numrows; i++)
                    {
                            row = new int[numcolumns];
                            string[] rowstr = new string[numcolumns];
                        for (int k = 0; k < numcolumns; k++)
                            row[k] = matrix[i, k];

                        Array.Sort(row);
                        Array.Reverse(row);

                        string[] output = new string[numcolumns];
                        for (int j = 0; j < numcolumns; j++)
                            output[j] = row[j].ToString();
                        dataGridView2.Rows.Add(output);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Отметьте порядок сортировки!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonCreateMatrix_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            if (numericUpDown2Rows.Value == 0) MessageBox.Show("Введите кол-во строк!");
            else if (numericUpDown2Columns.Value == 0) MessageBox.Show("Введите кол-во столбцов!");
            else
            {
            try
            {
                numrows = (int)numericUpDown2Rows.Value;
                numcolumns= (int)numericUpDown2Columns.Value;
                Random rand = new Random();

                dataGridView2.ColumnCount=numcolumns;
                string[] row = new string[numcolumns];

                for(int i=0;i<numrows;i++)
                {
                    for (int j = 0; j < numcolumns; j++)
                        row[j] = rand.Next(-99, 99).ToString();

                    dataGridView2.Rows.Add(row);
                }

                for (int i = 0; i < numcolumns; i++)
                    dataGridView2.Columns[i].Name = i.ToString();

                for(int i= 0; i < numrows; i++)
                    dataGridView2.Rows[i].HeaderCell.Value=i.ToString();

                dataGridView2.Visible = true;

                    matrix = new int[numrows, numcolumns];
                    for (int i = 0; i < numrows; i++)
                        for (int j = 0; j < numcolumns; j++)
                            matrix[i, j] = Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value);
                }
            catch
            {
                MessageBox.Show("Ошибка","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            }
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            try
            {
                int mult = 1;
                for (int i = 0; i < numrows; i++)
                    for (int j = 0; j < numcolumns; j++)
                        mult *= Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value);
                labelMultiple.Text = mult.ToString();
                labelMultiple.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}