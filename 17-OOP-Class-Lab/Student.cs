using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_Class_Lab
{
    public class Student
    {
		//Filed - dışarıdan doğrudan erişilemez (encapsulation)
		private int _id;
        private string _firstName;
		private string _lastName;
		private ICollection<int> _examScores;

        //Constructor
        public Student(int id, string firstName, string lastName)
        {
            Id = id;
			FirstName = firstName;
			LastName = lastName;
			_examScores = new List<int>();
        }

        //Only Read
        public int Id
		{
			get { return _id; }
			private set { _id = value; }
		}
		public string FirstName
		{
			get { return _firstName; }
			private set { _firstName = value; }
		}
        public string LastName 
		{
			get { return _lastName; }
			private set { _lastName = value; }
		}

        public string FullName => _firstName + " " + _lastName;

		//Read-Write
        public string Department { get; set; } = String.Empty;

		public double AverageScore => _examScores.Count == 0 ? 0 : _examScores.Average();

        public void AddExamScore(int score)
		{
			if (score < 0 || score > 100)
				throw new ArgumentException("Not 0 ile 100 arasında olmalıdır!");

			_examScores.Add(score);
		}

		public IReadOnlyList<int> GetExamScores()
		{
			return _examScores.ToList().AsReadOnly();
		}

		public string DisplayInfo()
		{
			return $"Id: {Id} | Ad: {FullName} Bölüm: {Department}\nNot Ortalaması: {AverageScore:F2}\nNotlar: {string.Join(", ", _examScores)}";
		}
    }
}
