using System;
using System.Collections.Generic;

public class Resumes
{
    public string _name;
    public List<Job> _jobs = new List<Job>(); // Change List<string> to List<Job>

    public string Display()
    {
        string result = $"Name: {_name}\nJobs:\n";

        // Loop through each job in the list and display details
        foreach (Job job in _jobs)
        {
            result += $"- {job.Display()}\n";
        }

        return result;
    }
}