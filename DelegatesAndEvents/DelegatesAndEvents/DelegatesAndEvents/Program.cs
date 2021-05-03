using System;

namespace DelegatesAndEvents
{
    class Program
    {
        
        static void Main(string[] args)
        {
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

            var worker = new Worker();
            worker.workPerformed += delegate (object sender, WorkPerformedEventArgs e)
            {
                Console.WriteLine("Hours Worked : " + e.Hours + " " + e.WorkType);
            };
            worker.workCompleted += Work_WorkCompleted;
           
           //worker.workCompleted -= Work_WorkCompleted;
            worker.DoWork(8,WorkType.GenerateReports);



            Console.Read();
    
        }

        //private static void Worker_workPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine("Hours Worked : " + e.Hours + " " + e.WorkType);
        //}

        static void Work_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work Completed.....");
        }

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
