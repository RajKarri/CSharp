using System.Collections.Generic;
using JsonEngine.Models;
using Newtonsoft.Json;

namespace JsonEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Json serialization and deserialization test for simple object
            Student studentObjToSerialize = new Student() { Id = 101, Name = "Dave", Age = 20 };
            Student studentObjToDeSerialize = new Student();
            string jsonStudent = JsonConvert.SerializeObject(studentObjToSerialize);
            studentObjToDeSerialize = JsonConvert.DeserializeObject<Student>(jsonStudent);

            // 2. Json serialization and deserialization test for complex object with nested objects
            Professor professorObjToSerialize = new Professor() { Id = 201, Name = "John", Age = 20 };
            Professor professorObjToDeSerialize = new Professor();
            professorObjToSerialize.Departments = new List<Department>
            {
                new Department() { Id = 301, Name = "Physics" },
                new Department() { Id = 302, Name = "Computers" }
            };
            string jsonProfessor = JsonConvert.SerializeObject(professorObjToSerialize);
            professorObjToDeSerialize = JsonConvert.DeserializeObject<Professor>(jsonProfessor);

            // 3. Json serialization and deserialization test for complex object with nested objects and read only property
            Professor1 professor1ObjToSerialize = new Professor1() { Id = 201, Name = "John", Age = 20 };
            Professor1 professor1ObjToDeSerialize = new Professor1();
            professor1ObjToSerialize.Departments = new List<Department>
            {
                new Department() { Id = 301, Name = "Physics" },
                new Department() { Id = 302, Name = "Computers" }
            };
            string jsonProfessor1 = JsonConvert.SerializeObject(professor1ObjToSerialize);
            professor1ObjToDeSerialize = JsonConvert.DeserializeObject<Professor1>(jsonProfessor1);

            // 4. Json serialization and deserialization test for complex object with nested objects and read and write property
            // Notice difference in "DepartmentsString" property in professor2ObjToSerialize & professor2ObjToDeSerialize objects before and after
            Professor2 professor2ObjToSerialize = new Professor2() { Id = 201, Name = "John", Age = 20 };
            Professor2 professor2ObjToDeSerialize = new Professor2();
            professor2ObjToSerialize.Departments = new List<Department>
            {
                new Department() { Id = 301, Name = "Physics" },
                new Department() { Id = 302, Name = "Computers" }
            };
            string jsonProfessor2 = JsonConvert.SerializeObject(professor2ObjToSerialize);
            professor2ObjToDeSerialize = JsonConvert.DeserializeObject<Professor2>(jsonProfessor2);
        }
    }
}

