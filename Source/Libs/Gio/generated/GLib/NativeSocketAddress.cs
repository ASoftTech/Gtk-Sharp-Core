// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class NativeSocketAddress : GLib.SocketAddress {

		public NativeSocketAddress (IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_native_socket_address_new(IntPtr native, UIntPtr len);

		public NativeSocketAddress (IntPtr native, ulong len) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (NativeSocketAddress)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_native_socket_address_new(native, new UIntPtr (len));
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GNativeSocketAddressClass {
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.SocketAddress)).GetClassSize ();
		static Dictionary<GLib.GType, GNativeSocketAddressClass> class_structs;

		static GNativeSocketAddressClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GNativeSocketAddressClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GNativeSocketAddressClass class_struct = (GNativeSocketAddressClass) Marshal.PtrToStructure (class_ptr, typeof (GNativeSocketAddressClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GNativeSocketAddressClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_native_socket_address_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_native_socket_address_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
