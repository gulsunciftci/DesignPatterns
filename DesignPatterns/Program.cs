using DesignPatterns.mementoo;
using DesignPatterns.state;
using DesignPatterns.state.abuse;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User(Name: "Gulsun",age: 24);
            Console.WriteLine(user.Name);
            user.sayHello();

            TaxCalculator calculator = getCalculator();
            calculator.calculateTax();

           var account = new Account();
            account.deposit(10);
            account.Withdraw(5);
            Console.WriteLine(account.getBalance());

            var mailService = new MailService();
            mailService.sendEmail();

            var textBox = new TextBox();
            textBox.enable();

            drawUIControl(new checkBox());

            var editor = new Editor();
            var history = new History();

            editor.setContent ("a");
            history.push(editor.createState());
            editor.setContent("b");
            history.push(editor.createState());
            editor.setContent("c");
            editor.restore(history.pop());
            editor.restore(history.pop());

            Console.WriteLine(editor.getContent());

            var canvas = new Canvas();
            canvas.setCurrentTool(new EraserTool());
            canvas.mouseDown();
            canvas.mouseUp();

            var stopwatch = new state.abuse.Stopwatch();
            stopwatch.setCurrentState(new StoppedState(stopwatch));
            stopwatch.click();
            stopwatch.click();
            stopwatch.click();
            
        }

        public static TaxCalculator getCalculator()
        {
            return new TaxCalculator2019();
        }
        public static void drawUIControl(UIControl control)
        {
            control.draw();
        }
    }
}
