// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

#region Autogenerated code
	public partial interface ISeekable : GLib.IWrapper {

		bool CanSeek { 
			get;
		}
		bool CanTruncate();
		bool Seek(long offset, GLib.SeekType type, GLib.Cancellable cancellable);
		long Position { 
			get;
		}
		bool Truncate(long offset, GLib.Cancellable cancellable);
	}
#endregion
}
