namespace Lecture
{
    public class Person
    {
        // Always code a property, unless you MUST use a field
        // A property = fast runtime, a field = slow runtime

        public Person(string name)
        {
            Initialize(name);
        }

        private void Initialize(string name)
        {
            Name = name;
        }

        // Works the same as saying return
        public string ToText => $"{nameof(Name)}: {Name}; {nameof(DateOfBirth)}: {DateOfBirth}";

        //public int Age 
        //{ 
        //    get
        //    {
        //        return DateOnly.FromDateTime(DateTime.Now);
        //    } 
        //}    

        public DateOnly DateOfBirth { get; set; }

        public string? MiddleName { get; set; }    

        private string? _Name;
        public string Name
        {
            // Can use => instead of curly brackets and "return"
            get => _Name!; 

            // You can make only the setter private so that other classes cannot set, but they can get
            set 
            {
                // Always use "nameof" when throwing exception
                if(value is null) throw new ArgumentException(nameof(value)); 
                if(string.IsNullOrWhiteSpace(value)) throw new ArgumentException(
                    $"{nameof(Name)} cannot be null or empty value", nameof(value));
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