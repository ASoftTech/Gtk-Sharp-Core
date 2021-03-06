// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Revealer : Gtk.Bin {

		public Revealer (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_revealer_new();

		public Revealer () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Revealer)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_revealer_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_revealer_get_transition_type(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_revealer_set_transition_type(IntPtr raw, int transition);

		[GLib.Property ("transition-type")]
		public Gtk.RevealerTransitionType TransitionType {
			get  {
				int raw_ret = gtk_revealer_get_transition_type(Handle);
				Gtk.RevealerTransitionType ret = (Gtk.RevealerTransitionType) raw_ret;
				return ret;
			}
			set  {
				gtk_revealer_set_transition_type(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_revealer_get_transition_duration(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_revealer_set_transition_duration(IntPtr raw, uint duration);

		[GLib.Property ("transition-duration")]
		public uint TransitionDuration {
			get  {
				uint raw_ret = gtk_revealer_get_transition_duration(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set  {
				gtk_revealer_set_transition_duration(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_revealer_get_reveal_child(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_revealer_set_reveal_child(IntPtr raw, bool reveal_child);

		[GLib.Property ("reveal-child")]
		public bool RevealChild {
			get  {
				bool raw_ret = gtk_revealer_get_reveal_child(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_revealer_set_reveal_child(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_revealer_get_child_revealed(IntPtr raw);

		[GLib.Property ("child-revealed")]
		public bool ChildRevealed {
			get  {
				bool raw_ret = gtk_revealer_get_child_revealed(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkRevealerClass {
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Bin)).GetClassSize ();
		static Dictionary<GLib.GType, GtkRevealerClass> class_structs;

		static GtkRevealerClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkRevealerClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkRevealerClass class_struct = (GtkRevealerClass) Marshal.PtrToStructure (class_ptr, typeof (GtkRevealerClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkRevealerClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_revealer_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_revealer_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
