using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using static Google.Android.Material.BottomNavigation.BottomNavigationView;

namespace dashboarddesign
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoAcionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity,IOnNavigationItemSelectedListener
    {
        BottomNavigationView bottomNavigationView;
        homefragment home;
        likefragment like;
        locationfragment location;
        profilefragment profilefragment;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            bottomNavigationView = FindViewById<BottomNavigationView>(Resource.Id.bottomNavigationView);
            bottomNavigationView.SetOnNavigationItemSelectedListener(this);
             home = new homefragment();
            like = new likefragment(); 
            location = new locationfragment();
            profilefragment = new profilefragment();    


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.action_home:
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.flFragment, home).Commit();
                    
                    return true;

                case Resource.Id.action_Like:
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.flFragment, like).Commit();
                    return true;

                case Resource.Id.action_loaction:
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.flFragment, location).Commit();
                    return true;

                case Resource.Id.action_profile:
                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.flFragment, profilefragment).Commit();
                    return true;
            }
            return false;
        }
    }
}