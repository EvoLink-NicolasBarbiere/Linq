using LinqPracticing.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPracticingTests
{
    [TestClass]
    public class LinqPracticingTests
    {
        private List<MyObject> _myObjects = new List<MyObject>()
        {
            new MyObject() {Id = 1, Name = "Toto"},
            new MyObject() {Id = 33, Name = "Tata"},
            new MyObject() {Id = 2, Name = "Test"},
            new MyObject() {Id = 52, Name = "Tutu"},
            new MyObject() {Id = 8, Name = "Doe"},
            new MyObject() {Id = 14, Name = "NoName"},
            new MyObject() {Id = 1, Name = "Flyn"},
        };

        /// <summary>
        /// Utiliser la méthode Select pour retourner une liste de propriété Name
        /// </summary>
        [TestMethod]
        public void SelectOnlyPropertyNameShouldReturnListOfString()
        {
            Assert.IsInstanceOfType(LinqPracticing.LinqPracticing.SelectPropertyName(_myObjects), typeof(List<string>));
        }

        /// <summary>
        /// Utiliser la méthode First pour récupérer le premier élément
        /// </summary>
        [TestMethod]
        public void GetFirstElementOfListShouldReturnToto()
        {
            Assert.IsTrue(LinqPracticing.LinqPracticing.GetFirst(_myObjects).Name == "Toto");
        }

        /// <summary>
        /// Utiliser la méthode First pour retourner le premier élément selon une condition
        /// </summary>
        [TestMethod]
        public void GetFirstElementWithIdExist1ShouleReturnToto()
        {
            Assert.IsTrue(LinqPracticing.LinqPracticing.GetFirstWithCondition(_myObjects).Name == "Toto");
        }

        /// <summary>
        /// Utiliser la méthode First pour retourner un élément inexistant selon une condition
        /// </summary>
        [TestMethod]
        public void GetFirstElementWithIdNoExistShouleReturnException()
        {
            Assert.ThrowsException<InvalidOperationException>(() => LinqPracticing.LinqPracticing.GetFirstWithConditionException(_myObjects));
        }

        /// <summary>
        /// Utiliser la méthode FirstOrDefault pour récupérer le premier élément
        /// </summary>
        [TestMethod]
        public void GetFirstOrDefaultElementOfListShouldReturnToto()
        {
            Assert.IsTrue(LinqPracticing.LinqPracticing.GetFirstOrDefault(_myObjects).Name == "Toto");
        }

        /// <summary>
        /// Utiliser la méthode FirstOrDefault pour retourner le premier élément selon une condition
        /// </summary>
        [TestMethod]
        public void GetFirstOrDefaultElementWithIdExistShouleReturnToto()
        {
            Assert.IsTrue(LinqPracticing.LinqPracticing.GetFirstOrDefaultWithCondition(_myObjects).Name == "Toto");
        }

        /// <summary>
        /// Utiliser la méthode FirstOrDefault pour retourner un élément inexistant selon une condition
        /// </summary>
        [TestMethod]
        public void GetFirstOrDefaultElementWithIdNotExistShouleReturnNull()
        {
            Assert.IsNull(LinqPracticing.LinqPracticing.GetFirstOrDefaultConditionNull(_myObjects));
        }

        /// <summary>
        /// Utiliser la méthode Where pour retourner une liste d'élément
        /// </summary>
        [TestMethod]
        public void GetElementsWhereIdExistShouldReturn2Elements()
        {
            Assert.IsTrue(LinqPracticing.LinqPracticing.GetElementsWhereIdExist(_myObjects).Count == 2);
        }

        /// <summary>
        /// Utiliser la méthode Where pour retourner une liste d'élément
        /// </summary>
        [TestMethod]
        public void GetElementsWhereIdNoExistShouldReturn0Elements()
        {
            Assert.IsTrue(LinqPracticing.LinqPracticing.GetElementsWhereIdNotExist(_myObjects).Count == 0);
        }

        /// <summary>
        /// Utiliser la méthode Any pour retourner un boolean
        /// </summary>
        [TestMethod]
        public void AnyElementInListShouldReturnTrue()
        {
            Assert.IsTrue(LinqPracticing.LinqPracticing.AnyElement(_myObjects));
        }

        /// <summary>
        /// Utiliser la méthode Any avec condition pour retourner un boolean
        /// </summary>
        [TestMethod]
        public void AnyElementInListShouldWithConditionReturnTrue()
        {
            Assert.IsTrue(LinqPracticing.LinqPracticing.AnyElementWithExistId(_myObjects));
        }

        /// <summary>
        /// Utiliser la méthode Any avec condition pour retourner un boolean
        /// </summary>
        [TestMethod]
        public void AnyElementInListShouldWithConditionReturnFalse()
        {
            Assert.IsFalse(LinqPracticing.LinqPracticing.AnyElementWithNotExistId(_myObjects));
        }

        /// <summary>
        /// Utiliser la méthode Order pour ordrer selon une propriété
        /// </summary>
        [TestMethod]
        public void OrderListShouldReturnListOrdered()
        {
            var orderedList = LinqPracticing.LinqPracticing.OrderList(_myObjects);

            Assert.IsTrue(orderedList[0].Name == "Toto");
            Assert.IsTrue(orderedList[1].Name == "Flyn");
            Assert.IsTrue(orderedList[2].Name == "Test");
            Assert.IsTrue(orderedList[3].Name == "Doe");
            Assert.IsTrue(orderedList[4].Name == "NoName");
            Assert.IsTrue(orderedList[5].Name == "Tata");
            Assert.IsTrue(orderedList[6].Name == "Tutu");
        }

        /// <summary>
        /// Utiliser la méthode Order + ThenBy pour ordrer selon 2 propriété
        /// </summary>
        [TestMethod]
        public void OrderListShouldReturnListOrderedByTwoPreperties()
        {
            var orderedList = LinqPracticing.LinqPracticing.OrderThenByList(_myObjects);

            Assert.IsTrue(orderedList[0].Name == "Flyn");
            Assert.IsTrue(orderedList[1].Name == "Toto");
            Assert.IsTrue(orderedList[2].Name == "Test");
            Assert.IsTrue(orderedList[3].Name == "Doe");
            Assert.IsTrue(orderedList[4].Name == "NoName");
            Assert.IsTrue(orderedList[5].Name == "Tata");
            Assert.IsTrue(orderedList[6].Name == "Tutu");
        }

        /// <summary>
        /// Utiliser la méthode Take pour retourner 3 éléments de la liste
        /// </summary>
        [TestMethod]
        public void Take3ElementsOfList()
        {
            var list = LinqPracticing.LinqPracticing.TakeThreeElements(_myObjects);

            Assert.IsTrue(list.Count == 3);
            Assert.IsTrue(list[0].Name == "Toto");
            Assert.IsTrue(list[1].Name == "Tata");
            Assert.IsTrue(list[2].Name == "Test");
        }

        /// <summary>
        /// Utiliser la méthode TakeWhile pour retourner des éléments selon condition
        /// </summary>
        [TestMethod]
        public void TakeElementsWithCondition()
        {
            var list = LinqPracticing.LinqPracticing.TakeElementsWithCondition(_myObjects);

            Assert.IsTrue(list.Count == 3);
            Assert.IsTrue(list[0].Name == "Toto");
            Assert.IsTrue(list[1].Name == "Tata");
            Assert.IsTrue(list[2].Name == "Test");
        }

        /// <summary>
        /// Utiliser la méthode GroupBy pour grouper des éléments
        /// </summary>
        [TestMethod]
        public void GroupByShouldReturnGroupedList()
        {
            var group = LinqPracticing.LinqPracticing.GroupElements(_myObjects);

            Assert.IsTrue(group.Count == _myObjects.Count - 1);
            Assert.IsTrue(group.Where(g => g.Key == 1).SelectMany(g => g).Count() == 2);
        }

        /// <summary>
        /// Utiliser la méthode Single pour récupérer un seul élément
        /// </summary>
        [TestMethod]
        public void GetSingle()
        {
            Assert.IsTrue(LinqPracticing.LinqPracticing.SingleElement(_myObjects).Name == "Test");
        }

        /// <summary>
        /// Utiliser la méthode Single pour récupérer un seul élément
        /// </summary>
        [TestMethod]
        public void GetSingleExceptionWithConditionReturningTwoElements()
        {
            Assert.ThrowsException<InvalidOperationException>(() => LinqPracticing.LinqPracticing.SingleElementException(_myObjects));
        }
        
        /// <summary>
        /// Utiliser la méthode Single pour récupérer un seul élément
        /// </summary>
        [TestMethod]
        public void GetSingleExceptionWithConditionReturningNoElement()
        {
            Assert.ThrowsException<InvalidOperationException>(() => LinqPracticing.LinqPracticing.SingleElementException2(_myObjects));
        }
    }
}
