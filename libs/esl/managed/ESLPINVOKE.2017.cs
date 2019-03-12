//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


class ESLPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="SWIGRegisterExceptionCallbacks_ESL")]
    public static extern void SWIGRegisterExceptionCallbacks_ESL(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_ESL")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_ESL(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_ESL(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_ESL(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(ESLPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(ESLPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="SWIGRegisterStringCallback_ESL")]
    public static extern void SWIGRegisterStringCallback_ESL(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_ESL(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static ESLPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_Event_set")]
  public static extern void ESLevent_Event_set(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_Event_get")]
  public static extern global::System.IntPtr ESLevent_Event_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_SerializedString_set")]
  public static extern void ESLevent_SerializedString_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_SerializedString_get")]
  public static extern string ESLevent_SerializedString_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_Mine_set")]
  public static extern void ESLevent_Mine_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_Mine_get")]
  public static extern int ESLevent_Mine_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_new_ESLevent__SWIG_0")]
  public static extern global::System.IntPtr new_ESLevent__SWIG_0(string jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_new_ESLevent__SWIG_1")]
  public static extern global::System.IntPtr new_ESLevent__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_new_ESLevent__SWIG_2")]
  public static extern global::System.IntPtr new_ESLevent__SWIG_2(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_delete_ESLevent")]
  public static extern void delete_ESLevent(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_Serialize")]
  public static extern string ESLevent_Serialize(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_SetPriority")]
  public static extern bool ESLevent_SetPriority(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_GetHeader")]
  public static extern string ESLevent_GetHeader(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_GetBody")]
  public static extern string ESLevent_GetBody(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_getType")]
  public static extern string ESLevent_getType(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_AddBody")]
  public static extern bool ESLevent_AddBody(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_AddHeader")]
  public static extern bool ESLevent_AddHeader(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_pushHeader")]
  public static extern bool ESLevent_pushHeader(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_unshiftHeader")]
  public static extern bool ESLevent_unshiftHeader(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_DelHeader")]
  public static extern bool ESLevent_DelHeader(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_FirstHeader")]
  public static extern string ESLevent_FirstHeader(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLevent_NextHeader")]
  public static extern string ESLevent_NextHeader(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_new_ESLconnection__SWIG_0")]
  public static extern global::System.IntPtr new_ESLconnection__SWIG_0(string jarg1, int jarg2, string jarg3, string jarg4);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_new_ESLconnection__SWIG_1")]
  public static extern global::System.IntPtr new_ESLconnection__SWIG_1(string jarg1, int jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_new_ESLconnection__SWIG_2")]
  public static extern global::System.IntPtr new_ESLconnection__SWIG_2(string jarg1, string jarg2, string jarg3, string jarg4);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_new_ESLconnection__SWIG_3")]
  public static extern global::System.IntPtr new_ESLconnection__SWIG_3(string jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_new_ESLconnection__SWIG_4")]
  public static extern global::System.IntPtr new_ESLconnection__SWIG_4(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_delete_ESLconnection")]
  public static extern void delete_ESLconnection(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_SocketDescriptor")]
  public static extern int ESLconnection_SocketDescriptor(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_Connected")]
  public static extern int ESLconnection_Connected(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_GetInfo")]
  public static extern global::System.IntPtr ESLconnection_GetInfo(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_Send")]
  public static extern int ESLconnection_Send(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_SendRecv")]
  public static extern global::System.IntPtr ESLconnection_SendRecv(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_Api")]
  public static extern global::System.IntPtr ESLconnection_Api(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_Bgapi")]
  public static extern global::System.IntPtr ESLconnection_Bgapi(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3, string jarg4);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_SendEvent")]
  public static extern global::System.IntPtr ESLconnection_SendEvent(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_sendMSG")]
  public static extern int ESLconnection_sendMSG(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_RecvEvent")]
  public static extern global::System.IntPtr ESLconnection_RecvEvent(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_RecvEventTimed")]
  public static extern global::System.IntPtr ESLconnection_RecvEventTimed(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_Filter")]
  public static extern global::System.IntPtr ESLconnection_Filter(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_Events")]
  public static extern int ESLconnection_Events(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_Execute")]
  public static extern global::System.IntPtr ESLconnection_Execute(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3, string jarg4);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_ExecuteAsync")]
  public static extern global::System.IntPtr ESLconnection_ExecuteAsync(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3, string jarg4);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_SetAsyncExecute")]
  public static extern int ESLconnection_SetAsyncExecute(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_SetEventLock")]
  public static extern int ESLconnection_SetEventLock(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_ESLconnection_Disconnect")]
  public static extern int ESLconnection_Disconnect(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("ESL", EntryPoint="CSharp_eslSetLogLevel")]
  public static extern void eslSetLogLevel(int jarg1);
}
