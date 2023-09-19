string s = "Каждый ";
string s1 = "охотник ";
string s2 = "желает ";
string s3 = "знать ";
string s4 = "где ";
string s5 = "сидит ";
string s6 = "фазан.";

Console.Write(s);
Console.Write(s1);
Console.Write(s2);
Console.Write(s3);
Console.Write(s4);
Console.Write(s5);
Console.WriteLine(s6);

string concatString = s + "охотник " + s2 + "знать " + s4 + "сидит " + s6;

Console.WriteLine(concatString);

string interpolatedString = $"{s} {s1} {s2} {s3} {s4} {s5} {s6}";

Console.WriteLine(interpolatedString);