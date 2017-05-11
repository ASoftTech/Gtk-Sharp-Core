// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class InetSocketAddress : GLib.SocketAddress, GLib.ISocketConnectable {

		public InetSocketAddress (IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_inet_socket_address_new(IntPtr address, ushort port);

		public InetSocketAddress (GLib.InetAddress address, ushort port) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (InetSocketAddress)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (address != null) {
					names.Add ("address");
					vals.Add (new GLib.Value (address));
				}
				names.Add ("port");
				vals.Add (new GLib.Value (port));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_inet_socket_address_new(address == null ? IntPtr.Zero : address.Handle, port);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_inet_socket_address_new_from_string(IntPtr address, uint port);

		public InetSocketAddress (string address, uint port) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (InetSocketAddress)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("address");
				vals.Add (new GLib.Value (address));
				names.Add ("port");
				vals.Add (new GLib.Value (port));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_address = GLib.Marshaller.StringToPtrGStrdup (address);
			Raw = g_inet_socket_address_new_from_string(native_address, port);
			GLib.Marshaller.Free (native_address);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_inet_socket_address_get_address(IntPtr raw);

		[GLib.Property ("address")]
		public GLib.InetAddress Address {
			get  {
				IntPtr raw_ret = g_inet_socket_address_get_address(Handle);
				GLib.InetAddress ret = GLib.Object.GetObject(raw_ret) as GLib.InetAddress;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ushort g_inet_socket_address_get_port(IntPtr raw);

		[GLib.Property ("port")]
		public ushort Port {
			get  {
				ushort raw_ret = g_inet_socket_address_get_port(Handle);
				ushort ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_inet_socket_address_get_flowinfo(IntPtr raw);

		[GLib.Property ("flowinfo")]
		public uint Flowinfo {
			get  {
				uint raw_ret = g_inet_socket_address_get_flowinfo(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_inet_socket_address_get_scope_id(IntPtr raw);

		[GLib.Property ("scope-id")]
		public uint ScopeId {
			get  {
				uint raw_ret = g_inet_socket_address_get_scope_id(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GInetSocketAddressClass {
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.SocketAddress)).GetClassSize ();
		static Dictionary<GLib.GType, GInetSocketAddressClass> class_structs;

		static GInetSocketAddressClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GInetSocketAddressClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GInetSocketAddressClass class_struct = (GInetSocketAddressClass) Marshal.PtrToStructure (class_ptr, typeof (GInetSocketAddressClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GInetSocketAddressClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_inet_socket_address_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_inet_socket_address_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_connectable_enumerate(IntPtr raw);

		public GLib.SocketAddressEnumerator Enumerate() {
			IntPtr raw_ret = g_socket_connectable_enumerate(Handle);
			GLib.SocketAddressEnumerator ret = GLib.Object.GetObject(raw_ret) as GLib.SocketAddressEnumerator;
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_connectable_proxy_enumerate(IntPtr raw);

		public GLib.SocketAddressEnumerator ProxyEnumerate() {
			IntPtr raw_ret = g_socket_connectable_proxy_enumerate(Handle);
			GLib.SocketAddressEnumerator ret = GLib.Object.GetObject(raw_ret) as GLib.SocketAddressEnumerator;
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_connectable_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr raw_ret = g_socket_connectable_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

#endregion
	}
}