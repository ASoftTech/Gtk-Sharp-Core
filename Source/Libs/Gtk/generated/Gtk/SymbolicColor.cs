// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SymbolicColor : GLib.Opaque {

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_symbolic_color_get_type();

		[Obsolete]
		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_symbolic_color_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_symbolic_color_to_string(IntPtr raw);

		[Obsolete]
		public override string ToString() {
			IntPtr raw_ret = gtk_symbolic_color_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		public SymbolicColor(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_symbolic_color_new_alpha(IntPtr color, double factor);

		public SymbolicColor (Gtk.SymbolicColor color, double factor) 
		{
			Raw = gtk_symbolic_color_new_alpha(color == null ? IntPtr.Zero : color.Handle, factor);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_symbolic_color_new_literal(IntPtr color);

		public SymbolicColor (Gdk.RGBA color) 
		{
			IntPtr native_color = GLib.Marshaller.StructureToPtrAlloc (color);
			Raw = gtk_symbolic_color_new_literal(native_color);
			Marshal.FreeHGlobal (native_color);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_symbolic_color_new_mix(IntPtr color1, IntPtr color2, double factor);

		public SymbolicColor (Gtk.SymbolicColor color1, Gtk.SymbolicColor color2, double factor) 
		{
			Raw = gtk_symbolic_color_new_mix(color1 == null ? IntPtr.Zero : color1.Handle, color2 == null ? IntPtr.Zero : color2.Handle, factor);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_symbolic_color_new_name(IntPtr name);

		public SymbolicColor (string name) 
		{
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = gtk_symbolic_color_new_name(native_name);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_symbolic_color_new_shade(IntPtr color, double factor);

		public static SymbolicColor NewShade(Gtk.SymbolicColor color, double factor)
		{
			SymbolicColor result = new SymbolicColor (gtk_symbolic_color_new_shade(color == null ? IntPtr.Zero : color.Handle, factor));
			return result;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_symbolic_color_new_win32(IntPtr theme_class, int id);

		public SymbolicColor (string theme_class, int id) 
		{
			IntPtr native_theme_class = GLib.Marshaller.StringToPtrGStrdup (theme_class);
			Raw = gtk_symbolic_color_new_win32(native_theme_class, id);
			GLib.Marshaller.Free (native_theme_class);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_symbolic_color_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				gtk_symbolic_color_ref (raw);
				Owned = true;
			}
		}

		[Obsolete("Gtk.SymbolicColor is now refcounted automatically")]
		public SymbolicColor Ref () { return this; }

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_symbolic_color_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				gtk_symbolic_color_unref (raw);
				Owned = false;
			}
		}

		[Obsolete("Gtk.SymbolicColor is now refcounted automatically")]
		public void Unref () {}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gtk_symbolic_color_unref (handle);
				return false;
			}
		}

		~SymbolicColor ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}

#endregion
	}
}
