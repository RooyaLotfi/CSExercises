using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class Person
    {
        private int _id;
        private string name = "";
        private int age = 0;
        private char gender = 'M';
        private double weight = 0;
        private double height = 0;

        public Person(string id)
        {
            this._id = GenerateID();
        }

        public Person(string id, string name, int age, char gender, double weight)
        {
            this._id = GenerateID();
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public Person(string id, string name, int age, char gender, double weight, double height)
        {
            this._id = GenerateID();
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.weight = weight;
            this.height = height;
        }

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Id
        {
            get { return _id; }
        }

        public int Calculate()
        {
            float bmi = (float)weight/(float)(height * height);
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
            return "User : " + _id + ", name: " + name + ", age: "+ age + ", gender: " + gender;
        }

        private int GenerateID() 
        {
            Random rnd = new Random();
            _id = rnd.Next(10000000, 99999999);
            return _id;
        }
        


    }
}
