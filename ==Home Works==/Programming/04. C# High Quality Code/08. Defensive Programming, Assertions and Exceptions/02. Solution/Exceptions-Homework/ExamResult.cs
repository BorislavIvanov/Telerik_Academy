using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("The grade can't be negative!!!");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("The minGrade can't be negative!!!");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("The maximum grade should be bigger than the minimum grade!!!");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentException("Comments are obligatory! Please write some!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
