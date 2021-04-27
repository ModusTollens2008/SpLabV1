using BusinessLogic;
using BusinessLogic.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrunoGT.Models
{
    class ModelAnalyse
    {
        private IStructureAnalyse _Istr =new StructureAnalyse();
        public string AnalyseLog
        { get; set; }

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
