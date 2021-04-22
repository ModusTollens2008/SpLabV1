
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrunoGT.IViews;
using TrunoGT.Presenters;


namespace TrunoGT
{
	public partial class Form1 : Form,IForm
	{
		private string filepath;
		private string newfilepath;
		private string newcreatedate;
		private string newsize;
		private int binindex;
		private int dllindex;
		private string filepathdll;
		private string newnamedll;
		private string newversiondll;
		private string newlastchangedll;	
		private string code;
		private string codegt;
		private string result;
		private string firstnum;
		private string secondnum;
		private int mulresult;
		private string xornum;
		private int xorres;
		private string lowlog;
        private string filelog;

        private OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public Form1()
		{
			InitializeComponent();
			dataGridView1.ColumnCount = 4;
			dataGridView1.RowCount = 100;
			dataGridView1.Columns[0].Width = 50;
			dataGridView1.Columns[1].Width = 150;
			dataGridView1.Columns[0].HeaderCell.Value = "№";
			dataGridView1.Columns[1].HeaderCell.Value = "Расположение";
			dataGridView1.Columns[2].HeaderCell.Value = "Дата создания";
			dataGridView1.Columns[3].HeaderCell.Value = "Размер";
			dataGridView2.ColumnCount = 4;
			dataGridView2.RowCount = 100;
			dataGridView2.Columns[0].Width = 50;
			dataGridView2.Columns[1].Width = 150;
			dataGridView2.Columns[0].HeaderCell.Value = "№";
			dataGridView2.Columns[1].HeaderCell.Value = "Название";
			dataGridView2.Columns[2].HeaderCell.Value = "Версия";
			dataGridView2.Columns[3].HeaderCell.Value = "Дата изменения";
			ListOperationsPresenter LOPresenter = new ListOperationsPresenter(this);
			AnalyzePresenter analyzePresenter = new AnalyzePresenter(this);
			LowLevelPresenter lowLevelPresenter = new LowLevelPresenter(this);

		}
		public string FilePathDLL
		{
			get { return filepathdll; }
			set { filepathdll = value; }
		}
		public string newNameDLL
		{
			get { return newnamedll; }
			set { newnamedll = value; }
		}
		public string newVersionDLL
		{
			get { return newversiondll; }
			set { newversiondll = value; }
		}
		public string newLastChangeDLL
		{
			get { return newlastchangedll; }
			set { newlastchangedll = value; }
		}
		public string FilePath
		{	get { return filepath; }
			set { filepath = value; }
		}
		public int BinIndex
		{
			get { return binindex; }
			set { binindex = value; }
		}
		public int DLLIndex
		{
			get { return dllindex; }
			set { dllindex = value; }
		}
		public string newFilePath
		{
			get { return newfilepath; }
			set { newfilepath = value; }
		}
		public string newCreateDate
		{
			get { return newcreatedate; }
			set { newcreatedate = value; }
		}
		public string newSize
		{
			get { return newsize; }
			set { newsize = value; }
		}

		public string Code
		{	get  {return code; }
			set { code = value; }
		}

		public string CodeGT {
			get { return codegt; }
			set { codegt = value; }
		}
		public string Result {
			get { return result; }
			set { result = value; }
		}
		public string FirstNum {
			get { return firstnum; }
			set { firstnum = value; }
		}
		public string SecondNum {
			get { return secondnum; }
			set { secondnum = value; }
		}
		public int MulResult
		{
			get { return mulresult; }
			set { mulresult = value; }
		}
		public string XorNum
		{
			get { return xornum; }
			set { xornum = value; }
		}
		public int XorRes
		{
			get { return xorres; }
			set { xorres = value; }
		}
		public string LowLog
		{
			get { return lowlog; }
			set { lowlog = value; }
		}
        public string FileLog
        {
            get { return filelog; }
            set { filelog = value; }
        }
        public string AnalyseLog
        {
            get; set;
        }



		public event EventHandler Add;
		public event EventHandler Delete;
		public event EventHandler Save;
		public event EventHandler ReadFromFile;
		public event EventHandler Edit;
		public event EventHandler AddDLL;
		public event EventHandler DeleteDLL;
		public event EventHandler SaveDLL;
		public event EventHandler ReadFromFileDLL;
		public event EventHandler EditDLL;
		public event EventHandler Analyze10;
		public event EventHandler Analyze13;
		public event EventHandler XOR;
		public event EventHandler Mul;

