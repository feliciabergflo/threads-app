namespace Assignment4.General
{
    /// <summary>
    /// A generic class that manages a list of objects of type T.
    /// </summary>
    /// <typeparam name="T">The type of objects in the list.</typeparam>
    public class ListManager<T> : IListManager<T>
    {
        #region FIELDS
        private List<T> list;
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Returns the number of items in the collection 'list'
        /// </summary>
        public int Count { 
            get { return list.Count; } 
        }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instance of the ListManager class. 
        /// </summary>
        public ListManager()
        {
            list = new List<T>();
        }
        #endregion

        #region METHODS
        #region List Management
        /// <summary>
        /// Adds a new object to the list
        /// </summary>
        /// <param name="type"></param>
        /// <returns>True if method is addition is successful</returns>
        public bool Add(T type)
        {
            bool addOK = false;
            if (type != null)
            {
                list.Add(type);
                addOK = true;
            }
            return addOK;
        }

        /// <summary>
        /// Replace an object ina given position with a new object
        /// </summary>
        /// <param name="type"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ChangeAt(T type, int index)
        {
            bool changeOK = false;
            if (type != null && CheckIndex(index))
            {
                list[index] = type; 
                changeOK = true;
            }
            return changeOK;
        }

        /// <summary>
        /// Checks if given index is within the valid range of the collection.
        /// </summary>
        /// <param name="index">Index to be checked.</param>
        /// <returns>True if index is within valid range.</returns>
        public bool CheckIndex(int index)
        {
            bool indexOK = false;
            if (index >= 0 && index < Count)
            {
                indexOK = true;
            }
            return indexOK;
        }

        /// <summary>
        /// Removes all items in list
        /// </summary>
        public void DeleteAll()
        {
            list.Clear();
        }

        /// <summary>
        /// Removes item at a certain position in list
        /// </summary>
        /// <param name="index">Position in list</param>
        /// <returns>True if method succeded</returns>
        public bool DeleteAt(int index)
        {
            bool deleteOK = false;
            if (index >= 0)
            {
                list.RemoveAt(index);
                deleteOK = true;
            }
            return deleteOK;
        }

        /// <summary>
        /// Returns object from a certaion position in list
        /// </summary>
        /// <param name="index">Position in list</param>
        /// <returns>Object</returns>
        public T GetAt(int index)
        {
            return list[index];
        }
        #endregion

        #region String Representations
        /// <summary>
        /// Converts the elements in the list to an array of strings
        /// </summary>
        /// <returns>An array of strings representing the elements in list</returns>
        public string[] ToStringArray()
        {
            string[] array = list.Select(item => item.ToString()).ToArray();
            return array;
        }

        /// <summary>
        /// Converts the elements in the list to a list of strings
        /// </summary>
        /// <returns>A list of strings representing the elements in list</returns>
        public List<string> ToStringList()
        {
            List<string> stringList = list.Select(item => item.ToString()).ToList();
            //List<string> stringList = list.Select(item => item.ToString() + "\n").ToList();
            return stringList;
        }
        #endregion
        #endregion
    }
}
