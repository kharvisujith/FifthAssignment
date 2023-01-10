// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


onWord onWorddel = new onWord(ConsoleParser.onWordMethod);
onNumber onNumberdel = new onNumber(ConsoleParser.OnNumberMethod);
onJunk onJunkdel = new onJunk(ConsoleParser.onJunkMethod);

ConsoleParser.run(onWorddel, onNumberdel, onJunkdel);

public delegate void onWord();
public delegate void onNumber();
public delegate void onJunk();
public static class ConsoleParser
{
    public static void run(onWord onWorddel, onNumber onNumberdel, onJunk onJunkdel)
    {
        while (true)
        {
            Console.WriteLine("Enter input string");
            var inputString = Console.ReadLine();

            if (inputString.All(char.IsLetter))
            {
                onWorddel();
            }
            else if (inputString.All(char.IsNumber))
            {
                onNumberdel();
            }
            else
            {
                onJunkdel();
            }

        }
  
    }
    public static void onWordMethod ()
    {
          Console.WriteLine("This is from onWordMethod");
    }
    public static void OnNumberMethod()
    {
          Console.WriteLine("This is from onNumberMethod");
    }
    public static void onJunkMethod()
    {
        Console.WriteLine("This is from onJunkMethod");
    }
}