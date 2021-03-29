using System;
using System.Collections.Generic;
using System.Text;

namespace OopExamples.Encapsulation
{
    class PersonSolution
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private DateTime birthday;
        private string snils;

        public PersonSolution(string firstName, string lastName, string middleName, DateTime birthday)
        {
            if (firstName.Contains(" ") || lastName.Contains(" ") || middleName.Contains(" "))
            { throw new ArgumentException("недопустимое имя"); }

            if (birthday > DateTime.Now)
            { throw new ArgumentException("недопустимая дата рождения"); }

            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.birthday = birthday;
        }
        /*  пример создания, так же это реализовывается в java
        public void setSnils(string snils)
        { // todo: проверка номера по полноценному алгоритму, могла бы быть тут)
            if (snils.Length>11 || snils.Length < 11)
            {
                throw new ArgumentException("ошибка в СНИЛС");
            }
            this.snils = snils;
        }

        
         public string GetSnilsName()
        { return snils; }

        public string GetFirstName()
        { return firstName; }

        public string GetLastName()
        { return lastName; }

        public string GetMiddleName()
        { return middleName; }
        
        public DateTime GetBirthday() 
        { return birthday; }
        
        */

        public string GetFullName()
        { return $"{lastName} {firstName} {middleName}"; }


        public void PrintPersonInfo()
        { Console.WriteLine($"{lastName} {firstName} {middleName} {birthday:dd.MM.yyyy},{snils}"); }



        //Вариант создания в C#
        public string FirstName
        { 
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public string MiddleName
        {
            get { return middleName; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
        }

        public string Snils { 
            get { return snils; } 
            set {
                if (value.Length > 11 )
                {
                    throw new ArgumentException("ошибка в СНИЛС");
                }
                snils = value;
            } }
    }

    public static class PersonSolutionExampl
    {
        public static void Run()
        { // ожидаемое использование и реальное использование
            PersonSolution person = new PersonSolution("Ivanov", "Ivan", "Ivanovich", DateTime.Parse("01.01.1991"));
            person.Snils = "12345678901";
            string firstName = person.FirstName;
            string fullName = person.GetFullName();
            person.PrintPersonInfo();

        }
    }
}
