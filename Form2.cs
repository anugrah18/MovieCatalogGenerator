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
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;


namespace MovieCatalogGenerator
{
    public partial class Form2 : Class1
    {
        //Insert Youtube API Key here
        public string YOUTUBE_API_KEY = "";
        public List<Result> data = new List<Result>();

        public Form2(List<Result> Movies_database)
        {
            InitializeComponent();
            data = Movies_database;
            List  <string> listOfMovies = new List<string>();
            listOfMovies.Clear();

            foreach (Result res in Movies_database)
            {

                listOfMovies.Add(res.title);
            }

            //For initializaing the listBox1
            listBox1.DataSource = listOfMovies; 
        }

        //For returning all genres of a movie
        public string GenreConverter(int[] genre)
        {
            string genres = "";

            foreach(int x in genre)
            {
                if (x == 28)
                {
                    genres = genres + "#" + "Action " ;
                }

                else if (x == 12)
                {
                    genres = genres + "#" + "Adventure ";
                }

                else if (x == 16)
                {
                    genres = genres + "#" + "Animation ";
                }

                else if (x == 35)
                {
                    genres = genres + "#" + "Comedy ";
                }

                else if (x == 80)
                {
                    genres = genres + "#" + "Crime ";
                }

                else if (x == 99)
                {
                    genres = genres + "#" + "Documentary ";
                }

                else if (x == 18)
                {
                    genres = genres + "#" + "Drama ";
                }

                else if (x == 10751)
                {
                    genres = genres + "#" + "Family ";
                }

                else if (x == 14)
                {
                    genres = genres + "#" + "Fantasy ";
                }

                else if (x == 36)
                {
                    genres = genres + "#" + "History ";
                }

                else if (x == 27)
                {
                    genres = genres + "#" + "Horror ";
                }

                else if (x == 10402)
                {
                    genres = genres + "#" + "Music ";
                }

                else if (x == 9648)
                {
                    genres = genres + "#" + "Mystery ";
                }

                else if (x == 10749)
                {
                    genres = genres + "#" + "Romance ";
                }

                else if (x == 36)
                {
                    genres = genres + "#" + "History ";
                }

                else if (x == 878)
                {
                    genres = genres + "#" + "Science-Fiction ";
                }

                else if (x == 10770)
                {
                    genres = genres + "#" + "TV Movie ";
                }

                else if (x == 53)
                {
                    genres = genres + "#" + "Thriller ";
                }

                else if (x == 10752)
                {
                    genres = genres + "#" + "War ";
                }

                else if (x == 878)
                {
                    genres = genres + "#" + "Western ";
                }

            }
            return genres;
        }

        //Updating the details based on listBox1 Highlighted text
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Result res in data)
            {
                if (listBox1.Text == res.title)
                {
                    yearDisplay.Text = res.release_date;//Displaying the Year
                    var wc = new WebClient();
                    Image img = Image.FromStream(wc.OpenRead("http://image.tmdb.org/t/p/w500//" + res.poster_path));
                    pictureBox1.Image = img;//Displaying the poster
                    string genres_list = GenreConverter(res.genre_ids);
                    richTextBox1.Text = res.overview;//Displaying the Summary
                    textBox1.Text = genres_list;//Displaying the genres
                    int index = listBox1.SelectedIndex + 1;
                    textBox2.Text = index.ToString() + "/" + data.Count.ToString();//Displaying the Index
                    webBrowser1.Navigate(YoutubeRun(res.title + " " + res.release_date + " trailer"));//Displaying the movie trailer
                }
            }
        }

        //For sorting movies based on Title
        public List<Result> TitleSort(List<Result> data)
        {
            List<Result> res = new List<Result>();
            res = data.OrderBy(o => o.title).ToList();
            return res;
        }

        //For reverse sorting movies based on Title
        public List<Result> ReverseTitleSort(List<Result> data)
        {
            List<Result> res = new List<Result>();
            res = data.OrderByDescending(o => o.title).ToList();
            return res;
        }

        //For sorting movies based on Year
        public List<Result> YearSort(List<Result> data)
        {
            List<Result> res = new List<Result>();
            res = data.OrderBy(o => o.release_date).ToList();
            return res;
        }

        //For reverse sorting movies based on Year
        public List<Result> ReverseYearSort(List<Result> data)
        {
            List<Result> res = new List<Result>();
            res = data.OrderByDescending(o => o.release_date).ToList();
            return res;
        }

        //For sorting movies
        private void button1_Click(object sender, EventArgs e)
        {
            List<Result> newdata = new List<Result>();
            if (SortByTitle.Checked)
            {
                newdata = TitleSort(data);
            }

            else if (SortByTitle2.Checked)
            {
                newdata = ReverseTitleSort(data);
            }

            else if (sortByYear.Checked)
            {
                newdata = YearSort(data);
            }

            else if (sortByYear2.Checked)
            {
                newdata = ReverseYearSort(data);
            }

            List<string> newList = new List<string>();

            foreach (Result r in newdata)
            {
                newList.Add(r.title);
            }

            //Updating the listBox1
            listBox1.DataSource = newList;
        }

        //For returning the youtube link based on movie title
        public string YoutubeRun(string title)
        {
            string link = "";
            YouTubeService youtube = new YouTubeService(new BaseClientService.Initializer()
                {
                    //ApplicationName = " ";
                    ApiKey = YOUTUBE_API_KEY,
                }
            );
            SearchResource.ListRequest listRequest = youtube.Search.List("id");
            listRequest.Q = title;
            listRequest.MaxResults = 1;
            listRequest.Type = "video";
            SearchListResponse resp = listRequest.Execute();
            foreach (SearchResult result in resp.Items)
            {
                link = "https://www.youtube.com/v/"+result.Id.VideoId+"?version=3";
            }
            return link;
        }

        //For exiting the application
        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
