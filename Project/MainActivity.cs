using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Android.Media;
using System.Security.Policy;

namespace Project
{
    [Activity(Label = "The Idea Center App", MainLauncher = false, Icon = "@drawable/Icon")]
    public class MainActivity : Activity
    {
        private ListView mListView;
        private List<string> mItems;
        static List<Courses> courses;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            mListView = FindViewById<ListView>(Resource.Id.list);

            InitializeArray();

            mItems = new List<string>();

            for (int i = 0; i < courses.Count; i++)
            {
                mItems.Add(courses[i].Name);
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);

            mListView.Adapter = adapter;

            mListView.ItemClick += mListView_ItemClick;
            mListView.ItemLongClick += mListView_ItemLongClick;


        }

        void mListView_ItemClick(object osender, AdapterView.ItemClickEventArgs e)
        {
            Intent intent = new Intent(Application.Context, typeof(Description));
            intent.PutExtra("name", courses[e.Position].Name);
            intent.PutExtra("description", courses[e.Position].Description);
            StartActivity(intent);
        }

        void mListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            var website = courses[e.Position].link;
            var uri = Android.Net.Uri.Parse(website);
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }


        public void InitializeArray()
        {
            // Create Courses
            Courses cs50 = new Courses();
            cs50.Name = "CS50x Miami";
            cs50.Description = "Hack this Harvard course without leaving your hometown.\n\n<3\nBEST COURSE EVER \\o/ ";
            cs50.link = "http://theideacenter.co/cs50xmiami/";

            Courses design = new Courses();
            design.Name = "Design for Miami";
            design.Description = "Experiment, collaborate, and polish your skills using technology and your creativity.";
            design.link = "http://theideacenter.co/designformiami/";

            Courses create = new Courses();
            create.Name = "Create";
            create.Description = " Set your idea on the fast track by learning through experience.";
            create.link = "http://theideacenter.co/create/";

            Courses inovation = new Courses();
            inovation.Name = "Innovation M";
            inovation.Description = "Learn from the pros, get inspired, and top it off with a 24-hour challenge.";
            inovation.link = "http://theideacenter.co/innovationm/";

            Courses generation = new Courses();
            generation.Name = "Generation IT";
            generation.Description = "Jump start your tech career with this intensive program.";
            generation.link = "http://theideacenter.co/GenerationIT/";

            Courses market = new Courses();
            market.Name = "MarketHack";
            market.Description = "Learn the right tools to find your audience online and keep them coming back.";
            market.link = "http://theideacenter.co/markethack/";

            Courses web = new Courses();
            web.Name = "WebDev";
            web.Description = "Don't know where to begin? Start here for the basics.";
            web.link = "http://theideacenter.co/webdev/";

            Courses drones= new Courses();
            drones.Name = "Drones Up";
            drones.Description = "Capture breathtaking views as you operate a drone across the sky.";
            drones.link = "http://theideacenter.co/dronesup/";

            Courses start = new Courses();
            start.Name = "Start Up";
            start.Description = "Transform your idea into a real business. Make your pitch to mentors and experts.";
            start.link = "http://theideacenter.co/startupchallenge/";

            Courses puente = new Courses();
            puente.Name = "Puente";
            puente.Description = "Los recursos para desarrollar su idea y hallar soluciones tanto en Miami como en Cuba.";
            puente.link = "http://theideacenter.co/puente/";

            Courses make = new Courses();
            make.Name = "Drones Up";
            make.Description = " The hands-on skills you need for designing and prototyping.";
            make.link = "http://theideacenter.co/make1/";

            Courses google = new Courses();
            google.Name = "Google Analytics";
            google.Description = "Capture breathtaking views as you operate a drone across the sky.";
            google.link = "http://theideacenter.co/googleanalytics/";

            Courses face = new Courses();
            face.Name = "Facebook Blueprint";
            face.Description = "Make sure your message stands out on the world's biggest digital platform.";
            face.link = "http://theideacenter.co/blueprint/";

            Courses insight = new Courses();
            insight.Name = "Insight";
            insight.Description = "Build your data portfolio using the R and Tableau software.";
            insight.link = "http://theideacenter.co/insight/";

            Courses immersive = new Courses();
            immersive.Name = "Immersive Tech";
            immersive.Description = "Take tech in Miami to the next level with virtual and augmented reality.";
            immersive.link = "http://theideacenter.co/immersive/";

            // Add courses in the list
            courses = new List<Courses>();

            courses.Add(cs50);
            courses.Add(design);
            courses.Add(create);
            courses.Add(inovation);
            courses.Add(generation);
            courses.Add(market);
            courses.Add(web);
            courses.Add(drones);
            courses.Add(start);
            courses.Add(puente);
            courses.Add(make);
            courses.Add(google);
            courses.Add(face);
            courses.Add(insight);
            courses.Add(immersive);
        }
    }
}

