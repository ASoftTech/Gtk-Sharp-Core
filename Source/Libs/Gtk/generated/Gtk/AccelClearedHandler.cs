// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void AccelClearedHandler(object o, AccelClearedArgs args);

	public class AccelClearedArgs : GLib.SignalArgs {
		public string PathString{
			get {
				return (string) Args [0];
			}
		}

	}
}