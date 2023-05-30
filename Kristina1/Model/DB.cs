using Kristina1.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kristina1.Model
{
    class DB
    {
        List<Person> people;
        public DB()
        {
            people = new List<Person>();
        }
        public void Add(Person obj)
        {
            people.Add(obj);
        }
        public List<Person> GetPeople()
        {
            return people;
        }
        public void DeletePerson(Person a)
        {
            people.Remove(a);
        }
        public List<Person> SearchName(string name)
        {
            
                List<Person> search= new List<Person>();

                foreach (Person p in people)
                {
                if (p.Name == name)                      {
                        search.Add(p);
                    }
                }

                return search;
            }
        }

    }
    

