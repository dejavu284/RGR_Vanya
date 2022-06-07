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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int f;
        public int Row, Col;
        public double[,] two_array;
        public Random rnd = new Random();
        public bool is_exist_array = false;
        public int number_start = -10;
        public int number_end = 10;
        public SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        public OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tb_rows_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Range_random_values_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void count_columns_TextChanged(object sender, EventArgs e)
        {
            bool flag = int.TryParse(count_columns.Text, out Col);
        }

        private void number_start_TextChanged(object sender, EventArgs e)
        {
            bool flag = int.TryParse(Start.Text, out number_start);
        }

        private void End_TextChanged(object sender, EventArgs e)
        {
            bool flag = int.TryParse(End.Text, out number_end);
        }
        private void Exercise_1_12_CheckedChanged(object sender, EventArgs e)
        {
            string TaskText = "Сгенерировать матрицу и заполнить вещественными числами (положительными и отрицательными)." +
                " Найти среднее арифметическое элементов каждой строки и вывести их в виде дополнительного столбца матрицы. ";
            print_results.Text = TaskText;

            f = 1;

        }
        private void Exercise_2_30_CheckedChanged(object sender, EventArgs e)
        {
            string TaskText = "Сгенерировать квадратную (N≥5, M≥5) матрицу и заполнить вещественными числами (положительными и отрицательными)." +
                " Найти среднее арифметическое элементов стоящих на побочной диагонали и заполнить нулями элементы стоящие под побочной диагональю. ";
            print_results.Text = TaskText;

            f = 2;
        }
        private void Exercise_3_3_CheckedChanged(object sender, EventArgs e)
        {
            string TaskText = "Сгенерировать матрицу и заполнить вещественными числами (положительными и отрицательными)." +
                " Определить номер столбца с минимальной и максимальной суммой элементов. " +
                "Вывести номер столбца с минимальной и максимальной суммой, а также два значения суммы элементов. ";
            print_results.Text = TaskText;

            f = 3;
        }
        private void Exercise_4_21_CheckedChanged(object sender, EventArgs e)
        {
            string TaskText = "Сгенерировать матрицу (N != M) и заполнить вещественными числами (положительными и отрицательными)." +
                " Поменять местами строки по правилу: первая с последней, вторая с предпоследней и так далее.";
            print_results.Text = TaskText;

            f = 4;
        }
        private void Exercise_5_39_CheckedChanged(object sender, EventArgs e)
        {
            string TaskText = "Сгенерировать квадратную матрицу и заполнить вещественными числами (положительными и отрицательными)." +
                " Поменять местами элементы главной диагонали с элементами первой строки.";
            print_results.Text = TaskText;

            f = 5;
        }
        private void Create_array(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.RowCount = Row;
                dataGridView1.ColumnCount = Col;

                for (int i = 0; i < Row; i++)
                {
                    dataGridView1.Rows[i].Height = 30;
                }
                for (int i = 0; i < Col; i++)
                {
                    dataGridView1.Columns[i].Width = 50;
                }
                if (count_rows.Text.Length > 0 && count_columns.Text.Length > 0)
                {
                    int number_between = number_end - number_start;
                    two_array = new double[Row, Col];
                    for (int i = 0; i < Row; i++)
                    {
                        for (int j = 0; j < Col; j++)
                        {
                            two_array[i, j] = number_start + rnd.NextDouble() * number_between;
                            dataGridView1.Rows[i].Cells[j].Value = string.Format("{0:0.00}", two_array[i, j]);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Вы не ввели количество строк и/или столбцов!",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk,
                                MessageBoxDefaultButton.Button1);
            }
        }
        private void Complete_task_Click(object sender, EventArgs e)
        {

            switch (f)
            {
                case 1:
                    
                    try
                    {
                        if (two_array == null) throw new Exception();
                        double[,] NewArr = new double[Row, Col + 1];
                        for (int i = 0; i < Row; i++)
                        {
                            for (int j = 0; j < Col; j++)
                            {
                                NewArr[i, j] = two_array[i, j];
                            }
                        }
                        for (int i = 0; i < Row; i++)
                        {
                            double average = 0;
                            for (int j = 0; j < Col; j++)
                            {
                                average += NewArr[i, j];
                            }
                            average /= Col;
                            NewArr[i, Col] = average;
                        }

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        dataGridView1.RowCount = Row;
                        dataGridView1.ColumnCount = Col + 1;

                        for (int i = 0; i < Row; i++)
                        {
                            dataGridView1.Rows[i].Height = 30;
                        }
                        for (int i = 0; i < Col + 1; i++)
                        {
                            dataGridView1.Columns[i].Width = 50;
                        }

                        for (int i = 0; i < Row; i++)
                        {
                            for (int j = 0; j < Col + 1; j++)
                            {
                                dataGridView1.Rows[i].Cells[j].Value = string.Format("{0:0.00}", NewArr[i, j]);
                            }
                        }
                        print_results.Text = string.Format("Найти среднее арифметическое элементов каждой строки " +
                            "и вывести их в виде дополнительного столбца матрицы. ");
                    }
                    catch
                    {
                        MessageBox.Show("Вы не ввели количество строк и/или столбцов!",
                                        "Внимание",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Asterisk,
                                        MessageBoxDefaultButton.Button1);
                    }
                    break;

                case 2:
                    try
                    {
                        if (two_array == null) throw new Exception();
                        if (Row != Col || Row < 5 )
                        {
                            throw new AggregateException();
                        }
                        double average = 0;
                        for (int i = 1, j = Row - 1; i < Row; i ++, j --)
                        {
                            average += two_array[i-1, j];
                            two_array[i, j] = 0;
                        }
                        average += two_array[Row - 1, 0];
                        average /= Row;

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        dataGridView1.RowCount = Row;
                        dataGridView1.ColumnCount = Col;

                        for (int i = 0; i < Row; i++)
                        {
                            dataGridView1.Rows[i].Height = 30;
                        }
                        for (int i = 0; i < Col; i++)
                        {
                            dataGridView1.Columns[i].Width = 50;
                        }

                        for (int i = 0; i < Row; i++)
                        {
                            for (int j = 0; j < Col; j++)
                            {
                                dataGridView1.Rows[i].Cells[j].Value = string.Format("{0:0.00}", two_array[i, j]);
                            }
                        }
                        print_results.Text = string.Format("Заполнить нулями элементы стоящие под побочной диагональю. Среднее арифметическое: {0:0.00}",average);
                    }
                    catch (AggregateException)
                    {
                        MessageBox.Show("Не удовлетворяет условию задания, повторите попытку",
                                "Внимание",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1);
                    }
                    catch
                    {
                        MessageBox.Show("Вы не ввели количество строк и/или столбцов!",
                                        "Внимание",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Asterisk,
                                        MessageBoxDefaultButton.Button1);
                    }
                    break;

                case 3:
                    try
                    {
                        if (two_array == null) throw new Exception();
                        int nummin = 0, nummax = 0;
                        double Max = double.MinValue, Min = double.MaxValue, Sum = 0;

                        for (int i = 0; i < Col; i++)
                        {
                            Sum = 0;
                            for (int j = 0; j < Row; j++)
                            {
                                Sum += two_array[j, i];
                            }
                            if (Sum > Max)
                            {
                                Max = Sum;
                                nummax = i;
                            }
                            if (Sum < Min)
                            {
                                Min = Sum;
                                nummin = i;
                            }
                        }

                        print_results.Text = string.Format("Вывести номер столбца с минимальной: {0}, и максимальной: {1} суммой, а также два значения суммы элементов. Максимальная сумма: {2:0.00}, минимальная сумма: {3:0.00}", nummin,nummax,Max,Min);
                    }
                    catch
                    {
                        MessageBox.Show("Вы не ввели количество строк и/или столбцов!",
                                        "Внимание",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Asterisk,
                                        MessageBoxDefaultButton.Button1);
                    }
                    break;

                case 4:
                    try
                    {
                        if (two_array == null) throw new Exception();
                        if (Row == Col)
                        {
                            throw new AggregateException();
                        }

                        for (int i = 0; i < Row/2; i++)
                        {
                            for (int j = 0; j < Col; j++)
                            {
                                (two_array[i, j], two_array[Row - i - 1, j]) = (two_array[Row - i - 1, j], two_array[i, j]);
                            }
                        }

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        dataGridView1.RowCount = Row;
                        dataGridView1.ColumnCount = Col;

                        for (int i = 0; i < Row; i++)
                        {
                            dataGridView1.Rows[i].Height = 30;
                        }
                        for (int i = 0; i < Col; i++)
                        {
                            dataGridView1.Columns[i].Width = 50;
                        }

                        for (int i = 0; i < Row; i++)
                        {
                            for (int j = 0; j < Col; j++)
                            {
                                dataGridView1.Rows[i].Cells[j].Value = string.Format("{0:0.00}", two_array[i, j]);
                            }
                        }
                        print_results.Text = string.Format("Поменять местами строки по правилу: первая с последней, вторая с предпоследней и так далее.");
                    }
                    catch (AggregateException)
                    {
                        MessageBox.Show("Не удовлетворяет условию задания, повторите попытку",
                                "Внимание",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1);
                    }
                    catch
                    {
                        MessageBox.Show("Вы не ввели количество строк и/или столбцов!",
                                        "Внимание",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Asterisk,
                                        MessageBoxDefaultButton.Button1);
                    }
                    break;

                case 5:
                    try
                    {
                        if(two_array == null) throw new Exception();
                        if (Row != Col)
                        {
                            throw new AggregateException();
                        }

                        for (int i = 0; i < Row; i++)
                        {
                            (two_array[i, i], two_array[0, i]) = (two_array[0, i], two_array[i, i]);
                        }

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        dataGridView1.RowCount = Row;
                        dataGridView1.ColumnCount = Col;

                        for (int i = 0; i < Row; i++)
                        {
                            dataGridView1.Rows[i].Height = 30;
                        }
                        for (int i = 0; i < Col; i++)
                        {
                            dataGridView1.Columns[i].Width = 50;
                        }

                        for (int i = 0; i < Row; i++)
                        {
                            for (int j = 0; j < Col; j++)
                            {
                                dataGridView1.Rows[i].Cells[j].Value = string.Format("{0:0.00}", two_array[i, j]);
                            }
                        }
                        print_results.Text = string.Format("Поменять местами элементы последней строки с элементами первого столбца.");
                    }
                    catch (AggregateException)
                    {
                        MessageBox.Show("Не удовлетворяет условию задания, повторите попытку",
                                "Внимание",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1);
                    }
                    catch
                    {
                        MessageBox.Show("Вы не ввели количество строк и/или столбцов!",
                                        "Внимание",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Asterisk,
                                        MessageBoxDefaultButton.Button1);
                    }
                    break;


                default:
                    MessageBox.Show("Пипец ты чо делаешь, еще даже задание не выбрал, и массив не создал... ц ц ц ц ",
                                    "Чёёёёё",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Stop,
                                    MessageBoxDefaultButton.Button1);

                    break;

            }
            
        }
        private void Clear_all_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }

        private void print_results_TextChanged(object sender, EventArgs e)
        {

        }

        private void Open_from_file_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Текстовый файл|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(filePath);

                Row = int.Parse(sr.ReadLine());

                count_rows.Text = Row.ToString();

                Col = int.Parse(sr.ReadLine());

                count_columns.Text = Col.ToString();

                two_array = new double[Row, Col];

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.RowCount = Row;
                dataGridView1.ColumnCount = Col;

                for (int i = 0; i < Row; i++)
                {
                    dataGridView1.Rows[i].Height = 30;
                }
                for (int i = 0; i < Col; i++)
                {
                    dataGridView1.Columns[i].Width = 50;
                }

                for (int i = 0; i < Row; i++)
                {
                    string[] str_array = sr.ReadLine().Split('\t');
                    for (int j = 0; j < Col; j++)
                    {
                        two_array[i, j] = double.Parse(str_array[j]);
                    }
                }
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < Col; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = string.Format("{0:0.00}", two_array[i, j]);
                    }
                }

            }
        }

        private void Save_in_file_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Текстовый файл|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(filePath, false);

                sw.WriteLine(Row);

                sw.WriteLine(Col);

                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < Col; j++)
                    {
                        sw.Write("{0:0.00}\t", two_array[i, j]);
                    }
                    sw.WriteLine();

                }
                sw.Close();
            }
        }

        private void count_rows_TextChanged(object sender, EventArgs e)
        {
            bool flag = int.TryParse(count_rows.Text, out Row);
        }
    }
}
