// See https://aka.ms/new-console-template for more information
using Stacksh;
//Console.WriteLine("My Stack programme");
Stack myStack = new Stack();

myStack.Push(56);
myStack.Push(70);
myStack.Push(30);
myStack.DisplayStack();
myStack.Peek();
Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
myStack.DisplayStack();
