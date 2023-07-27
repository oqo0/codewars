// https://www.codewars.com/kata/534eb5ad704a49dcfa000ba6

using System;

static class Kata
{
  public static int Hanoi(int d) 
    => (int) Math.Pow(2, d) - 1;
}