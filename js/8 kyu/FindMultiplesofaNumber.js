// https://www.codewars.com/kata/58ca658cc0d6401f2700045f/

function findMultiples(int,limit){
    let result = []
    
    for (let i = int; i<=limit ; i+=int)
      result.push(i)
      
    return result
  }