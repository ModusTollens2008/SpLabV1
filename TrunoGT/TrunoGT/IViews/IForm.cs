using System;
using System.Collections.Generic;
using BusinessLogic;

namespace TrunoGT.IViews
{
    /// <summary>
    /// Интерфейс формы
    /// </summary>
	interface IForm
    {
        /// <summary>
        /// Анализируемый код для цикла foreach
        /// </summary>
        string Code
        {
            get; set;
        }
        /// <summary>
        /// Анализируемый код для цикла Do while
        /// </summary>
        string CodeGT
        {
            get; set;
        }
        /// <summary>
        /// Количество иттераций цикла
        /// </summary>
        string Result
        {
            get; set;
        }
        /// <summary>
        /// Путь к бинарному файлу
        /// </summary>
        string FilePath
        { get; set; }
        /// <summary>
        /// Путь к длл файлу
        /// </summary>
        string FilePathDLL
        { get; set; }
        /// <summary>
        /// Новое имя для длл файла
        /// </summary>
        string newNameDLL
        { get; set; }
        /// <summary>
        /// Новая версия длл файла
        /// </summary>
        string newVersionDLL
        { get; set; }
        /// <summary>
        /// Новая дата изменения длл файла
        /// </summary>
        string newLastChangeDLL
        { get; set; }
        /// <summary>
        /// Индекс бинарного файла в списке
        /// </summary>
        int BinIndex
        { get; set; }
        /// <summary>
        /// Индекс длл файла в списке
        /// </summary>
        int DLLIndex
        { get; set; }
        /// <summary>
        /// Новый путь к бинарному файлу
        /// </summary>
        string newFilePath
        { get; set; }
        /// <summary>
        /// Новая дата создания для бинарного файла
        /// </summary>
        string newCreateDate
        { get; set; }
        /// <summary>
        /// Новый размер бинарного файла
        /// </summary>
        string newSize
        { get; set; }
        /// <summary>
        /// Первое число для умножения
        /// </summary>
        string FirstNum
        {
            get; set;
        }
        /// <summary>
        /// Второе число для умножения
        /// </summary>
        string SecondNum
        {
            get; set;
        }
        /// <summary>
        /// Результат умножения
        /// </summary>
        int MulResult
        {
            get; set;
        }
        /// <summary>
        /// Число для побитового не
        /// </summary>
        string XorNum
        {
            get; set;
        }
        /// <summary>
        /// Результат побитового не
        /// </summary>
        int XorRes
        {
            get; set;
        }
        /// <summary>
        /// Лог для низкоуровневых операций
        /// </summary>
        string LowLog
        {
            get; set;
        }
        /// <summary>
        /// Лог для работы с файлом
        /// </summary>
        string FileLog
        {
            get; set;
        }
        /// <summary>
        /// Лог для анализа кода
        /// </summary>
        string AnalyseLog
        {
            get; set;
        }

        /// <summary>
        /// Ивент вывода списка
        /// </summary>
        /// <param name="binlist">список бинарных файлов</param>
		void OutTable(List<BinaryNode> binlist);
        /// <summary>
        /// Добавление бинарного файла
        /// </summary>
		event EventHandler Add;
        /// <summary>
        /// Удаление бинарного файла
        /// </summary>
		event EventHandler Delete;
        /// <summary>
        /// Сохранение бинарных файлов
        /// </summary>
		event EventHandler Save;
        /// <summary>
        /// Чтение из файла
        /// </summary>
		event EventHandler ReadFromFile;
        /// <summary>
        /// Изменение файла
        /// </summary>
		event EventHandler Edit;
        /// <summary>
        /// Ивент для вывода списка длл файлов
        /// </summary>
        /// <param name="dlllist">список длл файлов</param>
		void OutTableDLL(List<DllNode> dlllist);
        /// <summary>
        /// Добавление длл файла
        /// </summary>
		event EventHandler AddDLL;
        /// <summary>
        /// удаление длл файла
        /// </summary>
		event EventHandler DeleteDLL;
		event EventHandler SaveDLL;
        /// <summary>
        /// Чтение из XML 
        /// </summary>
		event EventHandler ReadFromFileDLL;
        /// <summary>
        /// Изменение файла
        /// </summary>
		event EventHandler EditDLL;

        /// <summary>
        /// Анализ foreach
        /// </summary>
		event EventHandler Analyze10;
        /// <summary>
        /// Анализ Do while
        /// </summary>
		event EventHandler Analyze13;
        /// <summary>
        /// Побитовое НЕ
        /// </summary>
		event EventHandler XOR;
        /// <summary>
        /// Умножение
        /// </summary>
		event EventHandler Mul;

        /// <summary>
        /// Очистка полей для умножения
        /// </summary>
        event EventHandler ClrMul;
        /// <summary>
        /// Очистка полей для побитового НЕ
        /// </summary>
        event EventHandler ClrXOR;
    }
}
