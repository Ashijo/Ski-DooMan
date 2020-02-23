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
                            new Quest (true, "Deverly quete description", 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                ),
                             new Quest (false, "tu arrive a l'hopital pis faut sauvez le chien",
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"),
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"),
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                )
                    ),
                     new Npc(
                        2, "herve", "green", 
                            new Quest (true, "Deverly quete description", 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                ),
                             new Quest (false, "tu arrive a l'hopital pis faut sauvez le chien",
                                new QuestAnswer(Value.Justice, "Demander à Hervé de se calmer de manière autoritaire", 2, " [Ski-Doo Man] \"Hervé, ta femme serait en beau maudit après toi. Tu te comporte mal avec les autres, ils ont pas a vivre tes états d’âmes, c’est pas juste. Arrête-moi ça.\" [Hervé] \“T’as raison Skidoo-Man, Claire supporte pas quand je pète un plomb… M’a aller me calmer dans ma chambre en attendant qu’elle revienne.\”", "Le calme revient au CHSLD. Hervé retourne à sa chambre et tout revient au calme."),
                                new QuestAnswer(Value.Resilience, "Rappeler à Hervé que sa femme est décédée il y a maintenant 5 ans, avec humour.", 0, " [Ski-Doo Man] \"Hervé, arrête de faire le fou, ta femme est morte ça fait longtemps! hahaha\”", "tout est bo"),
                                new QuestAnswer(Value.Wisedom, "Distraire Hervé avec un sujet anodin.  ", 1, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                )
                    ),
                    new Npc(
                        3, "joanne", "green", 
                            new Quest (true, "Deverly quete description", 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                ),
                             new Quest (false, "tu arrive a l'hopital pis faut sauvez le chien",
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"),
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"),
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                )
                    ),
                    new Npc(
                        4, "bertha", "green", 
                            new Quest (true, "Deverly quete description", 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                ),
                             new Quest (false, "tu arrive a l'hopital pis faut sauvez le chien",
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"),
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"),
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                )
                    ),
                    new Npc(
                        5, "leo", "green", 
                            new Quest (true, "Deverly quete description", 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                ),
                             new Quest (false, "tu arrive a l'hopital pis faut sauvez le chien",
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"),
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"),
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                )
                    ),
                    new Npc(
                        6, "helene", "green", 
                            new Quest (true, "Deverly quete description", 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                ),
                             new Quest (false, "tu arrive a l'hopital pis faut sauvez le chien",
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"),
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"),
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                )
                    )                  
            };

        }
    }
}