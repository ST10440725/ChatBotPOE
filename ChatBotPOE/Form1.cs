using System;
using System.Media;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualBasic;

namespace ChatBotPOE
{

    public partial class Form1 : Form
    {
        private bool tabTasksEnabled = false;
        private bool tabQuizEnabled = false;

        public string username = "";
        List<TaskClass> ListTask = new List<TaskClass>();
        Boolean boolTaskCompleted;

        int iCurrentQuestion = 0;
        int iScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richtxtChatResponses_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabMain.TabPages.Remove(tabTasks);    //disable the Tasks tab on load
            TabMain.TabPages.Remove(TabQuiz);     //disable the Quiz tab on load
            getQuestions();                       //load the first question of the quiz
            // Initialize components and set default states
            richtxtChatResponses.Enabled = false;      // disable chat responses on load
            txtUserResponse.Enabled = false;           // disable user response input on load
            btnSendUserResponse.Enabled = false;       // disable send button on load
            // Set initial focus on username input
            txtUserName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = txtUserName.Text.Trim();         // Get the username from the input field
            if (username.Length == 0)                   // Check if username is empty
            {
                MessageBox.Show("Please enter your name to start the chatbot.");       // Show message if username is empty
                return; // Exit the method if username is empty
            }
            else           //if username is provided proceed with the chatbot
            {
                // Enable interaction components
                richtxtChatResponses.Enabled = true;
                txtUserResponse.Enabled = true;
                btnSendUserResponse.Enabled = true;

                // Greet user with sound and message
                PlayGreetingSound();
                DisplayTextGreeting(username);
            }

        }

        // Method to play greeting sound
        private void PlayGreetingSound()
        {
            using (SoundPlayer player = new SoundPlayer("VoiceGreeting.wav")) //
            {
                player.PlaySync();//method to ensure the sound file is played before the program carries on
            }

        }

