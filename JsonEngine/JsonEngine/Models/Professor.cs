using System.Collections.Generic;

namespace JsonEngine.Models
{
    public class Professor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public IList<Department> Departments { get; set; }
    }
}
