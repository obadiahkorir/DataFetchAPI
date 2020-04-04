using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataFetchAPI.Models
{
    public class SideBarModel
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool ShowInPortal { get; set; }
    }
}