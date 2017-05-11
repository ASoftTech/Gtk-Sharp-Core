// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;

#region Autogenerated code
	public partial interface ITable : GLib.IWrapper {

		event System.EventHandler ColumnReordered;
		event Atk.ColumnDeletedHandler ColumnDeleted;
		event Atk.ColumnInsertedHandler ColumnInserted;
		event Atk.RowDeletedHandler RowDeleted;
		event System.EventHandler RowReordered;
		event System.EventHandler ModelChanged;
		event Atk.RowInsertedHandler RowInserted;
		bool AddColumnSelection(int column);
		bool AddRowSelection(int row);
		Atk.Object Caption { 
			get; set;
		}
		int GetColumnAtIndex(int index_);
		string GetColumnDescription(int column);
		int GetColumnExtentAt(int row, int column);
		Atk.Object GetColumnHeader(int column);
		int GetIndexAt(int row, int column);
		int NColumns { 
			get;
		}
		int NRows { 
			get;
		}
		int GetRowAtIndex(int index_);
		string GetRowDescription(int row);
		int GetRowExtentAt(int row, int column);
		Atk.Object GetRowHeader(int row);
		int GetSelectedColumns(out int selected);
		int GetSelectedRows(out int selected);
		Atk.Object Summary { 
			get; set;
		}
		bool IsColumnSelected(int column);
		bool IsRowSelected(int row);
		bool IsSelected(int row, int column);
		Atk.Object RefAt(int row, int column);
		bool RemoveColumnSelection(int column);
		bool RemoveRowSelection(int row);
		void SetColumnDescription(int column, string description);
		void SetColumnHeader(int column, Atk.Object header);
		void SetRowDescription(int row, string description);
		void SetRowHeader(int row, Atk.Object header);
	}

	[GLib.GInterface (typeof (TableAdapter))]
	public partial interface ITableImplementor : GLib.IWrapper {

		Atk.Object RefAt (int row, int column);
		int GetIndexAt (int row, int column);
		int GetColumnAtIndex (int index_);
		int GetRowAtIndex (int index_);
		int NColumns { get; }
		int NRows { get; }
		int GetColumnExtentAt (int row, int column);
		int GetRowExtentAt (int row, int column);
		Atk.Object Caption { get; set; }
		string GetColumnDescription (int column);
		Atk.Object GetColumnHeader (int column);
		string GetRowDescription (int row);
		Atk.Object GetRowHeader (int row);
		Atk.Object Summary { get; set; }
		void SetColumnDescription (int column, string description);
		void SetColumnHeader (int column, Atk.Object header);
		void SetRowDescription (int row, string description);
		void SetRowHeader (int row, Atk.Object header);
		int GetSelectedColumns (out int selected);
		int GetSelectedRows (out int selected);
		bool IsColumnSelected (int column);
		bool IsRowSelected (int row);
		bool IsSelected (int row, int column);
		bool AddRowSelection (int row);
		bool RemoveRowSelection (int row);
		bool AddColumnSelection (int column);
		bool RemoveColumnSelection (int column);
	}
#endregion
}
