// Составить программу вывода на экран числа, вводимого с клавиатуры.
// Выводимому числу должно предшествовать сообщение «Вы ввели число».

int Number;

Console.WriteLine("Введите число");
Number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Вы ввели число: {Number}");