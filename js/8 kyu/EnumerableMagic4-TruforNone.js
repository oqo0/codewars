// https://www.codewars.com/kata/545993ee52756d98ca0010e1/

function none(arr, fun) {
    for (let i = 0; i < arr.length; i++) {
      let item = arr[i];
      if (fun(item) == true) {
        return false;
      };
    }
    
    return true;
  }