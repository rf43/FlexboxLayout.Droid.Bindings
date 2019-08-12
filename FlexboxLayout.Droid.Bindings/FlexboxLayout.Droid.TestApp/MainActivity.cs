using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using Flexbox = Com.Google.Android.Flexbox;

namespace FlexboxLayout.Droid.TestApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            var flexboxLayout = FindViewById<Flexbox.FlexboxLayout>(Resource.Id.flexbox_layout_wrapper);
            flexboxLayout.FlexDirection = (int)Flexbox.FlexDirection.Column;

            var alignContent = Flexbox.AlignContent.Center;
            alignContent = Flexbox.AlignContent.SpaceAround;
            alignContent = Flexbox.AlignContent.SpaceBetween;
            alignContent = Flexbox.AlignContent.FlexEnd;
            alignContent = Flexbox.AlignContent.FlexStart;
            alignContent = Flexbox.AlignContent.Stretch;

            var alignSelf = Flexbox.AlignSelf.Auto;
            alignSelf = Flexbox.AlignSelf.Baseline;
            alignSelf = Flexbox.AlignSelf.Center;
            alignSelf = Flexbox.AlignSelf.FlexEnd;
            alignSelf = Flexbox.AlignSelf.FlexStart;
            alignSelf = Flexbox.AlignSelf.Stretch;

            var alignItem = Flexbox.AlignItems.Baseline;
            alignItem = Flexbox.AlignItems.Center;
            alignItem = Flexbox.AlignItems.FlexEnd;
            alignItem = Flexbox.AlignItems.FlexStart;
            alignItem = Flexbox.AlignItems.Stretch;

            var flexDirection = Flexbox.FlexDirection.Column;
            flexDirection = Flexbox.FlexDirection.ColumnReverse;
            flexDirection = Flexbox.FlexDirection.Row;
            flexDirection = Flexbox.FlexDirection.RowReverse;

            var flexWrap = Flexbox.FlexWrap.Wrap;
            flexWrap = Flexbox.FlexWrap.NoWrap;
            flexWrap = Flexbox.FlexWrap.WrapReverse;

            var justifyContent = Flexbox.JustifyContent.Center;
            justifyContent = Flexbox.JustifyContent.FlexEnd;
            justifyContent = Flexbox.JustifyContent.FlexStart;
            justifyContent = Flexbox.JustifyContent.SpaceAround;
            justifyContent = Flexbox.JustifyContent.SpaceBetween;
            justifyContent = Flexbox.JustifyContent.SpaceEvenly;
        }
    }
}
