using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaesarCipher_DG;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher_DG.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CaesarCipherTest()
        {
            string test1 = "random";
            string test2 = "random1";
            string test3 = "randomWords";
            string test4 = "Caesar";
            string test5 = "Cipher";

            string test1En = Program.CaesarCipher(test1, 3);
            string test2En = Program.CaesarCipher(test2, 4);
            string test3En = Program.CaesarCipher(test3, 5);
            string test4En = Program.CaesarCipher(test4, 6);
            string test5En = Program.CaesarCipher(test5, 7);

            Assert.AreEqual(test1En, "udqgrp");
            Assert.AreEqual(test2En, "verhsq1");
            Assert.AreEqual(test3En, "wfsitrBtwix");
            Assert.AreEqual(test4En, "Igkygx");
            Assert.AreEqual(test5En, "Jpwoly");

            string test1De = Program.CaesarCipher(test1En, -3);
            string test2De = Program.CaesarCipher(test2En, -4);
            string test3De = Program.CaesarCipher(test3En, -5);
            string test4De = Program.CaesarCipher(test4En, -6);
            string test5De = Program.CaesarCipher(test5En, -7);

            Assert.AreEqual(test1De, test1);
            Assert.AreEqual(test2De, test2);
            Assert.AreEqual(test3De, test3);
            Assert.AreEqual(test4De, test4);
            Assert.AreEqual(test5De, test5);
        }
    }
}