Console.Write("Vvedite name polzovatela  пше");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это Маша!");
}
else
{
    Console.Write("Privet, ");
    Console.WriteLine(username);
}