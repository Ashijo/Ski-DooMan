using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Ski_DooMan.App.Entities.GameEnt
{
    public class Quest
    {
        public bool questType { get; set; }
        public string description { get; set; }

        public Quest(bool questType, string description, QuestAnswer answerA, QuestAnswer answerB, QuestAnswer answerC)
        {
            this.questType = questType;
            this.description = description;
            this.answerA = answerA;
            this.answerB = answerB;
            this.answerC = answerC;
        }

        public QuestAnswer answerA { get; set;}
        public QuestAnswer answerB { get; set;}
        public QuestAnswer answerC { get; set; }

    }
}