using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    #region higher order function
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public int Rating { get; set; }

        public PoliticalOrientation Party;

        public Person()
        {

        }

        public Person(string firstName, string lastName, int rating)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Rating = rating;
        }

        public Person PersonCopy()
        {
            Person newPerson = new Person();
            newPerson.FirstName = this.FirstName;
            newPerson.LastName = this.LastName;
            newPerson.StartDate = this.StartDate;
            newPerson.Rating = this.Rating;
            newPerson.Party = this.Party;
            return newPerson;
        }


        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);

        }
        public string ToString(Func<Person,string> formatter)
        {
            if (formatter != null)
                return formatter(this);
            return this.ToString();
        }

        public enum PoliticalOrientation{
            Republican,
            Democrat,
            ThirdParty
        }

        public static Person operator + (Person person1, Person person2)
        {
            Person newPerson = person1.PersonCopy();
            newPerson.Rating = (person1.Rating + person2.Rating);

            return newPerson;
        }


    }
    #endregion 

}
