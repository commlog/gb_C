Console.WriteLine("Enter username: ");
string username = Console.ReadLine();

if (username.ToLower() == "maria")  // сделал все в нижнем регистре (что бы работало маШа)
{
    Console.WriteLine("Yes! This is Maria!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}