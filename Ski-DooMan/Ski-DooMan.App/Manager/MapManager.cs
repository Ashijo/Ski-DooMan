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
using Ski_DooMan.App.Entities.MapEnt;

namespace Ski_DooMan.App.Manager
{
    public class MapManager
    {
        List<Node> nodes;
        List<Road> roads;
        public Node characterPosition;
        public int[] trapperdRoads;
        public List<Road> selectedRoads;

        #region instance
        private static MapManager instance = null;

        private MapManager()
        {
            nodes = new List<Node>();
            roads = new List<Road>();
            selectedRoads = new List<Road>();

            var cityA = new Place(1, new Tools.Vector2(0, 0), "Ville A");
            var cityB = new Place(2, new Tools.Vector2(1, 0), "Ville B");
            var cityC = new Place(3, new Tools.Vector2(0, 1), "Ville C");
            var cityD = new Place(4, new Tools.Vector2(1, 1), "Ville D");

            var node5 = new Node(5, new Tools.Vector2(.5f, 0), "Foret A");
            var node6 = new Node(6, new Tools.Vector2(.5f, .5f), "Lac");
            var node7 = new Node(7, new Tools.Vector2(1, .5f), "Foret B");

            var road1 = new Road(cityA, node5, 1, "a road");
            var road2 = new Road(node5, cityB, 2, "a road");
            var road3 = new Road(cityA, cityC, 3, "a road");
            var road4 = new Road(node5, node6, 4, "a road");
            var road5 = new Road(node6, cityC, 5, "a road");
            var road6 = new Road(node6, cityB, 6, "a road");
            var road7 = new Road(node6, cityD, 7, "a road");
            var road8 = new Road(cityB, node7, 8, "a road");
            var road9 = new Road(node7, cityD, 9, "a road");

            Random rand = new Random();

            int rand1 = rand.Next(9);


            int rand2 = rand.Next(9);
            while (rand2 == rand1)
            {
                rand2 = rand.Next(9);
            }

            int rand3 = rand.Next(9);
            while (rand3 == rand1 || rand3 == rand2)
            {
                rand3 = rand.Next(9);
            }


            nodes.Add(cityA);
            nodes.Add(cityB);
            nodes.Add(cityC);
            nodes.Add(cityD);

            nodes.Add(node5);
            nodes.Add(node6);
            nodes.Add(node7);

            roads.Add(road1);
            roads.Add(road2);
            roads.Add(road3);
            roads.Add(road4);
            roads.Add(road5);
            roads.Add(road6);
            roads.Add(road7);
            roads.Add(road8);
            roads.Add(road9);

            roads[rand1].roadEvent = RoadEvent.Something;
            roads[rand2].roadEvent = RoadEvent.Something;
            roads[rand3].roadEvent = RoadEvent.Something;

            trapperdRoads = new int[] {
                roads[rand1].id,
                roads[rand2].id,
                roads[rand3].id
                };

            characterPosition = cityD;
        }

        public static MapManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MapManager();
                }
                return instance;
            }
        }

        #endregion

        public void AddTravelPart(int nodeA, int nodeB)
        {
            selectedRoads
                .Add(roads
                    .Find(node => (node.aNode.id == nodeA || node.aNode.id == nodeB)
                        && (node.bNode.id == nodeA || node.bNode.id == nodeB)));
        }

        public void ResetTravelSelect()
        {
            selectedRoads = new List<Road>();
        }

        public Place GetPlace(int id)
        {
            return nodes.Find(node => node.id == id) as Place;
        }

        public int[] GetQuestPlaceIds()
        {
            return nodes
                .Where(node => node.isPlace)
                .Cast<Place>()
                .Where(place => place.hasAQuest)
                .Select(place => place.id)
                .ToArray();
        }

        public void AddAQuest(int id)
        {
            (nodes.Find(node => node.id == id) as Place).isPlace = true;
        }

        public void ResolveQuest(int id)
        {
            (nodes.Find(node => node.id == id) as Place).isPlace = false;
        }

        public void ResetState()
        {
            foreach (var road in roads)
            {
                road.ResetState();
            }

            foreach (var place in nodes.Where(node => node.isPlace))
            {
                (place as Place).hasAQuest = false;
            }

            characterPosition = nodes.Find(node => node.id == 4);
        }

        public List<Node> GetValideMoveNodes(Node origin)
        {
            var validRoads = roads.Where(road => road.aNode.id == origin.id || road.bNode.id == origin.id);
            var validNodes = new List<Node>();

            foreach (var road in validRoads)
            {
                if (road.aNode.id == origin.id)
                {
                    validNodes.Add(road.bNode);
                }
                else
                {
                    validNodes.Add(road.aNode);
                }
            }

            return validNodes;
        }
    }
}