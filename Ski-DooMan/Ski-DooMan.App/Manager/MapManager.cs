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

namespace Ski_DooMan.App.Manager
{
    public class MapManager
    {
        List<Node> nodes;
        List<Road> roads;
        public Node characterPosition;

        #region instance
        private static MapManager instance = null;

        private MapManager()
        {
            nodes = new List<Node>();
            roads = new List<Road>();

            var cityA = new Place(1, new Tools.Vector2(0, 0), "Ville A");
            var cityB = new Place(2, new Tools.Vector2(1, 0), "Ville B");
            var cityC = new Place(3, new Tools.Vector2(0, 1), "Ville C");
            var cityD = new Place(4, new Tools.Vector2(1, 1), "Ville D");

            var node5 = new Node(5, new Tools.Vector2(.5f, 0), "Foret A");
            var node6 = new Node(6, new Tools.Vector2(.5f, .5f), "Lac");
            var node7 = new Node(7, new Tools.Vector2(1, .5f), "Foret B");

            var road1 = new Road(cityA, node5);
            var road2 = new Road(node5, cityB);
            var road3 = new Road(cityA, cityC);

            var road4 = new Road(node5, node6);
            var road5 = new Road(node6, cityC);
            var road6 = new Road(node6, cityB);
            var road7 = new Road(node6, cityD);

            var road8 = new Road(cityB, node7);
            var road9 = new Road(node7, cityD);

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


        public void ResetState()
        {
            foreach (var road in roads)
            {
                road.ResetState();
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