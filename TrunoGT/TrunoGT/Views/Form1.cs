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
		private int binindex;
		private OpenFileDialog openFileDialog1 = new OpenFileDialog();
		public Form1()
		{
			InitializeComponent();
			dataGridView1.ColumnCount = 4;
			dataGridView1.Columns[0].Width = 50;
			dataGridView1.Columns[1].Width = 150;
			dataGridView1.Columns[0].HeaderCell.Value = "№";
			dataGridView1.Columns[1].HeaderCell.Value = "Расположение";
			dataGridView1.Columns[2].HeaderCell.Value = "Дата создания";
			dataGridView1.Columns[3].HeaderCell.Value = "Размер";
			ListOperationsPresenter LOPresenter = new ListOperationsPresenter(this);
			dataGridView1.RowCount = 1;

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

		public event EventHandler Save;
		public event EventHandler Delete;
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
					//var sr = new StreamReader(openFileDialog1.FileName);
					//SetText(sr.ReadToEnd());
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
					$"Details:\n\n{ex.StackTrace}");
				}
			}
			dataGridView1.Rows.Add();
			Save.Invoke(sender, e);

		}

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (dataGridView1.Rows.Count!=1)
			{
				Delete.Invoke(sender, e);
				dataGridView1.Rows.RemoveAt(BinIndex+1);
			}
		}
	}
}
