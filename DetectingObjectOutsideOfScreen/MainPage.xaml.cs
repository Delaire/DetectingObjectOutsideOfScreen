using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DetectingObjectOutsideOfScreen
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        private void ScrollViewer_OnViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            //checking to see if the object still visible in the screen
            ShowMiniPlayer(sender);
        }

       
        private void ShowMiniPlayer(object sender)
        {
		    //Getting scrollViewer information
            var scrollViewer = (FrameworkElement)sender;

            //checking to see if the object that i want to track 
			//is still in the screen of the user

			//const to set and offset, this means that when we only see the 200px
			//of the object, we will see the other object, if we want to see check 
			//when the object is not on the screen then set the offset to 0
            const int offsetObjectBy = 200;
            if (IsObjectHidden(ObjectThatIAmTracking, scrollViewer, offsetObjectBy))
            {
                ObjectThatIWhatToSee.Visibility = Visibility.Visible;
            }
            else
            {
                ObjectThatIWhatToSee.Visibility = Visibility.Collapsed;
            }
        }

       
		//the object of this methode is to create 2 rectangles, from our two objects and see they interset or not
        protected bool IsObjectHidden(FrameworkElement child, FrameworkElement scrollViewer, int Offset)
        {
		   //Getting the information related to the scrollViewer
            GeneralTransform childTransform = child.TransformToVisual(scrollViewer);
			//creating out first rectangle using the object that i wish to ttrack
            Rect childRectangle = childTransform.TransformBounds(new Rect(new Point(0, 0), child.RenderSize));
            //creating out second rectangle  using the scrollViewer
			Rect ownerRectangle = new Rect(new Point(0, 0), scrollViewer.RenderSize);
			//Testing
            bool isInterset = IntersectsWith(childRectangle, ownerRectangle, Offset);
            return !isInterset;
        }

        public static bool IntersectsWith(Rect rect, Rect other, int offset)
        {
            // Test for separating axis on the two rectangles
            if (other.Bottom < rect.Top || other.Right < rect.Left
             || other.Top > rect.Bottom || other.Left > (rect.Right - offset))
            {
                return false;
            }
            return true;
        }


    }
}
