//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace OSGeo.GDAL {

using global::System;
using global::System.Runtime.InteropServices;

public class Attribute : global::System.IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;

  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  public Attribute(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(Attribute obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  public static HandleRef getCPtrAndDisown(Attribute obj, object parent) {
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
  public static HandleRef getCPtrAndSetReference(Attribute obj, object parent) {
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

  ~Attribute() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          GdalPINVOKE.delete_Attribute(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string GetName() {
    string ret = GdalPINVOKE.Attribute_GetName(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetFullName() {
    string ret = GdalPINVOKE.Attribute_GetFullName(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong GetTotalElementsCount() {
    ulong ret = GdalPINVOKE.Attribute_GetTotalElementsCount(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDimensionCount() {
    uint ret = GdalPINVOKE.Attribute_GetDimensionCount(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ExtendedDataType GetDataType() {
    IntPtr cPtr = GdalPINVOKE.Attribute_GetDataType(swigCPtr);
    ExtendedDataType ret = (cPtr == IntPtr.Zero) ? null : new ExtendedDataType(cPtr, true, ThisOwn_true());
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string ReadAsString() {
    string ret = GdalPINVOKE.Attribute_ReadAsString(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ReadAsInt() {
    int ret = GdalPINVOKE.Attribute_ReadAsInt(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double ReadAsDouble() {
    double ret = GdalPINVOKE.Attribute_ReadAsDouble(swigCPtr);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string[] ReadAsStringArray() {
        /* %typemap(csout) char** CSL */
        IntPtr cPtr = GdalPINVOKE.Attribute_ReadAsStringArray(swigCPtr);
        IntPtr objPtr;
        int count = 0;
        if (cPtr != IntPtr.Zero) {
            while (Marshal.ReadIntPtr(cPtr, count*IntPtr.Size) != IntPtr.Zero)
                ++count;
        }
        string[] ret = new string[count];
        if (count > 0) {
	        for(int cx = 0; cx < count; cx++) {
                objPtr = System.Runtime.InteropServices.Marshal.ReadIntPtr(cPtr, cx * System.Runtime.InteropServices.Marshal.SizeOf(typeof(IntPtr)));
                ret[cx]= (objPtr == IntPtr.Zero) ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(objPtr);
            }
        }
        if (cPtr != IntPtr.Zero)
            GdalPINVOKE.StringListDestroy(cPtr);
        
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
        return ret;
}

  public CPLErr WriteString(string val) {
    CPLErr ret = (CPLErr)GdalPINVOKE.Attribute_WriteString(swigCPtr, val);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CPLErr WriteStringArray(string[] vals) {
    CPLErr ret = (CPLErr)GdalPINVOKE.Attribute_WriteStringArray(swigCPtr, (vals != null)? new GdalPINVOKE.StringListMarshal(vals)._ar : null);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CPLErr WriteInt(int val) {
    CPLErr ret = (CPLErr)GdalPINVOKE.Attribute_WriteInt(swigCPtr, val);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CPLErr WriteDouble(double val) {
    CPLErr ret = (CPLErr)GdalPINVOKE.Attribute_WriteDouble(swigCPtr, val);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
