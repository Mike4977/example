// //Method 1

// void Method1()
// {
//     Console.WriteLine("Авторство этого мира принадлежит им");
// }
// Method1();


// //Method 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("какой-то текст");


// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//          i++;
//     }
// }
// //Method21(msg: "какой-то текст", count: 4);
// // Можно поменять местами явные вводные данные
// Method21(count: 4, msg: "какой-то текст");



// // Method 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// Method 4
string Method4(int count, string text)
{
    string result = String.Empty; // пустая строка
    
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4( 5, "asd ");
Console.WriteLine(res);

