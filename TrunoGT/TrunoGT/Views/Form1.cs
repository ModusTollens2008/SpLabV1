using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace TrunoGT
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
			dataGridView1.ColumnCount = 4;
			
			List<BinaryNode> nd = new List<BinaryNode>();
			//WorkWithFiles.ReadFromBin("D:/ SPLabV1 / SpLabV1 / TrunoGT / TrunoGT / TRUNOGTFILES / binfile.bin");
			BinListOperaions wd = new BinListOperaions();
			wd.BinFiles = WorkWithFiles.ReadFromBin("D:/SPLabV1/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/binfile.bin").ToList();
			nd = wd.BinFiles;
			nd.Add(new BinaryNode("Directory2", "114", "11.03.2020"));
			wd.BinFiles = WorkWithFiles.ReadFromBin("D:/SPLabV1/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/binfile.bin").ToList();
			nd = wd.BinFiles;

			dataGridView1.RowCount = nd.Count;
			for (int i=0;i<nd.Count;i++)
			{
				dataGridView1.Rows[i].Cells[0].Value = i+1;
				dataGridView1.Rows[i].Cells[1].Value = nd[i].Filepath;
				dataGridView1.Rows[i].Cells[2].Value = nd[i].Size;
				dataGridView1.Rows[i].Cells[3].Value = nd[i].Createdate;
				dataGridView1.Columns[0].Width = 20;
				dataGridView1.Columns[1].Width = 200;
				dataGridView1.Columns[2].Width = 100;
				dataGridView1.Columns[3].Width = 200;
			}

		}
		
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Console.WriteLine("sdfsdfdsfdsfsd");
		}
	}
}
