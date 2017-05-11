// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FrameClockIdle : Gdk.FrameClock {

		public FrameClockIdle (IntPtr raw) : base(raw) {}

		protected FrameClockIdle() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GdkFrameClockIdleClass {
		}

		static uint class_offset = ((GLib.GType) typeof (Gdk.FrameClock)).GetClassSize ();
		static Dictionary<GLib.GType, GdkFrameClockIdleClass> class_structs;

		static GdkFrameClockIdleClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GdkFrameClockIdleClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GdkFrameClockIdleClass class_struct = (GdkFrameClockIdleClass) Marshal.PtrToStructure (class_ptr, typeof (GdkFrameClockIdleClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GdkFrameClockIdleClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_frame_clock_idle_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_frame_clock_idle_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}