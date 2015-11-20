using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_1
{
    abstract class Action
    {
        private double a;
        private double b;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public abstract double Calculate(double a, double b);
    }
}
