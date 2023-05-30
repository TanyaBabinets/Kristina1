using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Kristina1.Model;
using Kristina1.NewFolder1;

namespace Kristina1
{
    internal class Controller
    {
        DB db = new DB();
        
        public void AddPerson(string n, int a)
        {
            db.Add(new Person(n, a));
        }
        public List<Person> GetAllPerson()
        {
            return db.GetPeople();
        }
        public void Delete(Person a)
        {
            db.DeletePerson(a); 
        }

        public List<Person> GetSearch(string name)
        {
          return  db.SearchName(name);
        }
    }
}
