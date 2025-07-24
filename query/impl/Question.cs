using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace query.impl
{
    public class Question
    {
        public string Name { get; set; }
        public Dictionary<string, bool> Answers { get; set; } 

        public Question(string name, Dictionary<string, bool> answers) {
            Answers = answers;
            Name = name;
        }
    }
}
