namespace MakePersonInC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class People
    {
        enum Gender { Male, Female };
        class Person
        {
            public Gender gender { get; set; }
            public string personName { get; set; }
            public int age { get; set; }
        }
        public void MakePerson(int personID)
        {
            Person newPerson = new Person();
            newPerson.age = personID;
            if (personID % 2 == 0)
            {
                newPerson.personName = "Gosho";
                newPerson.gender = Gender.Male;
            }
            else
            {
                newPerson.personName = "Maria";
                newPerson.gender = Gender.Female;
            }
        }
    }
}
