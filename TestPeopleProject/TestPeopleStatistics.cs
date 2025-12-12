using PeopleProject;



public class TestPersonStatistics
{
    private List<Person> GetSamplePeople()
    {
        return new List<Person>
        {
            new Person(1, "Anna", 20, true, 85),
            new Person(2, "Béla", 25, false, 30),
            new Person(3, "Cecil", 19, true, 40),
            new Person(4, "Dénes", 30, false, 95),
            new Person(5, "Emma", 22, true, 60)
        };
    }

    [Test]
    public void TestAverageAge()
    {
        var stats = new PersonStatistics(GetSamplePeople());
        Assert.AreEqual(23.2, stats.GetAverageAge(), 0.1);
    }

    [Test]
    public void TestNumberOfStudents()
    {
        var stats = new PersonStatistics(GetSamplePeople());
        Assert.AreEqual(3, stats.GetNumberOfStudents());
    }

    [Test]
    public void TestHighestScore()
    {
        var stats = new PersonStatistics(GetSamplePeople());
        Assert.AreEqual("Dénes", stats.GetPersonWithHighestScore().Name);
    }

    [Test]
    public void TestAverageScoreOfStudents()
    {
        var stats = new PersonStatistics(GetSamplePeople());
        Assert.AreEqual(61.67, stats.GetAverageScoreOfStudents(), 0.2);
    }

    [Test]
    public void TestOldestStudent()
    {
        var stats = new PersonStatistics(GetSamplePeople());
        Assert.AreEqual("Emma", stats.GetOldestStudent().Name);
    }

    [Test]
    public void TestIsAnyoneFailing()
    {
        var stats = new PersonStatistics(GetSamplePeople());
        Assert.IsTrue(stats.IsAnyoneFailing());
    }

    [Test]
    public void TestSetterReplacesList()
    {
        var stats = new PersonStatistics(new List<Person>());
        stats.People = new List<Person>
        {
            new Person(1, "Zoli", 50, false, 10)
        };

        Assert.IsTrue(stats.IsAnyoneFailing());
        Assert.AreEqual(50, stats.GetAverageAge());
    }
}
