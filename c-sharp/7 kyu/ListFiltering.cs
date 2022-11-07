// https://www.codewars.com/kata/53dbd5315a3c69eed20002dd/

using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ListFilterer
{
  public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
  {
    return listOfItems.OfType<int>().Cast<int>();
  }
}