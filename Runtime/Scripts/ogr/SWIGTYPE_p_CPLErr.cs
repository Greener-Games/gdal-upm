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

public class SWIGTYPE_p_CPLErr {
  private HandleRef swigCPtr;

  public SWIGTYPE_p_CPLErr(IntPtr cPtr, bool futureUse, object parent) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  protected SWIGTYPE_p_CPLErr() {
    swigCPtr = new HandleRef(null, IntPtr.Zero);
  }

  public static HandleRef getCPtr(SWIGTYPE_p_CPLErr obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
}

}
