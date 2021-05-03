using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    //public delegate int WorkPerformedHandler(object sender,WorkPerformedEventArgs);
    public class Worker
    {
        //direct event defination 
        public event EventHandler<WorkPerformedEventArgs> workPerformed;
        public event EventHandler workCompleted;

        public void DoWork(int hours,WorkType workType)
        {
           for (int i=0; i< hours; i++)
            {
                System.Threading.Thread.Sleep(1000);
                OnWorkPerformed(i + 1, workType);

            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            //if(workPerformed != null)
            //{
            //    workPerformed(hours, WorkType);
            //}

            var del = workPerformed as EventHandler<WorkPerformedEventArgs>;

            if(del != null)
            {
                del(this,new WorkPerformedEventArgs(hours,workType));
            }
        }

        protected virtual void OnWorkCompleted()
        {
            //if(workCompleted != null)
            //{
            //    workCompleted(this,EventArgs.Empty);
            //}

            var del = workCompleted as EventHandler;

            if (del != null)
            {
                del(this,EventArgs.Empty);
            }
        }
    }
}
