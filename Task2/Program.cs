int num = new Random().Next(10, 1000);

Console.WriteLine(num);

if (num < 99)
{
    Console.WriteLine(" Трерьей цифры нету");
}
else
{
    int digitThird = num % 10;

    Console.WriteLine(digitThird);
}

