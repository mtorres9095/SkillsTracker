﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker </h1>" +
                            "<h2>Coding Skills to Learn: </h2>" +
                            "<ol>" +
                                "<li> C#</li>" +
                                "<li> JavaScript </li>" +
                                "<li> Python </li>" +
                            "</ol>";
            return Content(html, "text/html");
        }
        [HttpGet("/skills/form")]
        public IActionResult SkillsForm()
        {
            string html = "<form method='post' action='/skills/form'>" +

                "<label for='date'> Date" +
                    "<br>" +
                    "<input type='date'  name='date' />" +
                "</label>" +
                "<br>" +

                "<label for='csharp'> C#" +
                "<br>" +
                   "<select name='csharp' >" +
                       "<option value='master coder'>Master Coder</option>" +
                       "<option value='making apps'>Making Apps</option>" +
                       "<option value='learing basics'>Learing Basics</option>" +
                    "</select>" +
                    "</label>" +
                    "<br>" +
                    "<label for='javascript'> JavaScript" +
                "<br>" +
                   "<select name='javascript' >" +
                       "<option value='master coder'>Master Coder</option>" +
                       "<option value='making apps'>Making Apps</option>" +
                       "<option value='learing basics'>Learing Basics</option>" +
                    "</select>" +
                    "</label>" +
                    "<br>" +

                "<label for='python'> Python" +
                "<br>" +
                   "<select name='python' >" +
                       "<option value='master coder'>Master Coder</option>" +
                       "<option value='making apps'>Making Apps</option>" +
                       "<option value='learing basics'>Learing Basics</option>" +
                    "</select>" +
                    "</label>" +
                    "<br>" +
                    "<br>" +
                 "<input type='submit' value='Submit'/>" +
               "</form>";
            return Content(html, "text/html");
        }
        // POST:/skills/form
        [HttpPost("/skills/form")]
        public IActionResult SkillsResult(string date, string csharp, string javascript, string python)
        {
            string html = $"<h1>{date}</h1>" +
                               "<ol>" +
                                  $"<li> C#: {csharp}</l1>" +
                                  $"<li> JavaScript: {javascript}</l1>" +
                                  $"<li> Python: {python}</l1>" +
                               "</ol>";

             return Content(html, "text/html");
        }




    }
}
