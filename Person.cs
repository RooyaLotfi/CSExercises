using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class Person
    {
        private string id;
        private string name = "";
        private int age = 0;
        private char gender = 'M';
        private double weight = 0;
        private double height = 0;

        public Person(string id)
        {
            this.id = id;
        }

        public Person(string id, string name, int age, char gender, double weight)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public Person(string id, string name, int age, char gender, double weight, double height)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.weight = weight;
            this.height = height;
        }

        public int Calculate()
        {
            int bmi = (weight)/(height^2);
            if(bmi < 18.5)
                return -1;
            else if( 18.5 <= bmi && bmi <= 25 )
                return 0;
            return 1;
        }

        public bool IsOver18()
        {
            if (age < 18)
                return false;
            else 
                return true;
        }

        private bool CheckGender(char gen)
        {
            if(gender == gen)
                return true;
            else
                return false;
        }
        
        public string ToString()
        {
            return "User : " + id + ", name: " + name + ", age: "+ age + ", gender: " + gender;
        }

        public int GenerateID() 
        {
            Random rnd = new Random(); 
            id = rnd.Next(10000000, 99999999);
            return id;
        }

    }
}
