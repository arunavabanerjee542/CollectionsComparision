using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsComparision
{
    // sorting using Icomparable  --> similar to Comparable in java

    // sorting using IComparer  --> similar to comparator in java

    // sorting using a delegate ( Comparision)

    // sorting using lambda 




    


    class Program
    {
        static public int mysort(Student a, Student b)
        {
            if (a.marks < b.marks)
            {
                return -1;
            }
            else if (a.marks> b.marks)
            {
                return 1;
            }
            return 0;
        }




        static void Main(string[] args)
        {

            List<Student> l = new List<Student>()
            {
                new Student(){ city="kolkata" , id =12, marks=133 , name="aAM"  },
                new Student(){ city="asansol" , id =1, marks=33 , name="SHYAM"  },
                new Student(){ city="hyd" , id =21, marks=7133 , name="RAGHU"  },
                 new Student(){ city="Ayd" , id =1000, marks=733 , name="AGHU"  },
                  new Student(){ city="byd" , id =210, marks=833 , name="bbAGHU"  }
            };

            SortName sn = new SortName();

          //  Comparison<Student> c = new Comparison<Student>(mysort);       // creating an instance to Comparision delegate

            l.Sort((a,b) =>  b.marks - a.marks);

            foreach(Student s in l)
            {
                Console.WriteLine(s.id + " " + s.name + " " + s.marks + " " + s.city);
            }





        }
    }

    class  Student
    {
        public string name { get; set; }
        public int id { get; set; }
        public string city { get; set; }
        public int marks { get; set; }

        public int CompareTo(Student other)
        {
           if(this.id<other.id)
            {
                return -1;
            }
           else if (this.id > other.id)
            {
                return 1;
            }
            return 0;
        }
    }




    class SortName : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.name.CompareTo(y.name);
        }
    }

}
