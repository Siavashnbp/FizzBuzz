using FizzBuzz.Services;

while (true)
{
    try
    {
        Run();
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}

void Run()
{
    Console.WriteLine("Enter your number:");
    var input = Console.ReadLine();
    var fizzBuzzServices = new FizzBuzzAppServices();
    var num = fizzBuzzServices.GetInt(input!);
    var isFizz = fizzBuzzServices.CheckFizz(num);
    var isBuzz = fizzBuzzServices.CheckBuzz(num);
    var result = fizzBuzzServices.PrintResult(isFizz, isBuzz);
    Console.WriteLine(result);
}