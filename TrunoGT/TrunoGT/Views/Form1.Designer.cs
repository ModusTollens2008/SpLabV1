namespace TrunoGT
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.thTusk = new System.Windows.Forms.RichTextBox();
			this.tenTusk = new System.Windows.Forms.RichTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.boxMulRes = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lowLevelLog = new System.Windows.Forms.RichTextBox();
			this.xorClr = new System.Windows.Forms.Button();
			this.xor = new System.Windows.Forms.Button();
			this.clr = new System.Windows.Forms.Button();
			this.mul = new System.Windows.Forms.Button();
			this.resBOX = new System.Windows.Forms.TextBox();
			this.boxXOR = new System.Windows.Forms.TextBox();
			this.boxSecondNum = new System.Windows.Forms.TextBox();
			this.boxFirstNum = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.fileBoxLog = new System.Windows.Forms.RichTextBox();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tusk10Box = new System.Windows.Forms.RichTextBox();
			this.tusk13Box = new System.Windows.Forms.RichTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.logBoxAnalyse = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.analyze13 = new System.Windows.Forms.Button();
			this.analyze10 = new System.Windows.Forms.Button();
			this.text4Analyze13 = new System.Windows.Forms.RichTextBox();
			this.text4Analyze10 = new System.Windows.Forms.RichTextBox();
			this.result13Box = new System.Windows.Forms.TextBox();
			this.result10Box = new System.Windows.Forms.TextBox();
			this.BinToBD = new System.Windows.Forms.Button();
			this.BinFromBD = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(-4, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(805, 480);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.thTusk);
			this.tabPage1.Controls.Add(this.tenTusk);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.boxMulRes);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.lowLevelLog);
			this.tabPage1.Controls.Add(this.xorClr);
			this.tabPage1.Controls.Add(this.xor);
			this.tabPage1.Controls.Add(this.clr);
			this.tabPage1.Controls.Add(this.mul);
			this.tabPage1.Controls.Add(this.resBOX);
			this.tabPage1.Controls.Add(this.boxXOR);
			this.tabPage1.Controls.Add(this.boxSecondNum);
			this.tabPage1.Controls.Add(this.boxFirstNum);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(797, 454);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Анализатор";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// thTusk
			// 
			this.thTusk.Location = new System.Drawing.Point(403, 156);
			this.thTusk.Name = "thTusk";
			this.thTusk.ReadOnly = true;
			this.thTusk.Size = new System.Drawing.Size(387, 59);
			this.thTusk.TabIndex = 17;
			this.thTusk.Text = "Вариант №13\nЗадание: Вычислить побитовое НЕ\nИсполнитель: Грушин Анатолий\nГруппа: " +
    "6304";
			// 
			// tenTusk
			// 
			this.tenTusk.Location = new System.Drawing.Point(403, 26);
			this.tenTusk.Name = "tenTusk";
			this.tenTusk.ReadOnly = true;
			this.tenTusk.Size = new System.Drawing.Size(387, 72);
			this.tenTusk.TabIndex = 16;
			this.tenTusk.Text = "Вариант №10\nЗадание: Умножить два целочисленных значения без знака с проверкой пе" +
    "реполнения\nИсполнитель: Бочкарев Михаил\nГруппа: 6304";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 81);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(59, 13);
			this.label10.TabIndex = 15;
			this.label10.Text = "Результат";
			// 
			// boxMulRes
			// 
			this.boxMulRes.Location = new System.Drawing.Point(92, 78);
			this.boxMulRes.Name = "boxMulRes";
			this.boxMulRes.ReadOnly = true;
			this.boxMulRes.Size = new System.Drawing.Size(157, 20);
			this.boxMulRes.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 233);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Лог";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(263, 189);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Результат";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(263, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Исходное число";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Второе число";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Первое число";
			// 
			// lowLevelLog
			// 
			this.lowLevelLog.Location = new System.Drawing.Point(12, 249);
			this.lowLevelLog.Name = "lowLevelLog";
			this.lowLevelLog.ReadOnly = true;
			this.lowLevelLog.Size = new System.Drawing.Size(778, 194);
			this.lowLevelLog.TabIndex = 8;
			this.lowLevelLog.Text = "";
			// 
			// xorClr
			// 
			this.xorClr.Location = new System.Drawing.Point(4, 185);
			this.xorClr.Name = "xorClr";
			this.xorClr.Size = new System.Drawing.Size(82, 20);
			this.xorClr.TabIndex = 7;
			this.xorClr.Text = "Очистить";
			this.xorClr.UseVisualStyleBackColor = true;
			this.xorClr.Click += new System.EventHandler(this.xorClr_Click);
			// 
			// xor
			// 
			this.xor.Location = new System.Drawing.Point(6, 159);
			this.xor.Name = "xor";
			this.xor.Size = new System.Drawing.Size(78, 20);
			this.xor.TabIndex = 6;
			this.xor.Text = "Логическое не";
			this.xor.UseVisualStyleBackColor = true;
			this.xor.Click += new System.EventHandler(this.xor_Click);
			// 
			// clr
			// 
			this.clr.Location = new System.Drawing.Point(265, 51);
			this.clr.Name = "clr";
			this.clr.Size = new System.Drawing.Size(86, 20);
			this.clr.TabIndex = 5;
			this.clr.Text = "Очистить";
			this.clr.UseVisualStyleBackColor = true;
			this.clr.Click += new System.EventHandler(this.clr_Click);
			// 
			// mul
			// 
			this.mul.Location = new System.Drawing.Point(265, 26);
			this.mul.Name = "mul";
			this.mul.Size = new System.Drawing.Size(86, 20);
			this.mul.TabIndex = 4;
			this.mul.Text = "Умножить";
			this.mul.UseVisualStyleBackColor = true;
			this.mul.Click += new System.EventHandler(this.mul_Click);
			// 
			// resBOX
			// 
			this.resBOX.Location = new System.Drawing.Point(92, 185);
			this.resBOX.Name = "resBOX";
			this.resBOX.ReadOnly = true;
			this.resBOX.Size = new System.Drawing.Size(157, 20);
			this.resBOX.TabIndex = 3;
			// 
			// boxXOR
			// 
			this.boxXOR.Location = new System.Drawing.Point(92, 159);
			this.boxXOR.Name = "boxXOR";
			this.boxXOR.Size = new System.Drawing.Size(157, 20);
			this.boxXOR.TabIndex = 2;
			// 
			// boxSecondNum
			// 
			this.boxSecondNum.Location = new System.Drawing.Point(92, 52);
			this.boxSecondNum.Name = "boxSecondNum";
			this.boxSecondNum.Size = new System.Drawing.Size(157, 20);
			this.boxSecondNum.TabIndex = 1;
			// 
			// boxFirstNum
			// 
			this.boxFirstNum.Location = new System.Drawing.Point(92, 26);
			this.boxFirstNum.Name = "boxFirstNum";
			this.boxFirstNum.Size = new System.Drawing.Size(157, 20);
			this.boxFirstNum.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button13);
			this.tabPage2.Controls.Add(this.button12);
			this.tabPage2.Controls.Add(this.BinFromBD);
			this.tabPage2.Controls.Add(this.BinToBD);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.fileBoxLog);
			this.tabPage2.Controls.Add(this.button10);
			this.tabPage2.Controls.Add(this.button9);
			this.tabPage2.Controls.Add(this.button8);
			this.tabPage2.Controls.Add(this.button7);
			this.tabPage2.Controls.Add(this.button6);
			this.tabPage2.Controls.Add(this.button5);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Controls.Add(this.dataGridView1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(797, 454);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Записи о файлах";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(475, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(25, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Log";
			// 
			// fileBoxLog
			// 
			this.fileBoxLog.Location = new System.Drawing.Point(478, 22);
			this.fileBoxLog.Name = "fileBoxLog";
			this.fileBoxLog.Size = new System.Drawing.Size(316, 426);
			this.fileBoxLog.TabIndex = 12;
			this.fileBoxLog.Text = "";
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(251, 237);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(94, 61);
			this.button10.TabIndex = 11;
			this.button10.Text = "Сохранить изменения в строке";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(12, 237);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(111, 27);
			this.button9.TabIndex = 10;
			this.button9.Text = "Загрузить из файла";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(12, 270);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(111, 28);
			this.button8.TabIndex = 9;
			this.button8.Text = "Сохранить в файл";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(129, 270);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(116, 28);
			this.button7.TabIndex = 8;
			this.button7.Text = "Удалить запись";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(129, 237);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(116, 27);
			this.button6.TabIndex = 7;
			this.button6.Text = "Добавить запись";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(251, 7);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(94, 62);
			this.button5.TabIndex = 6;
			this.button5.Text = "Сохранить изменения в строке";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 6);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(111, 29);
			this.button4.TabIndex = 5;
			this.button4.Text = "Загрузить из файла";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 39);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(111, 30);
			this.button3.TabIndex = 4;
			this.button3.Text = "Сохранить в файл";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(129, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 28);
			this.button2.TabIndex = 3;
			this.button2.Text = "Удалить запись";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(129, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 29);
			this.button1.TabIndex = 2;
			this.button1.Text = "Добавить запись";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(12, 304);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(460, 147);
			this.dataGridView2.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 75);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(460, 156);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.tusk10Box);
			this.tabPage3.Controls.Add(this.tusk13Box);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.logBoxAnalyse);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.analyze13);
			this.tabPage3.Controls.Add(this.analyze10);
			this.tabPage3.Controls.Add(this.text4Analyze13);
			this.tabPage3.Controls.Add(this.text4Analyze10);
			this.tabPage3.Controls.Add(this.result13Box);
			this.tabPage3.Controls.Add(this.result10Box);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(797, 454);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Низкоуровневые функции";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tusk10Box
			// 
			this.tusk10Box.Location = new System.Drawing.Point(6, 116);
			this.tusk10Box.Name = "tusk10Box";
			this.tusk10Box.ReadOnly = true;
			this.tusk10Box.Size = new System.Drawing.Size(218, 72);
			this.tusk10Box.TabIndex = 11;
			this.tusk10Box.Text = "Цикл-перебора foreach\n(<элемент>in <массив>){<тело цикла>}\nПосчитать сколько раз " +
    "выполнится цикл\nИсполнитель: Бочкарев Михаил\nГруппа: 6304";
			// 
			// tusk13Box
			// 
			this.tusk13Box.Location = new System.Drawing.Point(6, 325);
			this.tusk13Box.Name = "tusk13Box";
			this.tusk13Box.ReadOnly = true;
			this.tusk13Box.Size = new System.Drawing.Size(218, 105);
			this.tusk13Box.TabIndex = 10;
			this.tusk13Box.Text = "Цикл с постусловием do \n{<тело цикла>}while\n(<условие>)\nОпределить,выполнится ли " +
    "больше одного раза\nИсполнитель: Грушин Анатолий\nГруппа: 6304";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(384, 5);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(26, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Лог";
			// 
			// logBoxAnalyse
			// 
			this.logBoxAnalyse.Location = new System.Drawing.Point(384, 24);
			this.logBoxAnalyse.Name = "logBoxAnalyse";
			this.logBoxAnalyse.Size = new System.Drawing.Size(406, 419);
			this.logBoxAnalyse.TabIndex = 8;
			this.logBoxAnalyse.Text = "";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 433);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(221, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Была ли хотя бы одна иттерация do while?";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 194);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(193, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Количество иттераций цикла foreach";
			// 
			// analyze13
			// 
			this.analyze13.Location = new System.Drawing.Point(230, 325);
			this.analyze13.Name = "analyze13";
			this.analyze13.Size = new System.Drawing.Size(96, 37);
			this.analyze13.TabIndex = 5;
			this.analyze13.Text = "Анализ!";
			this.analyze13.UseVisualStyleBackColor = true;
			this.analyze13.Click += new System.EventHandler(this.analyze13_Click);
			// 
			// analyze10
			// 
			this.analyze10.Location = new System.Drawing.Point(230, 116);
			this.analyze10.Name = "analyze10";
			this.analyze10.Size = new System.Drawing.Size(96, 35);
			this.analyze10.TabIndex = 4;
			this.analyze10.Text = "Анализ!";
			this.analyze10.UseVisualStyleBackColor = true;
			this.analyze10.Click += new System.EventHandler(this.analyze10_Click);
			// 
			// text4Analyze13
			// 
			this.text4Analyze13.Location = new System.Drawing.Point(6, 227);
			this.text4Analyze13.Name = "text4Analyze13";
			this.text4Analyze13.Size = new System.Drawing.Size(320, 92);
			this.text4Analyze13.TabIndex = 3;
			this.text4Analyze13.Text = "";
			// 
			// text4Analyze10
			// 
			this.text4Analyze10.Location = new System.Drawing.Point(6, 15);
			this.text4Analyze10.Name = "text4Analyze10";
			this.text4Analyze10.Size = new System.Drawing.Size(323, 95);
			this.text4Analyze10.TabIndex = 2;
			this.text4Analyze10.Text = "";
			// 
			// result13Box
			// 
			this.result13Box.Location = new System.Drawing.Point(230, 430);
			this.result13Box.Name = "result13Box";
			this.result13Box.ReadOnly = true;
			this.result13Box.Size = new System.Drawing.Size(93, 20);
			this.result13Box.TabIndex = 1;
			this.result13Box.TextChanged += new System.EventHandler(this.result13Box_TextChanged);
			// 
			// result10Box
			// 
			this.result10Box.Location = new System.Drawing.Point(202, 194);
			this.result10Box.Name = "result10Box";
			this.result10Box.ReadOnly = true;
			this.result10Box.Size = new System.Drawing.Size(121, 20);
			this.result10Box.TabIndex = 0;
			// 
			// BinToBD
			// 
			this.BinToBD.Location = new System.Drawing.Point(352, 7);
			this.BinToBD.Name = "BinToBD";
			this.BinToBD.Size = new System.Drawing.Size(117, 28);
			this.BinToBD.TabIndex = 14;
			this.BinToBD.Text = "Сохранить в БД";
			this.BinToBD.UseVisualStyleBackColor = true;
			this.BinToBD.Click += new System.EventHandler(this.BinToBD_Click);
			// 
			// BinFromBD
			// 
			this.BinFromBD.Location = new System.Drawing.Point(352, 39);
			this.BinFromBD.Name = "BinFromBD";
			this.BinFromBD.Size = new System.Drawing.Size(117, 28);
			this.BinFromBD.TabIndex = 15;
			this.BinFromBD.Text = "Загрузить из БД";
			this.BinFromBD.UseVisualStyleBackColor = true;
			this.BinFromBD.Click += new System.EventHandler(this.BinFromBD_Click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(352, 236);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(117, 28);
			this.button12.TabIndex = 16;
			this.button12.Text = "Сохранить в БД";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(351, 270);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(117, 28);
			this.button13.TabIndex = 17;
			this.button13.Text = "Загрузить из БД";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(802, 477);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.RichTextBox lowLevelLog;
		private System.Windows.Forms.Button xorClr;
		private System.Windows.Forms.Button xor;
		private System.Windows.Forms.Button clr;
		private System.Windows.Forms.Button mul;
		private System.Windows.Forms.TextBox resBOX;
		private System.Windows.Forms.TextBox boxXOR;
		private System.Windows.Forms.TextBox boxSecondNum;
		private System.Windows.Forms.TextBox boxFirstNum;
		private System.Windows.Forms.Button analyze13;
		private System.Windows.Forms.Button analyze10;
		private System.Windows.Forms.RichTextBox text4Analyze13;
		private System.Windows.Forms.RichTextBox text4Analyze10;
		private System.Windows.Forms.TextBox result13Box;
		private System.Windows.Forms.TextBox result10Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox fileBoxLog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox logBoxAnalyse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox thTusk;
        private System.Windows.Forms.RichTextBox tenTusk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxMulRes;
        private System.Windows.Forms.RichTextBox tusk10Box;
        private System.Windows.Forms.RichTextBox tusk13Box;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button BinFromBD;
		private System.Windows.Forms.Button BinToBD;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
	}
}

