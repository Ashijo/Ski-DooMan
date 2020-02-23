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
                { "mona", " [Mona]\"Attention à tous les citoyens de la région. Ici votre mairesse Mona. J’ai besoin d’aide pour convaincre le service militaire que notre ville à besoin d’assistance immédiate en raison du verglas. Ils sont vraiment têtus!\" Lieu : {0} " },
                { "mona-deliver", "Mona est au village de {0}. [Mona]\"En tant que mairesse de votre ville je tiens à vous partager mon mécontentement envers le service militaire à date. Leur manque de collaboration est inacceptable! C’est pas dans mes habitudes, mais j'aimerais bien qu’on apprenne une leçon à ce cher Commandant. Si  quelqu’un pouvait lui lancer une boule de neige en pleine face, je dirais pas non!\" Lieu : {1} " },

                { "herve", " [Hervé]\"Claire? Claiiiiiire!? T’es tu dans radio ma chérie? Reviens donc à maison, j’veux souper avec toi ce soir. J’aime pas le monde icitte au CHSLD, y veulent pas me dire t’es où.\" Lieu : {0} " },
                { "herve-deliver", "Hervé est au village de {0}. [Hervé]\"Je sais qui fait pas beau dehors, mais j’veux pas que ma femme passe notre anniversaire de mariage toute seule. S.v.p. Ski-Doo Man, va donc prier sur la tombe à ma femme Caire.\" Lieu : {1} " },

                { "joanne", " [Joanne]\"Quelqu’un de libre? Je commence à perdre le contrôle de la foule rassemblé à la Polyvalente. Besoin de back-up dès que possible!\" Lieu : {0} " },
                { "joanne-deliver", "Joanne est au village de de {0}. [Joanne]\"J'ai besoin de quelqu’un de courageux pour nous aider à forcer la porte d’un hangar pour récupérer du gaz pour la génératrice. On s’en fout que ce soit pas légal.\" Lieu : {1} " },

                { "bertha", "[La belle Bertha]\"Belle Bertha au village, Belle Bertha au village. Imaginez-vous donc que j’ai une chicane de grands enfants dans ma taverne ce soir... Quelqu’un peut m’aider à contrôler la situation s.v.p? Ski-Doo Man? \" Lieu : {0} " },
                { "bertha-deliver", "La belle Bertha est au village de de {0}.[La belle Bertha]\"S.v.p! J’ai besoin d’un bon samaritain qui accepterait de réchauffer le pâté chinois à ma vieille mère sur son poêle à gaz. Elle ne sait pas s’en servir!\" Lieu : {1} " },

                { "leo", " [P'tit Léo] \"S.O.S. Ski-Doo Man! Mon Cléo! Mon chien Cléo va se noyer. Je sais pas quoi faire! Oh non, c’est toute ma faute! Aide-moi, vite Ski-Doo Man!\" Lieu : {0} " },
                { "leo-deliver", "Le p'tit Léo est au village de {0}.[P'tit Léo] \"Aide-moi Ski-Doo Man! Chui trop gêné pour dire à une fille de ma classe que je l’aime. Peux-tu passer lui dire à ma place?\" Lieu : {1} " },

                { "helene", " [Soeur Hélène] \"Paroissiens et paroissiennes, y a-t-il une âme sensible qui puisse braver le froid terrible et m’aider à raisonner le Père Roger à l’église? Il n’agit pas en bon chrétien en ces temps difficiles.\" Lieu : {0} " },
                { "helene-deliver", "Soeur Hélène est au village de {0}. [Soeur Hélène] \"Besoin de quelqu’un pour aller rendre visite à ma grand-mère malade et s’assurer que tout va bien pour elle. Merci d’avance !\" Lieu : {1} " }

            };
        }
    }
}//https://github.com/Ashijo/Ski-DooMan/invitations