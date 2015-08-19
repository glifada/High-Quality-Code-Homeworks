using System;

public class CSharpExam : Exam
{
    private int score;

    public CSharpExam(int score)
    {
        if (score < 0 || 100 < score)
        {
            throw new ArgumentOutOfRangeException("The score must be non-negative value smaller than 100!");
        }

        this.Score = score;
    }

    public int Score 
    {
        get { return this.score; }
        private set
        {
            if (value < 0 || 100 < value)
                {
                    throw new ArgumentOutOfRangeException ("The score must be non-negative value smaller than 100!");
                }
            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (Score < 0 || Score > 100)
        {
            throw new InvalidOperationException("The score must be non-negative value smaller than 100!");
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
