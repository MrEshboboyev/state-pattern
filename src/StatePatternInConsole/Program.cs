// The client code
using StatePatternInConsole;
using StatePatternInConsole.States.Concretes;

var context = new Context(new ConcreteStateA());
context.Request1();
context.Request2();