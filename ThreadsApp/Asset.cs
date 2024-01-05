namespace ThreadsApp
{
    /// <summary>
    /// Represents an asset that can be borrowed or returned. 
    /// </summary>
    internal class Asset
    {
        #region FIELDS
        private object lockObj = new object(); // Lock used to synchronize the data
        #endregion

        #region PROPERTIES
        public string ItemName {  get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
        public string LoanerName { get; set; }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instanceof the Asset class.
        /// </summary>
        /// <param name="name">The name of the asset.</param>
        /// <param name="description">The decsription of the asset. </param>
        public Asset(string name, string description)
        {
            ItemName = name;
            IsAvailable = true;
            Description = description;
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Borrows the asset, updating its status and details.
        /// </summary>
        /// <param name="personName">The name of the person borrowing.</param>
        /// <returns>True if the borrowing process is successful; otherwise false.</returns>
        public bool Borrow(string personName)
        {
            Console.WriteLine("Borrow: Entering the loop");

            bool processed = false;
            lock (lockObj)
            {
                Console.WriteLine("Borrow: Inside the lock block");

                Console.WriteLine("Borrow: IsAvailable before: " + IsAvailable);

                if (IsAvailable)
                {
                    Description = $"{ItemName} is now being used by {personName}";
                    LoanerName = personName;
                    IsAvailable = false;
                    processed = true;
                }

                Console.WriteLine("Borrow: IsAvailable after: " + IsAvailable);

            }

            Console.WriteLine("Borrow: Exiting the method. Processed: " + processed);

            return processed;
        }

        /// <summary>
        /// Returns the borrowed asset, updating its status and details.
        /// </summary>
        /// <param name="personName">The name of the person returning.</param>
        /// <returns>True if the return process is successful; otherwise false.</returns>
        public bool Return(string personName)
        {
            Console.WriteLine("Return: Entering the loop");

            bool processed = false;
            lock (lockObj)
            {
                Console.WriteLine("IsAvailable: " + IsAvailable);

                if ((!IsAvailable) && (personName == LoanerName))
                {
                    LoanerName = "";
                    Description = $"{ItemName} returned by {personName}";
                    IsAvailable = true;
                    processed = true;
                }
            }
            return processed;
        }

        public override string ToString()
        {
            string strAvailable = IsAvailable ? "Available" : "Not Available";
            string text = $"{ItemName,-20}{Description,-20}{strAvailable}";
            return text;
        }
        #endregion
    }
}
