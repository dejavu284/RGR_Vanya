
namespace WindowsFormsApp1
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
            this.count_rows = new System.Windows.Forms.TextBox();
            this.count_columns = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.TextBox();
            this.End = new System.Windows.Forms.TextBox();
            this.print_results = new System.Windows.Forms.TextBox();
            this.ZADANIA = new System.Windows.Forms.GroupBox();
            this.Complete_task = new System.Windows.Forms.Button();
            this.lb_print_results = new System.Windows.Forms.Label();
            this.Exercise_5_39 = new System.Windows.Forms.RadioButton();
            this.Exercise_4_21 = new System.Windows.Forms.RadioButton();
            this.Exercise_3_3 = new System.Windows.Forms.RadioButton();
            this.Exercise_2_30 = new System.Windows.Forms.RadioButton();
            this.Exercise_1_12 = new System.Windows.Forms.RadioButton();
            this.Two_arrays = new System.Windows.Forms.GroupBox();
            this.Clear_menu = new System.Windows.Forms.Button();
            this.lb_from = new System.Windows.Forms.Label();
            this.lb_to = new System.Windows.Forms.Label();
            this.lb_range_random_values = new System.Windows.Forms.Label();
            this.lb_columns = new System.Windows.Forms.Label();
            this.lb_rows = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Create_arr = new System.Windows.Forms.Button();
            this.save_in_file = new System.Windows.Forms.Button();
            this.Open_from_file = new System.Windows.Forms.Button();
            this.ZADANIA.SuspendLayout();
            this.Two_arrays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // count_rows
            // 
            this.count_rows.Location = new System.Drawing.Point(169, 47);
            this.count_rows.Name = "count_rows";
            this.count_rows.Size = new System.Drawing.Size(81, 22);
            this.count_rows.TabIndex = 0;
            this.count_rows.TextChanged += new System.EventHandler(this.count_rows_TextChanged);
            // 
            // count_columns
            // 
            this.count_columns.Location = new System.Drawing.Point(169, 75);
            this.count_columns.Name = "count_columns";
            this.count_columns.Size = new System.Drawing.Size(81, 22);
            this.count_columns.TabIndex = 1;
            this.count_columns.TextChanged += new System.EventHandler(this.count_columns_TextChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(419, 75);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(81, 22);
            this.Start.TabIndex = 2;
            this.Start.TextChanged += new System.EventHandler(this.number_start_TextChanged);
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(561, 75);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(81, 22);
            this.End.TabIndex = 3;
            this.End.TextChanged += new System.EventHandler(this.End_TextChanged);
            // 
            // print_results
            // 
            this.print_results.Location = new System.Drawing.Point(6, 286);
            this.print_results.Multiline = true;
            this.print_results.Name = "print_results";
            this.print_results.ReadOnly = true;
            this.print_results.Size = new System.Drawing.Size(336, 173);
            this.print_results.TabIndex = 4;
            this.print_results.TextChanged += new System.EventHandler(this.print_results_TextChanged);
            // 
            // ZADANIA
            // 
            this.ZADANIA.Controls.Add(this.save_in_file);
            this.ZADANIA.Controls.Add(this.Open_from_file);
            this.ZADANIA.Controls.Add(this.Complete_task);
            this.ZADANIA.Controls.Add(this.lb_print_results);
            this.ZADANIA.Controls.Add(this.Exercise_5_39);
            this.ZADANIA.Controls.Add(this.Exercise_4_21);
            this.ZADANIA.Controls.Add(this.Exercise_3_3);
            this.ZADANIA.Controls.Add(this.Exercise_2_30);
            this.ZADANIA.Controls.Add(this.Exercise_1_12);
            this.ZADANIA.Controls.Add(this.print_results);
            this.ZADANIA.Location = new System.Drawing.Point(667, 12);
            this.ZADANIA.Name = "ZADANIA";
            this.ZADANIA.Size = new System.Drawing.Size(349, 465);
            this.ZADANIA.TabIndex = 5;
            this.ZADANIA.TabStop = false;
            this.ZADANIA.Text = "Задания";
            this.ZADANIA.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Complete_task
            // 
            this.Complete_task.Location = new System.Drawing.Point(6, 222);
            this.Complete_task.Name = "Complete_task";
            this.Complete_task.Size = new System.Drawing.Size(168, 41);
            this.Complete_task.TabIndex = 12;
            this.Complete_task.Text = "Выполнить задание";
            this.Complete_task.UseVisualStyleBackColor = true;
            this.Complete_task.Click += new System.EventHandler(this.Complete_task_Click);
            // 
            // lb_print_results
            // 
            this.lb_print_results.AutoSize = true;
            this.lb_print_results.Location = new System.Drawing.Point(6, 266);
            this.lb_print_results.Name = "lb_print_results";
            this.lb_print_results.Size = new System.Drawing.Size(121, 17);
            this.lb_print_results.TabIndex = 11;
            this.lb_print_results.Text = "Вывод значений:";
            // 
            // Exercise_5_39
            // 
            this.Exercise_5_39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exercise_5_39.Location = new System.Drawing.Point(6, 182);
            this.Exercise_5_39.Name = "Exercise_5_39";
            this.Exercise_5_39.Size = new System.Drawing.Size(121, 34);
            this.Exercise_5_39.TabIndex = 9;
            this.Exercise_5_39.TabStop = true;
            this.Exercise_5_39.Text = "Задание 5";
            this.Exercise_5_39.UseVisualStyleBackColor = true;
            this.Exercise_5_39.CheckedChanged += new System.EventHandler(this.Exercise_5_39_CheckedChanged);
            // 
            // Exercise_4_21
            // 
            this.Exercise_4_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exercise_4_21.Location = new System.Drawing.Point(6, 142);
            this.Exercise_4_21.Name = "Exercise_4_21";
            this.Exercise_4_21.Size = new System.Drawing.Size(121, 34);
            this.Exercise_4_21.TabIndex = 8;
            this.Exercise_4_21.TabStop = true;
            this.Exercise_4_21.Text = "Задание 4";
            this.Exercise_4_21.UseVisualStyleBackColor = true;
            this.Exercise_4_21.CheckedChanged += new System.EventHandler(this.Exercise_4_21_CheckedChanged);
            // 
            // Exercise_3_3
            // 
            this.Exercise_3_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exercise_3_3.Location = new System.Drawing.Point(6, 103);
            this.Exercise_3_3.Name = "Exercise_3_3";
            this.Exercise_3_3.Size = new System.Drawing.Size(121, 33);
            this.Exercise_3_3.TabIndex = 7;
            this.Exercise_3_3.TabStop = true;
            this.Exercise_3_3.Text = "Задание 3";
            this.Exercise_3_3.UseVisualStyleBackColor = true;
            this.Exercise_3_3.CheckedChanged += new System.EventHandler(this.Exercise_3_3_CheckedChanged);
            // 
            // Exercise_2_30
            // 
            this.Exercise_2_30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exercise_2_30.Location = new System.Drawing.Point(6, 64);
            this.Exercise_2_30.Name = "Exercise_2_30";
            this.Exercise_2_30.Size = new System.Drawing.Size(121, 33);
            this.Exercise_2_30.TabIndex = 6;
            this.Exercise_2_30.TabStop = true;
            this.Exercise_2_30.Text = "Задание 2";
            this.Exercise_2_30.UseVisualStyleBackColor = true;
            this.Exercise_2_30.CheckedChanged += new System.EventHandler(this.Exercise_2_30_CheckedChanged);
            // 
            // Exercise_1_12
            // 
            this.Exercise_1_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exercise_1_12.Location = new System.Drawing.Point(6, 25);
            this.Exercise_1_12.Name = "Exercise_1_12";
            this.Exercise_1_12.Size = new System.Drawing.Size(121, 33);
            this.Exercise_1_12.TabIndex = 5;
            this.Exercise_1_12.TabStop = true;
            this.Exercise_1_12.Text = "Задание 1";
            this.Exercise_1_12.UseVisualStyleBackColor = true;
            this.Exercise_1_12.CheckedChanged += new System.EventHandler(this.Exercise_1_12_CheckedChanged);
            // 
            // Two_arrays
            // 
            this.Two_arrays.Controls.Add(this.lb_from);
            this.Two_arrays.Controls.Add(this.lb_to);
            this.Two_arrays.Controls.Add(this.lb_range_random_values);
            this.Two_arrays.Controls.Add(this.lb_columns);
            this.Two_arrays.Controls.Add(this.lb_rows);
            this.Two_arrays.Controls.Add(this.dataGridView1);
            this.Two_arrays.Controls.Add(this.Create_arr);
            this.Two_arrays.Controls.Add(this.End);
            this.Two_arrays.Controls.Add(this.Start);
            this.Two_arrays.Controls.Add(this.count_columns);
            this.Two_arrays.Controls.Add(this.count_rows);
            this.Two_arrays.Location = new System.Drawing.Point(12, 12);
            this.Two_arrays.Name = "Two_arrays";
            this.Two_arrays.Size = new System.Drawing.Size(649, 625);
            this.Two_arrays.TabIndex = 6;
            this.Two_arrays.TabStop = false;
            this.Two_arrays.Text = "Двумерные массивы";
            // 
            // Clear_menu
            // 
            this.Clear_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_menu.Location = new System.Drawing.Point(667, 483);
            this.Clear_menu.Name = "Clear_menu";
            this.Clear_menu.Size = new System.Drawing.Size(344, 150);
            this.Clear_menu.TabIndex = 11;
            this.Clear_menu.Text = "Очистить";
            this.Clear_menu.UseVisualStyleBackColor = true;
            this.Clear_menu.Click += new System.EventHandler(this.Clear_all_Click);
            // 
            // lb_from
            // 
            this.lb_from.AutoSize = true;
            this.lb_from.Location = new System.Drawing.Point(383, 76);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(30, 17);
            this.lb_from.TabIndex = 10;
            this.lb_from.Text = "От:";
            // 
            // lb_to
            // 
            this.lb_to.AutoSize = true;
            this.lb_to.Location = new System.Drawing.Point(524, 76);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(31, 17);
            this.lb_to.TabIndex = 9;
            this.lb_to.Text = "До:";
            this.lb_to.Click += new System.EventHandler(this.label4_Click);
            // 
            // lb_range_random_values
            // 
            this.lb_range_random_values.AutoSize = true;
            this.lb_range_random_values.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_range_random_values.Location = new System.Drawing.Point(383, 48);
            this.lb_range_random_values.Name = "lb_range_random_values";
            this.lb_range_random_values.Size = new System.Drawing.Size(227, 18);
            this.lb_range_random_values.TabIndex = 8;
            this.lb_range_random_values.Text = "Диапазон случайных значений:";
            this.lb_range_random_values.Click += new System.EventHandler(this.Range_random_values_Click);
            // 
            // lb_columns
            // 
            this.lb_columns.AutoSize = true;
            this.lb_columns.Location = new System.Drawing.Point(11, 76);
            this.lb_columns.Name = "lb_columns";
            this.lb_columns.Size = new System.Drawing.Size(155, 17);
            this.lb_columns.TabIndex = 7;
            this.lb_columns.Text = "Количество столбцов:";
            // 
            // lb_rows
            // 
            this.lb_rows.AutoSize = true;
            this.lb_rows.Location = new System.Drawing.Point(35, 47);
            this.lb_rows.Name = "lb_rows";
            this.lb_rows.Size = new System.Drawing.Size(131, 17);
            this.lb_rows.TabIndex = 6;
            this.lb_rows.Text = "Количество строк:";
            this.lb_rows.Click += new System.EventHandler(this.tb_rows_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(6, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(636, 502);
            this.dataGridView1.TabIndex = 5;
            // 
            // Create_arr
            // 
            this.Create_arr.Location = new System.Drawing.Point(256, 47);
            this.Create_arr.Name = "Create_arr";
            this.Create_arr.Size = new System.Drawing.Size(110, 50);
            this.Create_arr.TabIndex = 4;
            this.Create_arr.Text = "Создать массив";
            this.Create_arr.UseVisualStyleBackColor = true;
            this.Create_arr.Click += new System.EventHandler(this.Create_array);
            // 
            // save_in_file
            // 
            this.save_in_file.Location = new System.Drawing.Point(173, 76);
            this.save_in_file.Name = "save_in_file";
            this.save_in_file.Size = new System.Drawing.Size(169, 39);
            this.save_in_file.TabIndex = 7;
            this.save_in_file.Text = "Сохранить в файл";
            this.save_in_file.UseVisualStyleBackColor = true;
            this.save_in_file.Click += new System.EventHandler(this.Save_in_file_Click);
            // 
            // Open_from_file
            // 
            this.Open_from_file.Location = new System.Drawing.Point(173, 21);
            this.Open_from_file.Name = "Open_from_file";
            this.Open_from_file.Size = new System.Drawing.Size(169, 39);
            this.Open_from_file.TabIndex = 8;
            this.Open_from_file.Text = "Открыть из файла";
            this.Open_from_file.UseVisualStyleBackColor = true;
            this.Open_from_file.Click += new System.EventHandler(this.Open_from_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 645);
            this.Controls.Add(this.Two_arrays);
            this.Controls.Add(this.Clear_menu);
            this.Controls.Add(this.ZADANIA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ZADANIA.ResumeLayout(false);
            this.ZADANIA.PerformLayout();
            this.Two_arrays.ResumeLayout(false);
            this.Two_arrays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox count_rows;
        public System.Windows.Forms.TextBox count_columns;
        public System.Windows.Forms.TextBox Start;
        public System.Windows.Forms.TextBox End;
        public System.Windows.Forms.TextBox print_results;
        private System.Windows.Forms.GroupBox ZADANIA;
        public System.Windows.Forms.RadioButton Exercise_5_39;
        public System.Windows.Forms.RadioButton Exercise_4_21;
        public System.Windows.Forms.RadioButton Exercise_3_3;
        public System.Windows.Forms.RadioButton Exercise_2_30;
        public System.Windows.Forms.RadioButton Exercise_1_12;
        public System.Windows.Forms.Button Complete_task;
        private System.Windows.Forms.Label lb_print_results;
        private System.Windows.Forms.GroupBox Two_arrays;
        private System.Windows.Forms.Label lb_from;
        private System.Windows.Forms.Label lb_to;
        private System.Windows.Forms.Label lb_range_random_values;
        private System.Windows.Forms.Label lb_columns;
        private System.Windows.Forms.Label lb_rows;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button Create_arr;
        private System.Windows.Forms.Button Clear_menu;
        private System.Windows.Forms.Button save_in_file;
        private System.Windows.Forms.Button Open_from_file;
    }
}

