using SOLID.IO;
using System;
using System.IO;

namespace SOLID
{
    internal class Calculator
    {
        private IWriter writer;

        public Calculator(IWriter writer)
        {
            this.writer = writer;
        }

        public void Calculated(double a, double b, char operation)
        {
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = Add(a, b);
                    break;
                case '-':
                    result = Sub(a, b);
                    break;
                case '*':
                    result = Mul(a, b);
                    break;
                case '/':
                    result = Div(a, b);
                    break;
                default:
                    writer.Write("Not supported");
                    break;
            }
            writer.Write($"{a} {operation} {b} = {result}");
        }
        


    private  double Add(double a, double b)
        {
            var outcome = a + b;

            var output = $"{a} + {b} = {outcome}";
            LogHistory(output);
            return outcome;
        }

        private  double Div(double a, double b)
        {
            var outcome = a / b;

            var output = $"{a} / {b} = {outcome}";
            LogHistory(output);
            return outcome;
        }

        private  void LogHistory(string output)
        {
            File.AppendAllText("log.json", $"{DateTime.UtcNow} : {output}\n");
        }

        private  double Mul(double a, double b)
        {
            var outcome = a * b;

            var output = $"{a} * {b} = {outcome}";
            LogHistory(output);
            return outcome;
        }

        private  double Sub(double a, double b)
        {
            var outcome = a - b;

            var output = $"{a} - {b} = {outcome}";
            LogHistory(output);
            return outcome;
        }
    }
}