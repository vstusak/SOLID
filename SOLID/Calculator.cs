﻿using System;
using System.IO;

namespace SOLID
{
    internal class Calculator
    {

        public static void Calculated(double a, double b, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case operation == '+':
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
                    Console.WriteLine("Not supported");
                    break;
            }
            Console.WriteLine($"{a} {operation} {b} = {result}");
        }
        


    private static double Add(double a, double b)
        {
            var result = a + b;

            var output = $"{a} + {b} = {result}";
            LogHistory(output);
            return result;
        }

        private static double Div(double a, double b)
        {
            var result = a / b;

            var output = $"{a} / {b} = {result}";
            LogHistory(output);
            return result;
        }

        private static void LogHistory(string output)
        {
            File.AppendAllText("log.json", $"{DateTime.UtcNow} : {output}\n");
        }

        private static double Mul(double a, double b)
        {
            var result = a * b;

            var output = $"{a} * {b} = {result}";
            LogHistory(output);
            return result;
        }

        private static double Sub(double a, double b)
        {
            var result = a - b;

            var output = $"{a} - {b} = {result}";
            LogHistory(output);
            return result;
        }
    }
}