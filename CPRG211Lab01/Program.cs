using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace CPRG211Lab01
{
    //Creating a Person Class
    class Person
    {
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;

        // Constructor for the Person Class
        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        // DisplayPersonalInfo Method
        public string DisplayPersonalInfo()
        {
            return $"ID {this.personId}: " +
                $"{this.firstName} {this.lastName}'s " +
                $"favorite colour is {this.favoriteColour}";
        }

        //ChangeFavoriteColor Method
        public string ChangeFavoriteColour()
        {
            return this.favoriteColour = "White";
        }

        //GetAgeInTenYears Method
        public int GetAgeInTenYears()
        {
            return (this.age + 10);
        }

        //ToString Method
        public override string ToString()
        {
            return $"ID: {this.personId}\n" +
            $"First Name: {this.firstName}\n" +
            $"Last Name: {this.lastName}\n" +
            $"Favorite Colour: {this.favoriteColour}\n" +
            $"Age: {this.age}\n" +
            $"Is Working: {this.isWorking}";
        }
    }

    //Creating the Relation Class
    class Relation
    {
        public enum RelationshipType
        {
            Sister, Brother, Mother, Father
        }

        //ShowRelationship Method that Accepts 2 Person Objects
        public string ShowRelationship(Person per1, Person per2, Enum relation)
        {
            return $"Relationship between {per1.firstName} and {per2.firstName} is: {relation}hood";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating 4 Person Objects Using the Data
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);


            //Console.WriteLine($"{person2.personId}: {person2.firstName} {person2.lastName}'s favorite color is: {person2.favoriteColour}");

            // Display Gina's Information
            Console.WriteLine($"{person2.DisplayPersonalInfo()}");

            //Display Mike's Information as a List
            Console.WriteLine(person3.ToString());

            //Change Ian's Favorite Color and Display the Info
            person1.ChangeFavoriteColour();
            Console.WriteLine($"{person1.personId}: {person1.firstName} {person1.lastName}'s favorite color is: {person1.favoriteColour}");

            //Display Mary's Age in 10 Years
            Console.WriteLine($"{person4.firstName} {person4.lastName} age in 10 years: {person4.GetAgeInTenYears()}");

            //Create Two Relation Objects and Display the Relationship
            Relation relation1 = new Relation();
            Console.WriteLine($"{relation1.ShowRelationship(person2, person4, Relation.RelationshipType.Sister)}");

            Relation relation2 = new Relation();
            Console.WriteLine($"{relation2.ShowRelationship(person1, person3, Relation.RelationshipType.Brother)}");

            //Add all Person objects to a list
            List<Person> personList = new List<Person>(4) { person1, person2, person3, person4 };

            //Displaying average age of Person list
            double ageAverage = ((double)personList[0].age + personList[1].age + personList[2].age + personList[3].age) / personList.Count;
            Console.WriteLine(ageAverage);

            //Displaying the youngest and oldest person
            Console.WriteLine($"The youngest person is: {personList[1].firstName}");
            Console.WriteLine($"The oldest person is: {personList[2].firstName}");

            //Displaying people with first names that start with M
            Console.WriteLine(personList[2].ToString());
            Console.WriteLine(personList[3].ToString());

            //Displaying people who like the color blue
            Console.WriteLine(personList[2].ToString());

        }
    }
}
