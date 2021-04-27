using System;
using System.Collections.Generic;
using BusinessLogic;

namespace TrunoGT.IViews
{
	interface IForm
    {

        string Code
        {
            get; set;
        }
        string CodeGT
        {
            get; set;
        }
        string Result
        {
            get; set;
        }
        string FilePath
        { get; set; }
        string FilePathDLL
        { get; set; }
        string newNameDLL
        { get; set; }
        string newVersionDLL
        { get; set; }
        string newLastChangeDLL
        { get; set; }
        int BinIndex
        { get; set; }
        int DLLIndex
        { get; set; }
        string newFilePath
        { get; set; }
        string newCreateDate
        { get; set; }
        string newSize
        { get; set; }
        string FirstNum
        {
            get; set;
        }
        string SecondNum
        {
            get; set;
        }
        int MulResult
        {
            get; set;
        }
        string XorNum
        {
            get; set;
        }
        int XorRes
        {
            get; set;
        }
        string LowLog
        {
            get; set;
        }
        string FileLog
        {
            get; set;
        }
        string AnalyseLog
        {
            get; set;
        }

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

		event EventHandler Analyze10;
		event EventHandler Analyze13;
		event EventHandler XOR;
		event EventHandler Mul;
	}
}
