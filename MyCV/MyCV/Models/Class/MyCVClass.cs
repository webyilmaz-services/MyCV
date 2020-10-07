using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyCV.Models.EntityFramework;

namespace MyCV.Models.Class
{
    public class MyCVClass
    {
        public IEnumerable<tblMe> dbMe { get; set; }
        public IEnumerable<tblSite> dbSite { get; set; }
        public IEnumerable<tblSkill> dbSkill { get; set; }
    }
}