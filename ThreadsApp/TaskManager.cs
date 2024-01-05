using Assignment4.General;

namespace ThreadsApp
{
    /// <summary>
    /// Manages a list of assets and performs operations on them in a multi-threaded environment.
    /// </summary>
    internal class TaskManager : ListManager<Asset>
    {
        #region FIELDS
        private object lockObj = new object();
        private Random random = new Random();
        private ListBox listBox; // control from the MainForm to update
        #endregion

        #region DELEGATE
        private delegate void MethodInvoker(); // delegate for invoking main thread
        #endregion

        #region PROPERTIES
        public bool IsRunning { get; set; } = true;
        public ListManager<Asset> AssetList { get; set; }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instance of the TaskManager class.
        /// </summary>
        /// <param name="listBox">The ListBox control from the MainForm for updating.</param>
        public TaskManager(ListBox listBox)
        {
            this.listBox = listBox;
            AssetList = new ListManager<Asset>();
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Starts the working loop, performing operations on assets in a multi-threaded manner.
        /// </summary>
        public void StartWorking()
        {
            try
            {
                // The method runs in a loop as long as "IsRunning" is true
                while (IsRunning)
                {
                    if (Count == 0)
                    {
                        IsRunning = false;
                        break;
                    }

                    // The thread sleeps for 2 seconds in each iteration
                    Thread.Sleep(2000);

                    // A random item is selected from list
                    int index = random.Next(0, Count);
                    Asset? item = GetAt(index);

                    string? member = Thread.CurrentThread.Name;

                    bool processed = false;

                    int randomNumber = random.Next(0, 2);

                    // The thread randomly decides whether to borrow or return the item
                    if (random.Next(0, 2) == 0)
                    {
                        processed = item.Borrow(member);
                    }
                    else
                    {
                        processed = item.Return(member);
                    }

                    // If the process is successful, a message is created and added to the 
                    // control in the UI. The update is done through "Invoke" to ensure it
                    // happens on the UI thread. 
                    if (processed)
                    {
                        listBox.Invoke((MethodInvoker)(() => listBox.Items.Add(item.ToString())));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in StartWorking: {ex.Message}");
            }
        }
        #endregion
    }
}
