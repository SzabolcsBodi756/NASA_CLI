using Microsoft.VisualStudio.TestTools.UnitTesting;
using NASACLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASACLI.Tests
{
    [TestClass()]
    public class KuldetesTests
    {

        [TestMethod()]
        public void KockazatiSzintTest_1()
        {
            
            Kuldetes tesztKuldetes = new Kuldetes("Apollo 11; 1969; Hold; 3; Igen; Első emberes holdraszállás; 25,4; 10100");

            Assert.AreEqual(tesztKuldetes.KockazatiSzint(), "Magas");
        }

        [TestMethod()]
        public void KockazatiSzintTest_2()
        {

            Kuldetes tesztKuldetes = new Kuldetes("Apollo 11; 1969; Hold; 3; Igen; Első emberes holdraszállás; 25,4; 9900");

            Assert.AreEqual(tesztKuldetes.KockazatiSzint(), "Közepes");
        }

        [TestMethod()]
        public void KockazatiSzintTest_3()
        {

            Kuldetes tesztKuldetes = new Kuldetes("Apollo 11; 1969; Hold; 3; Igen; Első emberes holdraszállás; 0,9; 10100");

            Assert.AreEqual(tesztKuldetes.KockazatiSzint(), "Közepes");
        }

        [TestMethod()]
        public void KockazatiSzintTest_4()
        {

            Kuldetes tesztKuldetes = new Kuldetes("Apollo 11; 1969; Hold; 3; Igen; Első emberes holdraszállás; 0,8; 4500");

            Assert.AreEqual(tesztKuldetes.KockazatiSzint(), "Alacsony");
        }
    }
}