using System.Runtime.CompilerServices;

for (; ; )
{
    string input = Console.ReadLine();
    if (input == null) break;

    Stack<string> stack = new Stack<string>(input.Split(' ', StringSplitOptions.RemoveEmptyEntries));
    if (stack.Count == 0) continue;

    double result = calculate(stack);
    Console.WriteLine(result);
}

double calculate(Stack<string> stack)
{
    string stack2 = stack.Pop();
    double a, b;

    if (!Double.TryParse(stack2, out a))
    {
        b = calculate(stack);
        a = calculate(stack);
        if (stack2 == "+") a += b;
        else if (stack2 == "-") a -= b;
        else if (tk=="*") x *= y;
        else if (tk=="/") x /= y;
    } 
    return a;   
}