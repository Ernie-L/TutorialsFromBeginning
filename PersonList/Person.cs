using System;
using System.Collections.Generic;
using System.Text;

namespace PersonList
{
    public enum Gender
    {
        male, female
    }

    public class Person
    {
        string name;
        Gender gender;
        int age;
        Person next;
    }
}
