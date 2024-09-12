using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {

        public static void AddPerson(string[] people, int id, string name, string surname, int age)
        {
            int emptyIndex = GetFirstEmptyIndex(people);
            people[emptyIndex] = id.ToString();
            people[emptyIndex + 1] = name;
            people[emptyIndex + 2] = surname;
            people[emptyIndex + 3] = age.ToString();
        }
        public static void RemovePerson(string[] people, int id)
        {
            int idIndex = GetPersonInfoStartIndex(people, id);
            people[idIndex] = null;
            people[idIndex + 1] = null;
            people[idIndex + 2] = null;
            people[idIndex + 3] = null;
        }
        public static void GetById(string[] people, int id)
        {
            int personStartIndex = GetPersonInfoStartIndex(people, id);
            for (int i = personStartIndex; i < personStartIndex + 4; i++)
            {
                Console.WriteLine(people[i]);
            }
        }
        public static void PrintItems(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.WriteLine("---------------------------------");
        }
        public static int GetPersonInfoStartIndex(string[] people, int id)
        {
            for (int i = 0; i < people.Length; i += 4)
            {
                if (people[i] == id.ToString())
                {
                    return i;
                }
            }
            return -1;
        }
        public static int GetFirstEmptyIndex(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }


        public static void ChangingData(string[] people, int id, string oldData, string newData)
        {

            int index = GetPersonInfoStartIndex(people, id);
            for(int i = index; i < index + 4; i++)
            {
                if (people[index] == oldData)
                {
                    people[index] = newData;
                    break;
                }
            }
            
        }
        static void Main(string[] args)

        {
            string[] people = new string[2000];
            AddPerson(people, 1, "Armen", "Poghosyan", 25);
            AddPerson(people, 2, "Armine", "Vardanyan", 25);
            AddPerson(people, 3, "Mane", "Soghomonyan", 25);
            PrintItems(people);
            RemovePerson(people, 2);
            PrintItems(people);
            AddPerson(people, 4, "Samvel", "Petrosyan", 30);
            PrintItems(people);
            GetById(people, 4);
            ChangingData(people, 1,"Armen", "Kikos");
            PrintItems(people);
        }
    }
}
