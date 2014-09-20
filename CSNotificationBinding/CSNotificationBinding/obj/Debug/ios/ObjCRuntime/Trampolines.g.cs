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

namespace MonoTouch.ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate bool DCompletionCallback (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDCompletionCallback {
			static internal readonly DCompletionCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DCompletionCallback))]
			static unsafe bool Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::CSNotificationBinding.CompletionCallback) (descriptor->Target);
				System.Boolean retval = del ();
				return retval;
			}
		} /* class SDCompletionCallback */
		
		internal class NIDCompletionCallback {
			IntPtr blockPtr;
			DCompletionCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDCompletionCallback (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DCompletionCallback> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDCompletionCallback ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::CSNotificationBinding.CompletionCallback Create (IntPtr block)
			{
				return new NIDCompletionCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe bool Invoke ()
			{
				var ret = invoker (blockPtr);
				return ret;
			}
		} /* class NIDCompletionCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DCSVoidBlock (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDCSVoidBlock {
			static internal readonly DCSVoidBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DCSVoidBlock))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::CSNotificationBinding.CSVoidBlock) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDCSVoidBlock */
		
		internal class NIDCSVoidBlock {
			IntPtr blockPtr;
			DCSVoidBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDCSVoidBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DCSVoidBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDCSVoidBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::CSNotificationBinding.CSVoidBlock Create (IntPtr block)
			{
				return new NIDCSVoidBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDCSVoidBlock */
	}
}
