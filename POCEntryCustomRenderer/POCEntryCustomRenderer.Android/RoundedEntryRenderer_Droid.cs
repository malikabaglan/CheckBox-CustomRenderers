using System;
using Android.Content;
using Android.Graphics.Drawables;
using POCEntryCustomRenderer;
using POCEntryCustomRenderer.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly:ExportRenderer(typeof(RoundedEntry),typeof(RoundedEntryRenderer_Droid))]
namespace POCEntryCustomRenderer.Droid
{
 public class RoundedEntryRenderer_Droid:EntryRenderer
    {

        public RoundedEntryRenderer_Droid(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(e.OldElement==null)
            {

               // Control.SetBackgroundResource(Resource.Layout.rounded_shape);

                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(60f);
                gradientDrawable.SetStroke(5, Android.Graphics.Color.DeepPink);
                gradientDrawable.SetColor(Android.Graphics.Color.LightGray);
                Control.SetBackground(gradientDrawable);


                Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);

            
              }
        }
    }
}
