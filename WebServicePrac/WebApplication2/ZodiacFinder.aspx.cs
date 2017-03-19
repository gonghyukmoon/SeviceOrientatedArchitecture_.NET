using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ZodiacFinder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetDate_Click(object sender, EventArgs e)
        {
            string name = Name1.Text;
            FindZodiaService.ZodiaFinderServiceSoapClient findZodiaSvc = new FindZodiaService.ZodiaFinderServiceSoapClient();
            Date.Text = findZodiaSvc.FindZodiac(name);
        }

        protected void GetName_Click(object sender, EventArgs e)
        {
            int mon = Convert.ToInt32(Mon.Text);
            int day = Convert.ToInt32(Day.Text);
            FindByDate.ZodiacFinderByDateSoapClient findByDateSvc = new FindByDate.ZodiacFinderByDateSoapClient();
            Name2.Text = findByDateSvc.FindZodiacByDate(mon, day);
        }
    }
}