using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ExtensionTests
    {

        [TestMethod]
        public void Acronyms()
        {
            var text = "GPS";
            Assert.AreEqual(text, text.ToTitleCase());

            text = "love ASP .net";
            Assert.AreEqual("Love ASP .Net", text.ToTitleCase());
        }

        [TestMethod]
        public void Mixed_Cases()
        {
            var text = "PeaCe aNd WaR";
            Assert.AreEqual("Peace And War", text.ToTitleCase());
        }

        [TestMethod]
        public void Single_Letters()
        {
            var text = "a b c";
            Assert.AreEqual("A B C", text.ToTitleCase());
        }

        [TestMethod]
        public void Alternate_Cases()
        {
            var text = "Mr. McGregor";
            Assert.AreEqual("Mr. Mcgregor", text.ToTitleCase());
        }

        [TestMethod]
        public void Spaces()
        {
            var text = " spaced out";
            Assert.AreEqual(" Spaced Out", text.ToTitleCase());
        }

        [TestMethod]
        public void Non_Characters()
        {
            var text = "a.b,c/d[e]f_g{h}i=j!k@l`m~n#o$p%q^r&s(t)u|v?w*x<y>z:a;b";
            Assert.AreEqual("A.B,C/D[E]F_G{H}I=J!K@L`M~N#O$P%Q^R&S(T)U|V?W*X<Y>Z:A;B", text.ToTitleCase());
        }

        [TestMethod]
        public void Starts_With_Number()
        {
            var text = "7up";
            Assert.AreEqual("7Up", text.ToTitleCase());
        }

        [TestMethod]
        public void Starts_With_Multiple_Numbers()
        {
            var text = "36chambers";
            Assert.AreEqual("36Chambers", text.ToTitleCase());
        }

        [TestMethod]
        public void Contains_A_Number()
        {
            var text = "sk8r";
            Assert.AreEqual("Sk8r", text.ToTitleCase());
        }

        [TestMethod]
        public void Starts_With_Non_Character()
        {
            var text = "#pound";
            Assert.AreEqual("#Pound", text.ToTitleCase());
        }

        [TestMethod]
        public void Starts_With_Non_Character_Multiple()
        {
            var text = "##pound";
            Assert.AreEqual("##Pound", text.ToTitleCase());
        }

        [TestMethod]
        public void Starts_With_Non_Characters_Acronym()
        {
            var text = "#YOLO";
            Assert.AreEqual(text, text.ToTitleCase());
        }

        [TestMethod]
        public void Contains_A_Number_Followed_By_Non_Character()
        {
            var text = "sk8_r";
            Assert.AreEqual("Sk8_R", text.ToTitleCase());
        }

        [TestMethod]
        public void Contains_A_Non_Character_Followed_By_Number()
        {
            var text = "sk_8r";
            Assert.AreEqual("Sk_8R", text.ToTitleCase());
        }
    }

}
