using System;
using System.Collections.Generic;

namespace MediatorPattern
{
    //Mediator
    public interface Mediator
    {
        void send(String message, Colleague colleague);
    }

    //Colleage interface 
    public abstract class Colleague
    {
        private Mediator mediator;
        Colleague() { }
        public Colleague(Mediator m)
        {
            mediator = m;
        }

        //send a message via the mediator
        public void send(String message)
        {
            mediator.send(message, this);
        }

        //get access to the mediator
        Mediator getMediator()
        {
            return mediator;
        }

        public abstract void receive(String message);
    }

    // Concrete Mediator
    public class ApplicationMediator : Mediator
    {
        private List<Colleague> colleagues;

        public ApplicationMediator()
        {
            colleagues = new List<Colleague>();
        }

        public void addColleague(Colleague colleague)
        {
            colleagues.Add(colleague);
        }

        // Note this is a very simple implementation that would not
        // give you any additional benefit over Observer but 
        // you could have some very complex notification logic here
        public void send(String message, Colleague originator)
        {
            //let all other screens know that this screen has changed
            foreach (Colleague colleague in colleagues)
            {
                //don't tell ourselves
                if (colleague != originator)
                    colleague.receive(message);
            }
        }
    }

    // Concrete Colleague
    public class ConcreteColleague : Colleague
    {
        public ConcreteColleague(ApplicationMediator applicationMediator)
            : base(applicationMediator)
        {
        }

        public override void receive(string message)
        {
            Console.WriteLine("Colleague Received: " + message);
        }
    }

    // Concrete Colleague
    public class MobileColleague : Colleague
    {
        public MobileColleague(ApplicationMediator applicationMediator)
            : base(applicationMediator)
        {
        }

        public override void receive(String message)
        {
            Console.WriteLine("Mobile Received: " + message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationMediator mediator = new ApplicationMediator();

            ConcreteColleague desktop = new ConcreteColleague(mediator);
            MobileColleague mobile = new MobileColleague(mediator);

            mediator.addColleague(desktop);
            mediator.addColleague(mobile);

            desktop.send("Hello World");
            mobile.send("Hello");

            Console.ReadKey();
        }
    }
}
