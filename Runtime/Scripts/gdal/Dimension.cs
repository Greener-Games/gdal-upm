//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace OSGeo.GDAL {

using global::System;
using global::System.Runtime.InteropServices;

public class Dimension : global::System.IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;

  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  public Dimension(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(Dimension obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  public static HandleRef getCPtrAndDisown(Dimension obj, object parent) {
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
  public static HandleRef getCPtrAndSetReference(Dimension obj, object parent) {
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

  ~Dimension() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          GdalPINVOKE.delete_Dimension(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string GetName() {
    string ret = GdalPINVOKE.Dimension_GetName(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetFullName() {
    string ret = GdalPINVOKE.Dimension_GetFullName(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetType_() {
    string ret = GdalPINVOKE.Dimension_GetType_(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetDirection() {
    string ret = GdalPINVOKE.Dimension_GetDirection(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_GUIntBig GetSize() {
    SWIGTYPE_p_GUIntBig ret = new SWIGTYPE_p_GUIntBig(GdalPINVOKE.Dimension_GetSize(swigCPtr), true, null);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MDArray GetIndexingVariable() {
    IntPtr cPtr = GdalPINVOKE.Dimension_GetIndexingVariable(swigCPtr);
    MDArray ret = (cPtr == IntPtr.Zero) ? null : new MDArray(cPtr, true, ThisOwn_true());
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetIndexingVariable(MDArray array) {
    bool ret = GdalPINVOKE.Dimension_SetIndexingVariable(swigCPtr, MDArray.getCPtr(array));
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CPLErr Rename(string newName) {
    CPLErr ret = (CPLErr)GdalPINVOKE.Dimension_Rename(swigCPtr, newName);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
