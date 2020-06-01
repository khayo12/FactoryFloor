using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryFloor.Test
{
    [TestClass]
    public class FloorTest
    {
        [TestMethod]
        public void TestMoveBlocks()
        {
            var sequence = "N4,E2,S2,W4";
            var expectedResponse = "11 visited blocks\n3 right turns";

            var actualResponse = Floor.MoveBlocks(sequence);

            Assert.AreEqual(expectedResponse, actualResponse);
        }
        [TestMethod]
        public void TestMoveBlocksInvalidDirection()
        {
            var sequence = "Q1";
            var expectedResponse = "Invalid: Q direction.";
                        
            var actualResponse = Floor.MoveBlocks(sequence);

            Assert.AreEqual(expectedResponse, actualResponse);
        }
        [TestMethod]
        public void TestMoveBlocksInvalidSequence()
        {
            var sequence = "QS";
            var expectedResponse = string.Empty;

            var actualResponse = Floor.MoveBlocks(sequence);

            Assert.AreEqual(expectedResponse, actualResponse);
        }
    }
}
