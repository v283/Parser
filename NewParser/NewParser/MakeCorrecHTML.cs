using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewParser
{
    public class MakeCorrecHTML
    {
        //дочка

        //дочк&lt;strong&gt;&lt;span &gt;а&lt;/span&gt;&lt;/strong&gt; 
        static Dictionary<string, string> htmlDictionary = new Dictionary<string, string>()
        {
            {"""<span class="marker">А</span>""", "А" },
            {"""<span class="marker">Б</span>""", "Б" },
            {"""<span class="marker">В</span>""", "В" },
            {"""<span class="marker">Г</span>""", "Г" },
            {"""<span class="marker">Д</span>""", "Д" },

            {"""<span class="marker">1</span>""", "1" },
            {"""<span class="marker">2</span>""", "2" },
            {"""<span class="marker">3</span>""", "3" },
            {"""<span class="marker">4</span>""", "4" },
            {"""<span class="marker">5</span>""", "5" },
            {"""<span class="marker">6</span>""", "6" },
            {"""<span class="marker">7</span>""", "7" },
            {"""<span class="marker">8</span>""", "8" },

            //{"""<p style="text-align: center;">""", "" },
            //{"""<p style="text-align: left;">""", "" },
            //{"""<p style="text-align: right;">""", "" },
            //{"""<p>""", "" },
            //{"""</p>""", "" },

            //{"""<strong>""", """&lt;strong&gt;""" },
            //{"""</strong>""", """&lt;/strong&gt;""" },

            //{"""<span style="text-decoration: underline;">""", """&lt;u&gt;""" },
            //{"""</span>""", """&lt;/u&gt;""" },
        };

        //static Dictionary<string, string> htmlDictionary2 = new Dictionary<string, string>()
        //{
        //    {"""<""", """&lt;""" },
        //    {""">""", """&gt;""" },
        //};
        public static string ChangeHTML(string data)
        {
            string result = data;
            foreach (var item in htmlDictionary)
            {
                result = result.Replace(item.Key, item.Value);
            }
            //foreach (var item in htmlDictionary2)
            //{
            //    result = result.Replace(item.Key, item.Value);
            //}
            return result;

        }
    }
}
