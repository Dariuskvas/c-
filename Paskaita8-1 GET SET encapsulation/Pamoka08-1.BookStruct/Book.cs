namespace Pamoka08_1.BookStruct;

public class Book
{
    private string name;                    //private is mazosios raides pavadinimas
    private string id;
    private string localID;

    public string Name                      //public is didziosios raides
    {
        get { return name; }                //return - Grazinu Privat reiksme per Public elementa
        set { name = "kuku"; }              // uzsetinu privat reiksme per public kintamaji
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string LocalID
    {
        get { return localID; }
        set { localID = value; }
    }

    public Book(string xName, string xId)
    {
        Name = xName;
        Id = xId;
        LocalID = xName +"_"+xId;
    }  

}