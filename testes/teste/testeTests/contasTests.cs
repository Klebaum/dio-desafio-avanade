﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using teste;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace teste.Tests
{
    [TestClass()]
    public class contasTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 10;
            var contas = new contas();

            var result = contas.Soma(a, b);
            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void SubTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 0;
            var contas = new contas();

            var result = contas.Sub(a, b);
            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void DivTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 1;
            var contas = new contas();

            var result = contas.Div(a, b);
            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void MultTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 25;
            var contas = new contas();

            var result = contas.Mult(a, b);
            Assert.AreEqual(esperado, result);
        }
    }
}