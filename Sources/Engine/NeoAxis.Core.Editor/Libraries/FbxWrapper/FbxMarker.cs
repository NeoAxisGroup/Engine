//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Internal.Fbx {

public class FbxMarker : FbxNodeAttribute {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxMarker(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxMarker_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxMarker obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FbxClassId ClassId {
    set {
      FbxWrapperNativePINVOKE.FbxMarker_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMarker_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(FbxWrapperNativePINVOKE.FbxMarker_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxMarker Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMarker_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxMarker ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxMarker(cPtr, false);
    return ret;
  }

  public new static FbxMarker Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMarker_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxMarker ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxMarker(cPtr, false);
    return ret;
  }

  public override FbxNodeAttribute.EType GetAttributeType() {
    FbxNodeAttribute.EType ret = (FbxNodeAttribute.EType)FbxWrapperNativePINVOKE.FbxMarker_GetAttributeType(swigCPtr);
    return ret;
  }

  public void Reset() {
    FbxWrapperNativePINVOKE.FbxMarker_Reset(swigCPtr);
  }

  public void SetType(FbxMarker.EType pType) {
    FbxWrapperNativePINVOKE.FbxMarker_SetType(swigCPtr, (int)pType);
  }

  public FbxMarker.EType GetType() {
    FbxMarker.EType ret = (FbxMarker.EType)FbxWrapperNativePINVOKE.FbxMarker_GetType(swigCPtr);
    return ret;
  }

  public double GetDefaultOcclusion() {
    double ret = FbxWrapperNativePINVOKE.FbxMarker_GetDefaultOcclusion(swigCPtr);
    return ret;
  }

  public void SetDefaultOcclusion(double pOcclusion) {
    FbxWrapperNativePINVOKE.FbxMarker_SetDefaultOcclusion(swigCPtr, pOcclusion);
  }

  public double GetDefaultIKReachTranslation() {
    double ret = FbxWrapperNativePINVOKE.FbxMarker_GetDefaultIKReachTranslation(swigCPtr);
    return ret;
  }

  public void SetDefaultIKReachTranslation(double pIKReachTranslation) {
    FbxWrapperNativePINVOKE.FbxMarker_SetDefaultIKReachTranslation(swigCPtr, pIKReachTranslation);
  }

  public double GetDefaultIKReachRotation() {
    double ret = FbxWrapperNativePINVOKE.FbxMarker_GetDefaultIKReachRotation(swigCPtr);
    return ret;
  }

  public void SetDefaultIKReachRotation(double pIKReachRotation) {
    FbxWrapperNativePINVOKE.FbxMarker_SetDefaultIKReachRotation(swigCPtr, pIKReachRotation);
  }

  public double GetDefaultIKPull() {
    double ret = FbxWrapperNativePINVOKE.FbxMarker_GetDefaultIKPull(swigCPtr);
    return ret;
  }

  public void SetDefaultIKPull(double pIKPull) {
    FbxWrapperNativePINVOKE.FbxMarker_SetDefaultIKPull(swigCPtr, pIKPull);
  }

  public double GetDefaultIKPullHips() {
    double ret = FbxWrapperNativePINVOKE.FbxMarker_GetDefaultIKPullHips(swigCPtr);
    return ret;
  }

  public void SetDefaultIKPullHips(double pIKPullHips) {
    FbxWrapperNativePINVOKE.FbxMarker_SetDefaultIKPullHips(swigCPtr, pIKPullHips);
  }

  public FbxColor GetDefaultColor(FbxColor pColor) {
    FbxColor ret = new FbxColor(FbxWrapperNativePINVOKE.FbxMarker_GetDefaultColor(swigCPtr, FbxColor.getCPtr(pColor)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDefaultColor(FbxColor pColor) {
    FbxWrapperNativePINVOKE.FbxMarker_SetDefaultColor(swigCPtr, FbxColor.getCPtr(pColor));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxMarker__ELook_t Look {
    set {
      FbxWrapperNativePINVOKE.FbxMarker_Look_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxMarker__ELook_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMarker_Look_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxMarker__ELook_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxMarker__ELook_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t DrawLink {
    set {
      FbxWrapperNativePINVOKE.FbxMarker_DrawLink_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMarker_DrawLink_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble Size {
    set {
      FbxWrapperNativePINVOKE.FbxMarker_Size_set(swigCPtr, FbxPropertyTFbxDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMarker_Size_get(swigCPtr);
      FbxPropertyTFbxDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t ShowLabel {
    set {
      FbxWrapperNativePINVOKE.FbxMarker_ShowLabel_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMarker_ShowLabel_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble3 IKPivot {
    set {
      FbxWrapperNativePINVOKE.FbxMarker_IKPivot_set(swigCPtr, FbxPropertyTFbxDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMarker_IKPivot_get(swigCPtr);
      FbxPropertyTFbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxProperty GetOcclusion() {
    FbxProperty ret = new FbxProperty(FbxWrapperNativePINVOKE.FbxMarker_GetOcclusion(swigCPtr), true);
    return ret;
  }

  public FbxProperty GetIKReachTranslation() {
    FbxProperty ret = new FbxProperty(FbxWrapperNativePINVOKE.FbxMarker_GetIKReachTranslation(swigCPtr), true);
    return ret;
  }

  public FbxProperty GetIKReachRotation() {
    FbxProperty ret = new FbxProperty(FbxWrapperNativePINVOKE.FbxMarker_GetIKReachRotation(swigCPtr), true);
    return ret;
  }

  public FbxProperty GetIKPull() {
    FbxProperty ret = new FbxProperty(FbxWrapperNativePINVOKE.FbxMarker_GetIKPull(swigCPtr), true);
    return ret;
  }

  public FbxProperty GetIKPullHips() {
    FbxProperty ret = new FbxProperty(FbxWrapperNativePINVOKE.FbxMarker_GetIKPullHips(swigCPtr), true);
    return ret;
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(FbxWrapperNativePINVOKE.FbxMarker_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum EType {
    eStandard,
    eOptical,
    eEffectorFK,
    eEffectorIK
  }

  public enum ELook {
    eCube,
    eHardCross,
    eLightCross,
    eSphere,
    eCapsule,
    eBox,
    eBone,
    eCircle,
    eSquare,
    eStick,
    eNone
  }

}

}