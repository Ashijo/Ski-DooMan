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
using Ski_DooMan.App.Entities.MapEnt;
using Ski_DooMan.App.Manager;

namespace Ski_DooMan.App.Activities
{
    [Activity(Label = "Map")]
    public class Map : Activity
    {
        List<Node> validSelection;
        List<Node> journey;
        TextView journeyTextView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.map);

            Button cityABtn = this.FindViewById<Button>(Resource.Id.ville1);
            Button cityBBtn = this.FindViewById<Button>(Resource.Id.ville2);
            Button cityCBtn = this.FindViewById<Button>(Resource.Id.ville3);
            Button cityDBtn = this.FindViewById<Button>(Resource.Id.ville4);

            Button Node5Btn = this.FindViewById<Button>(Resource.Id.node5);
            Button Node6Btn = this.FindViewById<Button>(Resource.Id.node6);
            Button Node7Btn = this.FindViewById<Button>(Resource.Id.node7);

            Button ResetSequenceBtn = this.FindViewById<Button>(Resource.Id.resetSequence);

            ResetSequenceBtn.Click += delegate
            {
                ResetSequence();
            };

            journeyTextView = this.FindViewById<TextView>(Resource.Id.sequenceString);

            cityABtn.Click += delegate
            {
                CityAClick();
                UpdateSelection();
            };

            cityBBtn.Click += delegate
            {
                CityBClick();
                UpdateSelection();
            };

            cityCBtn.Click += delegate
            {
                CityCClick();
                UpdateSelection();
            };

            cityDBtn.Click += delegate
            {
                CityDClick();
                UpdateSelection();
            };


            Node5Btn.Click += delegate
            {
                Node5Click();
                UpdateSelection();
            };

            Node6Btn.Click += delegate
            {
                Node6Click();
                UpdateSelection();
            };
            Node7Btn.Click += delegate
            {
                Node7Click();
                UpdateSelection();
            };

            journeyTextView.Text = "On part bientot mon cheum ?";

            journey = new List<Node>();
            validSelection = MapManager.Instance.GetValideMoveNodes(MapManager.Instance.characterPosition);
        }

        public void Travel()
        {
            if (journey.Last().isPlace)
            {
                MapManager.Instance.characterPosition = journey.Last();
                //on y go
            };
        }

        public void UpdateSelection()
        {
            string journeyMsg = "Ou kon va : ";

            for (int i = 0; i < journey.Count; i++)
            {
                if (i != 0)
                {
                    journeyMsg += " - ";
                }

                journeyMsg += journey[i].name;
            }

            journeyTextView.Text = journeyMsg;
            validSelection = MapManager.Instance.GetValideMoveNodes(journey.Last());
        }

        public void ResetSequence()
        {
            journey = new List<Node>();
            validSelection = MapManager.Instance.GetValideMoveNodes(MapManager.Instance.characterPosition);
            journeyTextView.Text = "On part bientot mon cheum ?";
        }

        public void CityAClick()
        {
            if (validSelection.Any(node => node.id == 1))
            {
                journey.Add(validSelection.Find(node => node.id == 1));
            }
        }

        public void CityBClick()
        {
            if (validSelection.Any(node => node.id == 2))
            {
                journey.Add(validSelection.Find(node => node.id == 2));
            }
        }

        public void CityCClick()
        {
            if (validSelection.Any(node => node.id == 3))
            {
                journey.Add(validSelection.Find(node => node.id == 3));
            }
        }

        public void CityDClick()
        {
            if (validSelection.Any(node => node.id == 4))
            {
                journey.Add(validSelection.Find(node => node.id == 4));
            }
        }

        public void Node5Click()
        {
            if (validSelection.Any(node => node.id == 5))
            {
                journey.Add(validSelection.Find(node => node.id == 5));
            }
        }

        public void Node6Click()
        {
            if (validSelection.Any(node => node.id == 6))
            {
                journey.Add(validSelection.Find(node => node.id == 6));
            }
        }

        public void Node7Click()
        {
            if (validSelection.Any(node => node.id == 7))
            {
                journey.Add(validSelection.Find(node => node.id == 7));
            }
        }

    }
}