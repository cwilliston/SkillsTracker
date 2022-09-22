using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        //GET: /skill/
        [HttpGet("/skills")]
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Programming Languages</h2>" +
                "<ol>" +
                "  <li>C#</li>" +
                "  <li>JavaScript</li>" +
                "  <li>Java</li>" +
                "</ol>";


            return Content(html, "text/html");


        }

        //GET: /skills/form
        [HttpGet]
        [HttpPost]
        public IActionResult Form(string date, string csharp, string javascript, string java)
        {
            string skillsForm = @"<form method='post' action='/skills/form'>
                    Date:
                    <input type='date' name='date' />
                    <label for='csharp'>C#:</label>
                    <select name='csharp' id='csharp'>
                        <option value='Learning basics'>Learning basics</option>
                        <option value='Making Apps'>Making Apps</option>
                        <option value='Master Coder'>Master Coder</option></select>
                    <label for='javascript'>JavaScript:</label>
                    <select name='javascript' id='javascript'>
                        <option value='Learning basics'>Learning basics</option>
                        <option value='Making Apps'>Making Apps</option>
                        <option value='Master Coder'>Master Coder</option></select>
                    <label for='java'>Java:</label>
                    <select name='java' id='java'>
                        <option value='Learning basics'>Learning basics</option>
                        <option value='Making Apps'>Making Apps</option>
                        <option value='Master Coder'>Master Coder</option></select>
                    <input type='submit' value='Submit'/>
                </form>";
            if (HttpContext.Request.Method == "POST")
            {
                string html = @$"<h1>{date}</h1>
                              1. C#: {csharp}<br>
                              2. JavaScript: {javascript}<br>
                              3. Java: {java}
                              ";

                return Content(html, "text/html");
            }
                return Content(skillsForm, "text/html");
        }



    }
}
