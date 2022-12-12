using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Savarankiskas1
{
    public class CreateHTMLTable
    {
        public static string content { set; get; } 
        public string style { set; get; }

        public CreateHTMLTable()
        {
            style = @"style border='1px solid #000'";
        }

        public void createHTMLHead(string tableHeadTitle)
        {
            content += $"<p>{tableHeadTitle}</p>";
            content += $"<table {style}><tr{style}><th {style}>Lektuvo ID</th><th {style}>Lektuvo Modelis</th>" +
                $"<th {style}>Kompanijos pavadinimas</th><th {style}>Salis</th><th {style}>fromEU</th></tr>";
        }

        public void createHTMLBody(int idHTML, string modelHTML, string companyHTML, string countryHTML, Boolean fromEUHTML)
        {
            content += $"<tr><td>{idHTML}</td><td>{modelHTML}</td><td>{companyHTML}</td><td>{countryHTML}</td><td>{fromEUHTML}</td>";
        }

        public void createHTMLFile()
        {
                content += $"</tr></table><br>";
                File.WriteAllText(@"C:\Users\Darius\Desktop\PlaneReport2.html", content);
        }
    }
}
