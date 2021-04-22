using LowFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrunoGT.Models
{
    class ModelLowLevel
    {
        private LowLevelFunctions _ILow = new LowLevelFunctions();       
        public string LowLog
        {get;set;}
        public int XOR(string a)
        {
           int value = 0;
            try
            {
                value = int.Parse(a);
            }

            catch (ArgumentNullException)
            {
                LowLog += "Ошибка! " + "Первое число не было введено" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (FormatException)
            {
                LowLog += "Ошибка! Первое число имело неверный формат" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (OverflowException)
            {
                LowLog += "Слишком большое первое число!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (Exception)
            {
                LowLog += "Неизвестная ошибка в обработке первого числа!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }           
            LowLog += "Операция произошла успешно!";
           return _ILow.LowLevelNot(value);
           
        }
        public int Mul(string a, string b)
        {
            LowLog += "Инициализация умножения!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            int firstvalue = 0;
            int secondvalue = 0;
            int mulres;
            try
            {
                firstvalue = int.Parse(a);
            }

            catch (ArgumentNullException)
            {
                LowLog += "Ошибка! " + "Первое число не было введено" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (FormatException)
            {
                LowLog += "Ошибка! Первое число имело неверный формат" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (OverflowException)
            {
                LowLog += "Слишком большое первое число!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (Exception)
            {
                LowLog += "Неизвестная ошибка в обработке первого числа!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }

            try
            {
                secondvalue= int.Parse(b);
            }
            catch (ArgumentNullException)
            {
                LowLog += "Ошибка! " + "Второе число не было введено" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (FormatException)
            {
                LowLog += "Ошибка! Второе число имело неверный формат" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (OverflowException)
            {
                LowLog += "Слишком большое второе число!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (Exception)
            {
                LowLog += "Неизвестная ошибка в обработке второго числа!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            if ((secondvalue == 0) && (firstvalue == secondvalue))
            {
                mulres = 0;
                LowLog += "Упс! Что-то пошло не так :С" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            else
            {
                mulres = _ILow.LowLevelMultiple(firstvalue, secondvalue);
                LowLog += "Операция произошла успешно!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            return mulres;
            //return _ILow.LowLevelMultiple(a,b);
        }

    }
}
