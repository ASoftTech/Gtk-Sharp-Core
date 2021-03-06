// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SimpleIOStream : GLib.IOStream {

		public SimpleIOStream (IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_simple_io_stream_new(IntPtr input_stream, IntPtr output_stream);

		public SimpleIOStream (GLib.InputStream input_stream, GLib.OutputStream output_stream) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SimpleIOStream)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (input_stream != null) {
					names.Add ("input_stream");
					vals.Add (new GLib.Value (input_stream));
				}
				if (output_stream != null) {
					names.Add ("output_stream");
					vals.Add (new GLib.Value (output_stream));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_simple_io_stream_new(input_stream == null ? IntPtr.Zero : input_stream.Handle, output_stream == null ? IntPtr.Zero : output_stream.Handle);
		}

		[GLib.Property ("input-stream")]
		public new GLib.InputStream InputStream {
			get {
				GLib.Value val = GetProperty ("input-stream");
				GLib.InputStream ret = (GLib.InputStream) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("output-stream")]
		public new GLib.OutputStream OutputStream {
			get {
				GLib.Value val = GetProperty ("output-stream");
				GLib.OutputStream ret = (GLib.OutputStream) val;
				val.Dispose ();
				return ret;
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GSimpleIOStreamClass {
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.IOStream)).GetClassSize ();
		static Dictionary<GLib.GType, GSimpleIOStreamClass> class_structs;

		static GSimpleIOStreamClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GSimpleIOStreamClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GSimpleIOStreamClass class_struct = (GSimpleIOStreamClass) Marshal.PtrToStructure (class_ptr, typeof (GSimpleIOStreamClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GSimpleIOStreamClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_simple_io_stream_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_simple_io_stream_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
