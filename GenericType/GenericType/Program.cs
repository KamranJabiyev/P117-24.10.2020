using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //int[] arr = { 1, 2, 3,10, 4, 5 };
            //int[] arr1 = { 1, 7, 10, 5 };
            //int[] r=arr.SameValues(arr1);
            //foreach (int item in r)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Generic type
            //MyStringList strList = new MyStringList();
            //strList.Add("Balakishi");
            //strList.Add("Nigar");
            //strList.Add("Rufet");
            //strList.ShowList();

            //MyIntList intList = new MyIntList();
            //intList.Add(1);
            //intList.Add(2);
            //intList.Add(3);
            //intList.ShowList();

            //MyPersonList personList = new MyPersonList();
            //personList.Add(new Person("Aqil", "Beshirov"));
            //personList.Add(new Person("Ayshen", "Quliyeva"));
            //personList.Add(new Person("Zaur", "Necefli"));
            //personList.ShowList();

            //MyList<string> strList = new MyList<string>();
            //strList.Add("test");
            //strList.Add("test1");
            //strList.ShowList();
            //MyList<int> intList = new MyList<int>();
            //intList.Add(1);
            //intList.Add(2);
            //intList.Add(3);
            //intList.ShowList();
            //MyList<Person> myList = new MyList<Person>();
            //myList.Add(new Person("Nigar", "MemmedHesenzade"));
            //myList.Add(new Person("Reshad", "Xanmemmedli"));
            //ITest p1 = new Person("Kamran", "Haciyev");
            //myList.Add(p1);
            //myList.ShowList();
            //SecondList<Person, ITest> secondList = new SecondList<Person, ITest>();
            //SecondList<int, object> secondList1 = new SecondList<int, object>();

            #endregion

            #region Collections
            #region ArrayList - all types
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(10);
            //arrayList.Add("Turan");
            //arrayList.Add('c');
            //arrayList.Add(true);
            //arrayList.Add(new Person("Kamran", "Haciyev"));
            ////arrayList.Clear();
            //arrayList.RemoveAt(2);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(arrayList.Contains(true));

            #endregion

            #region List - custom generic type
            //List<string> strList = new List<string>(3);
            //Console.WriteLine(strList.Count);

            //strList.Add("Kamran");
            //strList[0] = "Aqil";
            //Console.WriteLine(strList[0]);
            //Console.WriteLine(strList.Find(s => s == "Aqil"));
            //List<int> intList = new List<int>();
            //intList.Add(20);
            //Console.WriteLine(strList.Contains("Imran"));
            //List<Person> people = new List<Person>();
            //people.Add(new Person());
            #endregion

            #region Dictionary - key,value
            //Dictionary<string, string> phones = new Dictionary<string, string>();
            //phones.Add("Kamran Jabiyev", "+994512373434");
            //phones.Add("Aqil", "+994558825377");
            //phones.Add("Nigar", "+994506530853");
            //phones.Remove("Nigar");
            //foreach (var item in phones)
            //{
            //    Console.WriteLine($"{item.Key}:{item.Value}");
            //}
            //Console.WriteLine(phones["Aqil"]);
            //phones["Huseyn"] = "+994505195417";
            //Console.WriteLine(phones["Huseyn"]);
            #endregion

            #region Queue - FIFO
            //Queue<Person> people = new Queue<Person>();
            //people.Enqueue(new Person("Nigar", "Kamran"));
            //people.Enqueue(new Person("Balakishi", "Qurbanov"));
            //people.Enqueue(new Person("Aqil", "Beshirov"));
            ////Console.WriteLine(people.Peek());
            //people.Dequeue();
            //people.Dequeue();
            //Console.WriteLine("Novbedekiler:");
            //foreach (Person item in people)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Stack - LIFO
            //Stack<Person> people = new Stack<Person>();
            //people.Push(new Person("Zaur", "Necefli"));
            //people.Push(new Person("Kamran", "Haciyev"));
            //people.Push(new Person("Nigar", "Memmedhesenzade"));
            ////Console.WriteLine(people.Peek());
            //Person p1=people.Pop();
            //Console.WriteLine("Novbedekiler:");
            //foreach (Person item in people)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region Struct - value
            //Person person;
            //person.Name = "Kamran";
            //MyStruct myStruct;
            //myStruct.c = 10;
            //Console.WriteLine(myStruct.c);
            //MyStruct myStruct1 = new MyStruct();
            #endregion
        }

        public static void Write<T>(T str) where T:class
        {
            Console.WriteLine(str);
        }
    }

    #region Struct - bosh ctor ola bilmez,ctor-da prop field set olunmalidir
    struct MyStruct
    {
        public int A { get; set; }
        public int B { get; set; }
        public int c;

        public MyStruct(int a,int b)
        {
            A = a;
            B = b;
            c = 12;
        }

        public void Sum()
        {
            Console.WriteLine(A+B);
        }

    }

    #endregion

    #region Generic type

    class Person : ITest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person()
        {

        }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }

    class SecondList<T,U> where T : U where U:class,ITest,new()
    {

    }
    class MyList<T> where T:class,ITest,new()
    {
        private T[] list;
        public MyList()
        {
            list = new T[0];
        }

        public void Add(T val)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = val;
        }

        public void ShowList()
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    interface ITest
    {

    }

    

    //class MyStringList
    //{
    //    private string[] list;

    //    public MyStringList()
    //    {
    //        list = new string[0];
    //    }

    //    public void Add(string val)
    //    {
    //        Array.Resize(ref list, list.Length + 1);
    //        list[list.Length - 1] = val;
    //    }

    //    public void ShowList()
    //    {
    //        foreach (string item in list)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //class MyIntList
    //{
    //    private int[] list;

    //    public MyIntList()
    //    {
    //        list = new int[0];
    //    }

    //    public void Add(int val)
    //    {
    //        Array.Resize(ref list, list.Length + 1);
    //        list[list.Length - 1] = val;
    //    }

    //    public void ShowList()
    //    {
    //        foreach (int item in list)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //class MyPersonList
    //{
    //    private Person[] list;

    //    public MyPersonList()
    //    {
    //        list = new Person[0];
    //    }

    //    public void Add(Person val)
    //    {
    //        Array.Resize(ref list, list.Length + 1);
    //        list[list.Length - 1] = val;
    //    }

    //    public void ShowList()
    //    {
    //        foreach (Person item in list)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
    #endregion
}
