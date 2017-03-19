using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication2
{
    /// <summary>
    /// Summary description for ZodiacFinderByDate
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ZodiacFinderByDate : System.Web.Services.WebService
    {

        [WebMethod]
        public string FindZodiacByDate(int mon,int day)
        {
            string date = day + "/" + mon + "/2015";

            if ((mon == 3 && day>=21 && day<=31) || (mon == 4 && day>=1 && day <= 20))
            {
                return "Aries";
            }
            else if((mon == 4 && day>= 21 && day <=30)||(mon == 5 && day>=1 && day <= 21 )){
                return "Taurus";
            }
            else if ((mon == 5 && day >= 22 && day <= 31) || (mon == 6 && day >= 1 && day <= 21))
            {
                return "Gemini";
            }
            else if ((mon == 6 && day >= 22 && day <= 30) || (mon == 7 && day >= 1 && day <= 22))
            {
                return "Cancer";
            }
            else if ((mon == 7 && day >= 23 && day <= 31) || (mon == 8 && day >= 1 && day <= 22))
            {
                return "Leo";
            }
            else if ((mon == 8 && day >= 23 && day <= 31) || (mon == 9 && day >= 1 && day <= 23))
            {
                return "Virgo";
            }
            else if ((mon == 9 && day >= 24 && day <= 30) || (mon == 10 && day >= 1 && day <= 23))
            {
                return "Libra";
            }
            else if ((mon == 10 && day >= 24 && day <= 31) || (mon == 11 && day >= 1 && day <= 22))
            {
                return "Scorpio";
            }
            else if ((mon == 11 && day >= 23 && day <= 30) || (mon == 12 && day >= 1 && day <= 21))
            {
                return "Sagittarius";
            }
            else if ((mon == 12 && day >= 22 && day <= 31) || (mon == 1 && day >= 1 && day <= 20))
            {
                return "Capricorn";
            }
            else if ((mon == 1 && day >= 21 && day <= 31) || (mon == 2 && day >= 1 && day <= 19))
            {
                return "Aquarius";
            }
            else if ((mon == 2 && day >= 20 && day <= 29) || (mon == 3 && day >= 1 && day <= 20))
            {
                return "Pisces";
            }
            else
            {
                return "Wrong Input Date";
            }
        }
    }
}
