namespace BSIT_32E1_Elective_2_Assignment_1.Models;

public class QuizResultItem
{
    public QuizQuestion Question { get; init; } = new();
    public string? SelectedKey { get; init; }
    public bool IsCorrect => SelectedKey == Question.CorrectKey;
}

public class QuizResultViewModel
{
    public List<QuizResultItem> Items { get; init; } = new();
    public int Score => Items.Count(i => i.IsCorrect);
    public int Total => Items.Count;
}