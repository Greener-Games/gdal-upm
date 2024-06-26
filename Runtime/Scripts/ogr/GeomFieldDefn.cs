//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace OSGeo.OGR {

using global::System;
using global::System.Runtime.InteropServices;

public class GeomFieldDefn : global::System.IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;

  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  public GeomFieldDefn(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(GeomFieldDefn obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  public static HandleRef getCPtrAndDisown(GeomFieldDefn obj, object parent) {
    if (obj != null)
    {
      obj.swigCMemOwn = false;
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }
  public static HandleRef getCPtrAndSetReference(GeomFieldDefn obj, object parent) {
    if (obj != null)
    {
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }

  ~GeomFieldDefn() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrPINVOKE.delete_GeomFieldDefn(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GeomFieldDefn(string name_null_ok, wkbGeometryType field_type) : this(OgrPINVOKE.new_GeomFieldDefn(name_null_ok, (int)field_type), true, null) {
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetName() {
    string ret = OgrPINVOKE.GeomFieldDefn_GetName(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetNameRef() {
    string ret = OgrPINVOKE.GeomFieldDefn_GetNameRef(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetName(string name) {
    OgrPINVOKE.GeomFieldDefn_SetName(swigCPtr, name);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public wkbGeometryType GetFieldType() {
    wkbGeometryType ret = (wkbGeometryType)OgrPINVOKE.GeomFieldDefn_GetFieldType(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetType(wkbGeometryType type) {
    OgrPINVOKE.GeomFieldDefn_SetType(swigCPtr, (int)type);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public OSGeo.OSR.SpatialReference GetSpatialRef() {
    IntPtr cPtr = OgrPINVOKE.GeomFieldDefn_GetSpatialRef(swigCPtr);
    OSGeo.OSR.SpatialReference ret = (cPtr == IntPtr.Zero) ? null : new OSGeo.OSR.SpatialReference(cPtr, true, ThisOwn_true());
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSpatialRef(OSGeo.OSR.SpatialReference srs) {
    OgrPINVOKE.GeomFieldDefn_SetSpatialRef(swigCPtr, OSGeo.OSR.SpatialReference.getCPtr(srs));
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IsIgnored() {
    int ret = OgrPINVOKE.GeomFieldDefn_IsIgnored(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetIgnored(int bIgnored) {
    OgrPINVOKE.GeomFieldDefn_SetIgnored(swigCPtr, bIgnored);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IsNullable() {
    int ret = OgrPINVOKE.GeomFieldDefn_IsNullable(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetNullable(int bNullable) {
    OgrPINVOKE.GeomFieldDefn_SetNullable(swigCPtr, bNullable);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

  public GeomCoordinatePrecision GetCoordinatePrecision() {
    IntPtr cPtr = OgrPINVOKE.GeomFieldDefn_GetCoordinatePrecision(swigCPtr);
    GeomCoordinatePrecision ret = (cPtr == IntPtr.Zero) ? null : new GeomCoordinatePrecision(cPtr, false, ThisOwn_false());
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetCoordinatePrecision(GeomCoordinatePrecision coordPrec) {
    OgrPINVOKE.GeomFieldDefn_SetCoordinatePrecision(swigCPtr, GeomCoordinatePrecision.getCPtr(coordPrec));
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
