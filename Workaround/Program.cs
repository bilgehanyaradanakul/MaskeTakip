// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

Person person1 = new Person();
person1.FirstName = "Bilgehan";
person1.LastName = "Yaradanakul";
person1.NationalIdentity = 1123123123;
person1.DateOfBirthYear = 2004;

PttManager pttManager = new PttManager (new PersonManager());
pttManager.GiveMask(person1);



 




