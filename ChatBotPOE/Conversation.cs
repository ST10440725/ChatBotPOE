using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChatBotPOE
{
    class Conversation
    {
        // Static lists of tips for each topic
        static List<string> LPasswordSafetyTips = new List<string>()
        {
            "Make sure to combine letters, numbers and symbols to create a complex password.",
            "Avoid using personal information that can be easily identified.",
            "Avoid repeating passwords on several accounts. Make each password unique."
        };

        static List<string> lPhishingTips = new List<string>()
        {
            "Be cautious of emails or messages that ask for personal information.",
            "Check the sender's email address to ensure it is legitimate.",
            "Do not click on links or download attachments from unknown sources."
        };

        static List<string> lSafeBrowsingTips = new List<string>()
        {
            "Make sure the website you are visiting is safe and secure.",
            "Look for 'https://' in the URL, which indicates a secure connection.",
            "Avoid clicking on links from suspicious sources or pop-up ads."
        };

        //Enum to track current and interested topics
        enum Topic { None, Password, Phishing, SafeBrowsing } // enum to represent topics
        static Topic currentTopic = Topic.None;    //topic the bot is currently discussing
        static Topic interestedTopic = Topic.None;  //topic the user has shown interest in
        static bool bSHowedInterest = false;         //flag to track if the user has shown interest in a topic
        static bool ShowedRecentActivityLog = false; // Flag to track if recent activity log was shown

        public static void BasicResponseSystem(string username, string input, RichTextBox chatBox, TabControl tabControl, TabPage tabTasks, TabPage tabQuiz, ref bool taskTabEnabled, ref bool quizTabEnabled)
        {
            input = input.Trim().ToLower();            //variable to hold the user input

            void BotResponses(string message, Color color, bool DisplayPrompt = true)   //method for the bot responses
            {
                chatBox.SelectionColor = color;
                chatBox.AppendText(message + "\n");

                //if statement to check if the bot must display the prompt
                if (DisplayPrompt)
                {
                    chatBox.SelectionColor = Color.Green;
                    chatBox.AppendText($"What can I assist you with today, {username}?\n");
                }
            }

            if (string.IsNullOrEmpty(input))  //if the input is null or empty
            {
                BotResponses("Please enter a valid question!", Color.Green);
                return;
            }

            if (input == "stop")
            {
                BotResponses($"Goodbye {username}, please stay safe online!", Color.Green);
                return;
            }

            if (input.Contains("how are you"))
            {
                BotResponses($"I am doing great, thank you for asking {username}.", Color.Green);
                return;
            }

            if (input.Contains("purpose"))
            {
                BotResponses($"I am here to help raise your cybersecurity awareness, {username}. I'm all ears!", Color.Green);
                return;
            }

            if (input.Contains("what can i ask"))
            {
                BotResponses($"You can ask me about password safety, phishing, and safe browsing, {username}.", Color.Green);
                return;
            }

            //show acitivty log
            if (input.Contains("activity log") || input.Contains("what have you done"))
            {
                BotResponses("Here's a summary of recent actions:", Color.Green,false);
                List<string> recentEntries = ActivityLog.getRecentEntries();
               
                if (recentEntries.Count == 0)
                {
                    BotResponses("No activity logged yet.", Color.Green);
                    return;
                }
                else
                {
                    foreach (var entry in recentEntries)
                    {
                        BotResponses(entry, Color.Green,false);
                    }

                    if (ActivityLog.LogEntries.Count > 10)
                    {
                        BotResponses("Type 'show more' if you'd like to see the full activity log", Color.Green, false);
                        ShowedRecentActivityLog = true;
                    }
                }
                chatBox.SelectionColor = Color.Green;
                chatBox.AppendText($"What can I assist you with today, {username}?\n");
                return;
            }

            if (input.Contains("show more"))
            {
                if (ShowedRecentActivityLog)
                {

                    chatBox.SelectionColor = Color.Green;
                    BotResponses("Here are all the activity log entries:\n", Color.Green, false);

                    foreach (var entry in ActivityLog.LogEntries)
                    {
                        BotResponses(entry, Color.Green, false);
                    }
                    ShowedRecentActivityLog = false; // Reset the flag after showing the full log
                    chatBox.SelectionColor = Color.Green;
                    chatBox.AppendText($"What can I assist you with today, {username}?\n");
                }
                else
                {
                    BotResponses("Before you can view the full activity log, make sure to view the recent activity log first.", Color.Green);
                }
                return;
            }

                //if the user asks to add a task, the task tab will be enabled and the user will be directed to the tab
                if (input.Contains("add task") && !taskTabEnabled)
                {
                    BotResponses($"The quiz tab has been enabled for you to take the quiz, please return to me when you are done", Color.Green);
                    tabControl.TabPages.Add(tabTasks);
                    tabControl.SelectedTab = tabTasks;
                    taskTabEnabled = true;
                    ActivityLog.AddEntry($"User asked to manage tasks");
                    return;
                }
                //if the user asks about tasks
                if (input.Contains("task"))
                {
                    BotResponses(username + ", I can help you manage tasks. Please specify if you'd like to add a task.",Color.Green);
                return;
                }
                //if the user asks to take a quiz the quiz tab will be enabled and the user will be directed to the tab
                if (input.Contains("quiz") && !quizTabEnabled)
                {
                    BotResponses($"The quiz tab has been enabled for you handle tasks, please return to me when you are done", Color.Green);
                    tabControl.TabPages.Add(tabQuiz);
                    tabControl.SelectedTab = tabQuiz;
                    quizTabEnabled = true;
                    ActivityLog.AddEntry($"User asked to take the quiz");
                    return;

                }

                //code to check if the user is interested in a topic
                //-----------------------------start of interested code-----------------------------
                if (input.Contains("interested"))
                {
                    bSHowedInterest = true;
                    if (input.Contains("password"))
                    {
                        interestedTopic = Topic.Password;
                        BotResponses("Great! I'll remember your interest in password safety. It's a crucial yet simple part of online safety.", Color.Green);
                    }
                    else if (input.Contains("phishing"))
                    {
                        interestedTopic = Topic.Phishing;
                        BotResponses("Got you! I'll remember your interest in phishing.", Color.Green);
                    }
                    else if (input.Contains("safe browsing"))
                    {
                        interestedTopic = Topic.SafeBrowsing;
                        BotResponses("Noted! I'll remember your interest in safe browsing.", Color.Green);
                    }
                    return;
                }
                //------------------------------end of interested code------------------------------

                // ---------------------------start of sentiment analysis---------------------------
                if ((input.Contains("password") || input.Contains("phishing") || input.Contains("safe browsing")) &&
                    (input.Contains("worried") || input.Contains("curious") || input.Contains("frustrated")))
                {
                    string sentimentResponse = "";

                    if (input.Contains("password"))
                    {
                        if (input.Contains("worried"))
                            sentimentResponse = "It's normal to feel worried about passwords. Want some tips?";
                        else if (input.Contains("curious"))
                            sentimentResponse = "I admire your curiosity about password safety! Want tips?";
                        else if (input.Contains("frustrated"))
                            sentimentResponse = "Feeling frustrated with passwords? I can help with that.";
                    }
                    else if (input.Contains("phishing"))
                    {
                        if (input.Contains("worried"))
                            sentimentResponse = "Phishing can be scary, but I can show you how to avoid it.";
                        else if (input.Contains("curious"))
                            sentimentResponse = "Curious about phishing? I’ve got great safety tips.";
                        else if (input.Contains("frustrated"))
                            sentimentResponse = "Frustrated with phishing threats? Let's tackle them.";
                    }
                    else if (input.Contains("safe browsing"))
                    {
                        if (input.Contains("worried"))
                            sentimentResponse = "Worried about safe browsing? Let's make it easier.";
                        else if (input.Contains("curious"))
                            sentimentResponse = "Curious about safe browsing? I'll guide you.";
                        else if (input.Contains("frustrated"))
                            sentimentResponse = "I get that. Safe browsing can be confusing, let me help.";
                    }
                BotResponses(sentimentResponse, Color.Green);
                return;
                }
                //------------------------------end of sentiment analysis-----------------------------

                //--------------------------start of basic keyword detection--------------------------
                if (input.Contains("password"))
                {
                    currentTopic = Topic.Password;
                    BotResponses(LPasswordSafetyTips[new Random().Next(LPasswordSafetyTips.Count)], Color.Green);
                    return;
                }

                if (input.Contains("phishing"))
                {
                    currentTopic = Topic.Phishing;
                    BotResponses(lPhishingTips[new Random().Next(lPhishingTips.Count)], Color.Green);
                    return;
                }

                if (input.Contains("safe browsing"))
                {
                    currentTopic = Topic.SafeBrowsing;
                    BotResponses(lSafeBrowsingTips[new Random().Next(lSafeBrowsingTips.Count)], Color.Green);
                    return;
                }
                //-----------------------------end of basic keyword detection-----------------------------

                //---------------if the user asks for more information on the current topic---------------
                if (input.Contains("more"))
                {
                    switch (currentTopic)
                    {
                        //based off the current topic the bot will respond with a random tip from the list
                        case Topic.Password:
                            BotResponses(LPasswordSafetyTips[new Random().Next(LPasswordSafetyTips.Count)], Color.Green);
                            break;
                        case Topic.Phishing:
                            BotResponses(lPhishingTips[new Random().Next(lPhishingTips.Count)], Color.Green);
                            break;
                        case Topic.SafeBrowsing:
                            BotResponses(lSafeBrowsingTips[new Random().Next(lSafeBrowsingTips.Count)], Color.Green);
                            break;
                        default:
                            BotResponses("Please ask about password safety, phishing or safe browsing first.", Color.Green);
                            break;
                    }
                    return;
                }

                //Error message for unrecognized input
                BotResponses("I am unsure how to respond to that. Could you please rephrase?", Color.Green);
                //if the user has shown interest in a topic, the bot will respond with a message based on the topic
                if (bSHowedInterest)
                {
                    switch (interestedTopic)
                    {
                        //based off the interested topic the bot will respond with a message related to that topic
                        case Topic.Password:
                            BotResponses("Since you're interested in password safety, I can provide more tips!", Color.Green);
                            break;
                        case Topic.Phishing:
                            BotResponses("Since you're interested in phishing, I can share some precautions.", Color.Green);
                            break;
                        case Topic.SafeBrowsing:
                            BotResponses("Interested in safe browsing? I’ll guide you through it!", Color.Green);
                            break;
                    }
                    bSHowedInterest = false;
                }
            
        }
    }
}
