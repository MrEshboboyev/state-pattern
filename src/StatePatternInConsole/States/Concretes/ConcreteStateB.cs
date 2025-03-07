namespace StatePatternInConsole.States.Concretes;

// Concrete states implement various behaviors, associated with a state of the context
public class ConcreteStateB : State
{
    public override void Handle1()
    {
        Console.WriteLine("ConcreteStateB handles request1.");
    }

    public override void Handle2()
    {
        Console.WriteLine("ConcreteStateB handles request1.");
        Console.WriteLine("ConcreteStateB wants to change state the state of the context.");
        _context.TransitionTo(new ConcreteStateA());
    }
}