        // Method to display text greeting in rich text box
        private void DisplayTextGreeting(string username)
        {
            richtxtChatResponses.Clear();   // Clear previous chat responses
            richtxtChatResponses.Font = new Font("Consolas", 10);   // Changig the font to Consolas for better readability

            richtxtChatResponses.SelectionColor = Color.Red;
            richtxtChatResponses.AppendText(
        @"=================================================
||                   ___                       ||
||                  /   \                      ||
||                 |     |                     ||
||                 |     |                     ||
||                __________                   ||
||               |    _     |                  ||
||               |   / \    |                  ||
||               |   \ /    |                  ||
||               |   ||     |                  ||
||               |    -     |                  ||
||                ----------                   ||
||                                             ||
=================================================
\                                               /
=================================================
");

            richtxtChatResponses.SelectionColor = Color.Green;
            richtxtChatResponses.AppendText("Hello! I'm your Cybersecurity Awareness Bot.\n");

            richtxtChatResponses.SelectionColor = System.Drawing.Color.Magenta;
            richtxtChatResponses.AppendText($"Welcome {username}! Let's explore the world of cybersecurity together!\n");

            richtxtChatResponses.SelectionColor = Color.Green;
            richtxtChatResponses.AppendText($"What can I assist you with today, {username}?\n");
        }

        private void btnSendUserResponse_Click(object sender, EventArgs e)
        {
            string input = txtUserResponse.Text.Trim();

            if (input.Length == 0)
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            // Show user's message in the chat box
            richtxtChatResponses.SelectionColor = Color.Blue;
            richtxtChatResponses.AppendText("You: " + input + "\n");

            // Call chatbot logic
            Conversation.BasicResponseSystem(username, input, richtxtChatResponses, TabMain, tabTasks, TabQuiz, ref tabTasksEnabled, ref tabQuizEnabled);


            // Clear user input
            txtUserResponse.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text) || string.IsNullOrWhiteSpace(txtTaskDescription.Text)) // checking if the task name and description are empty
            {
                MessageBox.Show("Please fill in both task name and description.");
                return;
            }
            else
            {
                var task = new TaskClass()     //creating a new task object with the provided name, description and reminder
                {
                    Name = txtTaskName.Text.Trim(),
                    Description = txtTaskDescription.Text.Trim(),
                    Reminder = dtpReminder.Value
                };
                ListTask.Add(task);           // adding the task to the ListTask list
                lstTasks.Items.Add(task);       // adding the task to the listbox
                MessageBox.Show("Task added successfully!");
            }
            ActivityLog.AddEntry($"User added task: {txtTaskName.Text.Trim()}");  // Log the addition in the activity log
        }

        //method to delete a task
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)   // Check if a task is selected
            {
                var selectedTask = (TaskClass)lstTasks.SelectedItem;   // Cast the selected item to TaskClass
                ListTask.Remove(selectedTask);                         // Remove the task from the ListTask list
                lstTasks.Items.Remove(selectedTask);                   // Remove the task from the listbox
                MessageBox.Show("Task deleted successfully!");
                //Log the deletion in the activity log
                ActivityLog.AddEntry($"User deleted task: {selectedTask.Name}");
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }

        }
        // Method to mark a task as completed
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItems != null)                 // Check if a task is selected
            {
                var selectedTask = (TaskClass)lstTasks.SelectedItem;    // Cast the selected item to TaskClass
                selectedTask.IsCompleted = true;                        // Mark the task as completed

                //log the completion in the activity log
                ActivityLog.AddEntry($"User marked task as completed: {selectedTask.Name}");

                int index = lstTasks.SelectedIndex;      //recording the index of the selected task
                lstTasks.Items.RemoveAt(index);             //removing the task to add back with the updated completed field
                lstTasks.Items.Insert(index, selectedTask);
                MessageBox.Show("Task marked as completed!");
            }
            else
            {
                MessageBox.Show("Please select a task to mark as completed.");
            }
        }

        private void Quiz_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //method to load the quiz questions in the label and answers in the radio buttons
        private void getQuestions()
        {
            var q = QuizQuestions.Questions[iCurrentQuestion];    //variable q to hold the current question based on the iCurrentQuestion index
            lblQuestion.Text = q.Question;   //loading the question in the label
            rb1.Text = q.Options[0];         //loadign the answers in the radio buttons
            rb2.Text = q.Options[1];
            rb3.Text = q.Options[2];
            rb4.Text = q.Options[3];
        }


        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            int iselected = -1; //auto initializing the selected answer index to -1 to check if an answer is selected

            if (rb1.Checked == true)
            {
                iselected = 0;
            }
            else if (rb2.Checked == true)
            {
                iselected = 1;
            }
            else if (rb3.Checked == true)
            {
                iselected = 2;
            }
            else if (rb4.Checked == true)
            {
                iselected = 3;
            }
            else
            {
                MessageBox.Show("Please select an answer before proceeding to the next question.");
                return;
            }

            if (iselected == QuizQuestions.Questions[iCurrentQuestion].CorrectAnswerIndex)    //if the selected answer is the same as the correct answer index
            {
                iScore++;
                lblFeedback.ForeColor = Color.Green; //change the feedback label color to green for correct answer
                lblFeedback.Text = "Correct! " + QuizQuestions.Questions[iCurrentQuestion].explanation;  // correct answer feedback
            }
            else
            {
                lblFeedback.ForeColor = Color.Red; //change the feedback label color to red for wrong answer
                lblFeedback.Text = "Incorrect! " + QuizQuestions.Questions[iCurrentQuestion].explanation;  //wrong answer feedback
            }

            iCurrentQuestion++;    //incrementing the current question index
            if (iCurrentQuestion < QuizQuestions.Questions.Count)    // //if the current question index is less than the total number of questions to make sure that the end of the quiz is not reached
            {
                getQuestions();
            }
            else //if the end of the quiz is reached
            {
                lblScore.Text = ($"Quiz completed! Your score is {iScore} out of {QuizQuestions.Questions.Count}.");
                //Activity log
                ActivityLog.AddEntry($"User completed the quiz with a score of {iScore} out of {QuizQuestions.Questions.Count}.");

                if (iScore < 5)
                {
                    lblScoreFeedback.Text = "Almost there! With a little more practice you'll be a pro in no time!.";
                }
                else if (iScore > 5)
                {
                    lblScoreFeedback.Text = "Great job! You have a solid understanding of cybersecurity!";
                }
                ;

                iCurrentQuestion = 0; //reset the current question index to 0
                iScore = 0;           //reset the score to 0
                getQuestions();       //call the getQuestions method to load the first question again
            }

        }
    }
}
