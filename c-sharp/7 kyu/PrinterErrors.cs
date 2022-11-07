// https://www.codewars.com/kata/56541980fa08ab47a0000040/

using System.Linq;

public class Printer 
{
    public static string PrinterError(string s) 
    {
        return s.Where(c => c > 'm').Count() + "/" + s.Length;
    }
}