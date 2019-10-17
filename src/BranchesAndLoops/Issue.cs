using System;
using System.Collections.Generic;

namespace BranchesAndLoops
{
    class Issue
    {
        // 1から20の整数のうち3で割り切れる数の合計値を求めよ。
        public void Run()
        {
            int start = 1;
            int end = 20;
            int dev = 3;
            int sum = 0;
            for (int i=start; i<=end; i++) {
                if (0 == (i % dev)) { sum += i; }
            }
            Console.WriteLine($"{start}〜{end}のうち{dev}で割り切れる数の合計は{sum}である。");
        }
    }
}
