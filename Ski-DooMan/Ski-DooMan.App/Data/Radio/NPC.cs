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
    public static class NPC
    {
        public static Dictionary<string, string> GetData()
        {
            return new Dictionary<string, string>
            {
                { "mona", " Mona à besoin d'aide à {0} " },
                { "mona-deliver", "Mona est au village de {0}. “QUEST” Lieu : {1} " },

                { "herve", " Hervé à besoin d'aide à {0} " },
                { "herve-deliver", "Hervé est au village de {0}. “Je sais qui fait pas beau dehors, mais j’veux pas que ma femme passe notre anniversaire de mariage toute seule. S.v.p. Ski-Doo Man, va donc prier sur la tombe à ma femme Caire.” Lieu : {1} " },

                { "joanne", " Joanne à besoin d'aide à {0} " },
                { "joanne-deliver", "Joanne est au village de de {0}. “ J'ai besoin de quelqu’un de courageux pour nous aider à forcer la porte d’un hangar pour récupérer du gaz pour la génératrice. On s’en fout que ce soit pas légal.” Lieu : {1} " },

                { "bertha", " La belle Bertha à besoin d'aide à {0} " },
                { "bertha-deliver", "La belle Bertha est au village de de {0}. “S.v.p! J’ai besoin d’un bon samaritain qui accepterait de réchauffer le pâté chinois à ma vieille mère sur son poêle à gaz. Elle ne sait pas s’en servir!” Lieu : {1} " },

                { "leo", " Le p'tit Léo à besoin d'aide à {0} " },
                { "leo-deliver", "Le p'tit Léo est au village de {0}. “Aide-moi Ski-Doo Man! Chui trop gêné pour dire à une fille de ma classe que je l’aime. Peux-tu passer lui dire à ma place?” Lieu : {1} " },

                { "helene", " Soeur Héène à besoin d'aide à {0} " },
                { "helene-deliver", "Soeur Hélène est au village de {0}. “Besoin de quelqu’un pour aller rendre visite à ma grand-mère malade et s’assurer que tout va bien pour elle. Merci d’avance !” Lieu : {1} " }

            };
        }
    }
}//https://github.com/Ashijo/Ski-DooMan/invitations