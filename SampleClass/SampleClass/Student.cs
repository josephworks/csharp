using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClass
{
    class Student
    {
        int m_id;
        int m_grade;
        string m_fname;
        string m_lname;
        int m_score1;
        int m_score2;
        int m_score3;

        public Student(int id, int grade, string fname, string lname)
        {
            m_id = id;
            m_grade = grade;
            m_fname = fname;
            m_lname = lname;
        }

        public int getID() { return m_id; }
        public int getGrade() { return m_grade; }
        public string getFirstName() { return m_fname; }
        public string getLastName() { return m_lname; }

        public override string ToString()
        {
            return string.Format("{0}, {1}-{2:N2}", m_lname, m_fname, avgScore());
        }
        public void setScore1(int score1) { m_score1 = score1; }
        public void setScore2(int score2) { m_score2 = score2; }
        public void setScore3(int score3) { m_score3 = score3; }
        public double avgScore()
        {
            return (m_score1 + m_score2 + m_score3) / 3.0;
        }
    }
}
