using System;

class Task1
{
    static void Main()
    {
        int i;
        for(i = 0; i < 10; i++)
            Console.WriteLine(i);
    Console.ReadLine();

        i = 0;
        while(i < 10)
        {
            Console.WriteLine(i);
            i++;
        }
        Console.ReadLine();

        i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 10);
        Console.ReadLine();

        i = 0;
        string[] words = new string[5];
        Console.WriteLine("Input 5 words:");
        while(i < 5) 
        {
            words[i] = Console.ReadLine();
            i++;
        }
        i = 0;
        while (i < 5)
        {
            Console.Write(words[i] + " ");
            i++;
        }

        Console.WriteLine("Input 5 words:");
        i = 0;
        do
        {
            words[i] = Console.ReadLine();
            i++;
        } while (i < 5);
        i = 0;
        do
        {
            Console.Write(words[i] + " ");
            i++;
        } while(i < 5);

    Console.ReadLine();
    }
}