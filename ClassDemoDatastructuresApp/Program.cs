// See https://aka.ms/new-console-template for more information
using DatastructuresLib.datastructures;
using DatastructuresLib.model;

Console.WriteLine("Hello, World!");




IPersonDatastructure collection = new PersonArray();

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

