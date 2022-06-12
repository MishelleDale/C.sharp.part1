Console.WriteLine("Указываем третью цифру в заданном числе");
Console.WriteLine("Введите число");

long Number = Convert.ToInt64(Console.ReadLine()); //задать более длинный интервал чисел
string NumberA = Convert.ToString(Number); // для дальнейшего извлечения символа через индекс

if ( -100 < Number && Number < 100)
   Console.WriteLine("В заданном числе третьей цифры нет");
if ( -100 >= Number)
  Console.WriteLine(NumberA[3]);
if (Number >= 100)
    Console.WriteLine(NumberA[2]);