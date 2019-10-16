using System;
using System.Collections.Generic;

namespace BranchesAndLoops
{
    class Loop
    {
        public void Run()
        {
            code0();
            code1();
            code2();
            code3();
        }
        private void code0()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
        }
        private void code1()
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
        }
        private void code2()
        {
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }
        }
        private void code3()
        {
            foreach (int i in new List<int>(){1,3,5})
            {
                Console.WriteLine($"foreach {i}");
            }
        }

    }
}
