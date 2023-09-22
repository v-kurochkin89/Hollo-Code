Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "виктор")
{
    Console.WriteLine("УРААА! Это же мой любимый пользователь!");
}
else
{
    Console.Write("Привет, маловажный пользователь ");
    Console.WriteLine(username);
}
