// Составить программу вывода на экран в одну строку
//четыре числа с тремя пробелами между ними
// создание объекта для генерации чисел
Random rnd = new Random();
  
int value = rnd.Next();  //Получить очередное случайное число
int value1 = rnd.Next(); //Получить очередное случайное число
int value2 = rnd.Next(); //Получить очередное случайное число
int value3 = rnd.Next(); //Получить очередное случайное число
  
Console.WriteLine(value + "   " + value1 + "   " +value2 + "   " + value3);  //Вывод числа в консоль
