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


        public void MulClr()
        {
            LowLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Значения для умножения очищены!" + "\n";
        }

        public void XORClr()
        {
            LowLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Значения для побитового НЕ очищены!" + "\n";
        }
        public int XOR(string a)
        {
           int value = 0;
            try
            {
                value = int.Parse(a);
                value = _ILow.LowLevelNot(value);
            }

            catch (ArgumentNullException)
            {
                LowLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Ошибка! " + "Число не было введено" + "\n";
            }
            catch (FormatException)
            {
                LowLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Ошибка! Число имело неверный формат" + "\n";
            }
            catch (OverflowException)
            {
                LowLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Слишком большое первое число!" + "\n";
            }
            catch (Exception)
            {
                LowLog +=  DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Неизвестная ошибка в обработке первого числа!" +  "\n";
            }
            if (value != 0)
            {
                LowLog +=DateTime.Now.ToString("dd.MM.yyyy ") +  DateTime.Now.ToString("HH:mm:ss ") + "Успешное вычисление побитового НЕ! " +"Результат вычисления: "+value+ "\n";
            }
            return value;
           
        }
        public int Mul(string a, string b)
        {
            LowLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Инициализация умножения!" + "\n";
            int firstvalue = 0;
            int secondvalue = 0;
            int mulres=0;
            try
            {
                firstvalue = int.Parse(a);
            }

            catch (ArgumentNullException)
            {
                LowLog +=  DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Ошибка! " + "Первое число не было введено" + "\n";
                return mulres;
            }
            catch (FormatException)
            {
                LowLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Ошибка! Первое число имело неверный формат" + "\n";
                return mulres;
            }
            catch (OverflowException)
            {
                LowLog += DateTime.Now.ToString("dd.MM.yyyy ")  + DateTime.Now.ToString("HH:mm:ss ") + "Слишком большое первое число!" + "\n";
                return mulres;
            }
            catch (Exception)
            {
                LowLog +=  DateTime.Now.ToString("dd.MM.yyyy ")  + DateTime.Now.ToString("HH:mm:ss ") + "Неизвестная ошибка в обработке первого числа!" + "\n";
                return mulres;
            }

            try
            {
                secondvalue= int.Parse(b);
                mulres = _ILow.LowLevelMultiple(firstvalue, secondvalue);
                LowLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Операция произошла успешно!" + "\n";
            }
            catch (ArgumentNullException)
            {
                LowLog +=  DateTime.Now.ToString("dd.MM.yyyy ")+ DateTime.Now.ToString("HH:mm:ss ") + "Ошибка! " + "Второе число не было введено" + "\n";
            }
            catch (FormatException)
            {
                LowLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Ошибка! Второе число имело неверный формат" + "\n";
            }
            catch (OverflowException)
            {
                LowLog +=  DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Слишком большое второе число!" + "\n";
            }
            catch (Exception)
            {
                LowLog +=  DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Неизвестная ошибка в обработке второго числа!"+ "\n";
            }
         
            
            return mulres;
            //return _ILow.LowLevelMultiple(a,b);
        }

    }
}
