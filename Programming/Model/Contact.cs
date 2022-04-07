namespace Programming.Model
{
    using System;
    
    public class Contact
    {
        private string _number;

        public string _name;

        public string _surname;

        public Contact()
        {
        }

        public Contact(string name,
            string surname,
            string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (!long.TryParse(value, out long num))
                {
                    throw new ArgumentException(
                        "the value of the Number field must consist of digits only");
                }

                if (value.Length != 11)
                {
                    throw new System.ArgumentException(
                        "the value of the Number field must consist of 11 digits");
                }

                _number = value;
            }
            
        }
        
        private void AssertStringContainsOnlyLetters(string value, string nameProperty)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException(
                        $"the value of the {nameProperty} field should consist only of English letters.");
                }
            }
        }
    }
}