using linkedListInDotNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace linkedListTest
{
    [TestClass]
    public class UnitTest1
        
    {
        LinkedList linkedList;

        public UnitTest1()
        {
            linkedList = new LinkedList();
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
            int nodeOne = linkedList.CheckingFirstElement();
            int nodeTwo = linkedList.CheckingMiddleElement();
            int nodeThree = linkedList.CheckingLastElement();
            bool result = nodeOne.Equals(thirdNode) && nodeTwo.Equals(secndNode) && nodeThree.Equals(firstNode);
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
            int NodeOne = linkedList.CheckingFirstElement();
            bool result = NodeOne.Equals(secondNode);
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
            int endValue = linkedList.CheckingLastElement();
            bool result = endValue.Equals(secondNode);
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
            int firstNode = linkedList.CheckingFirstElement();
            int secondNode = linkedList.CheckingMiddleElement();
            int thirdNode = linkedList.CheckingLastElement();

            bool result = firstNode.Equals(nodeOne) && secondNode.Equals(nodeTwo) && thirdNode.Equals(nodeThree);
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

            int nodeTwo = linkedList.CheckingMiddleElement();
            bool result = secondNode.Equals(nodeTwo);
            Assert.IsTrue(result);
        }
    }
}
