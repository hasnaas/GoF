using DesignPatterns;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.State;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("GoF Design Patterns Overview");
Console.WriteLine("/*****************************/");
Console.WriteLine("/****Behavioral patterns*****/");
/*
Console.WriteLine("----------Memento-------------");
var document = new Document();
var history=new History();
Console.WriteLine(document);
history.Push(document.SaveState());
document.Content = "Hello Memento";
history.Push(document.SaveState());
document.FontName = "Times New Roman";
history.Push(document.SaveState());
document.FontSize = 30;
//history.Push(document.SaveState());
Console.WriteLine("After several changes ...");
Console.WriteLine(document);
Console.WriteLine("Undo..");
document.RestoreState(history.Pop());
Console.WriteLine(document);
Console.WriteLine("Undo..");
document.RestoreState(history.Pop());
Console.WriteLine(document);
Console.WriteLine("Undo..");
document.RestoreState(history.Pop());
Console.WriteLine(document);
Console.WriteLine("Undo..");
Console.WriteLine(document);
Console.WriteLine("----------State-------------");
var walking = new WalkingMode();
var driving = new DrivingMode();

var direction = new DirectionService(driving);
Console.WriteLine("Now driving ... ETA is :"+ direction.getETA());
direction.TravelMode= walking;
Console.WriteLine("Now walking ... ETA is :"+ direction.getETA());
*/
Console.WriteLine("----------Iterator-------------");
var mcollection = new ProductCollection();
var p1 = new Product(1, "tomatoe");
var p2 = new Product(2, "apple");
var p3 = new Product(3, "mashroom");
mcollection.Add(p1);
mcollection.Add(p2);
mcollection.Add(p3);
var iterator=mcollection.GetIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}



