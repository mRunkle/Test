using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private  static int FIZZBUZZMAX;
        static void Main(string[] args)
        {
            FIZZBUZZMAX = 100;


            var dtrump = new Person();
            dtrump.FirstName = "donald";
            dtrump.LastName = "trump";
            dtrump.Rating = -100;
            dtrump.Party = Person.PoliticalOrientation.Republican;
            Console.WriteLine(dtrump.ToString(p => string.Format("{0}, {1} rated at:{2}", dtrump.FirstName, dtrump.LastName, dtrump.Rating)));

            var bsanders = new Person();
            bsanders.FirstName = "bernie";
            bsanders.LastName = "sanders";
            bsanders.Rating = 10;
            bsanders.Party = Person.PoliticalOrientation.Democrat;

            var jbush = new Person();
            jbush.FirstName = "jeb";
            jbush.LastName = "bush";
            jbush.Rating = 10;
            jbush.Party = Person.PoliticalOrientation.Republican;

             var jkasich = new Person();
            jkasich.FirstName = "john";
            jkasich.LastName = "kasich";
            jkasich.Rating = 11;
            jkasich.Party = Person.PoliticalOrientation.Republican;

            var swalker = new Person();
            swalker.FirstName = "scott";
            swalker.LastName = "walker";
            swalker.Rating = 12;
            swalker.Party = Person.PoliticalOrientation.Republican;
            var rpaul = new Person();
            rpaul.FirstName = "rand";
            rpaul.LastName = "paul";
            rpaul.Rating = 2;

            var spalin = new Person();
            spalin.FirstName = "sarah";
            spalin.LastName = "palin";
            spalin.Rating = -9000;
            spalin.Party = Person.PoliticalOrientation.Republican;

            var hclinton = new Person();
            hclinton.FirstName = "hillary";
            hclinton.LastName = "clinton";
            hclinton.Rating = 11;
            hclinton.Party = Person.PoliticalOrientation.Democrat;

            var MOMalley = new Person();
            MOMalley.FirstName = "Martin";
            MOMalley.LastName = "O\'Malley";
            MOMalley.Party = Person.PoliticalOrientation.Democrat;

           List<Person> people = new List<Person>();
            people.Add(dtrump);
            people.Add(bsanders);
            people.Add(jbush);
            people.Add(jkasich);
            people.Add(swalker);
            people.Add(rpaul);
            people.Add(spalin);
            people.Add(hclinton);
            people.Add(MOMalley);


            //create a new list of the same size where all peoples names are ron paul with a rating of 100
            List<Person> ronPaul = people.Select(e => new Person("Ron", "Paul", 100)).ToList();
            

            //create a new list of all candidates whose rating is greater than 7
            List<Person> rating7 = people.Where(p => p.Rating > 7).ToList();

            //create a list republicanViewPoint, where the rating of republicans are doubled and the democrates are halved
            List<Person> RepublicanViewPoint = people.Select(p =>
            {
                Person newPerson = p.PersonCopy();
                if (newPerson.Party == Person.PoliticalOrientation.Republican)
                {
                    newPerson.Rating *= 2;
                }
                else if (newPerson.Party == Person.PoliticalOrientation.Democrat)
                {
                    newPerson.Rating /= 2;
                }
                return newPerson;
            }).ToList();


            //create a list of democratViewPoint, where the rating of democrats are doubled and republicans are halved
            List<Person> democratViewPoint = people.Select(p =>
            {
                Person newPerson = p.PersonCopy();
                if (newPerson.Party == Person.PoliticalOrientation.Democrat)
                {
                    newPerson.Rating *= 2;
                }
                else if (newPerson.Party == Person.PoliticalOrientation.Republican)
                {
                    newPerson.Rating /= 2;
                }
                return newPerson;
            }).ToList();

            //zip the two lists together, adding their ratings and into a list named 'electionResults'
            List<Person> electionResults = RepublicanViewPoint.Zip(democratViewPoint, (r,d) => (r + d)).ToList();

            //find the best rated candidate in from electionResults using a select 
            
            var orderCandidate = from candidate in electionResults
                                orderby candidate.Rating descending
                                select candidate;
            var bestCandidate = orderCandidate.First();
            
         



           
            foreach (string s in Map(FIZZBUZZMAX))
            {
                Console.WriteLine(s);
            }
            foreach (string s in Filter(FIZZBUZZMAX))
            {
                Console.WriteLine(s);
            }
            foreach (string s in Zip(FIZZBUZZMAX))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

        }

        private static List<string> Zip(int FizzBuzzMax)
        {
            List<int> enumerated = Enumerable.Range(1, FizzBuzzMax).ToList();
            List<string> fizz = enumerated.Select(e => e % 3 == 0 ? "fizz" : "").ToList();
            List<int> buzz = enumerated.Select(e => e % 5 == 0 ? 2: 3).ToList();
            List<string> fizzbuzz = fizz.Zip(buzz, (f,b)=> (f+((b +2)+"") )).ToList();
            return fizzbuzz;
        }

        private static List<string> Filter(int FizzBuzzMax)
        {
            List<int> enumerated = Enumerable.Range(1, FizzBuzzMax).ToList();
            List<int> fizz = enumerated.Where(e => e % 3 == 0).ToList();
            List<int> buzz = enumerated.Where(e => e % 5 == 0).ToList();


            List<string> fizzbuzz = enumerated.Select(e =>
                fizz.Contains(e) && buzz.Contains(e) ? "fizzbuzz" :
                    fizz.Contains(e)? "fizz" : 
                        buzz.Contains(e)? "buzz" :
                            String.Empty).ToList();
            return fizzbuzz;
        }
        private static List<string> Map(int FizzBuzzMax)
        {
            List<int> enumerated = Enumerable.Range(1, FizzBuzzMax).ToList();
            List<string> fizzbuzz =
                enumerated.Select(e =>
                {
                    if(e%15==0)
                        return "fizzbuzz";
                    else if(e%3==0)
                        return "=fizz";
                    else if(e%5==0)
                        return "=buzz";
                    else 
                        return ""+e;
                }).ToList();
            return fizzbuzz;
        }
    }
}
