using linkedListInDotNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace linkedListTest
{
    [TestClass]
    public class UnitTest1
        
    {
        LinkedList linkedList;
        Stack stack;
        Queue queue;

        public UnitTest1()
        {
            linkedList = new LinkedList();
            stack = new Stack();
            queue = new Queue();
        }

        /// <summary>
        /// Given three numbers when added to linked list should have last number added at front.
        /// </summary>
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

        /// <summary>
        /// Given three numbers when removed first number should return second number has first number.
        /// </summary>
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

        /// <summary>
        /// Given three numbers when removed last number should return second number has last number.
        /// </summary>
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

        /// <summary>
        /// Given three numbers when appended to linked list should be added at last.
        /// </summary>
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

        /// <summary>
        /// Given two elements when inserted third element in between should return true.
        /// </summary>
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

        /// <summary>
        /// Given value when searched in linked list should return equal.
        /// </summary>
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

        /// <summary>
        /// Given values when searched for a value and inserted value there should return true.
        /// </summary>
        [TestMethod]
        public void givenValues_WhenSearchedForAValueAndInsertedValueThere_shouldReturnTrue()
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

        /// <summary>
        /// Given size of the values wnen a value deleted and checked for size should return the size.
        /// </summary>
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

        /// <summary>
        /// Given elements when pushed into stack and peeked should return element on top.
        /// </summary>
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

        /// <summary>
        /// Given elements when popped should remove element on top.
        /// </summary>
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

        /// <summary>
        /// Given size of the elements when emptied should give zero.
        /// </summary>
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

        /// <summary>
        /// Given elements when checked if it is empty should return true if empty.
        /// </summary>
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

        //Queue

        /// <summary>
        /// Given elements when added into queue and then removed should return true.
        /// </summary>
        [TestMethod]
        public void givenElements_WhenAddedIntoQueueAndThenRemoved_ShouldReturnTrue()
        {
            Queue queue = new Queue();
            int firstElement = 56;
            int secondElement = 30;
            int thirdElement = 70;
            queue.EnqueueData(firstElement);
            queue.EnqueueData(secondElement);
            queue.EnqueueData(thirdElement);
            queue.DequeueData();
            bool result = queue.IsEmpty();
            Assert.IsTrue(result);

        }

        /// <summary>
        /// Given size of the elements in queue when checked for size should return.
        /// </summary>
        [TestMethod]
        public void givenElementsInQueue_WhenCheckedForSize_ShouldReturnSize()
        {
            Queue queue = new Queue();
            int firstElement = 56;
            int secondElement = 30;
            int thirdElement = 70;
            queue.EnqueueData(firstElement);
            queue.EnqueueData(secondElement);
            queue.EnqueueData(thirdElement);
            int size = queue.Size();
            Assert.AreEqual(3, size);
        }
    }
}
