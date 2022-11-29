// https://www.codewars.com/kata/5808dcb8f0ed42ae34000031/

// Creating an array with strings and taking it's value is much smarter
// ["Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine"]

function switchItUp(num) {
    switch (num) {
      case 0:
        return "Zero";
      case 1:
        return "One";
      case 2: 
        return "Two";
      case 3: 
        return "Three";
      case 4: 
        return "Four";
      case 5:
        return "Five";
      case 6: 
        return "Six";
      case 7:  
        return "Seven";
      case 8:
        return "Eight";
      case 9:  
        return "Nine";
      default:
        return "Invalid Input";
    }
  }