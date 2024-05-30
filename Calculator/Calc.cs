namespace Calculator
{
    public class Calc
    {
        public delegate int MathOperation(int a, int b);
        public int Addition(int a, int b) { return a + b;}
        public int Subtraction(int a, int b) { return a - b; }
        
        public int Multiplication(int a, int b) { return a * b; }
       
        public int Division(int a, int b)
        {
            if (b == 0) { throw new DivideByZeroException("Division by zero is not allowed"); }
            return a / b;
        }
        //Method to execute a math operation
        public int ExecuteOperation(MathOperation operation,int a,int b)
        {
            return operation(a,b);
        }
    }
}
