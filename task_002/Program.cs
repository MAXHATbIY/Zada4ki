// Составить программу вывода на экран "столбиком" пяти любых чисел,
//введенных пользователем с клавиатуры

// Console.WriteLine()

int firstNumber;
int secondNumber;
int thirdNumber;
int fourNumber;
int fiveNumber;

Console.WriteLine("Введите первое число");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
thirdNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четвертое число");
fourNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пятое число");
fiveNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);
Console.WriteLine(thirdNumber);
Console.WriteLine(fourNumber);
Console.WriteLine(fiveNumber);