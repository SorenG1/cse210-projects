using System;

namespace ConsoleApp1
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            if (IsComplete())
            {
                return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
            }
            else
            {
                return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
            }
        }

        public int GetBonus()
        {
            return _bonus;
        }
    }
}
