Console.WriteLine("Имя");
string username = Console.ReadLine();

if(username.ToLower() == "mascha")
{
    Console.WriteLine("Привет Маша!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
