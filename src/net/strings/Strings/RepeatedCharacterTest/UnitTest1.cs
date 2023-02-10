
namespace RepeatedCharacterTest
{
    public class Tests
    {
        private RepeatedCharacters repeatedCharacters = new RepeatedCharacters();

        [Test]
    public void isValidSimple()
        {
            string input = "a3o1oa3";
            Assert.True(repeatedCharacters.isValid(input));
            Assert.True(repeatedCharacters.isValid("aa3311oo"));
        }

        [Test]
    public void isValidWithSpaces()
        {
            string input = " ellemmeennttaall  mmaattssssnn";
            Assert.True(repeatedCharacters.isValid(input));
            Assert.False(repeatedCharacters.isValid(" eelleemmeennttaall  mmii  qquueerriiddoo  wwaattssoonn"));
        }

        [Test]
    public void isValidWithExtraChar()
        {
            string input = "aabbccc";
            Assert.True(repeatedCharacters.isValid(input));
            Assert.False(repeatedCharacters.isValid("aaabbc"));
        }
    }
}