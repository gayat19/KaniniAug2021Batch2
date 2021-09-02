using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingCollectionApplication
{
    class WorkingWithLIst
    {
        public void UnderstandingList()
        {
            List<int> numbers = new List<int>();
            numbers.Add(100);
            numbers.Add(200);
            numbers.Add(100);
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] *= 2;
                numbers[i] += i;
            }
            numbers.Add(340);
            Console.WriteLine("After all add");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Remove(340);
            Console.WriteLine("After removing");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Does the list contain 202?? "+numbers.Contains(202));
        }
        public void UnderstandingSet()
        {
            HashSet<string> names = new HashSet<string>();
            names.Add("Jim");
            names.Add("Tim");
            names.Add("Sim");
            names.Add("Bim");
            names.Add("Tim");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Removing 'sim'");
            names.Remove("Sim");
            Console.WriteLine("After removing");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Does the set contain 'Dim'?? " + names.Contains("Dim"));
        }
        public void UnderstandingLinkedList()
        {
            LinkedList<float> numbers = new LinkedList<float>();
            LinkedListNode<float> node = new LinkedListNode<float>(12.45f);
            numbers.AddFirst(node);
            numbers.AddAfter(node, 20);
            numbers.AddLast(30.4f);
            numbers.AddAfter(node, 22.2f);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        public void UnderstandingDictionary()
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>();
            students.Add(101, new Student(101,"Jim",98.2f));
            students.Add(102, new Student(102, "Kim", 88.2f));
            students.Add(103, new Student(103, "Bim", 92.8f));
            students.Add(104, new Student(104, "Dim", 77.5f));
            foreach (var item in students.Keys)
            {
                Console.WriteLine("The key is "+item);
                Console.WriteLine(students[item]);
            }
            Console.WriteLine("Does the collection conatain the key 103?? "+students.ContainsKey(103));
            Console.WriteLine("Check the value for Kim "+students.ContainsValue(new Student(102,"Kim",88.2f)));
        }
        public void MoreOnEqual()
        {
            Student s1 = new Student(101, "Jim", 98.2f);
            Student s2 = new Student(101, "Jim", 98.2f);
            //Student s2 = s1;
            if(s1==s2)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not equal");
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Score { get; set; }
        public Student()
        {

        }
        public static bool operator ==(Student s1,Student s2)
        {
            if (s1.Id == s2.Id && s1.Name == s2.Name)
                return true;
            else
                return false;
        }
        public static bool operator !=(Student s1, Student s2)
        {
            if (s1.Id == s2.Id && s1.Name == s2.Name)
                return false;
            else
                return true;
        }
        public override bool Equals(object obj)
        {
            Student s1, s2;
            s1 = this;
            s2 = (Student)obj;
            if (s1.Id == s2.Id && s1.Name == s2.Name)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return this.Id;
        }
        public Student(int id, string name, float score)
        {
            Id = id;
            Name = name;
            Score = score;
        }
        public override string ToString()
        {
            return Id+" "+Name+" "+Score;
        }
    }
}
