// https://www.codewars.com/kata/5541f58a944b85ce6d00006a/

public class ProdFib
{
  public static ulong[] productFib(ulong prod, ulong a = 0, ulong b = 1)
  {
    return a * b == prod ? new ulong[] { a, b, 1 }
        : (a * b > prod ? new ulong[] { a, b, 0 }
        : productFib(prod, b, a + b));
  }
}