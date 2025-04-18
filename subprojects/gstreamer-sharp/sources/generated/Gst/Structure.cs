// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Structure : GLib.Opaque {

		public GLib.GType Type {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("type"));
					return new GLib.GType((*raw_ptr));
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("type"));
					*raw_ptr = value.Val;
				}
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_get_name(IntPtr raw);

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_set_name(IntPtr raw, IntPtr name);

		public string Name {
			get  {
				IntPtr raw_ret = gst_structure_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gst_structure_set_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_structure_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_can_intersect(IntPtr raw, IntPtr struct2);

		public bool CanIntersect(Gst.Structure struct2) {
			bool raw_ret = gst_structure_can_intersect(Handle, struct2 == null ? IntPtr.Zero : struct2.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_copy(IntPtr raw);

		public Gst.Structure Copy() {
			IntPtr raw_ret = gst_structure_copy(Handle);
			Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), true);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_filter_and_map_in_place(IntPtr raw, GstSharp.StructureFilterMapFuncNative func, IntPtr user_data);

		[Obsolete]
		public void FilterAndMapInPlace(Gst.StructureFilterMapFunc func) {
			GstSharp.StructureFilterMapFuncWrapper func_wrapper = new GstSharp.StructureFilterMapFuncWrapper (func);
			gst_structure_filter_and_map_in_place(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_filter_and_map_in_place_id_str(IntPtr raw, GstSharp.StructureFilterMapIdStrFuncNative func, IntPtr user_data);

		public void FilterAndMapInPlaceIdStr(Gst.StructureFilterMapIdStrFunc func) {
			GstSharp.StructureFilterMapIdStrFuncWrapper func_wrapper = new GstSharp.StructureFilterMapIdStrFuncWrapper (func);
			gst_structure_filter_and_map_in_place_id_str(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_fixate(IntPtr raw);

		public void Fixate() {
			gst_structure_fixate(Handle);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_fixate_field(IntPtr raw, IntPtr field_name);

		public bool FixateField(string field_name) {
			IntPtr native_field_name = GLib.Marshaller.StringToPtrGStrdup (field_name);
			bool raw_ret = gst_structure_fixate_field(Handle, native_field_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_field_name);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_fixate_field_boolean(IntPtr raw, IntPtr field_name, bool target);

		public bool FixateFieldBoolean(string field_name, bool target) {
			IntPtr native_field_name = GLib.Marshaller.StringToPtrGStrdup (field_name);
			bool raw_ret = gst_structure_fixate_field_boolean(Handle, native_field_name, target);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_field_name);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_fixate_field_nearest_double(IntPtr raw, IntPtr field_name, double target);

		public bool FixateFieldNearestDouble(string field_name, double target) {
			IntPtr native_field_name = GLib.Marshaller.StringToPtrGStrdup (field_name);
			bool raw_ret = gst_structure_fixate_field_nearest_double(Handle, native_field_name, target);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_field_name);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_fixate_field_nearest_fraction(IntPtr raw, IntPtr field_name, int target_numerator, int target_denominator);

		public bool FixateFieldNearestFraction(string field_name, int target_numerator, int target_denominator) {
			IntPtr native_field_name = GLib.Marshaller.StringToPtrGStrdup (field_name);
			bool raw_ret = gst_structure_fixate_field_nearest_fraction(Handle, native_field_name, target_numerator, target_denominator);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_field_name);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_fixate_field_nearest_int(IntPtr raw, IntPtr field_name, int target);

		public bool FixateFieldNearestInt(string field_name, int target) {
			IntPtr native_field_name = GLib.Marshaller.StringToPtrGStrdup (field_name);
			bool raw_ret = gst_structure_fixate_field_nearest_int(Handle, native_field_name, target);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_field_name);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_fixate_field_string(IntPtr raw, IntPtr field_name, IntPtr target);

		public bool FixateFieldString(string field_name, string target) {
			IntPtr native_field_name = GLib.Marshaller.StringToPtrGStrdup (field_name);
			IntPtr native_target = GLib.Marshaller.StringToPtrGStrdup (target);
			bool raw_ret = gst_structure_fixate_field_string(Handle, native_field_name, native_target);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_field_name);
			GLib.Marshaller.Free (native_target);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_foreach(IntPtr raw, GstSharp.StructureForeachFuncNative func, IntPtr user_data);

		[Obsolete]
		public bool Foreach(Gst.StructureForeachFunc func) {
			GstSharp.StructureForeachFuncWrapper func_wrapper = new GstSharp.StructureForeachFuncWrapper (func);
			bool raw_ret = gst_structure_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_foreach_id_str(IntPtr raw, GstSharp.StructureForeachIdStrFuncNative func, IntPtr user_data);

		public bool ForeachIdStr(Gst.StructureForeachIdStrFunc func) {
			GstSharp.StructureForeachIdStrFuncWrapper func_wrapper = new GstSharp.StructureForeachIdStrFuncWrapper (func);
			bool raw_ret = gst_structure_foreach_id_str(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_array(IntPtr raw, IntPtr fieldname, out IntPtr array);

		public bool GetArray(string fieldname, out GLib.ValueArray array) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			IntPtr native_array;
			bool raw_ret = gst_structure_get_array(Handle, native_fieldname, out native_array);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			array = new GLib.ValueArray(native_array);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_boolean(IntPtr raw, IntPtr fieldname, out bool value);

		public bool GetBoolean(string fieldname, out bool value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			bool raw_ret = gst_structure_get_boolean(Handle, native_fieldname, out value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_clock_time(IntPtr raw, IntPtr fieldname, out ulong value);

		public bool GetClockTime(string fieldname, out ulong value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			bool raw_ret = gst_structure_get_clock_time(Handle, native_fieldname, out value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_date(IntPtr raw, IntPtr fieldname, out IntPtr value);

		public bool GetDate(string fieldname, out GLib.Date value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			IntPtr native_value;
			bool raw_ret = gst_structure_get_date(Handle, native_fieldname, out native_value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			value = new GLib.Date(native_value);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_date_time(IntPtr raw, IntPtr fieldname, out IntPtr value);

		public bool GetDateTime(string fieldname, out Gst.DateTime value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			IntPtr native_value;
			bool raw_ret = gst_structure_get_date_time(Handle, native_fieldname, out native_value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			value = native_value == IntPtr.Zero ? null : (Gst.DateTime) GLib.Opaque.GetOpaque (native_value, typeof (Gst.DateTime), true);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_double(IntPtr raw, IntPtr fieldname, out double value);

		public bool GetDouble(string fieldname, out double value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			bool raw_ret = gst_structure_get_double(Handle, native_fieldname, out value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_enum(IntPtr raw, IntPtr fieldname, IntPtr enumtype, out int value);

		public bool GetEnum(string fieldname, GLib.GType enumtype, out int value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			bool raw_ret = gst_structure_get_enum(Handle, native_fieldname, enumtype.Val, out value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_get_field_type(IntPtr raw, IntPtr fieldname);

		public GLib.GType GetFieldType(string fieldname) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			IntPtr raw_ret = gst_structure_get_field_type(Handle, native_fieldname);
			GLib.GType ret = new GLib.GType(raw_ret);
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_flags(IntPtr raw, IntPtr fieldname, IntPtr flags_type, out uint value);

		public bool GetFlags(string fieldname, GLib.GType flags_type, out uint value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			bool raw_ret = gst_structure_get_flags(Handle, native_fieldname, flags_type.Val, out value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_flagset(IntPtr raw, IntPtr fieldname, out uint value_flags, out uint value_mask);

		public bool GetFlagset(string fieldname, out uint value_flags, out uint value_mask) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			bool raw_ret = gst_structure_get_flagset(Handle, native_fieldname, out value_flags, out value_mask);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_fraction(IntPtr raw, IntPtr fieldname, out int value_numerator, out int value_denominator);

		public bool GetFraction(string fieldname, out int value_numerator, out int value_denominator) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			bool raw_ret = gst_structure_get_fraction(Handle, native_fieldname, out value_numerator, out value_denominator);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_int(IntPtr raw, IntPtr fieldname, out int value);

		public bool GetInt(string fieldname, out int value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			bool raw_ret = gst_structure_get_int(Handle, native_fieldname, out value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_int64(IntPtr raw, IntPtr fieldname, out long value);

		public bool GetInt64(string fieldname, out long value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			bool raw_ret = gst_structure_get_int64(Handle, native_fieldname, out value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_list(IntPtr raw, IntPtr fieldname, out IntPtr array);

		public bool GetList(string fieldname, out GLib.ValueArray array) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			IntPtr native_array;
			bool raw_ret = gst_structure_get_list(Handle, native_fieldname, out native_array);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			array = new GLib.ValueArray(native_array);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_structure_get_name_id(IntPtr raw);

		[Obsolete]
		public uint NameId { 
			get {
				uint raw_ret = gst_structure_get_name_id(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_get_name_id_str(IntPtr raw);

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_set_name_id_str(IntPtr raw, IntPtr value);

		public Gst.IdStr NameIdStr { 
			get {
				IntPtr raw_ret = gst_structure_get_name_id_str(Handle);
				Gst.IdStr ret = Gst.IdStr.New (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				gst_structure_set_name_id_str(Handle, native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_get_string(IntPtr raw, IntPtr fieldname);

		public string GetString(string fieldname) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			IntPtr raw_ret = gst_structure_get_string(Handle, native_fieldname);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_uint(IntPtr raw, IntPtr fieldname, out uint value);

		public bool GetUint(string fieldname, out uint value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			bool raw_ret = gst_structure_get_uint(Handle, native_fieldname, out value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_get_uint64(IntPtr raw, IntPtr fieldname, out ulong value);

		public bool GetUint64(string fieldname, out ulong value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			bool raw_ret = gst_structure_get_uint64(Handle, native_fieldname, out value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_get_value(IntPtr raw, IntPtr fieldname);

		public GLib.Value GetValue(string fieldname) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			IntPtr raw_ret = gst_structure_get_value(Handle, native_fieldname);
			GLib.Value ret = (GLib.Value) Marshal.PtrToStructure (raw_ret, typeof (GLib.Value));
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_has_field(IntPtr raw, IntPtr fieldname);

		public bool HasField(string fieldname) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			bool raw_ret = gst_structure_has_field(Handle, native_fieldname);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_has_field_typed(IntPtr raw, IntPtr fieldname, IntPtr type);

		public bool HasFieldTyped(string fieldname, GLib.GType type) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			bool raw_ret = gst_structure_has_field_typed(Handle, native_fieldname, type.Val);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_has_name(IntPtr raw, IntPtr name);

		public bool HasName(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			bool raw_ret = gst_structure_has_name(Handle, native_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_id_get_value(IntPtr raw, uint field);

		public GLib.Value IdGetValue(uint field) {
			IntPtr raw_ret = gst_structure_id_get_value(Handle, field);
			GLib.Value ret = (GLib.Value) Marshal.PtrToStructure (raw_ret, typeof (GLib.Value));
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_id_has_field(IntPtr raw, uint field);

		[Obsolete]
		public bool IdHasField(uint field) {
			bool raw_ret = gst_structure_id_has_field(Handle, field);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_id_has_field_typed(IntPtr raw, uint field, IntPtr type);

		[Obsolete]
		public bool IdHasFieldTyped(uint field, GLib.GType type) {
			bool raw_ret = gst_structure_id_has_field_typed(Handle, field, type.Val);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_id_set_value(IntPtr raw, uint field, IntPtr value);

		[Obsolete]
		public void IdSetValue(uint field, GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_structure_id_set_value(Handle, field, native_value);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_id_str_get_field_type(IntPtr raw, IntPtr fieldname);

		public GLib.GType IdStrGetFieldType(Gst.IdStr fieldname) {
			IntPtr native_fieldname = GLib.Marshaller.StructureToPtrAlloc (fieldname);
			IntPtr raw_ret = gst_structure_id_str_get_field_type(Handle, native_fieldname);
			GLib.GType ret = new GLib.GType(raw_ret);
			Marshal.FreeHGlobal (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_id_str_get_value(IntPtr raw, IntPtr fieldname);

		public GLib.Value IdStrGetValue(Gst.IdStr fieldname) {
			IntPtr native_fieldname = GLib.Marshaller.StructureToPtrAlloc (fieldname);
			IntPtr raw_ret = gst_structure_id_str_get_value(Handle, native_fieldname);
			GLib.Value ret = (GLib.Value) Marshal.PtrToStructure (raw_ret, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_id_str_has_field(IntPtr raw, IntPtr fieldname);

		public bool IdStrHasField(Gst.IdStr fieldname) {
			IntPtr native_fieldname = GLib.Marshaller.StructureToPtrAlloc (fieldname);
			bool raw_ret = gst_structure_id_str_has_field(Handle, native_fieldname);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_id_str_has_field_typed(IntPtr raw, IntPtr fieldname, IntPtr type);

		public bool IdStrHasFieldTyped(Gst.IdStr fieldname, GLib.GType type) {
			IntPtr native_fieldname = GLib.Marshaller.StructureToPtrAlloc (fieldname);
			bool raw_ret = gst_structure_id_str_has_field_typed(Handle, native_fieldname, type.Val);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_fieldname);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_id_str_nth_field_name(IntPtr raw, uint index);

		public Gst.IdStr IdStrNthFieldName(uint index) {
			IntPtr raw_ret = gst_structure_id_str_nth_field_name(Handle, index);
			Gst.IdStr ret = Gst.IdStr.New (raw_ret);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_id_str_remove_field(IntPtr raw, IntPtr fieldname);

		public void IdStrRemoveField(Gst.IdStr fieldname) {
			IntPtr native_fieldname = GLib.Marshaller.StructureToPtrAlloc (fieldname);
			gst_structure_id_str_remove_field(Handle, native_fieldname);
			Marshal.FreeHGlobal (native_fieldname);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_id_str_set_value(IntPtr raw, IntPtr fieldname, IntPtr value);

		public void IdStrSetValue(Gst.IdStr fieldname, GLib.Value value) {
			IntPtr native_fieldname = GLib.Marshaller.StructureToPtrAlloc (fieldname);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_structure_id_str_set_value(Handle, native_fieldname, native_value);
			Marshal.FreeHGlobal (native_fieldname);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_id_str_take_value(IntPtr raw, IntPtr fieldname, IntPtr value);

		public void IdStrTakeValue(Gst.IdStr fieldname, GLib.Value value) {
			IntPtr native_fieldname = GLib.Marshaller.StructureToPtrAlloc (fieldname);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_structure_id_str_take_value(Handle, native_fieldname, native_value);
			Marshal.FreeHGlobal (native_fieldname);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_id_take_value(IntPtr raw, uint field, IntPtr value);

		[Obsolete]
		public void IdTakeValue(uint field, GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_structure_id_take_value(Handle, field, native_value);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_intersect(IntPtr raw, IntPtr struct2);

		public Gst.Structure Intersect(Gst.Structure struct2) {
			IntPtr raw_ret = gst_structure_intersect(Handle, struct2 == null ? IntPtr.Zero : struct2.Handle);
			Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), true);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_is_equal(IntPtr raw, IntPtr structure2);

		public bool IsEqual(Gst.Structure structure2) {
			bool raw_ret = gst_structure_is_equal(Handle, structure2 == null ? IntPtr.Zero : structure2.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_is_subset(IntPtr raw, IntPtr superset);

		public bool IsSubset(Gst.Structure superset) {
			bool raw_ret = gst_structure_is_subset(Handle, superset == null ? IntPtr.Zero : superset.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_map_in_place(IntPtr raw, GstSharp.StructureMapFuncNative func, IntPtr user_data);

		[Obsolete]
		public bool MapInPlace(Gst.StructureMapFunc func) {
			GstSharp.StructureMapFuncWrapper func_wrapper = new GstSharp.StructureMapFuncWrapper (func);
			bool raw_ret = gst_structure_map_in_place(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_map_in_place_id_str(IntPtr raw, GstSharp.StructureMapIdStrFuncNative func, IntPtr user_data);

		public bool MapInPlaceIdStr(Gst.StructureMapIdStrFunc func) {
			GstSharp.StructureMapIdStrFuncWrapper func_wrapper = new GstSharp.StructureMapIdStrFuncWrapper (func);
			bool raw_ret = gst_structure_map_in_place_id_str(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_structure_n_fields(IntPtr raw);

		public int NFields() {
			int raw_ret = gst_structure_n_fields(Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_nth_field_name(IntPtr raw, uint index);

		public string NthFieldName(uint index) {
			IntPtr raw_ret = gst_structure_nth_field_name(Handle, index);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_remove_all_fields(IntPtr raw);

		public void RemoveAllFields() {
			gst_structure_remove_all_fields(Handle);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_remove_field(IntPtr raw, IntPtr fieldname);

		public void RemoveField(string fieldname) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			gst_structure_remove_field(Handle, native_fieldname);
			GLib.Marshaller.Free (native_fieldname);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_serialize(IntPtr raw, int flags);

		[Obsolete]
		public string Serialize(Gst.SerializeFlags flags) {
			IntPtr raw_ret = gst_structure_serialize(Handle, (int) flags);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_serialize_full(IntPtr raw, int flags);

		public string SerializeFull(Gst.SerializeFlags flags) {
			IntPtr raw_ret = gst_structure_serialize_full(Handle, (int) flags);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_set_array(IntPtr raw, IntPtr fieldname, IntPtr array);

		public void SetArray(string fieldname, GLib.ValueArray array) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			gst_structure_set_array(Handle, native_fieldname, array == null ? IntPtr.Zero : array.Handle);
			GLib.Marshaller.Free (native_fieldname);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_set_list(IntPtr raw, IntPtr fieldname, IntPtr array);

		public void SetList(string fieldname, GLib.ValueArray array) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			gst_structure_set_list(Handle, native_fieldname, array == null ? IntPtr.Zero : array.Handle);
			GLib.Marshaller.Free (native_fieldname);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_set_name_static_str(IntPtr raw, IntPtr name);

		public string NameStaticStr { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gst_structure_set_name_static_str(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_structure_set_parent_refcount(IntPtr raw, int refcount);

		public bool SetParentRefcount(int refcount) {
			bool raw_ret = gst_structure_set_parent_refcount(Handle, refcount);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_set_value(IntPtr raw, IntPtr fieldname, IntPtr value);

		public void SetValue(string fieldname, GLib.Value value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_structure_set_value(Handle, native_fieldname, native_value);
			GLib.Marshaller.Free (native_fieldname);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_set_value_static_str(IntPtr raw, IntPtr fieldname, IntPtr value);

		public void SetValueStaticStr(string fieldname, GLib.Value value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_structure_set_value_static_str(Handle, native_fieldname, native_value);
			GLib.Marshaller.Free (native_fieldname);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_take_value(IntPtr raw, IntPtr fieldname, IntPtr value);

		public void TakeValue(string fieldname, GLib.Value value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_structure_take_value(Handle, native_fieldname, native_value);
			GLib.Marshaller.Free (native_fieldname);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_take_value_static_str(IntPtr raw, IntPtr fieldname, IntPtr value);

		public void TakeValueStaticStr(string fieldname, GLib.Value value) {
			IntPtr native_fieldname = GLib.Marshaller.StringToPtrGStrdup (fieldname);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_structure_take_value_static_str(Handle, native_fieldname, native_value);
			GLib.Marshaller.Free (native_fieldname);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr raw_ret = gst_structure_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		public Structure(IntPtr raw) : base(raw) {}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_from_string(IntPtr str1ng, out IntPtr end);

		public Structure (string str1ng, out string end) 
		{
			IntPtr native_str1ng = GLib.Marshaller.StringToPtrGStrdup (str1ng);
			IntPtr native_end;
			Raw = gst_structure_from_string(native_str1ng, out native_end);
			GLib.Marshaller.Free (native_str1ng);
			end = GLib.Marshaller.Utf8PtrToString (native_end);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_new_empty(IntPtr name);

		public Structure (string name) 
		{
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = gst_structure_new_empty(native_name);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_new_from_string(IntPtr str1ng);

		public static Structure NewFromString(string str1ng)
		{
			IntPtr native_str1ng = GLib.Marshaller.StringToPtrGStrdup (str1ng);
			Structure result = new Structure (gst_structure_new_from_string(native_str1ng));
			GLib.Marshaller.Free (native_str1ng);
			return result;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_new_id_empty(uint quark);

		public Structure (uint quark) 
		{
			Raw = gst_structure_new_id_empty(quark);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_new_id_str_empty(IntPtr name);

		public Structure (Gst.IdStr name) 
		{
			IntPtr native_name = GLib.Marshaller.StructureToPtrAlloc (name);
			Raw = gst_structure_new_id_str_empty(native_name);
			Marshal.FreeHGlobal (native_name);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_structure_new_static_str_empty(IntPtr name);

		public static Structure NewStaticStrEmpty(string name)
		{
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Structure result = new Structure (gst_structure_new_static_str_empty(native_name));
			GLib.Marshaller.Free (native_name);
			return result;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_structure_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gst_structure_free (raw);
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return gst_structure_free;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("type"
							, 0
							, (uint) Marshal.SizeOf(typeof(GLib.GType)) // type
							, null
							, "name"
							, (long) Marshal.OffsetOf(typeof(GstStructure_typeAlign), "type")
							, 0
							),
						new GLib.AbiField("name"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // name
							, "type"
							, null
							, (long) Marshal.OffsetOf(typeof(GstStructure_nameAlign), "name")
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstStructure_typeAlign
		{
			sbyte f1;
			private GLib.GType type;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstStructure_nameAlign
		{
			sbyte f1;
			private string name;
		}


		// End of the ABI representation.

#endregion
	}
}
