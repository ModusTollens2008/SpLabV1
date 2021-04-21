using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrunoGT.IViews
{
	interface IForm
	{
		string FilePath
		{get; set;}
		string FilePathDLL
		{ get; set; }
		string newNameDLL
		{ get; set; }
		string newVersionDLL
		{ get; set; }
		string newLastChangeDLL
		{ get; set; }
		int BinIndex
		{get; set;}
		int DLLIndex
		{ get; set; }
		string newFilePath
		{get; set;}
		string newCreateDate
		{get; set;}
		string newSize
		{get; set;}

		void OutTable(List<BinaryNode> binlist);
		event EventHandler Add;
		event EventHandler Delete;
		event EventHandler Save;
		event EventHandler ReadFromFile;
		event EventHandler Edit;

		void OutTableDLL(List<DllNode> dlllist);
		event EventHandler AddDLL;
		event EventHandler DeleteDLL;
		event EventHandler SaveDLL;
		event EventHandler ReadFromFileDLL;
		event EventHandler EditDLL;
	}
}
