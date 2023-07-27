using System;

namespace CongratulatorLVL1
{
    internal class Person
    {
        public string Name { get; set; }
        public DateOnly BirthdayDate { get; set; }
        public Person(string name, DateOnly birthdayDate)
        {
            Name = name;
            BirthdayDate = birthdayDate;
        }
        public override string ToString()
        {
            return Name + ", дата рождения: " + BirthdayDate;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
