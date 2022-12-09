using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Integrator
    {
        private readonly Equation equation;
        public Integrator(Equation equation)
        {
            if (equation == null)
                throw new ArgumentNullException();
            this.equation = equation;
        }
        public double Integrate(double x1, double x2) // Функция интегрирования, x1 левая граница интегрирования, x2" правая граница интегрирования
        {
            if (x1 >= x2)
                throw new ArgumentException("Правая граница интегирования должны быть больше левой!");
            int N = 100; //Количество интервалов разбиения
            double h = (x2 - x1) / N; //Ширинa интервала
            double sum = 0; //"накопитель" значения интеграла
            for (int i = 0; i < N; i++) { sum += equation.GetValue(x1 + i * h) * h; }
            return sum;
        }
    }
}
