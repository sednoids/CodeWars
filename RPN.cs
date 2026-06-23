namespace RPN;

class Program
{
    static void Main(string[] args)
    {
        string expr = "3 4 +";
        string[] exprArray = expr.Split(" ");
        string operators = "+-*/";
        Stack<double> stack = [];
        for (int i = 0; i < exprArray.Length; i++)
        {
            if (operators.Contains(exprArray[i]))
            {
                double number1 = stack.Pop();
                double number2 = stack.Pop();

                switch (exprArray[i])
                {
                    case "+":
                        stack.Push(number2 + number1);
                        break;
                    case "-":
                        stack.Push(number2 - number1);
                        break;
                    case "*":
                        stack.Push(number2 * number1);
                        break;
                    case "/":
                        stack.Push(number2 / number1);
                        break;
                }
            }
            else
            {
                stack.Push(Convert.ToDouble(exprArray[i]));
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                } 
            }
        }
        
        double result = stack.Pop();
        Console.WriteLine(result);


    }
}