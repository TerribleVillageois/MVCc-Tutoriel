using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action....";
    }
    
    // Get: /HelloWorld/Welcome
    // Requires using System.Text.Encodings.Web;
    public string Welcome(string name, int numTimes = 1)
    {
        string phrase = String.Concat(Enumerable.Repeat(name + " ",numTimes));
        return phrase;
        return HtmlEncoder.Default.Encode($"Hello {name}, numTimes is : {numTimes}");
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }
}