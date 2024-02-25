namespace FizzBuzz.Services.FizzBuzz.Contracts
{
    public interface FizzBuzzServices
    {
        bool CheckBuzz(int num);
        bool CheckFizz(int num);
        int GetInt(string input);
        string PrintResult(bool isFizz, bool isBuzz);
    }
}