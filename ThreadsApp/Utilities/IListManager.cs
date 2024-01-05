namespace Assignment4.General
{
    /// <summary>
    /// Represents a generic list manager interface for managing a collection
    /// of type T. Provides methods to add, change, delete, and retrieve objects 
    /// from the collection. 
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection.</typeparam>
   public interface IListManager<T>
    {
        #region PROPERTIES
        /// <summary>
        /// Returns the number of items in the collection 'list'
        /// </summary>
        int Count { get; }
        #endregion

        #region METHODS
        /// <summary>
        /// Adds an object to the collection 'list'
        /// </summary>
        /// <param name="type">A type</param>
        /// <returns>True if method is successful</returns>
        bool Add(T type);

        /// <summary>
        /// Changes the object at a given position in collection 'list'
        /// </summary>
        /// <param name="type">a type</param>
        /// <param name="index">Position in list</param>
        /// <returns>True if method is successful</returns>
        bool ChangeAt(T type, int index);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        bool CheckIndex(int index);

        /// <summary>
        /// Deletes all objects in list
        /// </summary>
        void DeleteAll();

        /// <summary>
        /// Deletes object at given position in list
        /// </summary>
        /// <param name="index">Position in list</param>
        /// <returns>True if method is successful</returns>
        bool DeleteAt(int index);

        /// <summary>
        /// Returns an object at a given position in list
        /// </summary>
        /// <param name="index">Position in list</param>
        /// <returns>Object</returns>
        T GetAt(int index);
        
        /// <summary>
        /// Converts the elements in the list to an array of strings
        /// </summary>
        /// <returns>An array of strings representing the elements in list</returns>
        string[] ToStringArray();

        /// <summary>
        /// Converts the elements in the list to a list of strings
        /// </summary>
        /// <returns>A list of strings representing the elements in list</returns>
        List<string> ToStringList();
        #endregion
    }
}
