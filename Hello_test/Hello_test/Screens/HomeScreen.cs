using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Hello_test
{
	public partial class HomeScreen : UIViewController
	{
		public HomeScreen () : base ("HomeScreen", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.


			btnHelloWorld.TouchUpInside += (object sender, EventArgs e) => 
			{
				this.NavigationController.PushViewController(new Hello_main(),true);
			};

			btnHelloUniverse.TouchUpInside += (object sender, EventArgs e) => 
			{
				this.NavigationController.PushViewController(new HelloUniverse(),false);
			};
		}
	}
}

