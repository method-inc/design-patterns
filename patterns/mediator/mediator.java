//Source - http://java.dzone.com/articles/design-patterns-mediator
import java.util.ArrayList;

//Mediator
interface Mediator
{
  void send(String message, Colleague colleague);	
}

//Colleage interface 
abstract class Colleague
{
	private Mediator mediator;
  Colleague() {}
	public Colleague(Mediator m) {
    mediator = m;
	}

	//send a message via the mediator
  void send(String message) {
    mediator.send(message, this);
	}
	
	//get access to the mediator
	Mediator getMediator() {
		return mediator;
	}

  abstract void receive(String message);	
}

// Concrete Mediator
class ApplicationMediator implements Mediator
{
	private ArrayList<Colleague> colleagues;

  ApplicationMediator() { 
    colleagues = new ArrayList<Colleague>();
  } 

  void addColleague(Colleague colleague) { 
    colleagues.add(colleague);
  }

  // Note this is a very simple implementation that would not
  // give you any additional benefit over Observer but 
  // you could have some very complex notification logic here
	public void send(String message, Colleague originator)	{
		//let all other screens know that this screen has changed
		for(Colleague colleague: colleagues)
		{
			//don't tell ourselves
			if(colleague != originator)
				colleague.receive(message);
		}
	}
}

// Concrete Colleague
class ConcreteColleague extends Colleague
{
  public ConcreteColleague(ApplicationMediator applicationMediator) {
    super(applicationMediator);
  }

  void receive(String message)
  {
    System.out.println("Colleague Received: " + message);
  }	
}

// Concrete Colleague
class MobileColleague extends Colleague
{
  public MobileColleague(ApplicationMediator applicationMediator) {
    super(applicationMediator);
  }

  void receive(String message)
  {
    System.out.println("Mobile Received: " + message);
  }	
}

class Client 
{
  public static void main(String[] args) 
  {
    ApplicationMediator mediator = new ApplicationMediator(); 
      
    ConcreteColleague desktop = new ConcreteColleague(mediator);
    MobileColleague mobile = new MobileColleague(mediator);
     
    mediator.addColleague(desktop);
    mediator.addColleague(mobile);

    desktop.send("Hello World");
    mobile.send("Hello"); 
  }
}
