namespace ThreadsApp
{
    /// <summary>
    /// Represents the main form of the application. 
    /// </summary>
    public partial class MainForm : Form
    {
        #region FIELDS
        private bool safeExit = false;
        private const int maxNumOfThreads = 4;
        TaskManager taskManager = null;
        private Thread musicThread = null;
        MusicPlayer musicPlayer = null;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            taskManager = new TaskManager(lstTasks);
            UpdateGUI();
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Updates the GUI by clearing task list and adding assets. 
        /// </summary>
        private void UpdateGUI()
        {
            lstTasks.Items.Clear();
            foreach (string asset in taskManager.ToStringArray())
            {
                lstTasks.Items.Add(asset.ToString());
            }
        }

        /// <summary>
        /// Adds a new asset to the task manager. 
        /// </summary>
        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            string itemName = txtName.Text;
            string description = txtDescription.Text;

            if (!string.IsNullOrWhiteSpace(itemName) && !string.IsNullOrWhiteSpace(description))
            {
                Asset newAsset = new Asset(itemName, description);
                taskManager.Add(newAsset);

                UpdateGUI();

                txtName.Clear();
                txtDescription.Clear();
            }
            else
            {
                MessageBox.Show("Please provide both item name and description.");
            }
        }

        /// <summary>
        /// Clears the input fields for a new asset. 
        /// </summary>
        private void btnResetAsset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDescription.Clear();
        }

        /// <summary>
        /// Plays background music using a separate thread.
        /// </summary>
        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            // If a music thread is not alive, create one
            if ((musicThread == null) || (!musicThread.IsAlive))
            {
                string fileName = Application.StartupPath + @"..\..\..\song.mp3";
                musicPlayer = new MusicPlayer(fileName);

                // select background music
                musicThread = new Thread(new ThreadStart(musicPlayer.Play));
                musicThread.IsBackground = true;
                musicThread.Start(); // Executes the thread
            }
            else
            {
                // If a thread is already alive, just call the Play method
                musicPlayer.Play();
            }
        }

        /// <summary>
        /// Stops the background music.
        /// </summary>
        private void btnStopMusic_Click(object sender, EventArgs e)
        {
            musicPlayer.Stop();
        }

        /// <summary>
        /// Starts multiple threads to execute the task manager's StartWorking method.
        /// </summary>
        private void btnStartThreads_Click(object sender, EventArgs e)
        {
            safeExit = false;

            for (int i = 0; i < maxNumOfThreads; i++)
            {
                // Each thread created will execute the StartWorking method
                ThreadStart threadStart = new ThreadStart(taskManager.StartWorking);
                Thread thread = new Thread(threadStart);
                thread.Name = "Member" + (i + 1).ToString();
                thread.Start();
            }
            taskManager.IsRunning = true;
        }

        /// <summary>
        /// Stops the execution of threads by setting the IsRunning property to false.
        /// </summary>
        private void btnStopThreads_Click(object sender, EventArgs e)
        {
            taskManager.IsRunning = false;
            safeExit = true;
        }
        #endregion
    }
}
