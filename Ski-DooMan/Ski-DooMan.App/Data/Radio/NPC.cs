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
                { "mona", "fo sauver tonton a {0} " },
                { "mona-deliver", "fo mener Gilber de {0} a {1} " },
                { "mona", "fo sauver tonton a {0} " },
                { "mona-deliver", "fo mener Gilber de {0} a {1} " },
                { "mona", "fo sauver tonton a {0} " },
                { "mona-deliver", "fo mener Gilber de {0} a {1} " },
                { "mona", "fo sauver tonton a {0} " },
                { "mona-deliver", "fo mener Gilber de {0} a {1} " }
            };
        }
    }
}//https://github.com/Ashijo/Ski-DooMan/invitations