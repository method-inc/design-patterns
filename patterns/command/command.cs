using System;
using System.Collections.Generic;
 
namespace CommandPattern
{
    // The Command participant
    public interface ICommand
    {
        void Execute();
    }
 
    // The Invoker participant 
    public class RichTextEditorInvoker
    {
        // Note this is a somewhat naive way to store commands
        // but works for this example. An array would be better
        // suited for performance reasons depending on how much
        // processing you may need.
        private List<ICommand> _commands = new List<ICommand>();
 
        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }
    }
 
    // The Receiver class
    public class Text
    {
        public void Bold()
        {
            Console.WriteLine("The text is now bold");
        }
 
        public void Unbold()
        {
            Console.WriteLine("The text now unbolded");
        }
    }
 
    // The Command for bolding the text - ConcreteCommand #1
    public class BoldCommand : ICommand
    {
        private Text _text;
 
        public BoldCommand(Text text)
        {
            _text = text;
        }
 
        public void Execute()
        {
            _text.Bold();
        }
    }
 
    // The Command for unbolding the text - ConcreteCommand #2
    public class UnboldCommand : ICommand
    {
        private Text _text;
 
        public UnboldCommand(Text text)
        {
            _text = text;
        }
 
        public void Execute()
        {
            _text.Unbold();
        }
    }
 
    // The Client Participant
    internal class Program
    {
        public static void Main(string[] args)
        {
            Text paragraph = new Text();
            ICommand bold = new BoldCommand(paragraph);
            ICommand unbold = new UnboldCommand(paragraph);
 
            RichTextEditorInvoker richTextEditor  = new RichTextEditorInvoker();
            richTextEditor.StoreAndExecute(bold);
            richTextEditor.StoreAndExecute(unbold);
        }
    }
}
