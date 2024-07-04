using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    public struct Person
    {
        private int Age;
        private string Name;
        public Person()
        {
                
        }

        public int age
        {

        get; set; 
        } 

        public string name
        {
            get;set;
        }


        public override string ToString()
        {
            return $"{name}, {age}";
        }
    }
}
