using Xunit;

namespace Task_1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Sport newSport = new Football();
            newSport.ChangeRules("qer");
            Assert.Equal("Football\nRules: qer\nCount Of Players: 11", newSport.Print());
            Assert.Equal("qer", newSport.getRules());

            Football football = (Football)newSport;
            football.setResults("0:0");
            Assert.Equal("Play football", football.Play());
            football.ChangeRules();
            Assert.Equal("", football.getRules());
            

            Backetball backetball = new Backetball();
            Assert.Equal("Play some game", backetball.Play());
            backetball.ChangeRules("vfy");
            Assert.Equal("Backetball\nRules: vfy\nCount Of Players: 5", backetball.Print());
            Assert.Equal("vfy", backetball.getRules());
        }
    }
}