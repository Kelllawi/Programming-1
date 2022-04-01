using System;

namespace Programming.Model
{
    public class Subject
    {
        private int _mark;

        public Subject()
        {
        }

        public Subject(string name,
            int mark)
        {
            Name = name;
            Mark = mark;
        }

        public string Name { get; set; }
        
        public int Mark
        {
            get { return _mark; }
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new System.ArgumentException(
                        "the value of the Mark field should be between 1 (unsatisfactory) and 5 (excellent)");
                }

                _mark = value;
            }
        }
    }
}