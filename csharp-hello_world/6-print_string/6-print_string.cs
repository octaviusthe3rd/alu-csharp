using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		int count = 0;

        while (count < 3){
            Console.WriteLine(str);
            count++;
            }
        Console.WriteLine(str[0..9]);
        }
}