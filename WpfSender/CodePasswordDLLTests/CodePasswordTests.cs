﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodePasswordDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePasswordDLL.Tests
{
    [TestClass()]
    public class CodePasswordTests
    {
        [TestMethod()]
        public void getCodPassword_empty_empty()
        {
            // arrange 
            string strIn = "";
            string strExpected = "";
            // act 
            string strActual = CodePassword.getCodPassword(strIn);
            //assert
            Assert.AreEqual(strExpected, strActual);

        }
    }
}