using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using MementoPattern;
using StatePattern;
namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Memento();
            State();
        }

        static void Memento()
        {
            Originator originator = new Originator();
            Caretaker caretaker = new Caretaker();

            originator.State = "a";
            caretaker.Push(originator.CreateMemento());

            originator.State = "b";
            caretaker.Push(originator.CreateMemento());

            originator.State = "c";
            caretaker.Push(originator.CreateMemento());

            originator.State = "d";

            originator.RestoreMemento(caretaker.Pop());
            originator.RestoreMemento(caretaker.Pop());
            originator.RestoreMemento(caretaker.Pop());
        }

        static void State()
        {
            var canvas = new Canvas();
            canvas.currentTool = new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();
            canvas.currentTool = new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }

}