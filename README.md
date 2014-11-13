How to detect if an object is outside of the screen for Windows Store Apps (C#/XAML)
=========================


How to detect if an object is intersecting with another object

This is a tutorial on how to implement a methode that allows us to see if you have 2 objects that are intersecting with one another.
I mainly use this to see if an object is outside of the screen for the user and thus need to show him something else when that object is not visible anymore.

If you don't want to have to look at the code here is the important part, these two methodes IsObjectHidden and IntersectsWith.

//the object of this methode is to create 2 rectangles, from our two objects and see they intersect or not
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

		

License

This project is licensed under the MIT license.
