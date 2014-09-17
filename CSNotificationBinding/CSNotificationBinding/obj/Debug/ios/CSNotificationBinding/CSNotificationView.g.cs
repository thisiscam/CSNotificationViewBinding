//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace CSNotificationBinding {
	[Register("CSNotificationView", true)]
	public unsafe partial class CSNotificationView : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selDismissWithStyleMessageDurationAnimated_ = "dismissWithStyle:message:duration:animated:";
		static readonly IntPtr selDismissWithStyleMessageDurationAnimated_Handle = Selector.GetHandle ("dismissWithStyle:message:duration:animated:");
		[CompilerGenerated]
		const string selImage = "image";
		static readonly IntPtr selImageHandle = Selector.GetHandle ("image");
		[CompilerGenerated]
		const string selInitWithParentViewController_ = "initWithParentViewController:";
		static readonly IntPtr selInitWithParentViewController_Handle = Selector.GetHandle ("initWithParentViewController:");
		[CompilerGenerated]
		const string selIsShowingActivity = "isShowingActivity";
		static readonly IntPtr selIsShowingActivityHandle = Selector.GetHandle ("isShowingActivity");
		[CompilerGenerated]
		const string selNotificationViewWithParentViewControllerTintColorImageMessage_ = "notificationViewWithParentViewController:tintColor:image:message:";
		static readonly IntPtr selNotificationViewWithParentViewControllerTintColorImageMessage_Handle = Selector.GetHandle ("notificationViewWithParentViewController:tintColor:image:message:");
		[CompilerGenerated]
		const string selSetImage_ = "setImage:";
		static readonly IntPtr selSetImage_Handle = Selector.GetHandle ("setImage:");
		[CompilerGenerated]
		const string selSetShowingActivity_ = "setShowingActivity:";
		static readonly IntPtr selSetShowingActivity_Handle = Selector.GetHandle ("setShowingActivity:");
		[CompilerGenerated]
		const string selSetTintColor_ = "setTintColor:";
		static readonly IntPtr selSetTintColor_Handle = Selector.GetHandle ("setTintColor:");
		[CompilerGenerated]
		const string selShowInViewControllerStyleMessage_ = "showInViewController:style:message:";
		static readonly IntPtr selShowInViewControllerStyleMessage_Handle = Selector.GetHandle ("showInViewController:style:message:");
		[CompilerGenerated]
		const string selShowInViewControllerTintColorFontTextAlignmentImageMessageDuration_ = "showInViewController:tintColor:font:textAlignment:image:message:duration:";
		static readonly IntPtr selShowInViewControllerTintColorFontTextAlignmentImageMessageDuration_Handle = Selector.GetHandle ("showInViewController:tintColor:font:textAlignment:image:message:duration:");
		[CompilerGenerated]
		const string selShowInViewControllerTintColorImageMessageDuration_ = "showInViewController:tintColor:image:message:duration:";
		static readonly IntPtr selShowInViewControllerTintColorImageMessageDuration_Handle = Selector.GetHandle ("showInViewController:tintColor:image:message:duration:");
		[CompilerGenerated]
		const string selTintColor = "tintColor";
		static readonly IntPtr selTintColorHandle = Selector.GetHandle ("tintColor");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CSNotificationView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CSNotificationView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public CSNotificationView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CSNotificationView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CSNotificationView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithParentViewController:")]
		[CompilerGenerated]
		public CSNotificationView (global::MonoTouch.UIKit.UIViewController viewController)
			: base (NSObjectFlag.Empty)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithParentViewController_Handle, viewController.Handle), "initWithParentViewController:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithParentViewController_Handle, viewController.Handle), "initWithParentViewController:");
			}
		}
		
		[Export ("dismissWithStyle:message:duration:animated:")]
		[CompilerGenerated]
		public virtual void DismissWithStyle (CSNotificationViewStyle style, string message, global::System.Double duration, bool animated)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_int_IntPtr_Double_bool (this.Handle, selDismissWithStyleMessageDurationAnimated_Handle, (int)style, nsmessage, duration, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_int_IntPtr_Double_bool (this.SuperHandle, selDismissWithStyleMessageDurationAnimated_Handle, (int)style, nsmessage, duration, animated);
			}
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("notificationViewWithParentViewController:tintColor:image:message:")]
		[CompilerGenerated]
		public static CSNotificationView NotificationViewWithParentViewController (global::MonoTouch.UIKit.UIViewController viewController, global::MonoTouch.UIKit.UIColor tintColor, global::MonoTouch.UIKit.UIImage image, string message)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (tintColor == null)
				throw new ArgumentNullException ("tintColor");
			if (image == null)
				throw new ArgumentNullException ("image");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			CSNotificationView ret;
			ret =  Runtime.GetNSObject<CSNotificationView> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selNotificationViewWithParentViewControllerTintColorImageMessage_Handle, viewController.Handle, tintColor.Handle, image.Handle, nsmessage));
			NSString.ReleaseNative (nsmessage);
			
			return ret;
		}
		
		[Export ("showInViewController:style:message:")]
		[CompilerGenerated]
		public static void ShowInViewController (global::MonoTouch.UIKit.UIViewController viewController, CSNotificationViewStyle style, string message)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_IntPtr (class_ptr, selShowInViewControllerStyleMessage_Handle, viewController.Handle, (int)style, nsmessage);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("showInViewController:tintColor:image:message:duration:")]
		[CompilerGenerated]
		public static void ShowInViewController (global::MonoTouch.UIKit.UIViewController viewController, global::MonoTouch.UIKit.UIColor tintColor, global::MonoTouch.UIKit.UIImage image, string message, global::System.Double duration)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (tintColor == null)
				throw new ArgumentNullException ("tintColor");
			if (image == null)
				throw new ArgumentNullException ("image");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_Double (class_ptr, selShowInViewControllerTintColorImageMessageDuration_Handle, viewController.Handle, tintColor.Handle, image.Handle, nsmessage, duration);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("showInViewController:tintColor:font:textAlignment:image:message:duration:")]
		[CompilerGenerated]
		public static void ShowInViewController (global::MonoTouch.UIKit.UIViewController viewController, global::MonoTouch.UIKit.UIColor tintColor, global::MonoTouch.UIKit.UIFont font, global::MonoTouch.UIKit.UITextAlignment textAlignment, global::MonoTouch.UIKit.UIImage image, string message, global::System.Double duration)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (tintColor == null)
				throw new ArgumentNullException ("tintColor");
			if (font == null)
				throw new ArgumentNullException ("font");
			if (image == null)
				throw new ArgumentNullException ("image");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_int_IntPtr_IntPtr_Double (class_ptr, selShowInViewControllerTintColorFontTextAlignmentImageMessageDuration_Handle, viewController.Handle, tintColor.Handle, font.Handle, (int)textAlignment, image.Handle, nsmessage, duration);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[CompilerGenerated]
		object __mt_Image_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImage Image {
			[Export ("image", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selImageHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selImageHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Image_var = ret;
				return ret;
			}
			
			[Export ("setImage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetImage_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetImage_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Image_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowingActivity {
			[Export ("isShowingActivity")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selIsShowingActivityHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsShowingActivityHandle);
				}
			}
			
			[Export ("setShowingActivity:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowingActivity_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowingActivity_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_TintColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor TintColor {
			[Export ("tintColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selTintColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTintColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TintColor_var = ret;
				return ret;
			}
			
			[Export ("setTintColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTintColor_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTintColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_TintColor_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Image_var = null;
				__mt_TintColor_var = null;
			}
		}
	} /* class CSNotificationView */
}
