using DesignPatterns;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.TemplateMethod;
using History = DesignPatterns.Behavioral.Command.History;
using DesignPatterns.Behavioral.Mediator;

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



Console.WriteLine("--------Template Method-------");

var pdfMiner = new PDFdataMiner();
var docxMiner = new DOCXdataMiner();

pdfMiner.MineFile("path-to-pdfFile");
docxMiner.MineFile("path-to-docxFile");


Console.WriteLine("--------Command-------");
//Basic example
var service = new CustomerService();
var addCommand=new AddCustomerCommand(service);
var button = new Button(addCommand);
button.Click();
//Composite command
var composite = new CompositeCommand();
composite.AddCommand(new ResizeCommand());
composite.AddCommand(new BlackAndWhiteCommand());
composite.execute();
//implementing undo mechanism
var history = new History();
var document=new HTMLdocument();
document.Content = "Command pattern in action";
var boldCmd=new BoldCommand(document,history);
boldCmd.execute();
history.Push(boldCmd);
Console.WriteLine(document.Content);
if(history.Size() > 0)
history.Pop().unexecute();
Console.WriteLine(document.Content);
Console.WriteLine("--------Observer-------");
var appleStock = new Stock("AAPL",3000);
var googleStock = new Stock("GOOGL",4000);
var gmStock = new Stock("General Motors",150);
var statusBar = new StatusBar();
statusBar.AddStock(appleStock);
statusBar.AddStock(googleStock);
var stocklistView=new StockListView();
stocklistView.AddStock(appleStock);
stocklistView.AddStock(googleStock);
stocklistView.AddStock(gmStock);
appleStock.Price = 5000;
googleStock.Price = 8000;
*/
Console.WriteLine("--------Mediator-------");
var form = new RegisterFormDialogBox();
form.SimulateInteraction();



