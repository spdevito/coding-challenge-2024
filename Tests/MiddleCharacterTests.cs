using Challenge;

namespace Tests;

public class MiddleCharacterTests
{
    [TestCase("test", ExpectedResult = "es")]
    [TestCase("testing", ExpectedResult = "t")]
    [TestCase("middle", ExpectedResult = "dd")]
    [TestCase("character", ExpectedResult = "a")]
    [TestCase("A", ExpectedResult = "A")]
    [TestCase("Banana", ExpectedResult = "na")]
    [TestCase("Bananas", ExpectedResult = "a")]
    [TestCase("Banan", ExpectedResult = "n")]
    [TestCase("Malcolm", ExpectedResult = "c")]
    [TestCase("AxionBioSystems", ExpectedResult = "o")]
    [Test]
    public string Should_Return_Middle_Character(string input)
    {
        var mc = new MiddleCharacter();
        return mc.GetMiddle(input);
    }
}
