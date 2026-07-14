using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer Intern";
        job1._company = "Grupo Tress";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Supervisor";
        job2._company = "THALES";
        job2._startYear = 2023;
        job2._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = " Israel Martinez";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}