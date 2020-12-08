using linkedListInDotNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace linkedListTest
{
    [TestClass]
    public class UnitTest1
        
    {
        LinkedList linkedList;
        Stack stack;

        public UnitTest1()
        {
            linkedList = new LinkedList();
            stack = new Stack();
        }

        [TestMethod]
        public void givenThreeNumbers_WhenAddedToLinkedList_ShouldHaveLastNumberAddedAtFront()
        {
            int firstNode = 70;
            int secndNode = 30;
            int thirdNode = 56;

            linkedList.AddData(70);
            linkedList.AddData(30);
            linkedList.AddData(56);
            bool result = linkedList.head.data.Equals(thirdNode) && linkedList.head.next.data.Equals(secndNode)
                                                                    && linkedList.tail.data.Equals(firstNode);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenThreeNumbers_WhenRemovedFirstNumber_ShouldReturnSecondNumberHasFirstNumber()
        {
            int firstNode = 56;
            int secondNode = 30;
            int thirdNode = 70;

            linkedList.AppendData(firstNode);
            linkedList.AppendData(secondNode);
            linkedList.AppendData(thirdNode);
            linkedList.Pop();
            bool result = linkedList.head.data.Equals(secondNode);
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void givenThreeNumbers_WhenRemovedLastNumber_ShouldReturnSecondNumberHasLastNumber()
        {
            int firstNode = 56;
            int secondNode = 30;
            int thirdNode = 70;

            linkedList.AppendData(firstNode);
            linkedList.AppendData(secondNode);
            linkedList.AppendData(thirdNode);
            linkedList.PopLast();
            bool result = linkedList.tail.data.Equals(secondNode);
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void givenThreeNumbers_WhenAppendedToLinkedList_ShouldBeAddedAtLast()
        {
            int nodeOne = 56;
            int nodeTwo = 30;
            int nodeThree = 70;

            linkedList.AppendData(nodeOne);
            linkedList.AppendData(nodeTwo);
            linkedList.AppendData(nodeThree);
            bool result = linkedList.head.data.Equals(nodeOne) && linkedList.head.next.data.Equals(nodeTwo)
                                                                     && linkedList.tail.data.Equals(nodeThree);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenTwoElements_WhenInsertedThirdElementInBetween_ShouldReturnTrue()
        {
            int firstNode = 56;
            int secondNode = 30;
            int thirdNode = 70;

            linkedList.AppendData(firstNode);
            linkedList.AppendData(thirdNode);
            linkedList.InsertData(2, secondNode);
            bool result = linkedList.head.data.Equals(firstNode) && linkedList.head.next.data.Equals(secondNode)
                                                                    && linkedList.tail.data.Equals(thirdNode);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchElementinTheList()
        {
            int firstNode = 56;
            int secondNode = 30;
            int thirdNode = 70;
            linkedList.AppendData(firstNode);
            linkedList.AppendData(secondNode);
            linkedList.AppendData(thirdNode);
            int searchObject = linkedList.SearchData(secondNode);
            Assert.AreEqual(secondNode, searchObject);
        }

        [TestMethod]
        public void givenThreeValues_WhenSearchedForANumberAndInsertedValueThere_shouldReturnTrue()
        {
            int firstNode = 56;
            int secondNode = 30;
            int thirdNode = 40;
            int fourthNode = 70;
            linkedList.AppendData(firstNode);
            linkedList.AppendData(secondNode);
            linkedList.AppendData(fourthNode);
            linkedList.InsertData(3, thirdNode);
            int searchResult = linkedList.SearchData(thirdNode);
            Assert.AreEqual(thirdNode, searchResult);
        }
    }
}
