using System;
using System.Collections.Generic;

//Class: Job Responsibilities:
//Keeps track of the company, job title, start year, and end year.

//Behaviors:
//Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".

//Class: Resume

//Responsibilities:
//Keeps track of the person's name and a list of their jobs.

//Behaviors:
//Displays the resume, which shows the name first, followed by displaying each one of the jobs.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Apple Developer";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Carl Lee"; 
        resume1._job.Add(job1);
        resume1._job.Add(job2);
        resume1.Display();
        

        
    }

    public class Resume{
        
        public string _name;
        public List<Job>_job = new List<Job>();

        public void Display(){

             Console.WriteLine($"Name:{_name}");
             Console.WriteLine($"Jobs:");
             Console.WriteLine($"{_job[0]._jobTitle} ({_job[0]._company}) {_job[0]._startYear}-{_job[0]._endYear}");
             Console.WriteLine($"{_job[1]._jobTitle} ({_job[1]._company}) {_job[1]._startYear}-{_job[1]._endYear}");
        }
    }

    public class Job{
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear; 

    
        public void Display() {

            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear} ");
        }
    }


    
}