// See https://aka.ms/new-console-template for more information

using System.Text;
using System.Threading.Channels;
using DesignPatterns;
using DesignPatterns.memento;
using DesignPatterns.state;

public class Program
{
    public static void Main(string[] args)
    {
        Canvas canvas = new Canvas();
        canvas.CurrentTool = new SelectionTool();
        canvas.mouseDown();

    }

    static void memento()
    {
        var editor = new Editor();
        var history = new History();

        editor.Content = "a";
        history.push(editor.createState());
        editor.Content = "b";
        history.push(editor.createState());
        editor.Content = "c";
        editor.restore(history.pop());
        editor.restore(history.pop());

        Console.WriteLine(editor.Content);
    }
    
   static void Fibonacci(int num)
    {
        int previous = 0;
        int current = 0;
        int next = 1;

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(current);
            previous = current;
            current = next;
            next = previous + current;

        }
    }

    static bool palindrome(string s)
    {
        StringBuilder reverse = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            reverse.Append(s[i]);
        }
        Console.WriteLine(reverse);
        return reverse.ToString() == s;
    }
    
}


