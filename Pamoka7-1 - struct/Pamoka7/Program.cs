// See https://aka.ms/new-console-template for more information
using Pamoka7;
using Pamoka7.Models;

Console.WriteLine("Hello, World!");

creatMokinys creatMokinys = new creatMokinys();
creatMokinys.createMokiniai("Darius", "Kvas");
creatMokinys.createMokiniai("Darius2", "Kvas2");

createBookLibrary createBookLibrary = new createBookLibrary();
createBookLibrary.reateBooksLibrary("Jonas Biliunas", MokinysRespository.allMokinys[0].FirstName);
createBookLibrary.reateBooksLibrary("Kostas Kubilinskas", MokinysRespository.allMokinys[1].FirstName);


foreach (var i in MokinysRespository.allMokinys)
{
    Console.WriteLine("{0} {1} | {2} | {3}", i.FirstName, i.LastName, i.StartLearnDate,i.EndLearnDate);
    Console.WriteLine("Mokosi dienu {0}",(i.EndLearnDate - i.StartLearnDate).TotalDays);
}

foreach (var i in BookRespository.allBooks)
{
    Console.WriteLine("ID | {0} | {1} | {2} | {3}", i.ID, i.BookTitle, i.BookReaderName, i.TakeBookDate);
    Console.WriteLine("Knyga paimta {0}", (DateTime.Now - i.TakeBookDate).TotalDays);
}

Console.WriteLine("");