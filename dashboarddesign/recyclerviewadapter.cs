using Android.Content;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;


namespace dashboarddesign
{
    class recyclerviewadapter : RecyclerView.Adapter
    {
        RecyclerView.ViewHolder viewHolder;
        public const int USER = 0, IMAGE = 1;
        List<dashboardmodule> leavelist;
        MyViewHolder viewholder1;
       
        Context con;

        //public event EventHandler<int> itemClick;


        public recyclerviewadapter(List<dashboardmodule> leavelist, Context context)
        {
           this.leavelist = leavelist;
            con = context;
        }

        //public override int ItemCount => throw new NotImplementedException();
        public override int ItemCount
        {
            get { return 3; }
        }


        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
           
        MyViewHolder vh = holder as MyViewHolder;
            vh.typetext.Text = leavelist[position].type;
            vh.curency.Text = leavelist[position].currency;
            vh.day.Text = leavelist[position].day;
            vh.wishimage.SetBackgroundResource(leavelist[position].imageid);
            vh.card.SetPadding(5, 5, 5, 5);
            for (int i = 0; i <= leavelist.Count; i++)
            { 
            if (position % 2 == 0)
            {

                    
                    vh.card.SetBackgroundColor(Android.Graphics.Color.IndianRed);
            }
                else
                    {
                    vh.card.SetBackgroundColor(Android.Graphics.Color.LawnGreen);
                }
            }
        }



      

       
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

                
                    View v1 = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.rowitemdailyspends, parent, false);
                    viewHolder = new MyViewHolder(v1);
               
        
            return viewHolder;
        }
        public class MyViewHolder : RecyclerView.ViewHolder
        {
            //private readonly Action<int> listener;
            public ImageView wishimage;
            public CardView card;
            public TextView typetext, curency, day;
            public MyViewHolder(View itemView) : base(itemView)
            {
                card = itemView.FindViewById<CardView>(Resource.Id.cardimage);
                wishimage = itemView.FindViewById<ImageView>(Resource.Id.imageWhishlist);
                typetext = itemView.FindViewById<TextView>(Resource.Id.textitem);
                curency = itemView.FindViewById<TextView>(Resource.Id.currencytext);
                day = itemView.FindViewById<TextView>(Resource.Id.item3);
            }


        }
      

    }
}