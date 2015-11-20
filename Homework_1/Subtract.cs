using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_1
{
    class Subtract : Action, IAction
    {

        public override double Calculate(double a, double b)
        {
            A = a;
            B = b;
            return A - B;
        }

        #region IAction Members

        public string Remainder(double a, double b)
        {
            string s;
            A = a;
            B = b;
            try
            {
                return s = (A - B) % 2 == 0 ? "Рiзниця являється парним числом" : "Рiзниця являється непарним числом";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion
    }
}
