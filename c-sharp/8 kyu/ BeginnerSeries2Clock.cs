// https://www.codewars.com/kata/55f9bca8ecaa9eac7100004a/

using System;

public static class Clock
{
  public static int Past(int h, int m, int s) => h * 1000 * 60 * 60 + m * 1000 * 60 + s * 1000;
}