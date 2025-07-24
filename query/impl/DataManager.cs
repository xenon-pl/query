using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace query.impl
{
    public class DataManager
    {
        public List<Question> questions = new List<Question>();
        public int interval = 30; //minutes btw


        private static DataManager _instance;
        public static DataManager instance => _instance ??= new DataManager();

        private DataManager() { }
    }
}
