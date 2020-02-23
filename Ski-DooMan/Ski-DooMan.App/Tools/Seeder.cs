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
                             new Quest (false, "Mona est devant la porte d’entrée de la base militaire en discussion avec le Commandant Tremblay. Elle semble essayer de raisonner avec le militaire pour obtenir de l’aide pour les habitants de sa ville. Le commandant ne semble pas du tout être réceptif à ses demandes.",
                                new QuestAnswer(Value.Temperance, "Contrôler sa colère face à la situation et éloigner Mona.", 1, "[Ski-Doo Man] \" Mona, viens avec moi. Ils peuvent pas nous aider. Ça sert à rien de rester ici.\" [Mona] \"Je pense que t’as raison. Mais il fallait que j’essaye. Il y a une base au complet derrière ces murs qui pourraient nous aider en ville en ce moment!\"", "Mona entre au village frustrer. Par chance, elle arrive juste à temps pour gérer une grave crise à la mairie."),
                                new QuestAnswer(Value.Justice, "Soutenir fougueusement Mona face au Commandant militaire.", 0, "[Ski-Doo Man] \"Ça pas d’allure que vous faites rien pour nous aider! Vous devriez avoir honte!\" [Mona] \"Ski-Doo Man a raison! Il faut nous aider !\"", "Malheureusement, le Commandant ne change pas d’idée. Il ne reçoit aucun ordre et n’a pas le droit d’agir. Le village n’aura aucune aide de la base militaire cette nuit."),
                                new QuestAnswer(Value.Resilience, "Être positif", 2, "[Ski-Doo Man] \" C’est difficile pour tout le monde en ce moment. Mais il faut garder espoir que ça va s’améliorer!\" [Mona]\" T’as raison Ski-Doo Man. Ça sert à rien de se plaindre, il faut surtout agir. Avec eux ou sans eux.\"", "Mona et Ski-Doo Man retournent au village. Deux heures plus tard, Mona reçoit un message du Commandant. Ils viennent d’avoir l’autorisation du ministre et arrivent! Finalement...")
                                )
                    ),
                     new Npc(
                        2, "herve", "green", 
                            new Quest (true, "Deverly quete description", 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                ),
                             new Quest (false, "C’est le branle bas de combat au CHSLD. Hervé hurle à tue tête et cherche sa femme Claire. Il ne la trouve pas depuis ce matin et commence à devenir agressif. Mais qui pourrait régler cette situation?",
                                new QuestAnswer(Value.Justice, "Demander à Hervé de se calmer de manière autoritaire", 2, " [Ski-Doo Man] \"Hervé, ta femme serait en beau maudit après toi. Tu te comporte mal avec les autres, ils ont pas a vivre tes états d’âmes, c’est pas juste. Arrête-moi ça.\" [Hervé] \"T’as raison Skidoo-Man, Claire supporte pas quand je pète un plomb… M’a aller me calmer dans ma chambre en attendant qu’elle revienne.\"", "Le calme revient au CHSLD. Hervé retourne à sa chambre et tout revient au calme."),
                                new QuestAnswer(Value.Resilience, "Rappeler à Hervé que sa femme est décédée il y a maintenant 5 ans, avec humour.", 0, " [Ski-Doo Man] \"Hervé, arrête de faire le fou, ta femme est morte ça fait longtemps! hahaha\" [Hervé] \"T’es qui pour me dire ça mon maudit! Amène-toi que je t'apprenne une leçon Ski-Doo Man!\" ", "Hervé est maintenant enragé. Tout le monde est apeuré au CHSLD. Ski-Doo Man regrette son choix..."),
                                new QuestAnswer(Value.Wisedom, "Distraire Hervé avec un sujet anodin.  ", 1, " [Ski-Doo Man] \"Eille Hervé, raconte-moi encore la fois où t’as eu la médaille de courage après la grande guerre.\" [Hervé] \"Quoi? À oui, la médaille de courage! J’étais le seul à la recevoir dans mon régiment. Le sergent il… Attend, qu’est-ce que je faisais déjà moi? Pourquoi t’es là Ski-Doo Man?\" ", "Hervé, bien que plus calme qu’au début, est plus confus que jamais. Hervé accepte d’écouter la télé tranquille, mais sans enthousiasme.")
                                )
                    ),
                    new Npc(
                        3, "joanne", "green", 
                            new Quest (true, "Deverly quete description", 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                ),
                             new Quest (false, "Beaucoup de gens ont pris abri dans le Gymnase de la Polyvalente. Joanne a offert son aide pour aider à donner à manger et à boire. Les réserves commencent déjà à faiblir et les tensions commencent à monter. Joanne essaie avec peine et misère de calmer la foule mécontente, mais commence à perdre le contrôle de la situation. ",
                                new QuestAnswer(Value.Justice, "Proposer de rationner équitablement.", 2, "[Ski-Doo Man] \"Soyons tous et toutes raisonnables. Faut juste bien se rationner!\" [Joanne] \"Très bonne idée Ski-Doo Man! Chacun peut avoir sa juste part tant qu’on partage.\"", "Dès que le système de rationnement équitable a été mis en place, la situation s’est vraiment apaisée ! Joanne adore maintenant Ski-Doo Man."),
                                new QuestAnswer(Value.Resilience, "Divertir la foule pour la calmer.", 0, "[Ski-Doo Man] \"Au lieu de vous chamailler, venez donc voir ce que peut faire mon Ski-Doo. J’vais faire le plus gros jump que vous avez jamais vue.\" [Joanne] \"Maudit Ski-Doo Man… C’est pas la priorité. On a bien plus important à faire.\"", "Joanne tente de gérer la situation au gymnase au mieux qu’elle peut seule, mais ça dégénère rapidement. Aucune nourriture ni d’eau ne pourra finalement être distribué pour le reste de la nuit."),
                                new QuestAnswer(Value.Temperance, "Distribuer sa réserve personnelle de barres tendres.", 1, "[Ski-Doo Man] \"Du calme tout le monde! C’est peut-être pas grand chose, mais j’ai assez de barres granola pour vous tous dans mon coffre à Ski-Doo. Ça bouche un trou ces affaires là.\" [Joanne] \"Bien joué Ski-Doo Man! Merci!\"", "L’altruisme de Ski-Doo Man inspire toutes les personnes présentes. Le reste de la distribution se passe alors dans le calme. Joanne adore maintenant Ski-Doo Man.")
                                )
                    ),
                    new Npc(
                        4, "bertha", "green", 
                            new Quest (true, "Deverly quete description", 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo"), 
                                new QuestAnswer(Value.Courage, "Grimpe dans l'arbre", 0, "En utilisant l'echele tu attrape le chien, ", "tout est bo")
                                ),
                             new Quest (false, "C’est le chaos total dans la taverne à Belle Bertha depuis qu’elle a annoncé qu’il ne reste plus qu’une seule Labatt 50. Une bagarre générale a éclaté entre trois clients assoiffés. Personne ne semble prêt à intervenir. La barmaid lance un appel à l’aide pour trouver un médiateur. ",
                                new QuestAnswer(Value.Justice, "Partager la dernière bouteille de bière dans 3 verres. ", 1, "[Ski-Doo Man] \"Non mais ça va faire! On est tous des adultes ici. Regardez, maintenant vous avez tous une part égale à boire.\" [La belle Bertha] \"Ils ont pas l’air d’aimer ta solution mon beau Ski-Doo Man. Mais au moins ils ont arrêté de se battre.\"", "Les invités acceptent le compromis avec un air bête. Ski-Doo Man lance un sourire à la Belle Bertha, elle continue son travail."),
                                new QuestAnswer(Value.Humanity, "Offrir de partager son flasque de gin avec les 3 bagarreurs.", 2, "[Ski-Doo Man] \"Eille! Arrêtez donc de vous battre pour de l’alcool. J’ai assez de gin pour tout le monde moi!\" [La belle Bertha] \"T’as réussi à calmer la situation pas mal vite! Merci mon beau Ski-Doo Man.\" ", "Les invités font la paix et accepte l’invitation. Ski-Doo Man verse un petit verre de gin aux clients, ainsi qu’à lui-même et la Belle Bertha. Elle lui lance un sourire en coin."),
                                new QuestAnswer(Value.Courage, "Intervenir physiquement dans la bataille.", 0, "[Ski-Doo Man] \"Ouch… Ayoye ma Belle Bertha, excuse-moi. J’pensais vraiment être capable de maîtriser la situation… \" [La belle Bertha] \"Bon bon bon. Ça l’air que j’vais encore être obligé de tout régler moi-même! Moi qui pensais avoir trouvé un héros...\"", "La Belle Bertha lance un pichet de bière sur les 3 bagarreurs pour arrêter la bataille et dit à tout monde que quitter immédiatement!")
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