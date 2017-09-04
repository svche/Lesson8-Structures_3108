using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Structures_3108
{
    class Program
    {
         struct Humen
        {
            public string name;
            public int age;
            public char sex;
        }
        static void Main(string[] args)
        {
            /*
            Humen person;
            person.name = "Ivan";
            person.age = 20;
            person.sex = 'M';

            Console.WriteLine("{0} {1} {2} ",person.name, person.age, person.sex); */

            Humen[] persons;
            persons = new Humen[5];

            persons[0].name = "Ivan";
            persons[0].age = 28;
            persons[0].sex = 'M';

            persons[1].name = "Vladlen";
            persons[1].age = 21;
            persons[1].sex = 'M';

            persons[2].name = "Liliya";
            persons[2].age = 22;
            persons[2].sex = 'W';

            persons[3].name = "Slavon";
            persons[3].age = 27;
            persons[3].sex = 'M';

            persons[4].name = "Elena";
            persons[4].age = 60;
            persons[4].sex = 'W';

            foreach (Humen x in persons) Console.WriteLine(x.name + " " + x.age + " " + x.sex);

            // sorting

            int minAge;
            int numMinAge;
            Humen tmpHumen;

            for (int i = 0; i < persons.Length; i++)
            {
                numMinAge = i;
                minAge = persons[i].age ;

                for (int j = i; j < persons.Length; j++)
                {
                    if (minAge > persons[j].age)
                    {
                        minAge = persons[j].age;
                        numMinAge = j;
                    }
                }

                tmpHumen = persons[i];
                persons[i] = persons[numMinAge];
                persons[numMinAge] = tmpHumen;

            }
            Console.WriteLine();
            foreach (Humen x in persons) Console.WriteLine( x.age + " " + x.sex + " " +  x.name);





        }
    }
}
