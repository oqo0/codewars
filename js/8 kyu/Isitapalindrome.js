// https://www.codewars.com/kata/57a1fd2ce298a731b20006a4/

function isPalindrome(s) {
    s = s.toLowerCase();
    
    for (let i = 0, j = s.length - 1;
         i < s.length;
         i++, j--) {
      if (s[i] !== s[j])
        return false;
    }
    
    return true;
}