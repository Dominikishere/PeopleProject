using PeopleProject;

[TestFixture]
public class TestPersonStatistics
{
    private List<Person> peopleList1;
    private List<Person> peopleList2;

    [SetUp]
    public void Setup()
    {
        peopleList1 = new List<Person>
        {
            new Person(1, "Anna", 20, true, 80),
            new Person(2, "Bela", 30, false, 50)
        };

        peopleList2 = new List<Person>
        {
            new Person(3, "Cecil", 40, true, 90),
            new Person(4, "Dani", 60, true, 30)
        };
    }

    [Test]
    public void GetAverageAge_TwoDifferentLists()
    {
        var stats = new PersonStatistics(peopleList1);
        Assert.That(stats.GetAverageAge(), Is.EqualTo(25));

        stats.People = peopleList2;
        Assert.That(stats.GetAverageAge(), Is.EqualTo(50));
    }

    [Test]
    public void GetNumberOfStudents_TwoDifferentLists()
    {
        var stats = new PersonStatistics(peopleList1);
        Assert.That(stats.GetNumberOfStudents(), Is.EqualTo(1));

        stats.People = peopleList2;
        Assert.That(stats.GetNumberOfStudents(), Is.EqualTo(2));
    }

    [Test]
    public void GetPersonWithHighestScore_TwoDifferentLists()
    {
        var stats = new PersonStatistics(peopleList1);
        Assert.That(stats.GetPersonWithHighestScore().Name, Is.EqualTo("Anna"));

        stats.People = peopleList2;
        Assert.That(stats.GetPersonWithHighestScore().Name, Is.EqualTo("Cecil"));
    }

    [Test]
    public void GetAverageScoreOfStudents_TwoDifferentLists()
    {
        var stats = new PersonStatistics(peopleList1);
        Assert.That(stats.GetAverageScoreOfStudents(), Is.EqualTo(80));

        stats.People = peopleList2;
        Assert.That(stats.GetAverageScoreOfStudents(), Is.EqualTo(60));
    }

    [Test]
    public void GetOldestStudent_TwoDifferentLists()
    {
        var stats = new PersonStatistics(peopleList1);
        Assert.That(stats.GetOldestStudent().Name, Is.EqualTo("Anna"));

        stats.People = peopleList2;
        Assert.That(stats.GetOldestStudent().Name, Is.EqualTo("Dani"));
    }

    [Test]
    public void IsAnyoneFailing_TwoDifferentLists()
    {
        var stats = new PersonStatistics(peopleList1);
        Assert.That(stats.IsAnyoneFailing(), Is.False);

        stats.People = peopleList2;
        Assert.That(stats.IsAnyoneFailing(), Is.True);
    }
}
