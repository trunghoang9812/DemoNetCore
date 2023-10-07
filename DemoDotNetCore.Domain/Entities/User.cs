using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDotNetCore.Domain.Entities
{
    public class User
    {
        public User()
        {

        }
        public User(string name, string gender, int age, string address)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Address = address;
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public int Age { get; private set; }
        public string Address { get; private set; }
    }
}
