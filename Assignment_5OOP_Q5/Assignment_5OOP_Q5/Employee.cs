namespace Assignment_5OOP_Q5
{
    class Employee
    {
        public string name;
        public Employee(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return (name);
        }
    }
}
internal class Employee
    {
        private string name;

        public Employee(string name)
        {
            this.name = name;
        }
    }
