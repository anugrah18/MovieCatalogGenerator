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
    public partial class MovieCatalogGenerator : Class1
    {
        //Insert TMDB API Key here
        string TMDB_API_KEY = "";

        public List<Result> Movies_database = new List<Result>();

        class movie_titles
        {
            private string name;
            private int year;

            public void set_name(string MovieName)
            {
                name = MovieName;
            }

            public void set_year(int MovieYear)
            {
                year = MovieYear;
            }

            public string get_name()
            {
                return name;
            }

            public int get_year()
            {
                return year;
            }
        }

        string folder_path = "";
        ArrayList movie_list = new ArrayList();

        //Containing list of movies name and year
        List<movie_titles> Movies = new List<movie_titles>();

        public MovieCatalogGenerator()
        {
            InitializeComponent();
        }
        //For making window moveable
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        //Browse Button
        private void button1_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.RootFolder = Environment.SpecialFolder.Desktop;
            folder.ShowNewFolderButton = false;

            if (folder.ShowDialog() == DialogResult.OK)
            {
                searchtext.Text = folder.SelectedPath;
                folder_path = @searchtext.Text;
            }
        }

        //Catalog Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (folder_path != "")
            {
                movie_list.Clear();
                Movies_database.Clear();

                string[] folder = Directory.GetDirectories(folder_path);

                //For adding Folders in Directory as string
                foreach (string movie_name in folder)
                {
                    movie_list.Add(new DirectoryInfo(movie_name).Name);
                }

                //For Parsing the movie and year
                foreach (string mov in movie_list)
                {
                    movie_titles temp = new movie_titles();
                    char[] delimiter = { '(', ')', '_', '.', '[', ']' };
                    string[] str = mov.Split(delimiter);
                    temp.set_name(str[0]);
                    string[] str2 = str[1].Split(delimiter);
                    temp.set_year(int.Parse(str2[0]));
                    Movies.Add(temp);
                }

                //For generating data of the respective movies
                foreach (movie_titles a in Movies)
                {
                    WebClient wc = new WebClient();
                    var json = wc.DownloadString("https://api.themoviedb.org/3/search/movie?query=" + a.get_name() + "&api_key=" + TMDB_API_KEY);
                    json = @json;
                    Rootobject samp = new JavaScriptSerializer().Deserialize<Rootobject>(json);
                    Boolean found_match = false;

                    //Only storing movies with match year
                    for (int i = 0; i < samp.results.Length; i++)
                    {
                        string[] str;
                        str = samp.results[i].release_date.Split('-');
                        samp.results[i].release_date = str[0];
                        if (samp.results[i].release_date == a.get_year().ToString() && found_match == false)
                        {
                            Movies_database.Add(samp.results[i]);
                            found_match = true;
                        }
                    }
                }

                //Displaying the movie data 
                Form2 repository = new Form2(Movies_database);
                repository.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No folder selected cannot Browse");
            }
        }

        //Exit Button
        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Help Button
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Movie Catalog Generator\n \n This Software was developed by Anugrah Kumar and uses following REST based APIs - \n1.TMDB API \n2.Youtube Data API");
        }
    }
}
