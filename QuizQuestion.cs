using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;

namespace FireFun
{
    class QuizQuestion
    {

        private string question;
        private string correctAnswer;
        private string[] incorrectAnswers;
        private string[] answers;
        private bool donotsort;
        private string attribution;
        private Image image = Properties.Resources.question;
        private string imageURL = "";

        private RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider();

        public QuizQuestion(string question, object image, string correctAnswer, string[] incorrectAnswers, string attribution = "", bool donotsort = false)
        {
            this.question = question;
            this.correctAnswer = correctAnswer;
            this.incorrectAnswers = incorrectAnswers;
            this.donotsort = donotsort;
            if(image is Image)
            {
                this.image = (Image)image;
            } else if (image is string)
            {
                imageURL = (string)image;
                if (attribution == "") attribution = imageURL;
            }

            if (correctAnswer != null && incorrectAnswers != null)
            {
                List<string> list = new List<string>(incorrectAnswers);
                list.Add(correctAnswer);
                answers = list.ToArray();
                ShuffleAnswers();
            }

            this.attribution = attribution;
        }

        private void ShuffleAnswers()
        {
            if(!donotsort)
            {
                answers = answers.OrderBy(x => Next()).ToArray();
            } else
            {
                Array.Sort(answers);
            }
        } 

        public int Next()
        {
            byte[] randomInt = new byte[4];
            rnd.GetBytes(randomInt);
            return Convert.ToInt32(randomInt[0]);
        }


        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }

        public string[] IncorrectAnswers
        {
            get { return incorrectAnswers; }
            set { incorrectAnswers = value; }
        }

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }
        public string ImageURL
        {
            get { return imageURL; }
            set { imageURL = value; }
        }

        public string[] Answers
        {
            get { return answers; }
            set { answers = value; ShuffleAnswers(); }
        }

        public string Attribution
        {
            get { return attribution; }
            set { attribution = value; }
        }
        public bool DontSort
        {
            get { return donotsort; }
            set { donotsort = value; }
        }
    }
}
