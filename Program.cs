using DesignPatterns;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.TemplateMethod;
using History = DesignPatterns.Behavioral.Command.History;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.ChainOfResponsability;
using DesignPatterns.Behavioral.Visitor;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Proxy;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;

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

Console.WriteLine("--------Mediator-------");
var form = new RegisterFormDialogBox();
form.SimulateInteraction();


Console.WriteLine("-----Chain Of Responsability-----");
//building the chain
var compressor = new Compressor(null);
var logger = new Logger(compressor);
var authenticator=new Authenticator(logger);
//applying
var server=new WebServer(authenticator);
Console.WriteLine("First request");
server.handle(new HttpRequest("admin", "1234"));
Console.WriteLine("Second request");
server.handle(new HttpRequest("admin2", "1234"));



Console.WriteLine("--------Visitor-------");
var document = new DesignPatterns.Behavioral.Visitor.HTMLdocument();
document.Add(new HeadingNode());
document.Add(new AnchorNode());

document.Execute(new HighlightOperation());
document.Execute(new UnderlineOperation());
*/

Console.WriteLine("/****Structural patterns*****/");
/*
Console.WriteLine("-----Composite-----");
var subTeam1 = new Team();
var subTeam2 = new Team();

subTeam1.Add(new TruckResource());
subTeam1.Add(new HumanResource());
subTeam1.Add(new HumanResource());

subTeam2.Add(new TruckResource());
subTeam2.Add(new HumanResource());

var team =new Team();
team.Add(subTeam1);
team.Add(subTeam2);
team.Deploy();


Console.WriteLine("-----Adapter-----");
var gmailCLient = new GmailAdapter();
var emailClient= new EmailClient();
emailClient.AddProvider(gmailCLient);
emailClient.DownloadEmails();


Console.WriteLine("-----Decorator-----");
var editor = new Editor();
editor.OpenProject("path-to-project");


Console.WriteLine("-----Facade-----");
var twitterFacade = new TwitterService();
twitterFacade.getTweets();


Console.WriteLine("-----Flyweight-----");

var pointService = new PointService(new PointIconFactory());
pointService.getPoints();


Console.WriteLine("-----Bridge-----");
var basicRemote = new RemoteControl(new SamsungTV());
var advancedRemote=new AdvancedRemoteControl(new SonyTV());
basicRemote.TurnOn();
basicRemote.TurnOff();
advancedRemote.TurnOn();
advancedRemote.setChannel(12);
advancedRemote.TurnOff();


Console.WriteLine("-----Proxy-----");
var dbContext = new DbContext();

// We read an object (eg a product) from a database.
var product = dbContext.getProduct(1);

// We modify the properties of the object in memory.
product.Name="Updated Name";

// DbContext should keep track of changed objects in memory.
// When we call saveChanges(), it'll automatically generate
// the right SQL statements to update our database.
dbContext.saveChanges();

// After saving the changes to the database, we can
// change our in-memory object again and save the changes.
product.Name="Another name";
dbContext.saveChanges();

*/

Console.WriteLine("/****Creational patterns*****/");
/*
Console.WriteLine("-----Prototype-----");
var timeline = new Timeline();
var text = new Text("Hello");
timeline.Add(text);

var menu = new ContextMenu(timeline);
menu.Duplicate(text);

Console.WriteLine("-----Singleton-----");

var config = ConfigManager.GetInstance();
config.Set("key1", "val1");

var other=ConfigManager.GetInstance();
Console.WriteLine(other.Get("key1"));

Console.WriteLine("-----Factory-----");
var gScheduler = new GregorianScheduler();
gScheduler.Schedule(new Event());

var aScheduler = new ArabianScheduler();
aScheduler.Schedule(new Event());


Console.WriteLine("-----Abstract Factory-----");
var form = new ContactForm();
form.render(new DesignPatterns.Creational.AbstractFactory.Theme1.Theme1WidgetFactory());
form.render(new DesignPatterns.Creational.AbstractFactory.Theme2.Theme2WidgetFactory());
*/

Console.WriteLine("-----Builder-----");
var document = new DesignPatterns.Creational.Builder.Document();
document.Add(new TextElement("Hello World"));
document.Add(new ImageElement("pic1.jpg"));

var textConverter = new TextDocumentBuilder();
var htmlConverter = new HtmlDocumentBuilder();

document.Export(htmlConverter, ".\\export.html");

// Only writes the text elements to the file
document.Export(textConverter, ".\\export.txt");
