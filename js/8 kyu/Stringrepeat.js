// https://www.codewars.com/kata/57a0e5c372292dd76d000d7e/

// string has a repeat() function
// The repeat() method constructs and returns a new string
// which contains the specified number of copies of the string
// on which it was called, concatenated together.

function repeatStr (n, s) {
    let res = s;
    for (let i = 1; i < n; i++)
      res += s;
    return res;
  }