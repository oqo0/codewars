// https://www.codewars.com/kata/554e4a2f232cdd87d9000038/

using System;
using System.Linq;

public class DnaStrand
{
    public static string MakeComplement(string dna)
    {
        return String.Concat(dna.Select(GetComplement));
    }

    public static char GetComplement(char symbol)
    {
        switch (symbol)
        {
            case 'A':
                return 'T';
            case 'T':
                return 'A';
            case 'C':
                return 'G';
            case 'G':
                return 'C';
            default:
                throw new ArgumentException();
        }
    }
}