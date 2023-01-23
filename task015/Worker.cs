class Worker
{
    class Worker
    {
        public int id;
        public string dep_id;
        public int age;
        public int salary;
        public string full_name;

        public Worker(int id, string dep_id, int age, int salary, string full_name)
        {
            this.id = id;
            this.dep_id = dep_id;
            this.age = age;
            this.salary = salary;
            this.full_name = full_name;
        }

        public override string ToString()
        {
            return $"id: {self.id} Full name: {self.full_name} age: {self.age} salary: {self.salary} dep id {self.dep_id}";
        }

    }
}