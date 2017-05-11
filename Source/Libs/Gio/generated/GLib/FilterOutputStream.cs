// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FilterOutputStream : GLib.OutputStream {

		public FilterOutputStream (IntPtr raw) : base(raw) {}

		protected FilterOutputStream() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_filter_output_stream_get_base_stream(IntPtr raw);

		[GLib.Property ("base-stream")]
		public GLib.OutputStream BaseStream {
			get  {
				IntPtr raw_ret = g_filter_output_stream_get_base_stream(Handle);
				GLib.OutputStream ret = GLib.Object.GetObject(raw_ret) as GLib.OutputStream;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_filter_output_stream_get_close_base_stream(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_filter_output_stream_set_close_base_stream(IntPtr raw, bool close_base);

		[GLib.Property ("close-base-stream")]
		public bool CloseBaseStream {
			get  {
				bool raw_ret = g_filter_output_stream_get_close_base_stream(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				g_filter_output_stream_set_close_base_stream(Handle, value);
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GFilterOutputStreamClass {
			IntPtr GReserved1;
			IntPtr GReserved2;
			IntPtr GReserved3;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.OutputStream)).GetClassSize ();
		static Dictionary<GLib.GType, GFilterOutputStreamClass> class_structs;

		static GFilterOutputStreamClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GFilterOutputStreamClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GFilterOutputStreamClass class_struct = (GFilterOutputStreamClass) Marshal.PtrToStructure (class_ptr, typeof (GFilterOutputStreamClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GFilterOutputStreamClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_filter_output_stream_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_filter_output_stream_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}