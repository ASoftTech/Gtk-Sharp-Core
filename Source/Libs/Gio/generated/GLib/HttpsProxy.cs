// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class HttpsProxy : GLib.HttpProxy {

		public HttpsProxy (IntPtr raw) : base(raw) {}

		protected HttpsProxy() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GHttpsProxyClass {
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.HttpProxy)).GetClassSize ();
		static Dictionary<GLib.GType, GHttpsProxyClass> class_structs;

		static GHttpsProxyClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GHttpsProxyClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GHttpsProxyClass class_struct = (GHttpsProxyClass) Marshal.PtrToStructure (class_ptr, typeof (GHttpsProxyClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GHttpsProxyClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

#endregion
	}
}
