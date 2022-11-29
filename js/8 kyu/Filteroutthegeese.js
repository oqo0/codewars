// https://www.codewars.com/kata/57ee4a67108d3fd9eb0000e7/

function gooseFilter (birds) {
    let geese = ["African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher"];
    let res = [];
    
    for (let i = 0; i < birds.length; i++) {
      if (geese.includes(birds[i]) == false){
        res.push(birds[i]);
      }
    }
    
    return res;
  };    