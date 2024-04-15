using pencil_durability_kata;

namespace pencil_durability_kata_tests
{
    public class PaperTests
    {
        [Test]
        public void Read()
        {
            var paper = new Paper();
            Assert.IsNotNull(paper.Text);
            Assert.That(paper.Read(), Is.EqualTo(string.Empty));
        }
    }
}
