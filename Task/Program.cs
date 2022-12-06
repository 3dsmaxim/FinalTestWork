Console.Clear();

Console.WriteLine("Введите строки по оканчанию ввода нажмите q и enter");
string[] textArray = new string[]{Console.ReadLine(), Console.ReadLine(), Console.ReadLine()};
Console.WriteLine($"[ {String.Join(", ",textArray)} ]");

string enterRowosition = textArray[0];
int textM = enterRowosition.Length;

Console.WriteLine(enterRowosition);
Console.WriteLine(textM);
