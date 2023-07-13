using System;

namespace laprak5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            numbers.CariNilaiMin(28, 24);
            numbers.CariNilaiMin(28, 24, 56);
            numbers.CariNilaiMax(28, 24);
            numbers.CariNilaiMax(28, 24, 56);
        }
    }
}