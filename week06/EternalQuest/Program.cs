using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        private static List<Goal> _goals = new List<Goal>();
        private static int _score = 0;

        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "6")
            {
                DisplayPlayerInfo();
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    CreateGoal();
                }
                else if (choice == "2")
                {
                    ListGoals();
                }
                else if (choice == "3")
                {
                    SaveGoals();
                }
                else if (choice == "4")
                {
                    LoadGoals();
                }
                else if (choice == "5")
                {
                    RecordEvent();
                }
            }
        }

        static void DisplayPlayerInfo()
        {
            int level = _score / 1000 + 1;
            Console.WriteLine($"You have {_score} points. Level: {level}");
        }

        static void CreateGoal()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string choice = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            if (choice == "1")
            {
                SimpleGoal goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (choice == "2")
            {
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (choice == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(goal);
            }
        }

        static void ListGoals()
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }

        static void RecordEvent()
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
            }
            Console.Write("Which goal did you accomplish? ");
            int choice = int.Parse(Console.ReadLine()) - 1;

            Goal goal = _goals[choice];
            goal.RecordEvent();
            _score += goal.GetPoints();

            Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points!");

            if (goal is ChecklistGoal)
            {
                ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                if (checklistGoal.IsComplete())
                {
                    _score += checklistGoal.GetBonus();
                    Console.WriteLine($"Bonus! You have earned {checklistGoal.GetBonus()} bonus points!");
                }
            }

            Console.WriteLine($"You now have {_score} points.");
        }

        static void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
        }

        static void LoadGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);

            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(":");
                string goalType = parts[0];
                string[] details = parts[1].Split(",");

                if (goalType == "SimpleGoal")
                {
                    string name = details[0];
                    string description = details[1];
                    int points = int.Parse(details[2]);
                    bool isComplete = bool.Parse(details[3]);

                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    if (isComplete)
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
                else if (goalType == "EternalGoal")
                {
                    string name = details[0];
                    string description = details[1];
                    int points = int.Parse(details[2]);

                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    string name = details[0];
                    string description = details[1];
                    int points = int.Parse(details[2]);
                    int bonus = int.Parse(details[3]);
                    int target = int.Parse(details[4]);
                    int amountCompleted = int.Parse(details[5]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int j = 0; j < amountCompleted; j++)
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
            }
        }
    }
}