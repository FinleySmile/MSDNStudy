namespace WhereConstraintTest
{
    class Employee
    {
        private string _name;
        private int _id;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}