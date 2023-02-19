//  Работа с текстом
// Дан текст, в котором нужно заменить все пробелы черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "с" заменить маленькими "С".

string text = "- Я думаю, сказал князь, улыбаясь, - что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] r

string Replace(string text, char oldSymbol, char newSymbol)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i  = 0; i < length; i++)
    {
        if (text[i] == oldSymbol) result = result + newSymbol;
        else result = result + text[i];
    } 
    return result;
}
string newText = Replace(text, ' ', '|');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'с', 'С');

Console.WriteLine(newText);
