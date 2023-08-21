//1. Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.
/*
int x;
int y;

Console.Write("Enter first num: "); x  = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second num: "); y  = Convert.ToInt32(Console.ReadLine());

if (x==y)
{
    Console.WriteLine((x+y)*3);
}
else{
    Console.WriteLine(x+y);
}
*/
//-----------------------------------------------------------------------------------------------------------------------------
//2. Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.
/*
Console.Write("Enter n: "); int n  = Convert.ToInt32(Console.ReadLine());
if (n > 51)
{
    Console.WriteLine((n-51)*3);
}
else{
    Console.WriteLine(51-n);
}
*/
//-----------------------------------------------------------------------------------------------------------------------------
//3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.

/*
Console.Write("First num: "); int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Second num: "); int num2 = Convert.ToInt32(Console.ReadLine());

bool status = (num1 == 30 || num2 == 30) ? true : (num1+num2 == 30) ? true :false;
Console.WriteLine("status: "+ status);
*/
//-----------------------------------------------------------------------------------------------------------------------------
//4. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
/*
Console.Write("num: "); int x = Convert.ToInt32(Console.ReadLine());
bool deger;
if(Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10)
    deger=true;
else
    deger=false;

Console.WriteLine(deger);
*/
//-----------------------------------------------------------------------------------------------------------------------------
//5. Write a C# Sharp program to create a string where 'if' is added to the front of a given string. If the string already begins with 'if', return it unchanged.
/*
Console.Write("string: "); string x = Console.ReadLine() ?? "";
string val = (x[0..2]=="if") ? x : "if " + x; 
Console.WriteLine(val);
*/
//-----------------------------------------------------------------------------------------------------------------------------
//6. Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.
/*
Console.Write("string: "); string mstrn = Console.ReadLine() ?? "";
Console.Write("Enter index: "); int index  = Convert.ToInt32(Console.ReadLine());
mstrn=mstrn.Remove(index,1);
Console.WriteLine(mstrn);
*/
//-----------------------------------------------------------------------------------------------------------------------------
//7. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
/*
Console.Write("string: "); string mystr = Console.ReadLine() ?? "";
string mystr2= (mystr.Length>1)? mystr[mystr.Length-1]+ mystr[1..(mystr.Length-1)]+ mystr[0] : mystr;
Console.WriteLine(mystr2);
*/
//-----------------------------------------------------------------------------------------------------------------------------
//8. Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string.
/*
Console.Write("string: "); string mystr = Console.ReadLine() ?? "";
string mystr2=(mystr.Length!=1) ? mystr[0..2]+mystr[0..2]+mystr[0..2]+mystr[0..2]:mystr;
Console.WriteLine(mystr2);
*/
//-----------------------------------------------------------------------------------------------------------------------------
//9. Write a C# Sharp program to create a string with the last char added at the front and back of a given string of length 1 or more.
/*
Console.Write("string: "); string mystr = Console.ReadLine() ?? "";
string mystr2=mystr[mystr.Length-1]+mystr+mystr[mystr.Length-1];
Console.WriteLine(mystr2);
*/
//-----------------------------------------------------------------------------------------------------------------------------
//10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.
/*
Console.Write("num: "); int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(x%3==0 || x%7==0);
*/
//-----------------------------------------------------------------------------------------------------------------------------
//11. Write a C# Sharp program to create a string taking the first 3 characters of a given string. Return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there.
/*
Console.Write("Enter string: ");string mystr=Console.ReadLine()?? "";
if(mystr.Length<=3){
    Console.WriteLine(mystr+mystr+mystr);
}else{
    Console.WriteLine(mystr[0..3]+mystr+mystr[0..3]);
}
*/










