namespace ThreadsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstTasks = new ListBox();
            grpAddItem = new GroupBox();
            btnResetAsset = new Button();
            btnAddAsset = new Button();
            lblName = new Label();
            txtName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnStartThreads = new Button();
            btnStopThreads = new Button();
            btnPlayMusic = new Button();
            btnStopMusic = new Button();
            panel1 = new Panel();
            lblTitle = new Label();
            grpAddItem.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.Location = new Point(436, 87);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(622, 304);
            lstTasks.TabIndex = 0;
            // 
            // grpAddItem
            // 
            grpAddItem.Controls.Add(btnResetAsset);
            grpAddItem.Controls.Add(btnAddAsset);
            grpAddItem.Controls.Add(lblName);
            grpAddItem.Controls.Add(txtName);
            grpAddItem.Controls.Add(lblDescription);
            grpAddItem.Controls.Add(txtDescription);
            grpAddItem.Location = new Point(24, 77);
            grpAddItem.Name = "grpAddItem";
            grpAddItem.Size = new Size(394, 314);
            grpAddItem.TabIndex = 1;
            grpAddItem.TabStop = false;
            grpAddItem.Text = "Add Asset";
            // 
            // btnResetAsset
            // 
            btnResetAsset.BackColor = SystemColors.ActiveBorder;
            btnResetAsset.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResetAsset.ForeColor = SystemColors.ActiveCaptionText;
            btnResetAsset.Location = new Point(145, 251);
            btnResetAsset.Name = "btnResetAsset";
            btnResetAsset.Size = new Size(106, 41);
            btnResetAsset.TabIndex = 7;
            btnResetAsset.Text = "Reset Asset";
            btnResetAsset.UseVisualStyleBackColor = false;
            btnResetAsset.Click += btnResetAsset_Click;
            // 
            // btnAddAsset
            // 
            btnAddAsset.BackColor = SystemColors.GradientActiveCaption;
            btnAddAsset.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAsset.ForeColor = SystemColors.ActiveCaptionText;
            btnAddAsset.Location = new Point(273, 251);
            btnAddAsset.Name = "btnAddAsset";
            btnAddAsset.Size = new Size(106, 41);
            btnAddAsset.TabIndex = 6;
            btnAddAsset.Text = "Add Asset";
            btnAddAsset.UseVisualStyleBackColor = false;
            btnAddAsset.Click += btnAddAsset_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblName.Location = new Point(9, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(111, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name of Asset:";
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 27);
            txtName.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDescription.Location = new Point(9, 77);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(91, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(146, 79);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(230, 136);
            txtDescription.TabIndex = 4;
            // 
            // btnStartThreads
            // 
            btnStartThreads.BackColor = SystemColors.MenuHighlight;
            btnStartThreads.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartThreads.ForeColor = Color.White;
            btnStartThreads.Location = new Point(745, 420);
            btnStartThreads.Name = "btnStartThreads";
            btnStartThreads.Size = new Size(148, 48);
            btnStartThreads.TabIndex = 7;
            btnStartThreads.Text = "Start Threads";
            btnStartThreads.UseVisualStyleBackColor = false;
            btnStartThreads.Click += btnStartThreads_Click;
            // 
            // btnStopThreads
            // 
            btnStopThreads.BackColor = Color.Gray;
            btnStopThreads.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStopThreads.ForeColor = Color.White;
            btnStopThreads.Location = new Point(910, 419);
            btnStopThreads.Name = "btnStopThreads";
            btnStopThreads.Size = new Size(148, 48);
            btnStopThreads.TabIndex = 8;
            btnStopThreads.Text = "Stop Threads";
            btnStopThreads.UseVisualStyleBackColor = false;
            btnStopThreads.Click += btnStopThreads_Click;
            // 
            // btnPlayMusic
            // 
            btnPlayMusic.BackColor = Color.White;
            btnPlayMusic.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlayMusic.ForeColor = Color.Black;
            btnPlayMusic.Location = new Point(18, 9);
            btnPlayMusic.Name = "btnPlayMusic";
            btnPlayMusic.Size = new Size(120, 30);
            btnPlayMusic.TabIndex = 9;
            btnPlayMusic.Text = "Play Music";
            btnPlayMusic.UseVisualStyleBackColor = false;
            btnPlayMusic.Click += btnPlayMusic_Click;
            // 
            // btnStopMusic
            // 
            btnStopMusic.BackColor = Color.White;
            btnStopMusic.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStopMusic.ForeColor = Color.Black;
            btnStopMusic.Location = new Point(251, 9);
            btnStopMusic.Name = "btnStopMusic";
            btnStopMusic.Size = new Size(120, 30);
            btnStopMusic.TabIndex = 10;
            btnStopMusic.Text = "Stop Music";
            btnStopMusic.UseVisualStyleBackColor = false;
            btnStopMusic.Click += btnStopMusic_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnPlayMusic);
            panel1.Controls.Add(btnStopMusic);
            panel1.Location = new Point(25, 420);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 47);
            panel1.TabIndex = 9;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(409, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(306, 38);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Family Asset Manager";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 498);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Controls.Add(btnStopThreads);
            Controls.Add(btnStartThreads);
            Controls.Add(grpAddItem);
            Controls.Add(lstTasks);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MainForm";
            Text = "MainForm";
            grpAddItem.ResumeLayout(false);
            grpAddItem.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTasks;
        private GroupBox grpAddItem;
        private Label lblName;
        private Label lblDescription;
        private TextBox txtDescription;
        private TextBox txtName;
        private Button btnAddAsset;
        private Button btnStartThreads;
        private Button btnStopThreads;
        private Button btnPlayMusic;
        private Button btnStopMusic;
        private Panel panel1;
        private Button btnResetAsset;
        private Label lblTitle;
    }
}
