// https://www.codewars.com/kata/58844f1a76933b1cd0000023/

namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int KillKthBit(int n,int k) => n & ~(1<<k-1);
    }
}