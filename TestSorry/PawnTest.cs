﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class PawnTests
    {
        [TestMethod()]
        public void PawnTest()
        {
            Pawn testPawn = new Pawn();
            testPawn.setBoardLocation(1,1);
            testPawn.ownerPlayer();
            testPawn.boardLocationX();
            testPawn.boardLocationY();
        }
    }
}