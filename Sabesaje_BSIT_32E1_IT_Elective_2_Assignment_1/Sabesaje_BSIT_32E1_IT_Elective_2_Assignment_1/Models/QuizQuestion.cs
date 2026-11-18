namespace BSIT_32E1_Elective_2_Assignment_1.Models;

public record QuizOption(string Key, string Text);

public class QuizQuestion
{
    public int Number { get; init; }
    public string Text { get; init; } = "";
    public List<QuizOption> Options { get; init; } = new();
    public string CorrectKey { get; init; } = "";
    public string Explanation { get; init; } = "";

    // Used when the question has no (complete) option list, e.g. a truncated question.
    public string? AnswerOverride { get; init; }
    public string? Note { get; init; }

    public bool HasOptions => Options.Count > 0;

    public string CorrectAnswerText =>
        AnswerOverride ?? Options.FirstOrDefault(o => o.Key == CorrectKey)?.Text ?? "";
}