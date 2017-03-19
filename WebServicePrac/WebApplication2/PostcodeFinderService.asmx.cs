using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace WebApplication2
{
    /// <summary>
    /// Summary description for PostcodeFinderService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class PostcodeFinderService : System.Web.Services.WebService
    {

        [WebMethod]
        public string FindPostcode(string suburb)
        {
            String postcode = "";
            Dictionary<string, string> postcodeList = new Dictionary<string, string>();
            string path = HttpRuntime.AppDomainAppPath + "/Postcodes.txt";
            StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
            string line="";
            while ((line = reader.ReadLine()) != null)
            {
                string[] row = line.Split(',');
                postcodeList.Add(row[0],row[1]);
            }
            postcodeList.TryGetValue(suburb, out postcode);
            return postcode;
        }
    }
}
