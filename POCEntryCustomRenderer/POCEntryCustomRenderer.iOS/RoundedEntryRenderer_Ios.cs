using System;
using CoreGraphics;
using POCEntryCustomRenderer;
using POCEntryCustomRenderer.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;



[assembly:ExportRenderer(typeof (RoundedEntry),typeof(RoundedEntryRenderer_Ios))]
namespace POCEntryCustomRenderer.iOS
{
    public class RoundedEntryRenderer_Ios:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement==null)
            {
                Control.Layer.CornerRadius = 20;
                Control.Layer.BorderWidth = 3f;
                Control.Layer.BorderColor = Color.DeepPink.ToCGColor();
                Control.Layer.BackgroundColor = Color.LightGray.ToCGColor();


                Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0));
                Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
            
            }

}
    }
}
