// Даны два действительных числа x и у. 
// Вычислить их сумму, разность, произведение и частное.
double x;
double y;

Console.WriteLine("Введите число: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
y = Convert.ToDouble(Console.ReadLine());

double Sum = x + y;
double Dif = x - y;
double Pro = x * y;
double Div = x / y;
Div = Math.Round(Div,2);

Console.WriteLine($"Сумма: {Sum}; Разность: {Dif}; Произведение: {Pro}; Частное: {Div}");
