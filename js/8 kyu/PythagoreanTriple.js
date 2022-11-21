// https://www.codewars.com/kata/5951d30ce99cf2467e000013/

function isPythagoreanTriple(arr) {
  const maxValue = Math.max(...arr);
  arr.splice(arr.indexOf(maxValue), 1);
  
  return maxValue * maxValue === arr[0] * arr[0] + arr[1] * arr[1];
}