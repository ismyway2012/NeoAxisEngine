//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Fbx {

public class FbxCharacterLink : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxCharacterLink(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxCharacterLink obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxCharacterLink() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxCharacterLink(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxCharacterLink() : this(FbxWrapperNativePINVOKE.new_FbxCharacterLink__SWIG_0(), true) {
  }

  public FbxCharacterLink(FbxCharacterLink pCharacterLink) : this(FbxWrapperNativePINVOKE.new_FbxCharacterLink__SWIG_1(FbxCharacterLink.getCPtr(pCharacterLink)), true) {
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxCharacterLink assign(FbxCharacterLink pCharacterLink) {
    FbxCharacterLink ret = new FbxCharacterLink(FbxWrapperNativePINVOKE.FbxCharacterLink_assign(swigCPtr, FbxCharacterLink.getCPtr(pCharacterLink)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reset() {
    FbxWrapperNativePINVOKE.FbxCharacterLink_Reset(swigCPtr);
  }

  public FbxNode mNode {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mNode_set(swigCPtr, FbxNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mNode_get(swigCPtr);
      FbxNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNode(cPtr, false);
      return ret;
    } 
  }

  public FbxString mTemplateName {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mTemplateName_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mTemplateName_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxVector4 mOffsetT {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mOffsetT_set(swigCPtr, FbxVector4.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mOffsetT_get(swigCPtr);
      FbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVector4(cPtr, false);
      return ret;
    } 
  }

  public FbxVector4 mOffsetR {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mOffsetR_set(swigCPtr, FbxVector4.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mOffsetR_get(swigCPtr);
      FbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVector4(cPtr, false);
      return ret;
    } 
  }

  public FbxVector4 mOffsetS {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mOffsetS_set(swigCPtr, FbxVector4.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mOffsetS_get(swigCPtr);
      FbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVector4(cPtr, false);
      return ret;
    } 
  }

  public FbxVector4 mParentROffset {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mParentROffset_set(swigCPtr, FbxVector4.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mParentROffset_get(swigCPtr);
      FbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVector4(cPtr, false);
      return ret;
    } 
  }

  public bool mHasRotSpace {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mHasRotSpace_set(swigCPtr, value);
    } 
    get {
      bool ret = FbxWrapperNativePINVOKE.FbxCharacterLink_mHasRotSpace_get(swigCPtr);
      return ret;
    } 
  }

  public FbxLimits mRLimits {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mRLimits_set(swigCPtr, FbxLimits.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mRLimits_get(swigCPtr);
      FbxLimits ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLimits(cPtr, false);
      return ret;
    } 
  }

  public FbxVector4 mPreRotation {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mPreRotation_set(swigCPtr, FbxVector4.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mPreRotation_get(swigCPtr);
      FbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVector4(cPtr, false);
      return ret;
    } 
  }

  public FbxVector4 mPostRotation {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mPostRotation_set(swigCPtr, FbxVector4.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mPostRotation_get(swigCPtr);
      FbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVector4(cPtr, false);
      return ret;
    } 
  }

  public int mRotOrder {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mRotOrder_set(swigCPtr, value);
    } 
    get {
      int ret = FbxWrapperNativePINVOKE.FbxCharacterLink_mRotOrder_get(swigCPtr);
      return ret;
    } 
  }

  public double mAxisLen {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mAxisLen_set(swigCPtr, value);
    } 
    get {
      double ret = FbxWrapperNativePINVOKE.FbxCharacterLink_mAxisLen_get(swigCPtr);
      return ret;
    } 
  }

  public FbxProperty mPropertyLink {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mPropertyLink_set(swigCPtr, FbxProperty.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mPropertyLink_get(swigCPtr);
      FbxProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxProperty(cPtr, false);
      return ret;
    } 
  }

  public FbxProperty mPropertyOffsetT {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mPropertyOffsetT_set(swigCPtr, FbxProperty.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mPropertyOffsetT_get(swigCPtr);
      FbxProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxProperty(cPtr, false);
      return ret;
    } 
  }

  public FbxProperty mPropertyOffsetR {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mPropertyOffsetR_set(swigCPtr, FbxProperty.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mPropertyOffsetR_get(swigCPtr);
      FbxProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxProperty(cPtr, false);
      return ret;
    } 
  }

  public FbxProperty mPropertyOffsetS {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mPropertyOffsetS_set(swigCPtr, FbxProperty.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mPropertyOffsetS_get(swigCPtr);
      FbxProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxProperty(cPtr, false);
      return ret;
    } 
  }

  public FbxProperty mPropertyParentOffsetR {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mPropertyParentOffsetR_set(swigCPtr, FbxProperty.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mPropertyParentOffsetR_get(swigCPtr);
      FbxProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxProperty(cPtr, false);
      return ret;
    } 
  }

  public FbxProperty mPropertyTemplateName {
    set {
      FbxWrapperNativePINVOKE.FbxCharacterLink_mPropertyTemplateName_set(swigCPtr, FbxProperty.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCharacterLink_mPropertyTemplateName_get(swigCPtr);
      FbxProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxProperty(cPtr, false);
      return ret;
    } 
  }

  public enum EType {
    eCharacterLink,
    eControlSetLink,
    eControlSetEffector,
    eControlSetEffectorAux
  }

}

}