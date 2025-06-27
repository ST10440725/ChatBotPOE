namespace ChatBotPOE
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            TabMain = new TabControl();
            tabChat = new TabPage();
            btnStartChatbot = new Button();
            txtUserName = new TextBox();
            lblName = new Label();
            btnSendUserResponse = new Button();
            txtUserResponse = new TextBox();
            richtxtChatResponses = new RichTextBox();
            tabTasks = new TabPage();
            btnCompleted = new Button();
            label7 = new Label();
            btnDeleteTask = new Button();
            btnAddTask = new Button();
            label5 = new Label();
            lstTasks = new ListBox();
            label4 = new Label();
            label3 = new Label();
            dtpReminder = new DateTimePicker();
            txtTaskDescription = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtTaskName = new TextBox();
            TabQuiz = new TabPage();
            lblScoreFeedback = new Label();
            label8 = new Label();
            lblScore = new Label();
            lblFeedback = new Label();
            btnNextQuestion = new Button();
            rb4 = new RadioButton();
            rb2 = new RadioButton();
            rb3 = new RadioButton();
            lblQuestion = new Label();
            rb1 = new RadioButton();
            btnQuestion = new Label();
            label6 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            TabMain.SuspendLayout();
            tabChat.SuspendLayout();
            tabTasks.SuspendLayout();
            TabQuiz.SuspendLayout();
            SuspendLayout();
            // 
            // TabMain
            // 
            TabMain.Controls.Add(tabChat);
            TabMain.Controls.Add(tabTasks);
            TabMain.Controls.Add(TabQuiz);
            TabMain.Location = new Point(0, 0);
            TabMain.Name = "TabMain";
            TabMain.SelectedIndex = 0;
            TabMain.Size = new Size(904, 486);
            TabMain.TabIndex = 0;
            // 
            // tabChat
            // 
            tabChat.Controls.Add(btnStartChatbot);
            tabChat.Controls.Add(txtUserName);
            tabChat.Controls.Add(lblName);
            tabChat.Controls.Add(btnSendUserResponse);
            tabChat.Controls.Add(txtUserResponse);
            tabChat.Controls.Add(richtxtChatResponses);
            tabChat.Location = new Point(4, 24);
            tabChat.Name = "tabChat";
            tabChat.Padding = new Padding(3);
            tabChat.Size = new Size(896, 458);
            tabChat.TabIndex = 0;
            tabChat.Text = "Chat";
            tabChat.UseVisualStyleBackColor = true;
            // 
            // btnStartChatbot
            // 
            btnStartChatbot.Location = new Point(188, 31);
            btnStartChatbot.Name = "btnStartChatbot";
            btnStartChatbot.Size = new Size(112, 23);
            btnStartChatbot.TabIndex = 8;
            btnStartChatbot.Text = "Start Chatbot";
            btnStartChatbot.UseVisualStyleBackColor = true;
            btnStartChatbot.Click += button1_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(22, 31);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(160, 23);
            txtUserName.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 13);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Enter your Name:";
            // 
            // btnSendUserResponse
            // 
            btnSendUserResponse.Location = new Point(482, 399);
            btnSendUserResponse.Name = "btnSendUserResponse";
            btnSendUserResponse.Size = new Size(90, 23);
            btnSendUserResponse.TabIndex = 5;
            btnSendUserResponse.Text = "Send Message";
            btnSendUserResponse.UseVisualStyleBackColor = true;
            btnSendUserResponse.Click += btnSendUserResponse_Click;
            // 
            // txtUserResponse
            // 
            txtUserResponse.Location = new Point(23, 400);
            txtUserResponse.Name = "txtUserResponse";
            txtUserResponse.Size = new Size(453, 23);
            txtUserResponse.TabIndex = 4;
            // 
            // richtxtChatResponses
            // 
            richtxtChatResponses.Location = new Point(23, 85);
            richtxtChatResponses.Name = "richtxtChatResponses";
            richtxtChatResponses.Size = new Size(630, 264);
            richtxtChatResponses.TabIndex = 0;
            richtxtChatResponses.Text = "";
            richtxtChatResponses.TextChanged += richtxtChatResponses_TextChanged;
            // 
            // tabTasks
            // 
            tabTasks.Controls.Add(btnCompleted);
            tabTasks.Controls.Add(label7);
            tabTasks.Controls.Add(btnDeleteTask);
            tabTasks.Controls.Add(btnAddTask);
            tabTasks.Controls.Add(label5);
            tabTasks.Controls.Add(lstTasks);
            tabTasks.Controls.Add(label4);
            tabTasks.Controls.Add(label3);
            tabTasks.Controls.Add(dtpReminder);
            tabTasks.Controls.Add(txtTaskDescription);
            tabTasks.Controls.Add(label2);
            tabTasks.Controls.Add(label1);
            tabTasks.Controls.Add(txtTaskName);
            tabTasks.Location = new Point(4, 24);
            tabTasks.Name = "tabTasks";
            tabTasks.Padding = new Padding(3);
            tabTasks.Size = new Size(896, 458);
            tabTasks.TabIndex = 1;
            tabTasks.Text = "Task";
            tabTasks.UseVisualStyleBackColor = true;
            // 
            // btnCompleted
            // 
            btnCompleted.Location = new Point(230, 201);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(135, 40);
            btnCompleted.TabIndex = 17;
            btnCompleted.Text = "Set task to completed";
            btnCompleted.UseVisualStyleBackColor = true;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(17, 12);
            label7.Name = "label7";
            label7.Size = new Size(331, 37);
            label7.TabIndex = 16;
            label7.Text = "Welcome to task manager:";
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(119, 201);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(105, 40);
            btnDeleteTask.TabIndex = 15;
            btnDeleteTask.Text = "Delete task";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(8, 201);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(105, 40);
            btnAddTask.TabIndex = 14;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(399, 12);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 10;
            label5.Text = "All tasks:";
            label5.Click += label5_Click;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(399, 43);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(494, 409);
            lstTasks.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 157);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 8;
            label4.Text = "Enter reminder date:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 157);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "(optional)";
            // 
            // dtpReminder
            // 
            dtpReminder.Location = new Point(128, 155);
            dtpReminder.Name = "dtpReminder";
            dtpReminder.Size = new Size(200, 23);
            dtpReminder.TabIndex = 6;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(128, 108);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(237, 23);
            txtTaskDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 111);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 2;
            label2.Text = "Enter task description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 71);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter the task name:";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(128, 68);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(237, 23);
            txtTaskName.TabIndex = 0;
            // 
            // TabQuiz
            // 
            TabQuiz.Controls.Add(lblScoreFeedback);
            TabQuiz.Controls.Add(label8);
            TabQuiz.Controls.Add(lblScore);
            TabQuiz.Controls.Add(lblFeedback);
            TabQuiz.Controls.Add(btnNextQuestion);
            TabQuiz.Controls.Add(rb4);
            TabQuiz.Controls.Add(rb2);
            TabQuiz.Controls.Add(rb3);
            TabQuiz.Controls.Add(lblQuestion);
            TabQuiz.Controls.Add(rb1);
            TabQuiz.Controls.Add(btnQuestion);
            TabQuiz.Controls.Add(label6);
            TabQuiz.Location = new Point(4, 24);
            TabQuiz.Name = "TabQuiz";
            TabQuiz.Padding = new Padding(3);
            TabQuiz.Size = new Size(896, 458);
            TabQuiz.TabIndex = 2;
            TabQuiz.Text = "Quiz";
            TabQuiz.UseVisualStyleBackColor = true;
            TabQuiz.Click += Quiz_Click;
            // 
            // lblScoreFeedback
            // 
            lblScoreFeedback.AutoSize = true;
            lblScoreFeedback.Location = new Point(297, 203);
            lblScoreFeedback.Name = "lblScoreFeedback";
            lblScoreFeedback.Size = new Size(97, 15);
            lblScoreFeedback.TabIndex = 28;
            lblScoreFeedback.Text = "[Score Feedback]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(297, 149);
            label8.Name = "label8";
            label8.Size = new Size(65, 28);
            label8.TabIndex = 27;
            label8.Text = "Score:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 11F);
            lblScore.Location = new Point(297, 174);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(151, 20);
            lblScore.TabIndex = 26;
            lblScore.Text = "[User score out of 10]";
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Font = new Font("Segoe UI", 13F);
            lblFeedback.Location = new Point(25, 203);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(97, 25);
            lblFeedback.TabIndex = 25;
            lblFeedback.Text = "[Feedback]";
            // 
            // btnNextQuestion
            // 
            btnNextQuestion.Location = new Point(25, 231);
            btnNextQuestion.Name = "btnNextQuestion";
            btnNextQuestion.Size = new Size(130, 37);
            btnNextQuestion.TabIndex = 24;
            btnNextQuestion.Text = "Save and submit";
            btnNextQuestion.UseVisualStyleBackColor = true;
            btnNextQuestion.Click += btnNextQuestion_Click;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(25, 176);
            rb4.Name = "rb4";
            rb4.Size = new Size(78, 19);
            rb4.TabIndex = 23;
            rb4.Text = "[Answer4]";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(25, 140);
            rb2.Name = "rb2";
            rb2.Size = new Size(78, 19);
            rb2.TabIndex = 22;
            rb2.Text = "[Answer2]";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(25, 158);
            rb3.Name = "rb3";
            rb3.Size = new Size(78, 19);
            rb3.TabIndex = 21;
            rb3.Text = "[Answer3]";
            rb3.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 15F);
            lblQuestion.Location = new Point(25, 84);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(111, 28);
            lblQuestion.TabIndex = 20;
            lblQuestion.Text = "[Questions]";
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Checked = true;
            rb1.Location = new Point(25, 124);
            rb1.Name = "rb1";
            rb1.Size = new Size(78, 19);
            rb1.TabIndex = 19;
            rb1.TabStop = true;
            rb1.Text = "[Answer1]";
            rb1.UseVisualStyleBackColor = true;
            rb1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnQuestion
            // 
            btnQuestion.AutoSize = true;
            btnQuestion.Font = new Font("Segoe UI", 15F);
            btnQuestion.Location = new Point(25, 71);
            btnQuestion.Name = "btnQuestion";
            btnQuestion.Size = new Size(0, 28);
            btnQuestion.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(8, 20);
            label6.Name = "label6";
            label6.Size = new Size(433, 37);
            label6.TabIndex = 17;
            label6.Text = "Welcome to the Cybersecurity quiz:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 492);
            Controls.Add(TabMain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            TabMain.ResumeLayout(false);
            tabChat.ResumeLayout(false);
            tabChat.PerformLayout();
            tabTasks.ResumeLayout(false);
            tabTasks.PerformLayout();
            TabQuiz.ResumeLayout(false);
            TabQuiz.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabMain;
        private TabPage tabChat;
        private RichTextBox richtxtChatResponses;
        private TabPage tabTasks;
        private TabPage TabQuiz;
        private Button btnSendUserResponse;
        private TextBox txtUserResponse;
        private Button btnStartChatbot;
        private TextBox txtUserName;
        private Label lblName;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtTaskDescription;
        private Label label2;
        private Label label1;
        private TextBox txtTaskName;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpReminder;
        private Label label5;
        private ListBox lstTasks;
        private Label label7;
        private Button btnDeleteTask;
        private Button btnAddTask;
        private Button btnCompleted;
        private Label label6;
        private Label btnQuestion;
        private RadioButton rb1;
        private Button btnNextQuestion;
        private RadioButton rb4;
        private RadioButton rb2;
        private RadioButton rb3;
        private Label lblQuestion;
        private Label label8;
        private Label lblScore;
        private Label lblFeedback;
        private Label lblScoreFeedback;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