		void IForm.OutTable(List<BinaryNode> binlist)
		{

			for (int i =0;i<binlist.Count;i++)
			{
				dataGridView1.Rows[i].Cells[0].Value = i+1;
				dataGridView1.Rows[i].Cells[1].Value = binlist[i].Filepath;
				dataGridView1.Rows[i].Cells[2].Value = binlist[i].Createdate;
				dataGridView1.Rows[i].Cells[3].Value = binlist[i].Size;
			}
			
		}
		void IForm.OutTableDLL(List<DllNode> binlist)
		{

			for (int i = 0; i < binlist.Count; i++)
			{
				dataGridView2.Rows[i].Cells[0].Value = i + 1;
				dataGridView2.Rows[i].Cells[1].Value = binlist[i].Name;
				dataGridView2.Rows[i].Cells[2].Value = binlist[i].Vers;
				dataGridView2.Rows[i].Cells[3].Value = binlist[i].Lastchange;
			}

		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					FilePath = openFileDialog1.FileName;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
					$"Details:\n\n{ex.StackTrace}");
				}
			}
			dataGridView1.Rows.Add();
			Add.Invoke(sender, e);
            fileBoxLog.Text = FileLog;

        }

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			BinIndex = dataGridView1.CurrentRow.Index;
			Delete.Invoke(sender, e);
			dataGridView1.Rows.RemoveAt(BinIndex);
            fileBoxLog.Text = FileLog;
        }

		private void button3_Click(object sender, EventArgs e)
		{
			Save.Invoke(sender, e);
            fileBoxLog.Text = FileLog;
		}

		private void button4_Click(object sender, EventArgs e)
		{	
			ReadFromFile.Invoke(sender, e);
            fileBoxLog.Text = FileLog;
        }

		private void button5_Click(object sender, EventArgs e)
		{
            try
            {
                BinIndex = dataGridView1.CurrentRow.Index;
                newFilePath = dataGridView1.Rows[BinIndex].Cells[1].Value.ToString();
                newCreateDate = dataGridView1.Rows[BinIndex].Cells[2].Value.ToString();
                newSize = dataGridView1.Rows[BinIndex].Cells[3].Value.ToString();
                Edit.Invoke(sender, e);
            }
            catch (NullReferenceException)
            {
                FileLog += "ERROR: Выберите файл для редактирования!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
                fileBoxLog.Text = FileLog;
            }
            catch (Exception)
            {
                FileLog += "ERROR: При сохранении произошла неизвестная ошибка!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
                fileBoxLog.Text = FileLog;
            }
            fileBoxLog.Text = FileLog;
        }

		private void button6_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					FilePathDLL = openFileDialog1.FileName;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
					$"Details:\n\n{ex.StackTrace}");
				}
			}
			dataGridView1.Rows.Add();
			AddDLL.Invoke(sender, e);
            fileBoxLog.Text = FileLog;
        }

		private void button7_Click(object sender, EventArgs e)
		{
			DLLIndex = dataGridView2.CurrentRow.Index;
			DeleteDLL.Invoke(sender, e);
			dataGridView2.Rows.RemoveAt(DLLIndex);
            fileBoxLog.Text = FileLog;
        }

		private void button8_Click(object sender, EventArgs e)
		{
			SaveDLL.Invoke(sender, e);
            fileBoxLog.Text = FileLog;
        }

		private void button9_Click(object sender, EventArgs e)
		{
			ReadFromFileDLL.Invoke(sender, e);
            fileBoxLog.Text = FileLog;
        }

		private void button10_Click(object sender, EventArgs e)
		{
            try
            {
                DLLIndex = dataGridView2.CurrentRow.Index;
                newNameDLL = dataGridView2.Rows[DLLIndex].Cells[1].Value.ToString();
                newVersionDLL = dataGridView2.Rows[DLLIndex].Cells[2].Value.ToString();
                newLastChangeDLL = dataGridView2.Rows[DLLIndex].Cells[3].Value.ToString();
                EditDLL.Invoke(sender, e);
            }
            catch (NullReferenceException)
            {
                FileLog += "ERROR: Выберите файл для редактирования!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
                fileBoxLog.Text = FileLog;
            }
            catch (Exception)
            {
                FileLog += "ERROR: При сохранении произошла неизвестная ошибка!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
                fileBoxLog.Text = FileLog;
            }
            fileBoxLog.Text = FileLog;
        }

		private void mul_Click(object sender, EventArgs e)
		{
			FirstNum = boxFirstNum.Text;
			SecondNum = boxSecondNum.Text;
			Mul.Invoke(sender, e);
			boxSecondNum.Text = "Результат = " + MulResult;
			boxFirstNum.Text = "Умножаем " + FirstNum + " на " + SecondNum;
			boxSecondNum.ReadOnly = true;
			boxFirstNum.ReadOnly = true;
			lowLevelLog.Text = LowLog;
			mul.Enabled = false;
		}

		private void clr_Click(object sender, EventArgs e)
		{
			boxFirstNum.ReadOnly = false;
			boxSecondNum.ReadOnly = false;
			boxFirstNum.Clear();
			boxSecondNum.Clear();
			mul.Enabled = true;
            LowLog += "Значения очищены для умножения" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            lowLevelLog.Text = LowLog;
        }

		private void xor_Click(object sender, EventArgs e)
		{
			XorNum = boxXOR.Text;
			XOR.Invoke(sender, e);
			resBOX.Text = "Результат = " + XorRes;
			boxXOR.Text = "Исходное число=  " + XorNum;
			xor.Enabled = false;
			boxXOR.ReadOnly = true;
			lowLevelLog.Text = LowLog;

		}

		private void xorClr_Click(object sender, EventArgs e)
		{
			boxXOR.ReadOnly = false;
			xor.Enabled = true;
			boxXOR.Clear();
			resBOX.Clear();
            LowLog += "Значения очищены для НЕ" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            lowLevelLog.Text = LowLog;
        }

		private void analyze10_Click(object sender, EventArgs e)
		{
			Code = text4Analyze10.Text;
			Analyze10.Invoke(sender, e);
			result10Box.Text = Result;
            logBoxAnalyse.Text = AnalyseLog;
		}

		private void analyze13_Click(object sender, EventArgs e)
		{
			CodeGT = text4Analyze13.Text;
			Analyze13.Invoke(sender, e);
			result13Box.Text = Result;
            logBoxAnalyse.Text = AnalyseLog;
        }
	}
}
