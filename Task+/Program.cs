// Написать программу для перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994


Dictionary<char, int> map = new Dictionary<char, int>()
{{'I', 1 }, {'V', 5 }, {'X', 10 }, {'L', 50 }, {'C', 100 }, {'D', 500 }, {'M', 1000 }};

string InputNumber(string text)
{
    Console.Write($"{text}: ");
    string input = Console.ReadLine()!;
    return input.ToUpper();
}

int ConvertToArabic(string romanNumber)
{
    int result = 0;
    for (int i = 0; i < romanNumber.Length; i++)
    {
        if (i + 1 < romanNumber.Length && IsSubtractive(romanNumber[i], romanNumber[i + 1]))
        {
            result -= map[romanNumber[i]];
        }
        else
        {
            result += map[romanNumber[i]];
        }
    }
    return result;
}

bool IsSubtractive(char c1, char c2)
{
    return map[c1] < map[c2];
}

void PrintResult(string romanResult, int arabicResult)
{
    Console.Clear();
    Console.WriteLine("Вы ввели число - " + romanResult);
    Console.WriteLine("Результат перевода в арабские цифры - " + arabicResult);
}

void Main()
{
    Console.Clear();
    string romanNumbers = InputNumber("Введите ваше число римскими цифрами");
    int arabicNumber = ConvertToArabic(romanNumbers);
    PrintResult(romanNumbers, arabicNumber);
}

Main();