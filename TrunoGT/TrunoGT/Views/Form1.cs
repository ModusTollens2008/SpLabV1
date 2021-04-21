using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
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

		}

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			BinIndex = dataGridView1.CurrentRow.Index;
			Delete.Invoke(sender, e);
			dataGridView1.Rows.RemoveAt(BinIndex);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Save.Invoke(sender, e);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			
			ReadFromFile.Invoke(sender, e);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			BinIndex = dataGridView1.CurrentRow.Index;
			newFilePath = dataGridView1.Rows[BinIndex].Cells[1].Value.ToString();
			newCreateDate = dataGridView1.Rows[BinIndex].Cells[2].Value.ToString();
			newSize = dataGridView1.Rows[BinIndex].Cells[3].Value.ToString();
			Edit.Invoke(sender,e);
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
		}

		private void button7_Click(object sender, EventArgs e)
		{
			DLLIndex = dataGridView2.CurrentRow.Index;
			DeleteDLL.Invoke(sender, e);
			dataGridView2.Rows.RemoveAt(DLLIndex);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			SaveDLL.Invoke(sender, e);
		}

		private void button9_Click(object sender, EventArgs e)
		{
			ReadFromFileDLL.Invoke(sender, e);
		}

		private void button10_Click(object sender, EventArgs e)
		{
			DLLIndex = dataGridView2.CurrentRow.Index;
			newNameDLL = dataGridView2.Rows[DLLIndex].Cells[1].Value.ToString();
			newVersionDLL = dataGridView2.Rows[DLLIndex].Cells[2].Value.ToString();
			newLastChangeDLL = dataGridView2.Rows[DLLIndex].Cells[3].Value.ToString();
			EditDLL.Invoke(sender, e);
		}
	}
}
