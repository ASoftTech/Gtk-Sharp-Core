// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void ActionActivatedHandler(object o, ActionActivatedArgs args);

	public class ActionActivatedArgs : GLib.SignalArgs {
		public int Index{
			get {
				return (int) Args [0];
			}
		}

	}
}