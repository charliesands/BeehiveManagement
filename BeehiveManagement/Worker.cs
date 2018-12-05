using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeehiveManagement
{
    class Worker
    {
        private string[] jobsICanDo;
        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }

        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        private int shiftsToWork;
        private int shiftsWorked;

    }
}
