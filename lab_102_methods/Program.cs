using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_102_methods
{
    class Program
    {   
        static void Main(string[] args)
        {

            //Create Object 

            Student emmanuel = new Student("Emmanuel", 25, "Nigerian", "London", "Bedfordshire");
            Console.WriteLine(emmanuel.toString());


        }
    }
}    public class Student
     {
         //Instance Variables
            String name;
               int age;
            String nationality;
            String city;
            String university;

    //Constructor
            public Student(String name, int age, String nationality, String city, String university)
            {
                this.name = name;
                this.age = age;
                this.nationality = nationality;
                this.city = city;
                this.university = university;

            }
            //1st method 
            public String getName()
            {
                return name;
            }

            //2nd method
            public int getAge()
            {
                 return age; 
            }
            //3rd method
            public String getNationality()
            {
                return nationality;
            }
            //4th method 
            public String getCity()
            {
                return city; 
            }
            //5th Method
            public String getUniversity()
            {
                return university;
            }

    public String toString()
    {
        return ($"My name is" + {this.getName()} + "I am aged\t" + {this.getAge()} + ",\t" + {this.getNationality()} +
                 "\t,live in\t" + {this.getCity()} + "\tand attend\t" + { this.getUniversity()});
    }

}
       ;