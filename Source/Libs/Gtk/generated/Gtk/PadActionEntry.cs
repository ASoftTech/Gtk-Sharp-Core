// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct PadActionEntry : IEquatable<PadActionEntry> {

		public Gtk.PadActionType Type;
		public int Index;
		public int Mode;
		public string Label;
		public string ActionName;

		public static Gtk.PadActionEntry Zero = new Gtk.PadActionEntry ();

		public static Gtk.PadActionEntry New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gtk.PadActionEntry.Zero;
			return (Gtk.PadActionEntry) Marshal.PtrToStructure (raw, typeof (Gtk.PadActionEntry));
		}

		public bool Equals (PadActionEntry other)
		{
			return true && Type.Equals (other.Type) && Index.Equals (other.Index) && Mode.Equals (other.Mode) && Label.Equals (other.Label) && ActionName.Equals (other.ActionName);
		}

		public override bool Equals (object other)
		{
			return other is PadActionEntry && Equals ((PadActionEntry) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Type.GetHashCode () ^ Index.GetHashCode () ^ Mode.GetHashCode () ^ Label.GetHashCode () ^ ActionName.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}