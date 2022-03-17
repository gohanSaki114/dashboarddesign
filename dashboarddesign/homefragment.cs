using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dashboarddesign
{
    public class homefragment : Fragment
    {

        List<dashboardmodule> leavelist;
        recyclerviewadapter mAdapter;
        RecyclerView recycler;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
          

        }

        private void datainput()
        {
            leavelist = new List<dashboardmodule>
            {
               new dashboardmodule{ type ="Net Banking",currency="$232.5",day="16 feb",imageid = Resource.Drawable.ic_home},
               new dashboardmodule{ type ="Foods and Drinks",currency="$232.5",day="14 mar",imageid = Resource.Drawable.ic_dine},
               new dashboardmodule{ type ="Clothes",currency="$232.5",day="17 apr",imageid = Resource.Drawable.ic_cloths},
               new dashboardmodule{ type ="Sports",currency="$232.5",day="18 may",imageid = Resource.Drawable.ic_sub},
            };
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
          View view = inflater.Inflate(Resource.Layout.fragment_first, container, false);

            datainput();

            RecyclerView.LayoutManager mLayoutManager = new LinearLayoutManager(Context);
            recycler = view.FindViewById<RecyclerView>(Resource.Id.recyclerview);
            
            recycler.SetLayoutManager(mLayoutManager);
            mAdapter = new recyclerviewadapter(leavelist, Context);
            recycler.SetAdapter(mAdapter);
            return view;

        }
    }
}