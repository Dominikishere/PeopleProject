// PersonStatistics.cs
using PeopleProject;
using System;
using System.Collections.Generic;

public class PersonStatistics
{
    public List<Person> People { private get; set; }

    public PersonStatistics(List<Person> people)
    {
        if (people == null)
            throw new ArgumentNullException(nameof(people));

        People = people;
    }

    public double GetAverageAge()
    {
        if (People == null || People.Count == 0) return 0;

        double sum = 0;
        int count = 0;
        foreach (var person in People)
        {
            sum += person.Age;
            count++;
        }

        if (count == 0) return 0;
        return sum / count;
    }

    public int GetNumberOfStudents()
    {
        if (People == null) return 0;

        int count = 0;
        foreach (var person in People)
        {
            if (person.IsStudent) count++;
        }
        return count;
    }

    public Person GetPersonWithHighestScore()
    {
        if (People == null || People.Count == 0) return null;

        Person best = null;
        foreach (var person in People)
        {
            if (best == null || person.Score > best.Score)
                best = person;
        }
        return best;
    }

    public double GetAverageScoreOfStudents()
    {
        if (People == null) return 0;

        double sum = 0;
        int count = 0;
        foreach (var person in People)
        {
            if (person.IsStudent)
            {
                sum += person.Score;
                count++;
            }
        }
        if (count == 0) return 0;
        return sum / count;
    }

    public Person GetOldestStudent()
    {
        if (People == null) return null;

        Person oldest = null;
        foreach (var person in People)
        {
            if (person.IsStudent)
            {
                if (oldest == null || person.Age > oldest.Age)
                    oldest = person;
            }
        }
        return oldest;
    }

    public bool IsAnyoneFailing()
    {
        if (People == null) return false;

        foreach (var person in People)
        {
            if (person.Score < 40) return true;
        }
        return false;
    }
}
