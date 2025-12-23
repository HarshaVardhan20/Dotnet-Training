using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSession.ConstructorEx
{
    public class Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogHistory { get; set; }
        public Visitor()
        {
            LogHistory += $"Object created at {DateTime.Now.ToString()} {Environment.NewLine}";
        }

        public Visitor(int id) : this(){
            Id = id;
            LogHistory += $"Object with id created at {DateTime.Now.ToString()} {Environment.NewLine}";
        }
        public Visitor(int id,string name) : this(id)
        {
            Name = name;
            LogHistory += $"Object with name created at {DateTime.Now.ToString()} {Environment.NewLine}";
        }
        public Visitor(int id,string name, string description) : this(id,name)
        {
            Description = description;
            LogHistory += $"Object with description created at {DateTime.Now.ToString()} {Environment.NewLine}";
        }
    }

    public class Employee
    {
        private int id;
        
        public int Id
        {
            set
            {
                if (value> 0)
                {
                    id = value;
                }
                else
                {
                    id = 0;
                    throw new InvalidDataException("id cannot be less than zero");
                }
            }
        }
    }

}