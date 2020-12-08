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
                                                                    && linkedList.endNode.data.Equals(firstNode);
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
            bool result = linkedList.endNode.data.Equals(secondNode);
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
                                                                     && linkedList.endNode.data.Equals(nodeThree);
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
                                                                    && linkedList.endNode.data.Equals(thirdNode);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenValue_WhenSearchedInLinkedList_ShouldReturnEqual()
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
        public void givenValues_WhenSearchedForANumberAndInsertedValueThere_shouldReturnTrue()
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

        [TestMethod]
        public void givenValues_WnenAValueDeletedAndCheckedForSize_ShouldReturnSize()
        {
            int firstNode = 56;
            int secondNode = 30;
            int thirdNode = 40;
            int fourthNode = 70;
            linkedList.AppendData(firstNode);
            linkedList.AppendData(secondNode);
            linkedList.AppendData(thirdNode);
            linkedList.AppendData(fourthNode);
            linkedList.DeleteData(thirdNode);
            int size = linkedList.Size();
            Assert.AreEqual(3, size);
        }


        //Stack

        [TestMethod]
        public void givenElements_WhenPushedIntoStackAndPeeked_ShouldReturnElementOnTop()
        { 
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;
            stack.Push(firstElement);
            stack.Push(secondElement);
            stack.Push(thirdElement);
            int peek = stack.Peek();
            Assert.AreEqual(thirdElement, peek);
        }

        [TestMethod]
        public void givenElements_WhenPopped_ShouldRemoveElementOnTop()
        {
            Stack stack = new Stack();
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;
            stack.Push(firstElement);
            stack.Push(secondElement);
            stack.Push(thirdElement);
            stack.Pop();
            int peek = stack.Peek();
            Assert.AreEqual(secondElement, peek);
        }

        [TestMethod]
        public void givenElements_WhenEmptied_ShouldGiveZeroSize()
        {
            Stack stack = new Stack();
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;
            stack.Push(firstElement);
            stack.Push(secondElement);
            stack.Push(thirdElement);
            stack.EmptyingTheStack();
            int size = stack.Size();
            Assert.AreEqual(0, size);
        }

        [TestMethod]
        public void givenElements_WhenCheckedIFItIsEmpty_ShouldReturnTrueIfEmpty()
        {
            Stack stack = new Stack();
            int firstElement = 70;
            int secondElement = 30;
            int thirdElement = 56;
            stack.Push(firstElement);
            stack.Push(secondElement);
            stack.Push(thirdElement);
            stack.EmptyingTheStack();
            bool result = stack.IsEmpty();
            Assert.IsTrue(result);
        }
    }
}
