// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class DataInputStream : GLib.BufferedInputStream {

		public DataInputStream (IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_data_input_stream_new(IntPtr base_stream);

		public DataInputStream (GLib.InputStream base_stream) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (DataInputStream)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (base_stream != null) {
					names.Add ("base_stream");
					vals.Add (new GLib.Value (base_stream));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_data_input_stream_new(base_stream == null ? IntPtr.Zero : base_stream.Handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_data_input_stream_get_byte_order(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_data_input_stream_set_byte_order(IntPtr raw, int order);

		[GLib.Property ("byte-order")]
		public GLib.DataStreamByteOrder ByteOrder {
			get  {
				int raw_ret = g_data_input_stream_get_byte_order(Handle);
				GLib.DataStreamByteOrder ret = (GLib.DataStreamByteOrder) raw_ret;
				return ret;
			}
			set  {
				g_data_input_stream_set_byte_order(Handle, (int) value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_data_input_stream_get_newline_type(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_data_input_stream_set_newline_type(IntPtr raw, int type);

		[GLib.Property ("newline-type")]
		public GLib.DataStreamNewlineType NewlineType {
			get  {
				int raw_ret = g_data_input_stream_get_newline_type(Handle);
				GLib.DataStreamNewlineType ret = (GLib.DataStreamNewlineType) raw_ret;
				return ret;
			}
			set  {
				g_data_input_stream_set_newline_type(Handle, (int) value);
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GDataInputStreamClass {
			IntPtr GReserved1;
			IntPtr GReserved2;
			IntPtr GReserved3;
			IntPtr GReserved4;
			IntPtr GReserved5;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.BufferedInputStream)).GetClassSize ();
		static Dictionary<GLib.GType, GDataInputStreamClass> class_structs;

		static GDataInputStreamClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GDataInputStreamClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GDataInputStreamClass class_struct = (GDataInputStreamClass) Marshal.PtrToStructure (class_ptr, typeof (GDataInputStreamClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GDataInputStreamClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_data_input_stream_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_data_input_stream_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe byte g_data_input_stream_read_byte(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe new byte ReadByte(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			byte raw_ret = g_data_input_stream_read_byte(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			byte ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe short g_data_input_stream_read_int16(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe short ReadInt16(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			short raw_ret = g_data_input_stream_read_int16(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			short ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe int g_data_input_stream_read_int32(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe int ReadInt32(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_data_input_stream_read_int32(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			int ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe long g_data_input_stream_read_int64(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe long ReadInt64(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			long raw_ret = g_data_input_stream_read_int64(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			long ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_data_input_stream_read_line(IntPtr raw, out UIntPtr length, IntPtr cancellable, out IntPtr error);

		public unsafe string ReadLine(out ulong length, GLib.Cancellable cancellable) {
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_data_input_stream_read_line(Handle, out native_length, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_data_input_stream_read_line_async(IntPtr raw, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void ReadLineAsync(int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_data_input_stream_read_line_async(Handle, io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_data_input_stream_read_line_finish(IntPtr raw, IntPtr result, out UIntPtr length, out IntPtr error);

		public unsafe string ReadLineFinish(GLib.IAsyncResult result, out ulong length) {
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_data_input_stream_read_line_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out native_length, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_data_input_stream_read_line_finish_utf8(IntPtr raw, IntPtr result, out UIntPtr length, out IntPtr error);

		public unsafe string ReadLineFinishUtf8(GLib.IAsyncResult result, out ulong length) {
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_data_input_stream_read_line_finish_utf8(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out native_length, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_data_input_stream_read_line_utf8(IntPtr raw, out UIntPtr length, IntPtr cancellable, out IntPtr error);

		public unsafe string ReadLineUtf8(out ulong length, GLib.Cancellable cancellable) {
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_data_input_stream_read_line_utf8(Handle, out native_length, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe ushort g_data_input_stream_read_uint16(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe ushort ReadUint16(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			ushort raw_ret = g_data_input_stream_read_uint16(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			ushort ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe uint g_data_input_stream_read_uint32(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe uint ReadUint32(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			uint raw_ret = g_data_input_stream_read_uint32(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			uint ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe ulong g_data_input_stream_read_uint64(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe ulong ReadUint64(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			ulong raw_ret = g_data_input_stream_read_uint64(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			ulong ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_data_input_stream_read_until(IntPtr raw, IntPtr stop_chars, out UIntPtr length, IntPtr cancellable, out IntPtr error);

		public unsafe string ReadUntil(string stop_chars, out ulong length, GLib.Cancellable cancellable) {
			IntPtr native_stop_chars = GLib.Marshaller.StringToPtrGStrdup (stop_chars);
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_data_input_stream_read_until(Handle, native_stop_chars, out native_length, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_stop_chars);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_data_input_stream_read_until_async(IntPtr raw, IntPtr stop_chars, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void ReadUntilAsync(string stop_chars, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_stop_chars = GLib.Marshaller.StringToPtrGStrdup (stop_chars);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_data_input_stream_read_until_async(Handle, native_stop_chars, io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_stop_chars);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_data_input_stream_read_until_finish(IntPtr raw, IntPtr result, out UIntPtr length, out IntPtr error);

		public unsafe string ReadUntilFinish(GLib.IAsyncResult result, out ulong length) {
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_data_input_stream_read_until_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out native_length, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_data_input_stream_read_upto(IntPtr raw, IntPtr stop_chars, IntPtr stop_chars_len, out UIntPtr length, IntPtr cancellable, out IntPtr error);

		public unsafe string ReadUpto(string stop_chars, out ulong length, GLib.Cancellable cancellable) {
			IntPtr native_stop_chars = GLib.Marshaller.StringToPtrGStrdup (stop_chars);
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_data_input_stream_read_upto(Handle, native_stop_chars, new IntPtr ((long) System.Text.Encoding.UTF8.GetByteCount (stop_chars)), out native_length, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_stop_chars);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_data_input_stream_read_upto_async(IntPtr raw, IntPtr stop_chars, IntPtr stop_chars_len, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void ReadUptoAsync(string stop_chars, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_stop_chars = GLib.Marshaller.StringToPtrGStrdup (stop_chars);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_data_input_stream_read_upto_async(Handle, native_stop_chars, new IntPtr ((long) System.Text.Encoding.UTF8.GetByteCount (stop_chars)), io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_stop_chars);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_data_input_stream_read_upto_finish(IntPtr raw, IntPtr result, out UIntPtr length, out IntPtr error);

		public unsafe string ReadUptoFinish(GLib.IAsyncResult result, out ulong length) {
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_data_input_stream_read_upto_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out native_length, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

#endregion
	}
}
