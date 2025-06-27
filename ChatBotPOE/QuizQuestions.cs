using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotPOE
{
    class QuizQuestions
    {
        public string Question { get; set; }
        public string[] Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public string explanation { get; set; }

       public static List<QuizQuestions> Questions = new List<QuizQuestions>()
        {
            new QuizQuestions
            {
                   Question = "What makes a strong password?",
                   Options = new string[] {"Your birthday", "A mix of numbers letters and symbols", "Just lowercase letters", "Just Numbers"},
                   CorrectAnswerIndex = 1,
                   explanation = "A mix of numbers are significantly more difficult to guess"
            },
            new QuizQuestions
            {
                   Question = "What should you do if you receive a suspicious email?",
                   Options = new string[] {"Click on it", "Share it", "Report it", "Delete it"},
                   CorrectAnswerIndex = 3,
                   explanation = "Any suspicious email of this type should be deleted immediately"
            },
            new QuizQuestions
            {
                   Question = "How should you store your passwords?",
                   Options = new string[] {"A page", "On your phone", "Sticky note", "Password manager"},
                   CorrectAnswerIndex = 3,
                   explanation = "A password manager is eessential for protectign all your passwords"
            },
            new QuizQuestions
            {
                   Question = "What is phishing?",
                   Options = new string[] {"Antivirus","a Video-game","A scam" , "a recovery tool"},
                   CorrectAnswerIndex = 2,
                   explanation = "Phishing is a type of scam where they trick you to reveal personal information"
            },
            new QuizQuestions
            {
                   Question = "Should you use the same password for all your accounts?",
                   Options = new string[] {"No", "Doesn't matter", "Yes", "sometimes"},
                   CorrectAnswerIndex = 0,
                   explanation = "If an attacker guesses one password he has access to all your accountS?"
            },
            new QuizQuestions
            {
                   Question = "Why what should you avoid doing when on public wifi?",
                   Options = new string[] {"Handle personal information", "Watch videos", "Listen to music", "take pictures"},
                   CorrectAnswerIndex = 0,
                   explanation = "Any information you handle on public wifi can be intercepted"
            },
            new QuizQuestions
            {
                   Question = "What is social engineering?",
                   Options = new string[] {"Coding for a business", "Web designing as a profession","Tricking people to reveal personal info", "Programming robots"},
                   CorrectAnswerIndex = 3,
                   explanation = "Social engineering is when attackers trick you to reveal personal infromation"
            },
            new QuizQuestions
            {
                   Question = "If a stranger asks for personal infromation what should you do?",
                   Options = new string[] {"disengage immediately", "Give the information", "Entertain them", "Say you'll get back to them"},
                   CorrectAnswerIndex = 0,
                   explanation = "Avoiding these peoples tricks are very important for your safety"
            },
            new QuizQuestions
            {
                   Question = "What does 'https://' mean?",
                   Options = new string[] {"Site is secure", "Site is entertaining", "Site is fake", "You should leave immediately"},
                   CorrectAnswerIndex = 0,
                   explanation = "https:// means the site is safe for browsing!"
            },
            new QuizQuestions
            {
                   Question = "Which of the following is a sign of phishing message",
                   Options = new string[] {"Says your account is safe", "apologises for the inconvenience", "Asks for password or credit card information", "Written with no misspelled words"},
                   CorrectAnswerIndex = 2,
                   explanation = "Any message askign for credit card or password information is a sign of a scam!"
            }
         };

    }
}


    
