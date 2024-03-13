// See https://aka.ms/new-console-template for more information

using System.Text;
using DesignPatterns.factory;
using DesignPatterns.memento;
using DesignPatterns.state;

public class Program
{
    public static void Main(string[] args)
    {
        factoryExample();

    }

    static void mementoExample()
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

    static void stateExample()
    {
        Canvas canvas = new Canvas();
        canvas.CurrentTool = new SelectionTool();
        canvas.mouseDown();
    }

    static void factoryExample()
    {
        IPayment payment = PaymentFactory.create(PaymentMethod.ApplePay);
        payment.Pay(7000.00);
    }
    
}


