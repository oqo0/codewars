// https://www.codewars.com/kata/5601c5f6ba804403c7000004/

function barTriang(p1, p2, p3) {
    const cordX = (p1[0] + p2[0] + p3[0]) / 3;
    const cordY = (p1[1] + p2[1] + p3[1]) / 3;
    return [ rem(cordX), rem(cordY) ];
  }
  function rem(num) {
    return Number.parseFloat(num.toFixed(4));
  }