using System;
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string shortname, string description, int points, int target, int bonus) : base(shortname, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override int RecordEvent()
    {
        if (_amountCompleted < _target ){

            _amountCompleted++;

            if (_amountCompleted == _target){
                Console.WriteLine($"Congratulations! You have completed the goal: {_shortName} and earned a bonus of {_bonus} points!");
                return _points + _bonus;
            }
            else if (_amountCompleted < _target){
                Console.WriteLine($" Keep it up, you have completed {_shortName} {_amountCompleted}. Only {_target - _amountCompleted} to go.");
                return _points;
            }
            else
            {
                Console.WriteLine($"An ERROR has occurred. Please try again.");
                return 0;
            }
        }
        else
        {
            Console.WriteLine($"{_bonus} is your bonus points for completing your task.");
            Console.WriteLine($"Your points are {_points}.");
            return 0;
        }
        
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;  // Returns true when target is reached
    }
    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
          return $"{checkbox} {_shortName} ({_description} )-- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";  
    }
}