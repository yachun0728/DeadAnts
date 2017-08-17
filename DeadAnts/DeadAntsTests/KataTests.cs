using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeadAnts.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void Input_4_ant_no_one_dead()
        {
            Assert.AreEqual(0, Kata.DeadAntCount("ant ant ant ant"));
        }
        
        [TestMethod]
        public void Input_null_no_one_dead()
        {
            Assert.AreEqual(0, Kata.DeadAntCount(null));
        }
        
        [TestMethod]
        public void Input_2_dead_ants_can_get_2_dead_ants()
        {
            Assert.AreEqual(2, Kata.DeadAntCount("ant anantt aantnt"));
        }

        [TestMethod]
        public void Input_1_dead_ants_can_get_1_dead_ants()
        {
            Assert.AreEqual(1, Kata.DeadAntCount("ant ant .... a nt"));
        }

        [TestMethod]
        public void Input_10_dead_ant_can_get_10_dead_ants()
        {
            Assert.AreEqual(10, Kata.DeadAntCount("nt.aaaa..atn...t..an.tana.t..nt..tnttant.annna.n...t."));
        }
        [TestMethod]
        public void Input_11_dead_ant_can_get_11_dead_ants()
        {
            Assert.AreEqual(11, Kata.DeadAntCount("tnn...tnt...nat.t..tn.na.at.naaanat.aaa..atn..ntt.n.."));
        }
    }
}
