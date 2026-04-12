public class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} | {_description} | Completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} |{_description} | Completed {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}