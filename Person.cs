﻿namespace Football
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}