using System;

class Program
{
    static void Main(string[] args)
    {
        public class Job;

        Job job1 = new Job();
        job1._jobTitle = "";
        job1._company = "";
        job1._startYear = ;
        job1._endYear = ;

/*
        Job job2 = new Job();
        job2._jobTitle = "Data Scientest";
        job2._company = "Tesla";
        job2._startYear = 2022;
        job2._endYear = 2023;
*/
        Resume myResume = new Resume();
        myResume._name = "Sam Anderson";

        myResume._jobs.Add(job1);
        //myResume._jobs.Add(job2);

        myResume.Display();
    }
}