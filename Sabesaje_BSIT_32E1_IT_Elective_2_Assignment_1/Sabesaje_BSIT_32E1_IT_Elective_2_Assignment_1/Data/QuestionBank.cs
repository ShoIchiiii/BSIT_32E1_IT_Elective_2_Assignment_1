using BSIT_32E1_Elective_2_Assignment_1.Models;

namespace BSIT_32E1_Elective_2_Assignment_1.Data;

public static class QuestionBank
{
    private static QuizOption O(string key, string text) => new(key, text);

    public static readonly IReadOnlyList<QuizQuestion> All = new List<QuizQuestion>
    {
        new()
        {
            Number = 1,
            Text = "What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?",
            Options =
            {
                O("A", "SSR returns JSON payloads, whereas a Web API compiles .cshtml Razor views on the server."),
                O("B", "SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON."),
                O("C", "SSR only works with mobile applications, whereas Web APIs are restricted to desktop web browsers."),
                O("D", "SSR requires client-side routing in React, whereas Web APIs manage HTML layouts directly on the server.")
            },
            CorrectKey = "B",
            Explanation = "In MVC (SSR) the server runs the controller, fills a Razor view and returns finished HTML. A Web API only returns data (usually JSON), and the client decides how to render it."
        },
        new()
        {
            Number = 2,
            Text = "Why do Web API controllers in ASP.NET Core inherit from ControllerBase instead of Controller?",
            Options =
            {
                O("A", "ControllerBase supports Razor View rendering using View() and ViewData."),
                O("B", "ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead."),
                O("C", "Controller is obsolete in .NET 8 and cannot handle HTTP POST requests."),
                O("D", "ControllerBase automatically creates SQLite database files on application startup.")
            },
            CorrectKey = "B",
            Explanation = "Controller extends ControllerBase and adds View(), ViewData and other view support. An API returns data, not views, so ControllerBase is the leaner base class."
        },
        new()
        {
            Number = 3,
            Text = "Which framework attribute automatically triggers an HTTP 400 Bad Request response when incoming request payloads fail structural model validation?",
            Options =
            {
                O("A", "[Route]"),
                O("B", "[HttpGet]"),
                O("C", "[ApiController]"),
                O("D", "[FromQuery]")
            },
            CorrectKey = "C",
            Explanation = "[ApiController] enables API-specific behaviors, including automatic HTTP 400 responses when ModelState is invalid, plus binding source inference."
        },
        new()
        {
            Number = 4,
            Text = "Which HTTP status code should an API return after successfully creating a new resource via a POST request, along with a Location header pointing to the new URI?",
            Options =
            {
                O("A", "200 OK"),
                O("B", "201 Created"),
                O("C", "204 No Content"),
                O("D", "404 Not Found")
            },
            CorrectKey = "B",
            Explanation = "201 Created signals a new resource was made. In ASP.NET Core, CreatedAtAction() or CreatedAtRoute() returns it with the Location header."
        },
        new()
        {
            Number = 5,
            Text = "When a DELETE request successfully removes a resource from the server and returns no content in the response body, which HTTP status code is standard?",
            Options =
            {
                O("A", "200 OK"),
                O("B", "201 Created"),
                O("C", "204 No Content"),
                O("D", "400 Bad Request")
            },
            CorrectKey = "C",
            Explanation = "204 No Content means the request succeeded and there is nothing to send back. In ASP.NET Core this is returned by NoContent()."
        },
        new()
        {
            Number = 6,
            Text = "Which of the following endpoint URIs follows RESTful resource-oriented naming best practices?",
            Options =
            {
                O("A", "GET /api/getAllCourses"),
                O("B", "GET /api/courses"),
                O("C", "POST /api/createNewCourseRecord"),
                O("D", "POST /api/deleteCourseById?id=5")
            },
            CorrectKey = "B",
            Explanation = "REST URIs name resources with plural nouns and let the HTTP verb express the action. Verbs inside the path (get, create, delete) go against that."
        },
        new()
        {
            Number = 7,
            Text = "What is the primary function of the [Route(\"api/[controller]\")] attribute in ASP.NET Core?",
            Options =
            {
                O("A", "It connects the controller directly to an Entity Framework database context."),
                O("B", "It maps incoming URI request paths to the controller class using the class name token."),
                O("C", "It encrypts all incoming JSON payloads."),
                O("D", "It enables Cross-Origin Resource Sharing (CORS) for external React apps.")
            },
            CorrectKey = "B",
            Explanation = "The [controller] token is replaced by the controller's class name without the \"Controller\" suffix, so CoursesController is reached at /api/courses."
        },
        new()
        {
            Number = 8,
            Text = "Which HTTP verb is safe and idempotent, intended exclusively for retrieving resource data without altering server state?",
            Options =
            {
                O("A", "POST"),
                O("B", "PUT"),
                O("C", "GET"),
                O("D", "DELETE")
            },
            CorrectKey = "C",
            Explanation = "GET is safe (it does not change server state) and idempotent (repeating it has the same effect). PUT and DELETE are idempotent but not safe; POST is neither."
        },
        new()
        {
            Number = 9,
            Text = "In ASP.NET Core Web API, what wrapper type allows action methods to return either a strongly typed domain object or standard HTTP status result helpers (such as Ok(), NotFound())?",
            Options = { },
            AnswerOverride = "ActionResult<T>",
            Explanation = "ActionResult<T> lets an action return either a T (implicitly converted) or any ActionResult helper such as Ok(), NotFound() or BadRequest(), while keeping the response type visible to Swagger.",
            Note = "The options for this question were cut off in the source, so it appears in the answer key only and is left out of the quiz."
        }
    };
}