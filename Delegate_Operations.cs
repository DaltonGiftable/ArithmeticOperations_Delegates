using System;

namespace Delegate_Operations
{

    //delegate declaration
    public delegate int OperatorDelegate(int operand);

    public class ArithmeticOperation
    {
        private int result;

        public int PerformOperation(OperatorDelegate operation, int operand)
        {
            result = operation(operand);
            return result;
        }

        public int GetNum()
        {
            return result;
        }

        public int Add(int operand)
        {
            return operand + 10;
        }

        public int Multiply(int operand)
        {
            return operand * 10;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            ArithmeticOperation operation = new ArithmeticOperation();

            //user integer input
            Console.Write("Enter an integer: ");
            int integerValue = int.Parse(Console.ReadLine());

            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Add 10");
            Console.WriteLine("2. Multiply by 10");
            int operatorChoice = int.Parse(Console.ReadLine());

            OperatorDelegate selectedOperator = null;
            //operator choice check
            if (operatorChoice == 1)
            {
                selectedOperator = operation.Add;
            }
            else if (operatorChoice == 2)
            {
                selectedOperator = operation.Multiply;
            }

            if (selectedOperator != null)
            {
                operation.PerformOperation(selectedOperator, integerValue);
                int result = operation.GetNum();

                Console.WriteLine("\nResult: {0}", result);
            }
            else
            {
                Console.WriteLine("Invalid Operator Choice!");
            }
        }
    }
}