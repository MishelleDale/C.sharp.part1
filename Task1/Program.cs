Console.WriteLine("Показываем вторую цифру из трехзначного числа");
Console.WriteLine("Введите трехзначное число");

int Number = Convert.ToInt32(Console.ReadLine());

if (Number < 100 || Number > 999)
     Console.WriteLine("Введено неверное число");

else
    {
    int sum = Number / 10;
    int second_figure = sum%10;

    Console.WriteLine("Вторая цифра в " + Number + " - " + second_figure); 
    }