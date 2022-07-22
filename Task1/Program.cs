int num = new Random().Next(100,1000);
Console.WriteLine(num);

int digitOne = num / 10;

int digitSecond = num % 100;


Console.WriteLine(digitSecond/10);
