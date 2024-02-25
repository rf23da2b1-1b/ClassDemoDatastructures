// See https://aka.ms/new-console-template for more information
using ClassDemoDatastructuresApp;
using DatastructuresLib.datastructures;
using DatastructuresLib.model;




/*

IPersonDatastructure collection = new PersonHashSet();

collection.Add(new Person(1, "peter"));
collection.Add(new Person(2, "anders"));
collection.Add(new Person(3, "henrik"));
collection.Add(new Person(4, "ivan"));
collection.Add(new Person(5, "vibeke"));


Console.WriteLine("alle personer");
foreach (Person person in collection.GetAll())
{
    Console.WriteLine(person);
}

Console.WriteLine("person  nummer 3");
Console.WriteLine(collection.GetById(3));

Console.WriteLine("person nummer 7");
try
{
    collection.GetById(7);
}
catch(KeyNotFoundException knfe)
{
    Console.WriteLine(knfe.Message);
}

*/

/*
 * Noget med equals

Console.WriteLine();
Console.WriteLine(" ===> Equals <====");
Console.WriteLine();
Person p1 = new Person(5, "peter");
Person p2 = new Person(5, "peter");
Person p3 = p1;

if (p1 == p2)
{
    Console.WriteLine("ja p1 og p2 er ens");
}

if (p1.Equals(p2))
{
    Console.WriteLine("ja p1 og p2 er ens");
}

if (p1 == p3)
{
    Console.WriteLine("ja p1 og p3 er ens");
}

Console.WriteLine("Hashcodes");
Console.WriteLine("p1 " + p1.GetHashCode());
Console.WriteLine("p2 " + p2.GetHashCode());
Console.WriteLine("p3 " + p3.GetHashCode());

*/

Worker w = new Worker();
w.Run();

