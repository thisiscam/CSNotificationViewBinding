using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace CSNotificationBinding {
	public delegate void CSVoidBlock ();
	public delegate bool CompletionCallback();

	[BaseType (typeof (UIView))]
	public partial interface CSNotificationView {

		[Static, Export ("showInViewController:style:message:")]
		void ShowInViewController (UIViewController viewController, CSNotificationViewStyle style, string message);

		[Static, Export ("showInViewController:tintColor:image:message:duration:")]
		void ShowInViewController (UIViewController viewController, UIColor tintColor, UIImage image, string message, double duration);

		[Static, Export ("showInViewController:tintColor:font:textAlignment:image:message:duration:")]
		void ShowInViewController (UIViewController viewController, UIColor tintColor, UIFont font, UITextAlignment textAlignment, UIImage image, string message, double duration);

		[Static, Export ("notificationViewWithParentViewController:tintColor:image:message:")]
		CSNotificationView NotificationViewWithParentViewController (UIViewController viewController, UIColor tintColor, [NullAllowed]UIImage image, string message);

		[Export ("initWithParentViewController:")]
		IntPtr Constructor (UIViewController viewController);

		[Export ("setVisible:animated:completion:")]
		void SetVisible (bool showing, bool animated, CompletionCallback completion);

		[Export ("dismissWithStyle:message:duration:animated:")]
		void DismissWithStyle (CSNotificationViewStyle style, string message, double duration, bool animated);

		[Export ("visible")]
		bool Visible { [Bind ("isShowing")] get; }

		[Export ("image", ArgumentSemantic.Retain)]
		UIImage Image { get; set; }

		[Export ("tintColor", ArgumentSemantic.Retain)]
		UIColor TintColor { get; set; }

		[Export ("showingActivity")]
		bool ShowingActivity { [Bind ("isShowingActivity")] get; set; }


		[Export ("tapHandler", ArgumentSemantic.Copy)]
		CSVoidBlock TapHandler { get; set; }
	}
}
