using BusinessLogic;
using BusinessLogic.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrunoGT.Models
{
    /// <summary>
    /// Класс моделей анализа кода
    /// </summary>
    class ModelAnalyse
    {
        /// <summary>
        /// Экземпляр класса анализа кода
        /// </summary>
        private IStructureAnalyse _Istr =new StructureAnalyse();
        /// <summary>
        /// Лог действий
        /// </summary>
        public string AnalyseLog
        { get; set; }

        /// <summary>
        /// Модель анализа цикла WhileDo
        /// </summary>
        /// <param name="code">Анализируемый код</param>
        /// <returns>Возвращает была ли хотя бы одна иттерация</returns>
        public int CheckWhileDoStucture(string code)
        {
            AnalyseLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Анализ кода начался!" + "\n";
            int a = -1;
            try
            {
                a = _Istr.CheckWhileDoStucture(code);
            }
            catch (System.IndexOutOfRangeException)
            {
                AnalyseLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Отсуствует тело цикла!" + "\n";
            }
            catch (System.IO.FileNotFoundException)
            {
                AnalyseLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Код невозможно скомпилировать!" + "\n";
            }
            catch (Exception)
            {
                AnalyseLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Ошибка ввода!" + "\n";
            }
            if (a < 0)
            {
                AnalyseLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Не обнаружена правильная языковая конструкция" + "\n";
                a = 0;
            }
            else
            {
                AnalyseLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Код успешно скомпилирован!" + "\n";
            }
            return a;          
        }
        /// <summary>
        /// Модель анализа цикла foreach
        /// </summary>
        /// <param name="code">Анализируемый код</param>
        /// <returns>Возвращает количество иттераций цикла</returns>
        public int CheckStucture(string code)
        {
            AnalyseLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Анализ кода начался!" + "\n";
            int a = -1;
            try
            {
                a = _Istr.CheckStucture(code);
            }
            catch (System.IndexOutOfRangeException)
            {
                AnalyseLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Отсуствует тело цикла!"+ "\n";
            }
            catch (System.IO.FileNotFoundException)
            {
                AnalyseLog += DateTime.Now.ToString("dd.MM.yyyy ")  + DateTime.Now.ToString("HH:mm:ss ") + "Код невозможно скомпилировать!"+ "\n";
            }
            catch (Exception)
            {
                AnalyseLog += DateTime.Now.ToString("dd.MM.yyyy ")  + DateTime.Now.ToString("HH:mm:ss ")+ "Ошибка ввода!" + "\n";
            }
            if (a < 0)
            {
                AnalyseLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Не обнаружена правильная языковая конструкция" + "\n";
                a = 0;
            }
            else
            {
                AnalyseLog += DateTime.Now.ToString("dd.MM.yyyy ")  + DateTime.Now.ToString("HH:mm:ss ") + "Код успешно скомпилирован!" + "\n";
            }
            return a;
        }
    }
}
