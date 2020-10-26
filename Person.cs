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

        public Person(string id){
            this.id = id;
        }

        public Person(string id, string name, int age, char gender, double weight){
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public Person(string id, string name, int age, char gender, double weight, double height){
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.weight = weight;
            this.height = height;
        }


    }
}
