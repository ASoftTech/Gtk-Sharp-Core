// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class UnixFDList : GLib.Object {

		public UnixFDList (IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_fd_list_new();

		public UnixFDList () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UnixFDList)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = g_unix_fd_list_new();
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GUnixFDListClass {
			IntPtr GReserved1;
			IntPtr GReserved2;
			IntPtr GReserved3;
			IntPtr GReserved4;
			IntPtr GReserved5;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GUnixFDListClass> class_structs;

		static GUnixFDListClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GUnixFDListClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GUnixFDListClass class_struct = (GUnixFDListClass) Marshal.PtrToStructure (class_ptr, typeof (GUnixFDListClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GUnixFDListClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe int g_unix_fd_list_append(IntPtr raw, int fd, out IntPtr error);

		public unsafe int Append(int fd) {
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_unix_fd_list_append(Handle, fd, out error);
			int ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe int g_unix_fd_list_get(IntPtr raw, int index_, out IntPtr error);

		public unsafe int Get(int index_) {
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_unix_fd_list_get(Handle, index_, out error);
			int ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_unix_fd_list_get_length(IntPtr raw);

		public int Length { 
			get {
				int raw_ret = g_unix_fd_list_get_length(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_fd_list_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_unix_fd_list_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_unix_fd_list_peek_fds(IntPtr raw, out int length);

		public int PeekFds(out int length) {
			int raw_ret = g_unix_fd_list_peek_fds(Handle, out length);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_unix_fd_list_steal_fds(IntPtr raw, out int length);

		public int StealFds(out int length) {
			int raw_ret = g_unix_fd_list_steal_fds(Handle, out length);
			int ret = raw_ret;
			return ret;
		}

#endregion
	}
}