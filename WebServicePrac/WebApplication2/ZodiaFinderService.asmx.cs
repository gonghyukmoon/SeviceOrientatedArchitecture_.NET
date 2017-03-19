using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication2
{
    /// <summary>
    /// Summary description for ZodiaFinderService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ZodiaFinderService : System.Web.Services.WebService
    {
        [WebMethod]
        public string FindZodiac(string zodiac)
        {
            string findZodiac = "";
            Dictionary<string, string> ZodiacFinder = new Dictionary<string, string>();
            ZodiacFinder.Add("Aries", "03/21 – 04/20");
            ZodiacFinder.Add("Taurus", "04/21 – 05/21");
            ZodiacFinder.Add("Gemini", "05/22 – 06/21");
            ZodiacFinder.Add("Cancer", "06/22 – 07/22");
            ZodiacFinder.Add("Leo", "07/23 – 08/22");
            ZodiacFinder.Add("Virgo", "08/23 – 09/23");
            ZodiacFinder.Add("Libra", "09/24 – 10/23");
            ZodiacFinder.Add("Scorpio", "10/24 – 11/22");
            ZodiacFinder.Add("Sagittarius", "11/23 – 12/21");
            ZodiacFinder.Add("Capricorn", "12/22 – 01/20");
            ZodiacFinder.Add("Aquarius", "01/21 – 02/19");
            ZodiacFinder.Add("Pisces", "02/20 – 03/20");

            if (!ZodiacFinder.TryGetValue(zodiac, out findZodiac))
            {
                findZodiac = "Not found";
            }

            return findZodiac;
        }
    }
}
