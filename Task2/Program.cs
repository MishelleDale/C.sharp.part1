int Number = new Random().Next(100, 1000);
System.Console.WriteLine(Number); // Cheching three-digit number

int Number1 = Number / 100; // first figure
int Number3 = Number%10; // third figure

System.Console.Write(Number1);
System.Console.Write(Number3);