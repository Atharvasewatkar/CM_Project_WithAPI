using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AllOperationsLibrary.Entities
{
    public class CustomerEntity
    {

        public string NAME          {get; set;}
        public string ADDRESS       { get; set; }
        public string CONTACT        { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string CITYID            { get; set; }
        public string PACKAGEID          { get; set; }
        public string GROUPID        { get; set; }
        public string USER_ID           { get; set; }
        public string PASSWORD           { get; set; }

    }
}
