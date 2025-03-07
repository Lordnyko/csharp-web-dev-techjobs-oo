﻿using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation,
            PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return $@"\nID: {Id}\nName: {ValueChecker(Name)}\nEmployer: {ValueChecker(EmployerName.Value)}\nLocation: {ValueChecker(EmployerLocation.Value)}\nPosition Type: {ValueChecker(JobType.Value)}\nCore Competency: {ValueChecker(JobCoreCompetency.Value)}\n";

        }

        private string ValueChecker(string item)
        {
            if (item == "")
            {
                return "Data not available";
            }
            else
            {
                return item;
            }
        }

    }
}
