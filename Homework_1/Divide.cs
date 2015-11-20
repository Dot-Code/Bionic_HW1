using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_1
{
    class Divide : Action, IAction
    {
        public override double Calculate(double a, double b)
        {
            A = a;
            B = b;
            if (B == 0)
                try
                {
                    {
                        throw new DivideByZeroException();
                        return A / B;
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Дiлення на нуль не можливе");
                }
            return A / B;
        }

        #region IAction Members

        public string Remainder(double a, double b)
        {
            string s;
            A = a;
            B = b;
            try
            {
                return s = (A / B) % 2 == 0 ? "Результат дiлення являється парним числом" : "Результат дiлення являється непарним числом";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion
    }
}
