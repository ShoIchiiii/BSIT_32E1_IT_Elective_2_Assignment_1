using BSIT_32E1_Elective_2_Assignment_1.Data;
using BSIT_32E1_Elective_2_Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT_32E1_Elective_2_Assignment_1.Controllers;

public class HomeController : Controller
{
    // Answer key: every question with the correct answer highlighted.
    public IActionResult Index()
    {
        return View(QuestionBank.All);
    }

    // Quiz form: only questions that have a complete option list.
    [HttpGet]
    public IActionResult Quiz()
    {
        var questions = QuestionBank.All.Where(q => q.HasOptions).ToList();
        return View(questions);
    }

    // Grades the submitted answers on the server and renders the Result view.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Quiz(Dictionary<int, string>? answers)
    {
        answers ??= new Dictionary<int, string>();

        var items = QuestionBank.All
            .Where(q => q.HasOptions)
            .Select(q => new QuizResultItem
            {
                Question = q,
                SelectedKey = answers.TryGetValue(q.Number, out var key) ? key : null
            })
            .ToList();

        return View("Result", new QuizResultViewModel { Items = items });
    }
}