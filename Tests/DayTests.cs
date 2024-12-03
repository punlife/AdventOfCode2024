using AdventOfCode2024;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Day1()
    {
        Assert.Multiple(() =>
        {
            Assert.That(new Day1().RunTask1(File.ReadAllLines(@"Data\Day1Test.txt")), Is.EqualTo(11));
            Assert.That(new Day1().RunTask2(File.ReadAllLines(@"Data\Day1Test.txt")), Is.EqualTo(31));
        });
    }
    
    [Test]
    public void Day2()
    {
        Assert.Multiple(() =>
        {
            Assert.That(new Day2().RunTask1(File.ReadAllLines(@"Data\Day2Test.txt")), Is.EqualTo(2));
            Assert.That(new Day2().RunTask2(File.ReadAllLines(@"Data\Day2Test.txt")), Is.EqualTo(14));
        });
    }
    
    [Test]
    public void Day3()
    {
        Assert.Multiple(() =>
        {
            Assert.That(new Day3().RunTask1(File.ReadAllLines(@"Data\Day3Test.txt")), Is.EqualTo(161));
            Assert.That(new Day3().RunTask2(File.ReadAllLines(@"Data\Day3Test2.txt")), Is.EqualTo(168));
        });
    }
}