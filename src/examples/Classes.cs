using System;

namespace HourOfCode.Examples
{
    public class Classes
    {
        public static void Main(string[] args)
        {
            Person p = new Person("Sergio", "Luis", new DateTime(1993, 10, 11));
            p.SayHello();
            Person.SayGoodBye(p);

            if (p.IsUnderAge)
            {
                Console.WriteLine("Person {0} is underage!", p.FirstName);
            }
            else
            {
                Console.WriteLine("Person {0} is older than the freaking sun.", p.FirstName);
            }
        }

        public class Person
        {
            public string FirstName { get { return first; } } // backing field
            public string LastName { get; private set; } // Auto-implemented property
            public bool IsUnderAge
            {
                get
                {
                    return born == DateTime.MinValue
                        ?  true // We don't have data about when they were born so better be safe
                        : (born.AddYears(18) <= DateTime.UtcNow);
                }
            }

            public Person(string firstName, string lastName)
            {
                first = FirstName;
                LastName = lastName;
                born = DateTime.MinValue;
            }

            public Person(string firstName, string lastName, DateTime bornTime)
            {
                first = firstName;
                LastName = lastName;
                born = bornTime;
            }

            public void SayHello()
            {
                // Console.WriteLine("Hello, {0} {1}!", this.first, this.LastName);
                Console.WriteLine("Hello, {0} {1}!", first, LastName);
            }

            public static void SayGoodBye(Person p)
            {
                Console.WriteLine("Goodbye, {0} {1}!", p.FirstName, p.LastName);
            }

            private string first;
            private DateTime born;
        }

    }
}
