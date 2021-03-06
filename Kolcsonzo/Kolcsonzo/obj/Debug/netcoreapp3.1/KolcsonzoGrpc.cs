// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Kolcsonzo.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Kolcsonzo {
  public static partial class Kolcsonzo
  {
    static readonly string __ServiceName = "Kolcsonzo.Kolcsonzo";

    static readonly grpc::Marshaller<global::Kolcsonzo.Empty> __Marshaller_Kolcsonzo_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Kolcsonzo.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Kolcsonzo.Car> __Marshaller_Kolcsonzo_Car = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Kolcsonzo.Car.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Kolcsonzo.Type> __Marshaller_Kolcsonzo_Type = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Kolcsonzo.Type.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Kolcsonzo.LoginData> __Marshaller_Kolcsonzo_LoginData = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Kolcsonzo.LoginData.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Kolcsonzo.Session_Id> __Marshaller_Kolcsonzo_Session_Id = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Kolcsonzo.Session_Id.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Kolcsonzo.Session_Id2> __Marshaller_Kolcsonzo_Session_Id2 = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Kolcsonzo.Session_Id2.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Kolcsonzo.Result> __Marshaller_Kolcsonzo_Result = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Kolcsonzo.Result.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Kolcsonzo.Car4> __Marshaller_Kolcsonzo_Car4 = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Kolcsonzo.Car4.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Kolcsonzo.Car2> __Marshaller_Kolcsonzo_Car2 = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Kolcsonzo.Car2.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Kolcsonzo.Car3> __Marshaller_Kolcsonzo_Car3 = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Kolcsonzo.Car3.Parser.ParseFrom);

    static readonly grpc::Method<global::Kolcsonzo.Empty, global::Kolcsonzo.Car> __Method_List = new grpc::Method<global::Kolcsonzo.Empty, global::Kolcsonzo.Car>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "List",
        __Marshaller_Kolcsonzo_Empty,
        __Marshaller_Kolcsonzo_Car);

    static readonly grpc::Method<global::Kolcsonzo.Type, global::Kolcsonzo.Car> __Method_ListType = new grpc::Method<global::Kolcsonzo.Type, global::Kolcsonzo.Car>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListType",
        __Marshaller_Kolcsonzo_Type,
        __Marshaller_Kolcsonzo_Car);

    static readonly grpc::Method<global::Kolcsonzo.LoginData, global::Kolcsonzo.Session_Id> __Method_Login = new grpc::Method<global::Kolcsonzo.LoginData, global::Kolcsonzo.Session_Id>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Login",
        __Marshaller_Kolcsonzo_LoginData,
        __Marshaller_Kolcsonzo_Session_Id);

    static readonly grpc::Method<global::Kolcsonzo.Session_Id2, global::Kolcsonzo.Result> __Method_Logout = new grpc::Method<global::Kolcsonzo.Session_Id2, global::Kolcsonzo.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Logout",
        __Marshaller_Kolcsonzo_Session_Id2,
        __Marshaller_Kolcsonzo_Result);

    static readonly grpc::Method<global::Kolcsonzo.Car4, global::Kolcsonzo.Result> __Method_Add = new grpc::Method<global::Kolcsonzo.Car4, global::Kolcsonzo.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Add",
        __Marshaller_Kolcsonzo_Car4,
        __Marshaller_Kolcsonzo_Result);

    static readonly grpc::Method<global::Kolcsonzo.Car2, global::Kolcsonzo.Result> __Method_Delete = new grpc::Method<global::Kolcsonzo.Car2, global::Kolcsonzo.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_Kolcsonzo_Car2,
        __Marshaller_Kolcsonzo_Result);

    static readonly grpc::Method<global::Kolcsonzo.Car2, global::Kolcsonzo.Result> __Method_Rent = new grpc::Method<global::Kolcsonzo.Car2, global::Kolcsonzo.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Rent",
        __Marshaller_Kolcsonzo_Car2,
        __Marshaller_Kolcsonzo_Result);

    static readonly grpc::Method<global::Kolcsonzo.Car3, global::Kolcsonzo.Result> __Method_Back = new grpc::Method<global::Kolcsonzo.Car3, global::Kolcsonzo.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Back",
        __Marshaller_Kolcsonzo_Car3,
        __Marshaller_Kolcsonzo_Result);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Kolcsonzo.KolcsonzoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Kolcsonzo</summary>
    [grpc::BindServiceMethod(typeof(Kolcsonzo), "BindService")]
    public abstract partial class KolcsonzoBase
    {
      public virtual global::System.Threading.Tasks.Task List(global::Kolcsonzo.Empty request, grpc::IServerStreamWriter<global::Kolcsonzo.Car> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task ListType(global::Kolcsonzo.Type request, grpc::IServerStreamWriter<global::Kolcsonzo.Car> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Kolcsonzo.Session_Id> Login(global::Kolcsonzo.LoginData request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Kolcsonzo.Result> Logout(global::Kolcsonzo.Session_Id2 request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Kolcsonzo.Result> Add(global::Kolcsonzo.Car4 request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Kolcsonzo.Result> Delete(global::Kolcsonzo.Car2 request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Kolcsonzo.Result> Rent(global::Kolcsonzo.Car2 request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Kolcsonzo.Result> Back(global::Kolcsonzo.Car3 request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(KolcsonzoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_List, serviceImpl.List)
          .AddMethod(__Method_ListType, serviceImpl.ListType)
          .AddMethod(__Method_Login, serviceImpl.Login)
          .AddMethod(__Method_Logout, serviceImpl.Logout)
          .AddMethod(__Method_Add, serviceImpl.Add)
          .AddMethod(__Method_Delete, serviceImpl.Delete)
          .AddMethod(__Method_Rent, serviceImpl.Rent)
          .AddMethod(__Method_Back, serviceImpl.Back).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, KolcsonzoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_List, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Kolcsonzo.Empty, global::Kolcsonzo.Car>(serviceImpl.List));
      serviceBinder.AddMethod(__Method_ListType, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Kolcsonzo.Type, global::Kolcsonzo.Car>(serviceImpl.ListType));
      serviceBinder.AddMethod(__Method_Login, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Kolcsonzo.LoginData, global::Kolcsonzo.Session_Id>(serviceImpl.Login));
      serviceBinder.AddMethod(__Method_Logout, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Kolcsonzo.Session_Id2, global::Kolcsonzo.Result>(serviceImpl.Logout));
      serviceBinder.AddMethod(__Method_Add, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Kolcsonzo.Car4, global::Kolcsonzo.Result>(serviceImpl.Add));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Kolcsonzo.Car2, global::Kolcsonzo.Result>(serviceImpl.Delete));
      serviceBinder.AddMethod(__Method_Rent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Kolcsonzo.Car2, global::Kolcsonzo.Result>(serviceImpl.Rent));
      serviceBinder.AddMethod(__Method_Back, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Kolcsonzo.Car3, global::Kolcsonzo.Result>(serviceImpl.Back));
    }

  }
}
#endregion
