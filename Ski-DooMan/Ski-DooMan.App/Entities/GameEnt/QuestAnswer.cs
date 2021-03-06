﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Ski_DooMan.App.Tools;

namespace Ski_DooMan.App.Entities.GameEnt
{
    public class QuestAnswer
    {
        Value preferedValue { get; set; }

        public QuestAnswer(Value preferedValue, string title, int winValue, string label, string result)
        {
            this.preferedValue = preferedValue;
            this.title = title;
            this.winValue = winValue;
            this.label = label;
            this.result = result;
        }

        public string title { get; set; }
        public int winValue { get; set; }

        public string label { get; set; }
        public string result { get; set; }

    }
}