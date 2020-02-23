using System;
using System.Collections.Generic;

using Ski_DooMan.App.Data.Radio;

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
    }
}