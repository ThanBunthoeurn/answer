//Case 1
Console.Write("Input 1: ");
//"[BE][FE][Urgent] there is error"
string input = Console.ReadLine();
string words = input.Substring(2, input.LastIndexOf(']') - 2);

Console.Write("Output 1 : ");
Console.WriteLine("\"Receive channels: " + words.Replace("][", ",") + "\"");
//Case 2
Console.Write("Input 2 : ");
//"[BE][QA][HAHA][Urgent] there is error"
string input2 = Console.ReadLine();
string words2 = input2.Replace("[HAHA]", "");
string mystr = words2.Substring(2, words2.LastIndexOf(']') - 2);

Console.Write("Output 2 : ");
Console.WriteLine("\"Receive channels: " + mystr.Replace("][", ",") + "\"");

Console.ReadLine();