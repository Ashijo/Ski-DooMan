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

namespace Ski_DooMan.App.Data.Radio
{
    public static class Music
    {
        public static List<string> GetDataCourage()
        {
            return new List<string>()
            {
                "Pour que tu m’aimes encore de Céline Dion ",
                "L’homme 7 UP des Respectables "
            };

        }

        public static List<string> GetDataResilience()
        {
            return new List<string>()
            {
                "Aux portes du matin de Richard Séguin ",
                "Maudit bonheur de Michel Rivard "
            };

        }

        public static List<string> GetDataHumanity()
        {
            return new List<string>()
            {
                "En 1990 de Jean Leloup",
                "Alegria du Cirque du Soleil "
            };

        }

        public static List<string> GetDataWisedom()
        {
            return new List<string>()
            {
                "Le plus fort, c’est mon père de Lynda Lemay",
                "Seigneur de Kevin Parent"
            };

        }

        public static List<string> GetDataTemperance()
        {
            return new List<string>()
            {
                "Calvaire de La chicane",
                "Sèche tes pleurs de Daniel Bélanger "
            };

        }

        public static List<string> GetDataJustice()
        {
            return new List<string>()
            {
                "Tous les cris, les SOS de Marie-Denise Pelletier ",
                "La rue Principale des Colocs "
            };

        }
    }
}