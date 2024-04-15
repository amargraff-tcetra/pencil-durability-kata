using pencil_durability_kata;

namespace pencil_durability_kata_tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var example = new Class1();
        Assert.AreEqual("Hello World", example.getGreeting());
    }    
}