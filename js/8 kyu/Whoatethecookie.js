// https://www.codewars.com/kata/55a996e0e8520afab9000055/

function cookie(data) {
    let name;
    
    const typeOfDate = typeof data;
    
    if (typeOfDate == "string") {
      name = "Zach";
    } else if (typeOfDate == "number") {
      name = "Monica";
    } else {
      name = "the dog";
    }
    
    return `Who ate the last cookie? It was ${name}!`;
  }