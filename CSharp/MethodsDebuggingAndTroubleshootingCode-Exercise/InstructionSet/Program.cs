using System;

class InstructionSet
{
    static void Main()
    {
        string opCode = Console.ReadLine();

        while (opCode != "END")
        {
           
            switch (opCode)
            {
                case "INC":
                    {
                        int operandOne = int.Parse(Console.ReadLine());
                        Console.WriteLine(operandOne++);
                        break;
                    }
                case "DEC":
                    {
                        int operandOne = int.Parse(Console.ReadLine());
                        Console.WriteLine(operandOne--);
                        break;
                    }
                case "ADD":
                    {
                        int operandOne = int.Parse(Console.ReadLine());
                        int operandTwo = int.Parse(Console.ReadLine());
                        Console.WriteLine((long)operandOne+operandTwo);
                        break;
                    }
                case "MLA":
                    {
                        int operandOne = int.Parse(Console.ReadLine());
                        int operandTwo = int.Parse(Console.ReadLine());
                        Console.WriteLine((long)operandOne*operandTwo); ;
                        break;
                    }
            }
            opCode = Console.ReadLine();

            
        }
    }
}