﻿using System;
using System.Collections.Generic;
using CustomListProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTests
{
    [TestClass]
    public class CustomListTests
    {
        //[TestMethod]
        //public void Indexer_Test0()
        //{
        //    // Arrange
        //    CustomList<int> myList = new CustomList<int>();
        //    int testValue1 = 100;
        //    int expected = 100;
        //    int actual;

        //    // Act
        //    myList[0] = testValue1;
        //    actual = myList[0];

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void Indexer_Test1()
        //{
        //    // Arrange
        //    CustomList<int> myList = new CustomList<int>();
        //    int testValue1 = 50;
        //    int expected = 50;
        //    int actual;

        //    // Act
        //    myList[1] = testValue1;
        //    actual = myList[1];

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void Indexer_Test2()
        //{
        //    // Arrange
        //    CustomList<int> myList = new CustomList<int>();
        //    int testValue1 = 75;
        //    int expected = 75;
        //    int actual;

        //    // Act
        //    myList[2] = testValue1;
        //    actual = myList[2];

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void Indexer_Test3()
        //{
        //    // Arrange
        //    CustomList<int> myList = new CustomList<int>();
        //    int testValue1 = 15;
        //    int expected = 15;
        //    int actual;

        //    // Act
        //    myList[3] = testValue1;
        //    actual = myList[3];

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void Indexer_Test4()
        //{
        //    // Arrange
        //    CustomList<int> myList = new CustomList<int>();
        //    int testValue1 = 13;
        //    int expected = 13;
        //    int actual;

        //    // Act
        //    myList[4] = testValue1;
        //    actual = myList[4];

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void FiveIndex_Add()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 1;
            int addValue2 = 2;
            int addValue3 = 3;
            int addValue4 = 4;
            int addValue5 = 5;
            int expected = 5;
            int actual;
            // Act
            myList.Add(addValue1);
            myList.Add(addValue2);
            myList.Add(addValue3);
            myList.Add(addValue4);
            myList.Add(addValue5);
            actual = myList[4];
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OneIndex_Add()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 15;
            int expected = 15;
            int actual;
            // Act
            myList.Add(addValue1);
            actual = myList[0];
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TwoIndex_Add()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 15;
            int addValue2 = 25;
            int expected = 25;
            int actual;
            // Act
            myList.Add(addValue1);
            myList.Add(addValue2);
            actual = myList[1];
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SevenIndex_Add()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 1;
            int addValue2 = 2;
            int addValue3 = 3;
            int addValue4 = 4;
            int addValue5 = 5;
            int addValue6 = 6;
            int addValue7 = 7;
            int expected = 7;
            int actual;
            // Act
            myList.Add(addValue1);
            myList.Add(addValue2);
            myList.Add(addValue3);
            myList.Add(addValue4);
            myList.Add(addValue5);
            myList.Add(addValue6);
            myList.Add(addValue7);
            actual = myList[6];
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FifteenIndex_Add()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 1;
            int addValue2 = 2;
            int addValue3 = 3;
            int addValue4 = 4;
            int addValue5 = 5;
            int addValue6 = 6;
            int addValue7 = 7;
            int addValue8 = 8;
            int addValue9 = 9;
            int addValue10 = 10;
            int addValue11 = 11;
            int addValue12 = 12;
            int addValue13 = 13;
            int addValue14 = 14;
            int addValue15 = 15;
            int expected = 15;
            int actual;
            // Act
            myList.Add(addValue1);
            myList.Add(addValue2);
            myList.Add(addValue3);
            myList.Add(addValue4);
            myList.Add(addValue5);
            myList.Add(addValue6);
            myList.Add(addValue7);
            myList.Add(addValue8);
            myList.Add(addValue9);
            myList.Add(addValue10);
            myList.Add(addValue11);
            myList.Add(addValue12);
            myList.Add(addValue13);
            myList.Add(addValue14);
            myList.Add(addValue15);
            actual = myList[14];
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TwoIndex_Remove()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 15;
            int addValue2 = 25;
            int expected = 25;
            int actual;
            // Act
            myList.Add(addValue1);
            myList.Add(addValue2);
            myList.Remove(addValue1);
            actual = myList[0];
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ThreeIndex_Check1_Remove()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 15;
            int addValue2 = 35;
            int addValue3 = 25;
            int expected1 = 25;
            int expected2 = 15;
            int actual1;
            int actual2;
            // Act
            myList.Add(addValue1);
            myList.Add(addValue2);
            myList.Add(addValue3);
            myList.Remove(addValue2);
            actual1 = myList[1];
            actual2 = myList[0];
            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
        [TestMethod]
        public void FourIndex_Check01_Remove2()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 15;
            int addValue2 = 35;
            int addValue3 = 25;
            int addValue4 = 45;
            int expected1 = 45;
            int expected2 = 15;
            int actual1;
            int actual2;
            // Act
            myList.Add(addValue1);
            myList.Add(addValue2);
            myList.Add(addValue3);
            myList.Add(addValue4);
            myList.Remove(addValue2);
            myList.Remove(addValue3);
            actual1 = myList[1];
            actual2 = myList[0];
            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
        [TestMethod]
        public void FourIndex_Check0_Remove3()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 15;
            int addValue2 = 35;
            int addValue3 = 25;
            int addValue4 = 45;
            int expected1 = 45;
            int actual1;
            // Act
            myList.Add(addValue1);
            myList.Add(addValue2);
            myList.Add(addValue3);
            myList.Add(addValue4);
            myList.Remove(addValue1);
            myList.Remove(addValue2);
            myList.Remove(addValue3);
            actual1 = myList[0];
            // Assert
            Assert.AreEqual(expected1, actual1);
        }
        [TestMethod]
        public void SixIndex_Check02_Remove3()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 15;
            int addValue2 = 35;
            int addValue3 = 25;
            int addValue4 = 45;
            int addValue5 = 55;
            int addValue6 = 65;
            int expected1 = 45;
            int expected2 = 65;
            int actual1;
            int actual2;
            // Act
            myList.Add(addValue1);
            myList.Add(addValue2);
            myList.Add(addValue3);
            myList.Add(addValue4);
            myList.Add(addValue5);
            myList.Add(addValue6);
            myList.Remove(addValue1);
            myList.Remove(addValue2);
            myList.Remove(addValue3);
            actual1 = myList[0];
            actual2 = myList[2];
            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
        [TestMethod]

        public void ListToSting_TwoValues_AddOnly()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 15;
            int addValue2 = 35;
            myList.Add(addValue1);
            myList.Add(addValue2);
            string expected = "15, 35";
            string actual1;
            // Act
            actual1 = myList.ToString();

            // Assert
            Assert.AreEqual(expected, actual1);
        }
        [TestMethod]

        public void ListToSting_ThreeValues_AddOnly()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 15;
            int addValue2 = 35;
            int addValue3 = 45;
            myList.Add(addValue1);
            myList.Add(addValue2);
            myList.Add(addValue3);
            string expected = "15, 35, 45";
            string actual1;
            // Act
            actual1 = myList.ToString();

            // Assert
            Assert.AreEqual(expected, actual1);
        }
        [TestMethod]

        public void ListToSting_ThreeValues_WithRemove()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 15;
            int addValue2 = 35;
            int addValue3 = 45;
            myList.Add(addValue1);
            myList.Add(addValue2);
            myList.Add(addValue3);
            myList.Remove(addValue2);
            string expected = "15, 45";
            string actual1;
            // Act
            actual1 = myList.ToString();

            // Assert
            Assert.AreEqual(expected, actual1);
        }
        [TestMethod]

        public void ListToSting_FiveValues_WithRemove()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int addValue1 = 15;
            int addValue2 = 35;
            int addValue3 = 45;
            int addValue4 = 55;
            int addValue5 = 65;
            myList.Add(addValue1);
            myList.Add(addValue2);
            myList.Add(addValue3);
            myList.Add(addValue4);
            myList.Add(addValue5);
            myList.Remove(addValue2);
            myList.Remove(addValue3);
            string expected = "15, 55, 65";
            string actual1;
            // Act
            actual1 = myList.ToString();

            // Assert
            Assert.AreEqual(expected, actual1);
        }
        [TestMethod]

        public void ListToSting_FourString()
        {
            // Arrange
            CustomList<string> myList = new CustomList<string>();
            string addString1 = "Hello";
            string addString2 = "World";
            string addString3 = "Im";
            string addString4 = "Alive";
            myList.Add(addString1);
            myList.Add(addString2);
            myList.Add(addString3);
            myList.Add(addString4);
            string expected = "Hello, World, Im, Alive";
            string actual1;
            // Act
            actual1 = myList.ToString();

            // Assert
            Assert.AreEqual(expected, actual1);
        }
        [TestMethod]
        public void AdditionOverLoading_TwoLists()
        {
            // Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> actual;
            CustomList<int> expected = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int value4 = 40;
            myList1.Add(value1);
            myList1.Add(value2);
            myList2.Add(value3);
            myList2.Add(value4);
            expected.Add(value1);
            expected.Add(value2);
            expected.Add(value3);
            expected.Add(value4);

            // Act
            actual = myList1 + myList2;
            // Assert
            Assert.ReferenceEquals(expected, actual);
            
        }
        [TestMethod]
        public void SubtractionOverloading_TwoLists()
        {
            // Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> actual;
            CustomList<int> expected = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 10;
            int value4 = 40;
            myList1.Add(value1);
            myList1.Add(value2);
            myList2.Add(value3);
            myList2.Add(value4);
            expected.Add(value2);
            expected.Add(value4);

            // Act
            actual = myList1 - myList2;
            // Assert
            Assert.ReferenceEquals(expected, actual);

        }
        [TestMethod]
        public void SubtractionOverloading_TwoLists6()
        {
            // Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3 = new CustomList<int>();
            CustomList<int> actual;
            CustomList<int> expected = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int value4 = 40;
            int value5 = 40;
            int value6 = 20;
            myList1.Add(value1);
            myList1.Add(value2);
            myList1.Add(value3);
            myList1.Add(value4);
            myList2.Add(value5);
            myList2.Add(value6);
            expected.Add(value1);
            expected.Add(value3);

            // Act
            actual = myList1 - myList2;
            // Assert
            Assert.ReferenceEquals(expected, actual);

        }
    }
}
