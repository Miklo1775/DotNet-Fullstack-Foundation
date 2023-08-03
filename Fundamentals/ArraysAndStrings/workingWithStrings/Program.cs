using System.Text;

Console.WriteLine("Manipulating Strings");

string str1 = "Hello World";
string str2 = "Good-bye World";
Console.WriteLine(str1);
Console.WriteLine(str1.Length);
string concatenatedStr = string.Concat(str1,str2);
Console.WriteLine(concatenatedStr);
Console.WriteLine(str1 + str2);
Console.WriteLine(str1 == str2);
Console.WriteLine(str1.Equals(str2));

//immutable
string s1 = "C# Programming";
string s2 = "Java Programming";

//Mutable
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("C# Programming");
stringBuilder.Append("Java Programming");
Console.WriteLine(stringBuilder);