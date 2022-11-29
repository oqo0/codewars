// https://www.codewars.com/kata/577a98a6ae28071780000989/

let min = function(list) {
  for (let i = 0; i < list.length; i++) {
    if (list[i] < list[0])
      list[0] = list[i];
  }
  return list[0];
}

let max = function(list) {
  for (let i = 0; i < list.length; i++) {
    if (list[i] > list[0])
      list[0] = list[i];
  }
  return list[0];
}