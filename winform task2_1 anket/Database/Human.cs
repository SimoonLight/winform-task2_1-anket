using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_task2_1_anket.Database
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Father_name { get; set; }
        public string Nickname { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Number { get; set; }
        public DateTime DateTime { get; set; }
        public string Sex { get; set; }

        public Human()
        {
            this.Name = string.Empty;
            this.Surname = string.Empty;
            this.Father_name = string.Empty;
            this.Nickname = string.Empty;
            this.Country = string.Empty;
            this.City = string.Empty;
            this.Number = string.Empty;
            this.DateTime = DateTime.MinValue;
            this.Sex = string.Empty;
        }
        public Human(string name, string surname, string father_name, string nickname, string country, string city, string number, DateTime dateTime, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Father_name = father_name;
            this.Nickname = nickname;
            this.Country = country;
            this.City = city;
            this.Number = number;
            this.DateTime = dateTime;
            this.Sex = sex;
        }
        public override string ToString()
        {
            return $@" Name : {this.Name}\n Surname : {this.Surname}\n Father name : {this.Father_name}\n Nickname : {this.Nickname}\n
 Country : {this.Country}\n City : {this.City}\n City : {this.City}\n Number : {this.Number}\n Datetime : {this.DateTime}\n Sex : {this.Sex}";
        }

    }

    public class Base
    {
        List<Human> humans;
        public Base()
        {
            humans = new List<Human>();
        }
        public Base(List<Human> humans)
        {
            this.humans = new List<Human>(humans);
        }
        public void AddHuman(Human human)
        {
            humans.Add(human);
        }
        public void DeleteHuman(Human human)
        {
            humans.Remove(human);
        }
    }

}
