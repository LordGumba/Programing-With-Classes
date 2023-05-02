using System;

class Program
{
    
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Clown";
        job1._company = "McDonalds";
        job1._startYear = 2016;
        job1._endYear = 2102;

        Job job2 = new Job();
        job2._jobTitle = "Hamburgular";
        job2._company = "McJerusalem";
        job2._startYear = 0022;
        job2._endYear = 1623;

        Resume myResume = new Resume();
        myResume._name = "Percy Jackson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}