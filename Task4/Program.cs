Console.WriteLine("Проверяем, является ли указанный день выходным");
Console.WriteLine("Введите номер дня недели");

int day = Convert.ToInt32(Console.ReadLine());

if (day > 7 || day < 1) 
    Console.WriteLine("Введите цифру от 1 до 7");
    
if (day == 6 || day == 7)
   Console.WriteLine("Да, выходной");
if (day > 0 && day < 6)
   Console.WriteLine("Нет, не выходной");
