// Written by Kelvin Maher
// 1/27/25


using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace QuizCalculatorEdabit
{
    public class QuizCalculatorClass
    {

        // private double total = -1.00;
        // private double average = -1.00;
        // private string letterGrade = "n/a";

        

        // Gets and sets

        // Beware of "magic numbers"
        public double Quiz1
        { 
            get { return this.quiz1; }
            set
            {
                if (value > 100 || value < 0)
                {
                    this.quiz1 = -1.00;
                }
                else
                {
                    this.quiz1 = value;
                }
            }
        }

        public double Quiz2
        {
            get { return this.quiz2; }
            set
            {
                if (value > 100 || value < 0)
                {
                    this.quiz2 = -1.00;
                }
                else
                {
                    this.quiz2 = value;
                }
            }
        }

        public double Quiz3
        {
            get { return this.quiz3; }
            set
            {
                if (value > 100 || value < 0)
                {
                    this.quiz3 = -1.00;
                }
                else
                {
                    this.quiz3 = value;
                }
            }
        }

        public double Quiz4
        {
            get { return this.quiz4; }
            set
            {
                if (value > 100.00 || value < 0.00)
                {
                    this.quiz4 = -1.00;
                }
                else
                {
                    this.quiz4 = value;
                }
            }
        }

        // methods

        public double CalcTotal()
        {
            double aTotal = 0.00;
            foreach
            return aTotal;
        }

        public double CalcAverage()
        {
            double aAverage = 0.00;
            aAverage = CalcTotal() / listOfQuizzes.count;
            return aAverage;
        }

        public string CalcLetterGrade()
        {
            double aAverage = 0.00;
            string aLetterGrade = "Z";
            aAverage = CalcAverage();
            if (aAverage >= 0.00 && aAverage < 60.00)
            {
                aLetterGrade = "F";
            }
            if (aAverage >= 60.00 && aAverage < 70.00)
            {
                aLetterGrade = "D";
            }
            if (aAverage >= 70.00 && aAverage < 80.00)
            {
                aLetterGrade = "C";
            }
            if (aAverage >= 80.00 && aAverage < 90.00)
            {
                aLetterGrade = "B";
            }
            if (aAverage >= 90.00 && aAverage <= 100.00)
            {
                aLetterGrade = "A";
            }
            return aLetterGrade;
        }

        public override string ToString()
        {
            string message = message;
            message += 

        }
    }
}
