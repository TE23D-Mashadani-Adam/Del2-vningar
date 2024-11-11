List<String> names = ["Adam", "Ahmed", "Imad", "Saymmon", "Janan"];
List<String> leksaker = ["Barbie", "Hund", "Katt", "Svärd", "Pokemon"];
List<int> värden = [2, 4, 5, 6, 7];

List<string> städer = [];

Random random = new();


for (int i = 0; i < names.Count; i++)
{
    int randomNum = random.Next(1, 5);
    Console.WriteLine($" {names[randomNum]} ger {leksaker[randomNum]} betyget {värden[randomNum]}");
}

string userInput = "";
while (userInput != "exit")
{
    Console.WriteLine("\n" + "Skriv ner namn på en stad");
    userInput = Console.ReadLine();

    if (userInput.ToLower() == "exit")
    {
        break;
    }
    else
    {
        städer.Add(userInput);
    }
}

Console.WriteLine("Städer:");
for (int i = 0; i < städer.Count; i++)
{
    Console.WriteLine(städer[i]);
}

Console.ReadLine();