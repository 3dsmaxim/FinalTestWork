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

string[] TextResult(string[] text)
{
    string[] result = new string[]{};
    string[] resultReservide = new string[]{};
    string check = String.Empty;
    int m = 0;
    for (int k = 0; k < text.Length; k++)
    {
        check = text[k];
        if (check.Length <= 3)
        {
            resultReservide = result;
            result = new string[m + 1];

            for (int l = 0; l < resultReservide.Length; l++)
            {
                result[l] = resultReservide[l];
                
            }
            result[m] = check;
            m++;
        }
    }
    return result;

}




Console.Clear();
Console.WriteLine($"[{String.Join(", ",textFyrst)}]");
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ",TextResult(textFyrst))}]");
Console.WriteLine();