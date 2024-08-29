using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp9
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }  

        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
    }

    
    public class Students : IEnumerable<Student>, IEnumerator<Student>
    {
        private List<Student> _students = new List<Student>();
        private int position = -1;

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public bool MoveNext()
        {
            while (++position < _students.Count)
            {
                if (_students[position].Grade > 90) 
                {
                    return true;
                }
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public Student Current
        {
            get
            {
                return _students[position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose() { }


        public IEnumerator<Student> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
