using System;

namespace BranchesAndLoops
{
    class If
    {
        public void Run()
        {
            code0();
            code1();
            code2();
            code3();
            code4();
            code5();
            code6();
            code7();
            code8();
            code9();
        }
        private void code0() { if (true) Console.WriteLine("if"); }
        private void code1()
        {
            if (false) Console.WriteLine("if");
            else Console.WriteLine("else");
        }
        private void code2()
        {
            if (false) Console.WriteLine("if");
            else if (true) Console.WriteLine("else if");
            else Console.WriteLine("else");
        }
        private void code3()
        {
            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
            b = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
        }
        private void code4()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is not greater than 10");
        }
        private void code5()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }
        }
        private void code6()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
        }
        private void code7()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
        }

        private void code8()
        {
            int v = (true) ? 1 : 2;
            Console.WriteLine($"v = {v}");
        }

        private void code9()
        {
            switch (5) {
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }
    }
}
