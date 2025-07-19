using System;

namespace ConsoleApp1
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            // Nothing happens, eternal goals are never complete
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetDetailsString()
        {
            return $"[ ] {_shortName} ({_description})";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{_shortName},{_description},{_points}";
        }
    }
}
