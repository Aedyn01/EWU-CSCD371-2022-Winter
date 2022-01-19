namespace Lecture
{
    public class Person
    {
        // Always code a property, unless you MUST use a field

        public Person(string name)
        {
            Initialize(name);
        }

        private string? _Name;
        public string Name
        {
            // Can use => instead of curly brackets and "return"
            get => _Name!; 
            set 
            {
                // Always use "nameof" when throwing exception
                if(value is null) throw new ArgumentException(nameof(value)); 
                _Name = value; 
            }   
        }

        (string, string)[] Passwords = new[] { 
            ("Inigo Montoya", "YouKilledMyF@ther!")
        }; 

        public bool Login(string userName, string password)
        {
            return password == "YouKilledMyF@ther!";
        }
    }
}