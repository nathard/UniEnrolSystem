using System;

namespace UniEnrolSystem
{
    public class Unit
    {
        // Attributes
        private string _Code, _Name;
        // Properties
        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        // Custom Constructor
        public Unit(string code, string name)
        {
            _Code = code;
            _Name = name;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}", _Code, _Name);
        }
    }
    public class Result
    {
        // Attributes
        private int _Mark;
        // Properties
        public int Mark
        {
            get { return _Mark; }
            set { _Mark = value; }
        }
        public string Grade
        {
            get
            {
                string temp = "";
                if (_Mark < 50) temp = "N";
                else if (_Mark < 60) temp = "P";
                else if (_Mark < 70) temp = "C";
                else if (_Mark < 80) temp = "D";
                else temp = "HD";
                return temp;
            }
        }
        // Custom Constructor
        public Result(int mark)
        {
            _Mark = mark;
        }

        public override string ToString()
        {
            return string.Format("{0,11} {1}", _Mark, Grade);
        }
    }
    public class Enrolment
    {
        // Attributes
        private Unit _Unit;
        private Result _Result;
        // Properties
        public Unit Unit
        {
            get { return _Unit; }
        }
        public Result Result
        {
            get { return _Result; }
            set { _Result = value; }
        }
        // Custom Constructor
        public Enrolment(Unit unit, Result result)
        {
            _Unit = unit;
            _Result = result;
        }
        public override string ToString()
        {
            return string.Format("{0,-14} : {1}", _Result, _Unit);
        }
    }
    public class Student
    {
        // Attributes
        private string _ID, _FamilyName, _GivenNames;
        private Enrolment[] _EnrolledUnits;
        private int _EnrolledMax;
        const int MAX_UNITS = 4;

        // Properties
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string FamilyName
        {
            get { return _FamilyName; }
            set { _FamilyName = value; }
        }
        public string GivenName
        {
            get { return _GivenNames; }
            set { _GivenNames = value; }
        }
        // Custom Constructor
        public Student(string id, string familyname, string givenname)
        {
            _ID = id;
            _FamilyName = familyname;
            _GivenNames = givenname;
            _EnrolledMax = -1;
            _EnrolledUnits = new Enrolment[MAX_UNITS];
        }
        public override string ToString()
        {
            return string.Format("ID {0}: {1}, {2}", _ID, _FamilyName, _GivenNames);
        }

        // Arrays, Methods and Indexers
        public void Enrol(Unit unit)
        {
            if (_EnrolledMax < _EnrolledUnits.Length)
            {
                _EnrolledUnits[_EnrolledMax + 1] = new Enrolment(unit, null);
                _EnrolledMax++;
            }
        }

        public Enrolment this[string code]
        {
            get
            {
                Enrolment temp = null;
                for (int i = 0; i < MAX_UNITS; i++)
                    if (_EnrolledUnits[i] != null && _EnrolledUnits[i].Unit.Code == code)
                    {
                        temp = _EnrolledUnits[i];
                        break;
                    }
                return temp;
            }
        }

        // Output
        static void Main(string[] args)
        {

            Unit u1 = new Unit("SIT103", "Introduction to Database Design");
            Unit u2 = new Unit("SIT104", "Introduction to Web Development");
            Unit u3 = new Unit("SIT131", "Object-Oriented Development");
            Unit u4 = new Unit("SIT152", "Game Design");

            Student demoStudent = new Student("210123456", "Smith", "J.");

            demoStudent.Enrol(u1);
            demoStudent.Enrol(u2);
            demoStudent.Enrol(u3);
            demoStudent.Enrol(u4);

            demoStudent["SIT131"].Result = new Result(80); demoStudent["SIT152"].Result = new Result(79);

            Console.WriteLine(demoStudent); Console.WriteLine(demoStudent["SIT103"]); Console.WriteLine(demoStudent["SIT104"]); Console.WriteLine(demoStudent["SIT131"]); Console.WriteLine(demoStudent["SIT152"]);
        }

    }
}

