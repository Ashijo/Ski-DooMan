using System;
using System.Collections.Generic;

using Ski_DooMan.App.Data.Radio;
using Ski_DooMan.App.Entities.GameEnt;

namespace Ski_DooMan.App.Tools
{
    public static class Seeder
    {
        public static Dictionary<Value, List<string>> GetMusics()
        {
            var dico = new Dictionary<Value, List<string>>();

            foreach (Value val in (Value[])Enum.GetValues(typeof(Value)))
            {
                switch (val)
                {
                    case Value.Justice:
                        dico.Add(val, Music.GetDataJustice());
                        break;
                    case Value.Courage:
                        dico.Add(val, Music.GetDataCourage());
                        break;
                    case Value.Resilience:
                        dico.Add(val, Music.GetDataResilience());
                        break;
                    case Value.Humanity:
                        dico.Add(val, Music.GetDataHumanity());
                        break;
                    case Value.Wisedom:
                        dico.Add(val, Music.GetDataWisedom());
                        break;
                    case Value.Temperance:
                        dico.Add(val, Music.GetDataTemperance());
                        break;
                }
            }

            return dico;
        }

        public static List<Npc> GetNpcs()
        {

            return new List<Npc>
            {
                new Npc(
                        1, "mona", "green", 
                            new Quest (false, "Deverly quete description", 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                ),
                             new Quest (true, "tu arrive a l'hopital pis faut sauvez le chien",
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"),
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"),
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                )
                    )
            };

        }
    }
}