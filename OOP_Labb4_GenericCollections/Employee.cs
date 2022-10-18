namespace OOP_Labb4_GenericCollections
{
    class Employee
    {
        public int _id;
        public string _name;
        public string _gender;
        public int _salary;

        public Employee(int id, string name, string gender, int salary)
        {
            _id = id;
            _name = name;
            _gender = gender;
            _salary = salary;
        }

        public override string ToString()
        {
            return $"id: {_id} - {_name} - {_gender} - {_salary}";
        }
    }
}
