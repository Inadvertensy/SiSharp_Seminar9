// Ввести число, знак, второе число
// Сохраняем число
// если точка вместо знака, то стираем предыдущий ответ
// с предыдущим ответом выполняем действия
// символ q - выход из программы

Console.WriteLine("Введите число");
double result = Convert.ToInt32(Console.ReadLine());
char sign=' ';

while (true)
{
    Console.WriteLine("Введите знак");
    sign = Console.ReadKey().KeyChar;
    if (sign=='q' )
    break;

    Console.WriteLine();

    Console.WriteLine("Введите число");
    int B = Convert.ToInt32(Console.ReadLine());

    switch (sign)
    {
        case '+':
            result = result + B;
            break;
        case '-':
            result = result - B;
            break;
        case '*':
            result = result * B;
            break;
        case '/':
            result = result / B;
            break;
        case '.':
            
            result = 0;
            break;

        default:
            Console.WriteLine("Error! Wrong sign!");
            break;
    }
    Console.WriteLine($"Result is {result}");
}


