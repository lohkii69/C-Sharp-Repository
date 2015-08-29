﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behive_System_Chapter_6
{
    class Queen
    {
        // An array of worker bee's to keep track of
        private Worker[] workers;
        private int shiftNumber = 0;    // number of shifts assigned to the bee

        /// <summary>
        /// Constructor taking in an array of worker bee objects
        /// </summary>
        /// <param name="workers"></param>
        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        /// <summary>
        /// Return true if a worker is found to assign a job to, or false
        /// if a worker isn't found.
        /// </summary>
        /// <param name="jobToBePerformed"></param>
        /// <param name="numOfShifts"></param>
        /// <returns></returns>
        public bool AssignWork(string jobToBePerformed, int numOfShifts)
        {
            for (int index = 0; index < workers.Length; index++)
            {
                if (workers[index].DoThisJob(jobToBePerformed, numOfShifts))
                {
                    return true;
                }
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            string report = "Report for shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                {
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                }
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                }
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                    {
                        report += "Worker #" + (i + 1) + " is doing '" + workers[i].CurrentJob + "' for " + workers[i].ShiftsLeft + " more shifts\r\n";
                    }
                    else
                    {
                        report += "Worker #" + (i + 1) + " will be done with '" + workers[i].CurrentJob + "' after this shift\r\n";
                    }
                }
            }
            return report;
        }
    }
}
