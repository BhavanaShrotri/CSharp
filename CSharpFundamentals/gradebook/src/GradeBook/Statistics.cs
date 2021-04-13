using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Avg
        {
            get
            {
                return sum/Count;
            }
        }
        
        public double High;
        public double Low;
         public double sum;
        public int Count;
        public char Letter
        {
            get
            {

             switch(Avg)
              {
                 case var d when d>=90.0:
                   return 'A';
                
                case var d when d>=80.0:
                     return'B';

                case var d when d>=70.0:
                     return'C';
                       
                case var d when d>=60.0:
                     return'D';
                   
                default:
                     return 'F';
                 
              }

            }
        }
       

        public void Add(double number)
        {
             sum+=number;
             Count+=1;
             High=Math.Max(number,High);
             Low=Math.Min(number,Low);
        }

        public Statistics()
        {

            sum=0.0;
            Count =0;
            High=double.MinValue;
            Low=double.MaxValue;
        }
    }
}