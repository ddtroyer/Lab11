using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student : Person
    {
        public Student(string name, string address, string program, int year, double fee): base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        private string program;

        public string getProgram()
        {
            return program;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        
        private int year;

        public int getYear()
        {
            return year;
        }
        public void setYear(int year)
        {
            this.year = year;
        }

        private double fee;

        public double getFee()
        {
            return fee;
        }
        public void setfee(double fee)
        {
            this.fee = fee;
        }

        public override string ToString()
        {
            return $"Student[{base.ToString()} program = {program}, year = {year}, fee = {fee}]";
        }
    }
}

