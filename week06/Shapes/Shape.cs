using System;

namespace ConsoleApp1
{
    public class Shape
    {
        protected string _color;

        public Shape(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        // Virtual method that can be overridden by derived classes
        public virtual double GetArea()
        {
            return 0;
        }
    }
}
