using System;
using System.Configuration;
using System.Net;
using DataFetchAPI.ODataRef;
using DataFetchAPI.WebRef;

namespace DataFetchAPI.Utils
{
    public class DBConfig
    {
        public static NAV ODataObj()
        {
            NAV nav = new NAV(new Uri(ConfigurationManager.AppSettings["ODATA_URI"]))
            {
                Credentials = new NetworkCredential(ConfigurationManager.AppSettings["W_USER"],
                    ConfigurationManager.AppSettings["W_PWD"], ConfigurationManager.AppSettings["DOMAIN"])
            };
            return nav;
        }
        public static ECommerce WebRefObj
        {
            get
            {
                var ws = new ECommerce();

                try
                {
                    var credentials = new NetworkCredential(ConfigurationManager.AppSettings["W_USER"], ConfigurationManager.AppSettings["W_PWD"], ConfigurationManager.AppSettings["DOMAIN"]);
                    ws.Credentials = credentials;
                    ws.PreAuthenticate = true;
                    ws.Timeout = -1;
                }
                catch (Exception ex)
                {
                    ex.Data.Clear();
                }
                return ws;
            }
        }
    }
}