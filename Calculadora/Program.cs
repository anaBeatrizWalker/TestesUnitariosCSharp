using Calculadora.Services;

CalculadoraImp calImp = new CalculadoraImp();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"{num1} + {num2} = {calImp.Somar(num1, num2)}");