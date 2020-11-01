using LinqPracticing.Models;
using System.Collections.Generic;
using System.Linq;

namespace LinqPracticing
{
    public static class LinqPracticing
    {
        public static List<string> SelectPropertyName(List<MyObject> myObjects)
        {
            return myObjects.Select(m => m.Name).ToList();
        }

        public static MyObject GetFirst(List<MyObject> myObjects)
        {
            return myObjects.First();
        }

        public static MyObject GetFirstWithCondition(List<MyObject> myObjects)
        {
            return myObjects.First(m => m.Id == 1);
        }

        public static MyObject GetFirstWithConditionException(List<MyObject> myObjects)
        {
            return myObjects.First(m => m.Id == 13);
        }

        public static MyObject GetFirstOrDefault(List<MyObject> myObjects)
        {
            return myObjects.FirstOrDefault();
        }

        public static MyObject GetFirstOrDefaultWithCondition(List<MyObject> myObjects)
        {
            return myObjects.FirstOrDefault(m => m.Id == 1);
        }

        public static MyObject GetFirstOrDefaultConditionNull(List<MyObject> myObjects)
        {
            return myObjects.FirstOrDefault(m => m.Id == 13);
        }

        public static List<MyObject> GetElementsWhereIdExist(List<MyObject> myObjects)
        {
            return myObjects.Where(m => m.Id == 1).ToList();
        }

        public static List<MyObject> GetElementsWhereIdNotExist(List<MyObject> myObjects)
        {
            return myObjects.Where(m => m.Id == 13).ToList();
        }

        public static bool AnyElement(List<MyObject> myObjects)
        {
            return myObjects.Any();
        }

        public static bool AnyElementWithExistId(List<MyObject> myObjects)
        {
            return myObjects.Any(m => m.Id == 1);
        }

        public static bool AnyElementWithNotExistId(List<MyObject> myObjects)
        {
            return myObjects.Any(m => m.Id == 13);
        }

        public static List<MyObject> OrderList(List<MyObject> myObjects)
        {
            return myObjects.OrderBy(m => m.Id).ToList();
        }
        public static List<MyObject> OrderThenByList(List<MyObject> myObjects)
        {
            return myObjects.OrderBy(m => m.Id).ThenBy(m => m.Name).ToList();
        }

        public static List<MyObject> TakeThreeElements(List<MyObject> myObjects)
        {
            return myObjects.Take(3).ToList();
        }

        public static List<MyObject> TakeElementsWithCondition(List<MyObject> myObjects)
        {
            return myObjects.TakeWhile(m => m.Id < 50).ToList();
        }

        public static List<IGrouping<int, MyObject>> GroupElements(List<MyObject> myObjects)
        {
            return myObjects.GroupBy(m => m.Id).ToList();
        }

        public static MyObject SingleElement(List<MyObject> myObjects)
        {
            return myObjects.Single(m => m.Id == 2);
        }

        public static MyObject SingleElementException(List<MyObject> myObjects)
        {
            return myObjects.Single(m => m.Id == 1);
        }

        public static MyObject SingleElementException2(List<MyObject> myObjects)
        {
            return myObjects.Single(m => m.Id == 13);
        }
    }
}
