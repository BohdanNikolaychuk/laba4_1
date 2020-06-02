using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
   public class Student
    {
        private string name;
        private string lastName;
        private string group;
        private string passport;
        private int year;
        private string adress;
        private int age;
        private int telephone;
        private int rating;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        public string Group
        {
            get => group;
            set => group = value;
        }
        public string Passport
        {
            get => passport;
            set => passport = value;

        }
        public int Year
        {
            get => year;
            set => year = value;
        }
        public string Adress
        {
            get => adress;
            set => adress = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public int Telephone
        {
            get => telephone;
            set => telephone = value;
        }
        public int Rating
        {
            get => rating;
            set => rating = value;
        }
        

    }
}
