using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WhatsAppLinkMaker.Business
{
    class CreateLink
    {
        public string fncGetLink(string strPhoneNumber , string strInputText)
        {
            //
            strPhoneNumber = "98" + strPhoneNumber.Remove(0, 1);
            strInputText = WebUtility.UrlEncode(strInputText);
            return string.Format("https://wa.me/{0}?text={1}", strPhoneNumber, strInputText);
        }
    }
}
