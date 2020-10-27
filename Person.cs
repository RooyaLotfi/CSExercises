using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class Person
    {
        private int _id;
        private string _name = "";
        private int _age = 0;
        private char _gender = 'M';
        private double _weight = 0;
        private double _height = 0;

        public Person()
        {
            this._id = GenerateID();
        }

        public Person(string name, int age, char gender, double weight)
        {
            this._id = GenerateID();
            this._name = name;
            this._age = age;
            this._gender = gender;
        }

        public Person(string name, int age, char gender, double weight, double height)
        {
            this._id = GenerateID();
            this._name = name;
            this._age = age;
            this._gender = gender;
            this._weight = weight;
            this._height = height;
        }

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int Id
        {
            get { return _id; }
        }

        public int Calculate()
        {
            float bmi = (float)_weight/(float)(_height * _height);
            if(bmi < 18.5)
                return -1;
            else if( 18.5 <= bmi && bmi <= 25 )
                return 0;
            return 1;
        }

        public bool IsOver18()
        {
            if (_age < 18)
                return false;
            else 
                return true;
        }

        private bool CheckGender(char gen)
        {
            if(_gender == gen)
                return true;
            else
                return false;
        }

        public string ToString => "User : " + _id + ", name: " + _name + ", age: " + _age + ", gender: " + _gender;

        private int GenerateID() 
        {
            Random rnd = new Random();
            _id = rnd.Next(10000000, 99999999);
            return _id;
        }

    }
}
