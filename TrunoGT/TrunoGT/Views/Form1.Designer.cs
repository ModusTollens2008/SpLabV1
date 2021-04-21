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
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.boxFirstNum = new System.Windows.Forms.TextBox();
			this.boxSecondNum = new System.Windows.Forms.TextBox();
			this.boxXOR = new System.Windows.Forms.TextBox();
			this.resBOX = new System.Windows.Forms.TextBox();
			this.mul = new System.Windows.Forms.Button();
			this.clr = new System.Windows.Forms.Button();
			this.xor = new System.Windows.Forms.Button();
			this.xorClr = new System.Windows.Forms.Button();
			this.lowLevelLog = new System.Windows.Forms.RichTextBox();
			this.result10Box = new System.Windows.Forms.TextBox();
			this.result13Box = new System.Windows.Forms.TextBox();
			this.text4Analyze10 = new System.Windows.Forms.RichTextBox();
			this.text4Analyze13 = new System.Windows.Forms.RichTextBox();
			this.analyze10 = new System.Windows.Forms.Button();
			this.analyze13 = new System.Windows.Forms.Button();
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
			// tabPage2
			// 
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
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(532, 85);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(131, 28);
			this.button2.TabIndex = 3;
			this.button2.Text = "Удалить запись";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(532, 52);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 27);
			this.button1.TabIndex = 2;
			this.button1.Text = "Добавить запись";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(46, 255);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(441, 161);
			this.dataGridView2.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(46, 52);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(441, 165);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// tabPage3
			// 
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
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(532, 119);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(131, 20);
			this.button3.TabIndex = 4;
			this.button3.Text = "Сохранить в файл";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(532, 145);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(131, 24);
			this.button4.TabIndex = 5;
			this.button4.Text = "Загрузить из файла";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(532, 175);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(131, 42);
			this.button5.TabIndex = 6;
			this.button5.Text = "Сохранить изменения в строке";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(532, 255);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(131, 27);
			this.button6.TabIndex = 7;
			this.button6.Text = "Добавить запись";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(532, 288);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(131, 28);
			this.button7.TabIndex = 8;
			this.button7.Text = "Удалить запись";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(532, 322);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(131, 20);
			this.button8.TabIndex = 9;
			this.button8.Text = "Сохранить в файл";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(532, 348);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(131, 24);
			this.button9.TabIndex = 10;
			this.button9.Text = "Загрузить из файла";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(532, 374);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(131, 42);
			this.button10.TabIndex = 11;
			this.button10.Text = "Сохранить изменения в строке";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// boxFirstNum
			// 
			this.boxFirstNum.Location = new System.Drawing.Point(78, 44);
			this.boxFirstNum.Name = "boxFirstNum";
			this.boxFirstNum.Size = new System.Drawing.Size(119, 20);
			this.boxFirstNum.TabIndex = 0;
			// 
			// boxSecondNum
			// 
			this.boxSecondNum.Location = new System.Drawing.Point(78, 70);
			this.boxSecondNum.Name = "boxSecondNum";
			this.boxSecondNum.Size = new System.Drawing.Size(119, 20);
			this.boxSecondNum.TabIndex = 1;
			// 
			// boxXOR
			// 
			this.boxXOR.Location = new System.Drawing.Point(78, 134);
			this.boxXOR.Name = "boxXOR";
			this.boxXOR.Size = new System.Drawing.Size(119, 20);
			this.boxXOR.TabIndex = 2;
			// 
			// resBOX
			// 
			this.resBOX.Location = new System.Drawing.Point(78, 160);
			this.resBOX.Name = "resBOX";
			this.resBOX.ReadOnly = true;
			this.resBOX.Size = new System.Drawing.Size(119, 20);
			this.resBOX.TabIndex = 3;
			// 
			// mul
			// 
			this.mul.Location = new System.Drawing.Point(314, 44);
			this.mul.Name = "mul";
			this.mul.Size = new System.Drawing.Size(75, 23);
			this.mul.TabIndex = 4;
			this.mul.Text = "button11";
			this.mul.UseVisualStyleBackColor = true;
			this.mul.Click += new System.EventHandler(this.mul_Click);
			// 
			// clr
			// 
			this.clr.Location = new System.Drawing.Point(314, 70);
			this.clr.Name = "clr";
			this.clr.Size = new System.Drawing.Size(75, 23);
			this.clr.TabIndex = 5;
			this.clr.Text = "button12";
			this.clr.UseVisualStyleBackColor = true;
			this.clr.Click += new System.EventHandler(this.clr_Click);
			// 
			// xor
			// 
			this.xor.Location = new System.Drawing.Point(314, 134);
			this.xor.Name = "xor";
			this.xor.Size = new System.Drawing.Size(75, 26);
			this.xor.TabIndex = 6;
			this.xor.Text = "button13";
			this.xor.UseVisualStyleBackColor = true;
			this.xor.Click += new System.EventHandler(this.xor_Click);
			// 
			// xorClr
			// 
			this.xorClr.Location = new System.Drawing.Point(314, 160);
			this.xorClr.Name = "xorClr";
			this.xorClr.Size = new System.Drawing.Size(75, 23);
			this.xorClr.TabIndex = 7;
			this.xorClr.Text = "button14";
			this.xorClr.UseVisualStyleBackColor = true;
			this.xorClr.Click += new System.EventHandler(this.xorClr_Click);
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
			// result10Box
			// 
			this.result10Box.Location = new System.Drawing.Point(86, 171);
			this.result10Box.Name = "result10Box";
			this.result10Box.ReadOnly = true;
			this.result10Box.Size = new System.Drawing.Size(124, 20);
			this.result10Box.TabIndex = 0;
			// 
			// result13Box
			// 
			this.result13Box.Location = new System.Drawing.Point(86, 383);
			this.result13Box.Name = "result13Box";
			this.result13Box.ReadOnly = true;
			this.result13Box.Size = new System.Drawing.Size(124, 20);
			this.result13Box.TabIndex = 1;
			// 
			// text4Analyze10
			// 
			this.text4Analyze10.Location = new System.Drawing.Point(86, 45);
			this.text4Analyze10.Name = "text4Analyze10";
			this.text4Analyze10.Size = new System.Drawing.Size(293, 112);
			this.text4Analyze10.TabIndex = 2;
			this.text4Analyze10.Text = "";
			// 
			// text4Analyze13
			// 
			this.text4Analyze13.Location = new System.Drawing.Point(86, 265);
			this.text4Analyze13.Name = "text4Analyze13";
			this.text4Analyze13.Size = new System.Drawing.Size(293, 112);
			this.text4Analyze13.TabIndex = 3;
			this.text4Analyze13.Text = "";
			// 
			// analyze10
			// 
			this.analyze10.Location = new System.Drawing.Point(413, 45);
			this.analyze10.Name = "analyze10";
			this.analyze10.Size = new System.Drawing.Size(90, 50);
			this.analyze10.TabIndex = 4;
			this.analyze10.Text = "button11";
			this.analyze10.UseVisualStyleBackColor = true;
			this.analyze10.Click += new System.EventHandler(this.analyze10_Click);
			// 
			// analyze13
			// 
			this.analyze13.Location = new System.Drawing.Point(413, 265);
			this.analyze13.Name = "analyze13";
			this.analyze13.Size = new System.Drawing.Size(90, 50);
			this.analyze13.TabIndex = 5;
			this.analyze13.Text = "button12";
			this.analyze13.UseVisualStyleBackColor = true;
			this.analyze13.Click += new System.EventHandler(this.analyze13_Click);
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
	}
}

