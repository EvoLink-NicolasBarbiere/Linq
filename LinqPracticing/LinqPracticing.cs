using LinqPracticing.Models;
using System.Collections.Generic;
using System.Linq;

namespace LinqPracticing
{
    public static class LinqPracticing
    {
        public static List<string> SelectPropertyName(List<MyObject> myObjects)
        {
            return myObjects.Select(o => o.Name).ToList();
        }

        public static MyObject GetFirst(List<MyObject> myObjects)
        {
            return myObjects.First();
        }

        public static MyObject GetFirstWithCondition(List<MyObject> myObjects)
        {
            return myObjects.First(o => o.Id == 1);
        }

        public static MyObject GetFirstWithConditionException(List<MyObject> myObjects)
        {
            return myObjects.First(o => o.Id == 999);
        }

        public static MyObject GetFirstOrDefault(List<MyObject> myObjects)
        {
            return myObjects.FirstOrDefault();
        }

        public static MyObject GetFirstOrDefaultWithCondition(List<MyObject> myObjects)
        {
            return myObjects.FirstOrDefault(o => o.Id == 1);
        }

        public static MyObject GetFirstOrDefaultConditionNull(List<MyObject> myObjects)
        {
            return myObjects.FirstOrDefault(o => o.Id == 999);
        }

        public static List<MyObject> GetElementsWhereIdExist(List<MyObject> myObjects)
        {
            return (List<MyObject>)myObjects.Where(o => o.Id == 1)
                                            .Where(o => o.Id == 2);
            //!
        }

        public static List<MyObject> GetElementsWhereIdNotExist(List<MyObject> myObjects)
        {
            return (List<MyObject>)myObjects.Where(o => o.Id > 999);
            //!
        }

        public static bool AnyElement(List<MyObject> myObjects)
        {
            return myObjects.Any();
        }

        public static bool AnyElementWithExistId(List<MyObject> myObjects)
        {
            return myObjects.Any(o => o.Id == 1);
        }

        public static bool AnyElementWithNotExistId(List<MyObject> myObjects)
        {
            return myObjects.Any(o => o.Id == 0);
        }

        public static List<MyObject> OrderList(List<MyObject> myObjects)
        {
            throw new System.Exception("no");
            //return myObjects.OrderBy(o => o.Name);
        }
        public static List<MyObject> OrderThenByList(List<MyObject> myObjects)
        {
            throw new System.Exception("no");
        }

        public static List<MyObject> TakeThreeElements(List<MyObject> myObjects)
        {
            throw new System.Exception("no");
        }

        public static List<MyObject> TakeElementsWithCondition(List<MyObject> myObjects)
        {
            return (List<MyObject>)myObjects.OrderByDescending(o => o).Take(3);
            //!
        }

        public static List<IGrouping<int, MyObject>> GroupElements(List<MyObject> myObjects)
        {
            return (List<IGrouping<int, MyObject>>)myObjects.GroupBy(o => o.Id);
            //!
        }

        public static MyObject SingleElement(List<MyObject> myObjects)
        {
            try
            {
               return myObjects.Single();
            }
            catch(System.InvalidOperationException)
            {
                return myObjects.First(o => o.Id == 2);
            }
           //!
        }

        public static MyObject SingleElementException(List<MyObject> myObjects)
        {
            throw new System.Exception("no");
        }

        public static MyObject SingleElementException2(List<MyObject> myObjects)
        {
            throw new System.Exception("no");
        }
    }
}
