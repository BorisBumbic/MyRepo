using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace XamarinSlotMachine.ImageViewScrolling
{
    public class ImageViewScrolling : FrameLayout
    {
        private static int ANIMATION_DUR = 150;
        public ImageView currentImage, nextImage;
        public int last_result = 0, old_value = 0;
        public IEventEnd eventEnd;

        public ImageViewScrolling(Context context) : base(context)
        {
            Init(context);
        }

        private void Init(Context context)
        {
            LayoutInflater.From(context).Inflate(Resource.Layout.layout1, this);
            currentImage = FindViewById<ImageView>(Resource.Id.currentImage);
            nextImage = FindViewById<ImageView>(Resource.Id.nextImage);

            nextImage.TranslationY = (Height);
        }

        internal void SetImage(ImageView imageView, int v)
        {
            if(v == Utils.BAR)
            {
                imageView.SetImageResource(Resource.Drawable.bar_done);
            }
            else if (v == Utils.SEVEN)
            {
                imageView.SetImageResource(Resource.Drawable.sevent_done);
            }
            else if (v == Utils.LEMON)
            {
                imageView.SetImageResource(Resource.Drawable.lemon_done);
            }
            else if (v == Utils.ORANGE)
            {
                imageView.SetImageResource(Resource.Drawable.orange_done);
            }
            else if (v == Utils.TRIPLE)
            {
                imageView.SetImageResource(Resource.Drawable.triple_done);
            }
            else
            {
                imageView.SetImageResource(Resource.Drawable.waternelon_done);
            }

            imageView.Tag = v;
            last_result = v;

        }

        public int GetValue()
        {
            return int.Parse(nextImage.Tag.ToString());
        }

        public ImageViewScrolling(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Init(Context);
        }

        public void SetEventEnd(IEventEnd eventEnd)
        {
            this.eventEnd = eventEnd;
        }

        public void SetValueRandom(int image, int rotate_count)
        {
            currentImage.Animate().SetDuration(ANIMATION_DUR).TranslationY(-Height).Start();

            nextImage.TranslationY = nextImage.Height;

            nextImage.Animate().TranslationY(0).SetDuration(ANIMATION_DUR).SetListener(new MyListener(this, image, rotate_count));
        }
    }
}