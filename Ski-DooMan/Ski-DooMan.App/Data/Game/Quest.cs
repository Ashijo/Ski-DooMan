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

namespace Ski_DooMan.App.Data.Game
{
    public static class Quest
    {
        public static Dictionary<string, string> GetData()
        {
            return new Dictionary<string, string>
            {
                { "mona", "sauve moe skidoo man" },
                { "mona-deverly", "rapporte mon chat au veterinaire" }
            };
        }
    }
}