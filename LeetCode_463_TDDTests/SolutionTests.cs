using System;
using LeetCode_463_TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_463_TDDTests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void IslandTest1()
        {
            var grid = new[,]
            {
                {0, 1}
            };

            var expected = 4;
            var sut = new Solution();
            var actual = sut.IslandPerimeter(grid);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IslandTest2()
        {
            var grid = new[,]
            {
                {0, 1, 1, 1, 0}
            };

            var expected = 8;
            var sut = new Solution();
            var actual = sut.IslandPerimeter(grid);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IslandTest3()
        {
            var grid = new[,]
            {
                {0, 1, 0,0},
                {1,1,1,0 },
                {0,1,0,0 },
                {1,1,0,0 }
            };

            var expected = 16;
            var sut = new Solution();
            var actual = sut.IslandPerimeter(grid);
            Assert.AreEqual(expected, actual);
        }
    }
}