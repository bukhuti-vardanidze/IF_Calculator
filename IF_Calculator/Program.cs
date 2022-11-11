Console.WriteLine("Enter First Number : ");
double number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number : ");
double number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Choose One Operation : [+] [-] [*] [/] [%]");
string operations = Console.ReadLine();

if (operations == "+")
{
    Console.WriteLine($"{number1}+{number2}= {number1+number2}");
}
else if(operations == "-")
{
    Console.WriteLine($"{number1}-{number2}= {number1-number2}");
}
else if(operations == "*") 
{
    Console.WriteLine($"{number1}*{number2}= {number1*number2}");
}
else if (operations == "/")
{
    Console.WriteLine($"{number1}/{number2}= {number1/number2}");
}
else if (operations == "%")
{
    Console.WriteLine($"{number1}%{number2}=  {number1%number2}");
}
else{
Console.WriteLine("Choose Correct Option!");
}