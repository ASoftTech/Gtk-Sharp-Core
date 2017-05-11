// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class IconSet : GLib.Opaque {

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_set_add_source(IntPtr raw, IntPtr source);

		[Obsolete]
		public void AddSource(Gtk.IconSource source) {
			gtk_icon_set_add_source(Handle, source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_set_copy(IntPtr raw);

		[Obsolete]
		public Gtk.IconSet Copy() {
			IntPtr raw_ret = gtk_icon_set_copy(Handle);
			Gtk.IconSet ret = raw_ret == IntPtr.Zero ? null : (Gtk.IconSet) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.IconSet), true);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_set_get_type();

		[Obsolete]
		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_icon_set_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_set_render_icon(IntPtr raw, IntPtr style, int direction, int state, int size, IntPtr widget, IntPtr detail);

		[Obsolete]
		public Gdk.Pixbuf RenderIcon(Gtk.Style style, Gtk.TextDirection direction, Gtk.StateType state, Gtk.IconSize size, Gtk.Widget widget, string detail) {
			IntPtr native_detail = GLib.Marshaller.StringToPtrGStrdup (detail);
			IntPtr raw_ret = gtk_icon_set_render_icon(Handle, style == null ? IntPtr.Zero : style.Handle, (int) direction, (int) state, (int) size, widget == null ? IntPtr.Zero : widget.Handle, native_detail);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			GLib.Marshaller.Free (native_detail);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_set_render_icon_pixbuf(IntPtr raw, IntPtr context, int size);

		[Obsolete]
		public Gdk.Pixbuf RenderIconPixbuf(Gtk.StyleContext context, Gtk.IconSize size) {
			IntPtr raw_ret = gtk_icon_set_render_icon_pixbuf(Handle, context == null ? IntPtr.Zero : context.Handle, (int) size);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_set_render_icon_surface(IntPtr raw, IntPtr context, int size, int scale, IntPtr for_window);

		[Obsolete]
		public Cairo.Surface RenderIconSurface(Gtk.StyleContext context, Gtk.IconSize size, int scale, Gdk.Window for_window) {
			IntPtr raw_ret = gtk_icon_set_render_icon_surface(Handle, context == null ? IntPtr.Zero : context.Handle, (int) size, scale, for_window == null ? IntPtr.Zero : for_window.Handle);
			Cairo.Surface ret = Cairo.Surface.Lookup (raw_ret, true);
			return ret;
		}

		public IconSet(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_set_new();

		public IconSet () 
		{
			Raw = gtk_icon_set_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_set_new_from_pixbuf(IntPtr pixbuf);

		public IconSet (Gdk.Pixbuf pixbuf) 
		{
			Raw = gtk_icon_set_new_from_pixbuf(pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_set_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				gtk_icon_set_ref (raw);
				Owned = true;
			}
		}

		[Obsolete("Gtk.IconSet is now refcounted automatically")]
		public IconSet Ref () { return this; }

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_set_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				gtk_icon_set_unref (raw);
				Owned = false;
			}
		}

		[Obsolete("Gtk.IconSet is now refcounted automatically")]
		public void Unref () {}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gtk_icon_set_unref (handle);
				return false;
			}
		}

		~IconSet ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}

#endregion
	}
}
