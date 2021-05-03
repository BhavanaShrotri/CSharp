using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesAndEvents
{
    public delegate int BizRulesDelegate(int x, int y);
    public class Program
    {
        static void Main(string[] args)
        {

            var custs = new List<Customer> 
            {
                 new Customer {ID =01, City ="Pune", FirstName ="Bhavana", LastName = "Shrotri"},
                 new Customer { ID = 02, City = "Satara", FirstName = "Rachana", LastName = "Shrotri" },
                 new Customer { ID = 03, City = "Kolhapur", FirstName = "Sagar", LastName = "Shinde" },
                 new Customer { ID = 04, City = "Pune", FirstName = "Anjali", LastName = "Naik" },
                 new Customer { ID = 05, City = "Nashik", FirstName = "Priyanka", LastName = "Desai" }
            };

            var PunCust = custs
                .Where(c => c.City == "Pune")
                .OrderBy(c => c.FirstName);

            foreach (var cust in PunCust)
            {
                Console.WriteLine(cust.FirstName);
            }

            //WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            //WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            //WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);


            //del1 += del2;
            //del1 += del3;
            //del1(10, WorkType.Golf);

            //del1 += del2 + del3;
            //int FinalHours=del1(30, WorkType.GenerateReports);

            //Console.WriteLine("Final Hours : " + FinalHours);




            //del1(5, WorkType.GenerateReports);
            //del2(4, WorkType.Golf);

            // DoWork(del1);

            //Anonymous Method 
            //worker.workPerformed += delegate (object sender, WorkPerformedEventArgs e)
            //{
            //    Console.WriteLine("Hours Worked : " + e.Hours + " " + e.WorkType);
            //};


            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate mulDel = (x, y) => x * y;
            var data = new ProcessData();
            data.Process(2, 3, addDel);

            Action<int, int> myAction = (x, y) =>Console.WriteLine( x + y );
            Action<int, int> myMulAction = (x, y) => Console.WriteLine(x * y);

            data.ProcessAction(5, 5, myMulAction);


            Func<int, int, int> funcAddDel = (x, y) => x + y;
            Func<int, int, int> funcMulDel = (x, y) => x * y;
            data.ProcessFunc(10, 5, funcMulDel);

            var worker = new Worker();

            worker.workPerformed += (s,e) =>
            {
                Console.WriteLine("Hours Worked : " + e.Hours + " " + e.WorkType);
                Console.WriteLine("Done");
            } ;
            worker.workCompleted += (s,e)=> Console.WriteLine("Work Completed....."); ;
           
           //worker.workCompleted -= Work_WorkCompleted;
            worker.DoWork(8,WorkType.GenerateReports);



            Console.Read();
    
        }

        //private static void Worker_workPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine("Hours Worked : " + e.Hours + " " + e.WorkType);
        //}

        //static void Work_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Work Completed.....");
        //}

        //static void DoWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.GoToMeetings);
        //}

        //static int WorkPerformed1(int hours,WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed1 called "+ hours.ToString());
        //    return hours + 1;
        //}

        //static int WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed2 called "+ hours.ToString());
        //    return hours + 2;
        //}
        //static int WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed3 called " + hours.ToString());
        //    return hours + 3;
        //}
    }

    public enum WorkType
    { 
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
