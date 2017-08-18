using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Net;
using System.Web.Script;
using System.Web.Script.Serialization;

namespace MovieCatalogGenerator
{
    public class Class1 : Form
    {
        
       
          //JSON Object of C# equivalent

        public class Rootobject
        {
            public int page { get; set; }
            public int total_results { get; set; }
            public int total_pages { get; set; }
            public Result[] results { get; set; }
        }

        public class Result
        {
            public int vote_count { get; set; }
            public int id { get; set; }
            public bool video { get; set; }
            public float vote_average { get; set; }
            public string title { get; set; }
            public float popularity { get; set; }
            public string poster_path { get; set; }
            public string original_language { get; set; }
            public string original_title { get; set; }
            public int[] genre_ids { get; set; }
            public string backdrop_path { get; set; }
            public bool adult { get; set; }
            public string overview { get; set; }
            public string release_date { get; set; }
        }
     


    }
}
