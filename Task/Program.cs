Console.Clear();

Console.WriteLine("Введите произвольный набор символов");
Console.WriteLine("Для ввода следующего набора вимволов нажмите enter и повторите ввод");
Console.WriteLine("для прекращения ввода нажмите enter не вводя никаких символов");
string enterRow = Console.ReadLine();
string[] textFyrst = new string[]{};
string[] textReservide= new string[]{};
int i = 0;
while (enterRow != "")
{
    textReservide = textFyrst;
    textFyrst = new string[i+1];
    
    for (int j = 0; j < textReservide.Length; j++)
    {
        textFyrst[j] = textReservide[j];
    }
    textFyrst[i] = enterRow;
    enterRow = Console.ReadLine();
    i++;
     
}

Console.WriteLine($"[{String.Join(", ",textFyrst)}]");