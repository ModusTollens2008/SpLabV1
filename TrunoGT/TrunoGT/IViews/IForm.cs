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
		int BinIndex
		{get; set;}
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
	}
}
