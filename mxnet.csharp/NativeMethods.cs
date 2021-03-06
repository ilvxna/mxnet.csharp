﻿using System;
using System.Runtime.InteropServices;
using System.Linq;
namespace mxnet.csharp
{


    /// Return Type: void
    ///param0: char*
    ///param1: NDArrayHandle->void*
    ///param2: void*
    public delegate void ExecutorMonitorCallback([In] [MarshalAs(UnmanagedType.LPStr)] string param0, IntPtr param1, IntPtr param2);

    /// Return Type: void
    ///param0: int
    ///param1: float**
    ///param2: int*
    ///param3: unsigned int**
    ///param4: int*
    ///param5: void*
    public delegate void NativeOpInfo_forward(int param0, ref IntPtr param1, ref int param2, ref IntPtr param3, ref int param4, IntPtr param5);

    /// Return Type: void
    ///param0: int
    ///param1: float**
    ///param2: int*
    ///param3: unsigned int**
    ///param4: int*
    ///param5: void*
    public delegate void NativeOpInfo_backward(int param0, ref IntPtr param1, ref int param2, ref IntPtr param3, ref int param4, IntPtr param5);

    /// Return Type: void
    ///param0: int
    ///param1: int*
    ///param2: unsigned int**
    ///param3: void*
    public delegate void NativeOpInfo_infer_shape(int param0, ref int param1, ref IntPtr param2, IntPtr param3);

    /// Return Type: void
    ///param0: char***
    ///param1: void*
    public delegate void NativeOpInfo_list_outputs(ref IntPtr param0, IntPtr param1);

    /// Return Type: void
    ///param0: char***
    ///param1: void*
    public delegate void NativeOpInfo_list_arguments(ref IntPtr param0, IntPtr param1);

    [StructLayout(LayoutKind.Sequential)]
    public struct NativeOpInfo
    {

        /// NativeOpInfo_forward
        public NativeOpInfo_forward AnonymousMember1;

        /// NativeOpInfo_backward
        public NativeOpInfo_backward AnonymousMember2;

        /// NativeOpInfo_infer_shape
        public NativeOpInfo_infer_shape AnonymousMember3;

        /// NativeOpInfo_list_outputs
        public NativeOpInfo_list_outputs AnonymousMember4;

        /// NativeOpInfo_list_arguments
        public NativeOpInfo_list_arguments AnonymousMember5;

        /// void*
        public IntPtr p_forward;

        /// void*
        public IntPtr p_backward;

        /// void*
        public IntPtr p_infer_shape;

        /// void*
        public IntPtr p_list_outputs;

        /// void*
        public IntPtr p_list_arguments;
    }

    /// Return Type: boolean
    ///param0: int
    ///param1: void**
    ///param2: int*
    ///param3: void*
    public delegate bool NDArrayOpInfo_forward(int param0, ref IntPtr param1, ref int param2, IntPtr param3);

    /// Return Type: boolean
    ///param0: int
    ///param1: void**
    ///param2: int*
    ///param3: void*
    public delegate bool NDArrayOpInfo_backward(int param0, ref IntPtr param1, ref int param2, IntPtr param3);

    /// Return Type: boolean
    ///param0: int
    ///param1: int*
    ///param2: unsigned int**
    ///param3: void*
    public delegate bool NDArrayOpInfo_infer_shape(int param0, ref int param1, ref IntPtr param2, IntPtr param3);

    /// Return Type: boolean
    ///param0: char***
    ///param1: void*
    public delegate bool NDArrayOpInfo_list_outputs(ref IntPtr param0, IntPtr param1);

    /// Return Type: boolean
    ///param0: char***
    ///param1: void*
    public delegate bool NDArrayOpInfo_list_arguments(ref IntPtr param0, IntPtr param1);

    /// Return Type: boolean
    ///param0: int*
    ///param1: int*
    ///param2: int*
    ///param3: int*
    ///param4: int**
    ///param5: void*
    public delegate bool NDArrayOpInfo_declare_backward_dependency(ref int param0, ref int param1, ref int param2, ref int param3, ref IntPtr param4, IntPtr param5);

    [StructLayout(LayoutKind.Sequential)]
    public struct NDArrayOpInfo
    {

        /// NDArrayOpInfo_forward
        public NDArrayOpInfo_forward AnonymousMember1;

        /// NDArrayOpInfo_backward
        public NDArrayOpInfo_backward AnonymousMember2;

        /// NDArrayOpInfo_infer_shape
        public NDArrayOpInfo_infer_shape AnonymousMember3;

        /// NDArrayOpInfo_list_outputs
        public NDArrayOpInfo_list_outputs AnonymousMember4;

        /// NDArrayOpInfo_list_arguments
        public NDArrayOpInfo_list_arguments AnonymousMember5;

        /// NDArrayOpInfo_declare_backward_dependency
        public NDArrayOpInfo_declare_backward_dependency AnonymousMember6;

        /// void*
        public IntPtr p_forward;

        /// void*
        public IntPtr p_backward;

        /// void*
        public IntPtr p_infer_shape;

        /// void*
        public IntPtr p_list_outputs;

        /// void*
        public IntPtr p_list_arguments;

        /// void*
        public IntPtr p_declare_backward_dependency;
    }

    /// Return Type: boolean
    ///param0: int
    ///param1: void**
    ///param2: int*
    ///param3: int*
    ///param4: boolean
    ///param5: void*
    public delegate bool CustomOpInfo_forward(int param0, ref IntPtr param1, ref int param2, ref int param3, [MarshalAs(UnmanagedType.I1)] bool param4, IntPtr param5);

    /// Return Type: boolean
    ///param0: int
    ///param1: void**
    ///param2: int*
    ///param3: int*
    ///param4: boolean
    ///param5: void*
    public delegate bool CustomOpInfo_backward(int param0, ref IntPtr param1, ref int param2, ref int param3, [MarshalAs(UnmanagedType.I1)] bool param4, IntPtr param5);

    /// Return Type: boolean
    ///param0: void*
    public delegate bool CustomOpInfo_del(IntPtr param0);

    [StructLayout(LayoutKind.Sequential)]
    public struct CustomOpInfo
    {

        /// CustomOpInfo_forward
        public CustomOpInfo_forward AnonymousMember1;

        /// CustomOpInfo_backward
        public CustomOpInfo_backward AnonymousMember2;

        /// CustomOpInfo_del
        public CustomOpInfo_del AnonymousMember3;

        /// void*
        public IntPtr p_forward;

        /// void*
        public IntPtr p_backward;

        /// void*
        public IntPtr p_del;
    }

    /// Return Type: boolean
    ///param0: char***
    ///param1: void*
    public delegate bool CustomOpPropInfo_list_arguments(ref IntPtr param0, IntPtr param1);

    /// Return Type: boolean
    ///param0: char***
    ///param1: void*
    public delegate bool CustomOpPropInfo_list_outputs(ref IntPtr param0, IntPtr param1);

    /// Return Type: boolean
    ///param0: int
    ///param1: int*
    ///param2: unsigned int**
    ///param3: void*
    public delegate bool CustomOpPropInfo_infer_shape(int param0, ref int param1, ref IntPtr param2, IntPtr param3);

    /// Return Type: boolean
    ///param0: int*
    ///param1: int*
    ///param2: int*
    ///param3: int*
    ///param4: int**
    ///param5: void*
    public delegate bool CustomOpPropInfo_declare_backward_dependency(ref int param0, ref int param1, ref int param2, ref int param3, ref IntPtr param4, IntPtr param5);

    /// Return Type: boolean
    ///param0: char*
    ///param1: int
    ///param2: unsigned int**
    ///param3: int*
    ///param4: int*
    ///param5: CustomOpInfo*
    ///param6: void*
    public delegate bool CustomOpPropInfo_create_operator([In] [MarshalAs(UnmanagedType.LPStr)] string param0, int param1, ref IntPtr param2, ref int param3, ref int param4, ref CustomOpInfo param5, IntPtr param6);

    /// Return Type: boolean
    ///param0: char***
    ///param1: void*
    public delegate bool CustomOpPropInfo_list_auxiliary_states(ref IntPtr param0, IntPtr param1);

    /// Return Type: boolean
    ///param0: void*
    public delegate bool CustomOpPropInfo_del(IntPtr param0);

    [StructLayout(LayoutKind.Sequential)]
    public struct CustomOpPropInfo
    {

        /// CustomOpPropInfo_list_arguments
        public CustomOpPropInfo_list_arguments AnonymousMember1;

        /// CustomOpPropInfo_list_outputs
        public CustomOpPropInfo_list_outputs AnonymousMember2;

        /// CustomOpPropInfo_infer_shape
        public CustomOpPropInfo_infer_shape AnonymousMember3;

        /// CustomOpPropInfo_declare_backward_dependency
        public CustomOpPropInfo_declare_backward_dependency AnonymousMember4;

        /// CustomOpPropInfo_create_operator
        public CustomOpPropInfo_create_operator AnonymousMember5;

        /// CustomOpPropInfo_list_auxiliary_states
        public CustomOpPropInfo_list_auxiliary_states AnonymousMember6;

        /// CustomOpPropInfo_del
        public CustomOpPropInfo_del AnonymousMember7;

        /// void*
        public IntPtr p_list_arguments;

        /// void*
        public IntPtr p_list_outputs;

        /// void*
        public IntPtr p_infer_shape;

        /// void*
        public IntPtr p_declare_backward_dependency;

        /// void*
        public IntPtr p_create_operator;

        /// void*
        public IntPtr p_list_auxiliary_states;

        /// void*
        public IntPtr p_del;
    }

    /// Return Type: boolean
    ///param0: char*
    ///param1: int
    ///param2: char**
    ///param3: char**
    ///param4: CustomOpPropInfo*
    public delegate bool CustomOpPropCreator([In] [MarshalAs(UnmanagedType.LPStr)] string param0, int param1, ref IntPtr param2, ref IntPtr param3, ref CustomOpPropInfo param4);


  
    /// Return Type: void
    ///key: int
    ///recv: NDArrayHandle->void*
    ///local: NDArrayHandle->void*
    ///handle: void*
    public delegate void MXKVStoreUpdater(int key, IntPtr recv, IntPtr local, IntPtr handle);

    /// Return Type: void
    ///head: int
    ///body: char*
    ///controller_handle: void*
    public delegate void MXKVStoreServerController(int head, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string body, IntPtr controller_handle);


    public static class NativeMethods
    {

  

        /// Return Type: char*
        [DllImport("libmxnet.dll", EntryPoint = "MXGetLastError")]
        public static extern IntPtr MXGetLastErrorNative();

        public static string MXGetLastError()
        {
            return Marshal.PtrToStringAnsi(MXGetLastErrorNative());
        }


        /// Return Type: int
        ///seed: int
        [DllImport("libmxnet.dll", EntryPoint = "MXRandomSeed")]
        public static extern int MXRandomSeed(int seed);


        /// Return Type: int
        [DllImport("libmxnet.dll", EntryPoint = "MXNotifyShutdown")]
        public static extern int MXNotifyShutdown();


        /// Return Type: int
        ///out: NDArrayHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayCreateNone")]
        public static extern int MXNDArrayCreateNone(out IntPtr @out);


        /// Return Type: int
        ///shape: mx_uint*
        ///ndim: mx_uint->unsigned int
        ///dev_type: int
        ///dev_id: int
        ///delay_alloc: int
        ///out: NDArrayHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayCreate")]
        public static extern int MXNDArrayCreate(
              [MarshalAs(UnmanagedType.LPArray,ArraySubType = UnmanagedType.U4)]uint[] shape, 
              uint ndim, DeviceType devType,
              int dev_id, 
              int delay_alloc,
              out IntPtr @out);


        /// Return Type: int
        ///shape: mx_uint*
        ///ndim: mx_uint->unsigned int
        ///dev_type: int
        ///dev_id: int
        ///delay_alloc: int
        ///dtype: int
        ///out: NDArrayHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayCreateEx")]
        public static extern int MXNDArrayCreateEx(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)]uint[] shape,
            uint ndim,
            DeviceType dev_type,
            int dev_id, 
            int delay_alloc, 
            int dtype,
            out IntPtr @out);


        /// Return Type: int
        ///buf: void*
        ///size: size_t->unsigned int
        ///out: NDArrayHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayLoadFromRawBytes")]
        public static extern int MXNDArrayLoadFromRawBytes(IntPtr buf, [MarshalAs(UnmanagedType.SysUInt)] uint size, ref IntPtr @out);


        /// Return Type: int
        ///handle: NDArrayHandle->void*
        ///out_size: size_t*
        ///out_buf: char**
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArraySaveRawBytes")]
        public static extern int MXNDArraySaveRawBytes(IntPtr handle, ref uint out_size, ref IntPtr out_buf);


        /// Return Type: int
        ///fname: char*
        ///num_args: mx_uint->unsigned int
        ///args: NDArrayHandle*
        ///keys: char**
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArraySave")]
        public static extern int MXNDArraySave([In] [MarshalAs(UnmanagedType.LPStr)] string fname, uint num_args, ref IntPtr args, ref IntPtr keys);


        /// Return Type: int
        ///fname: char*
        ///out_size: mx_uint*
        ///out_arr: NDArrayHandle**
        ///out_name_size: mx_uint*
        ///out_names: char***
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayLoad")]
        public static extern int MXNDArrayLoad([In] [MarshalAs(UnmanagedType.LPStr)] string fname, ref uint out_size, ref IntPtr out_arr, ref uint out_name_size, ref IntPtr out_names);


        /// Return Type: int
        ///handle: NDArrayHandle->void*
        ///data: void*
        ///size: size_t->unsigned int
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArraySyncCopyFromCPU")]
        public static extern int MXNDArraySyncCopyFromCPU(IntPtr handle, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)] float[] data, uint size);


        /// Return Type: int
        ///handle: NDArrayHandle->void*
        ///data: void*
        ///size: size_t->unsigned int
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArraySyncCopyToCPU")]
        public static extern int MXNDArraySyncCopyToCPU(IntPtr handle, IntPtr data,uint size);


        /// Return Type: int
        ///handle: NDArrayHandle->void*
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayWaitToRead")]
        public static extern int MXNDArrayWaitToRead(IntPtr handle);


        /// Return Type: int
        ///handle: NDArrayHandle->void*
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayWaitToWrite")]
        public static extern int MXNDArrayWaitToWrite(IntPtr handle);


        /// Return Type: int
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayWaitAll")]
        public static extern int MXNDArrayWaitAll();


        /// Return Type: int
        ///handle: NDArrayHandle->void*
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayFree")]
        public static extern int MXNDArrayFree(IntPtr handle);


        /// Return Type: int
        ///handle: NDArrayHandle->void*
        ///slice_begin: mx_uint->unsigned int
        ///slice_end: mx_uint->unsigned int
        ///out: NDArrayHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArraySlice")]
        public static extern int MXNDArraySlice(IntPtr handle, uint slice_begin, uint slice_end, out IntPtr @out);


        /// Return Type: int
        ///handle: NDArrayHandle->void*
        ///idx: mx_uint->unsigned int
        ///out: NDArrayHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayAt")]
        public static extern int MXNDArrayAt(IntPtr handle, uint idx, ref IntPtr @out);


        /// Return Type: int
        ///handle: NDArrayHandle->void*
        ///ndim: int
        ///dims: int*
        ///out: NDArrayHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayReshape")]
        public static extern int MXNDArrayReshape(IntPtr handle,
            int ndim,
            [In] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)] int[] dims,
            out IntPtr @out);


        /// Return Type: int
        ///handle: NDArrayHandle->void*
        ///out_dim: mx_uint*
        ///out_pdata: mx_uint**
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayGetShape")]
        public static extern int MXNDArrayGetShape(IntPtr handle, out uint out_dim, out IntPtr out_pdata);


        /// Return Type: int
        ///handle: NDArrayHandle->void*
        ///out_pdata: mx_float**
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayGetData")]
        public static extern int MXNDArrayGetData(IntPtr handle, ref IntPtr out_pdata);


        /// Return Type: int
        ///handle: NDArrayHandle->void*
        ///out_dtype: int*
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayGetDType")]
        public static extern int MXNDArrayGetDType(IntPtr handle, out int out_dtype);


        /// Return Type: int
        ///handle: NDArrayHandle->void*
        ///out_dev_type: int*
        ///out_dev_id: int*
        [DllImport("libmxnet.dll", EntryPoint = "MXNDArrayGetContext")]
        public static extern int MXNDArrayGetContext(IntPtr handle, ref int out_dev_type, ref int out_dev_id);


        /// Return Type: int
        ///out_size: mx_uint*
        ///out_array: FunctionHandle**
        [DllImport("libmxnet.dll", EntryPoint = "MXListFunctions")]
        public static extern int MXListFunctions(ref uint out_size, ref IntPtr out_array);


        /// Return Type: int
        ///name: char*
        ///out: FunctionHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXGetFunction")]
        public static extern int MXGetFunction([In] [MarshalAs(UnmanagedType.LPStr)] string name, out IntPtr @out);


        /// Return Type: int
        ///fun: FunctionHandle->void*
        ///name: char**
        ///description: char**
        ///num_args: mx_uint*
        ///arg_names: char***
        ///arg_type_infos: char***
        ///arg_descriptions: char***
        ///return_type: char**
        [DllImport("libmxnet.dll", EntryPoint = "MXFuncGetInfo")]
        public static extern int MXFuncGetInfo(IntPtr fun, ref IntPtr name, ref IntPtr description, ref uint num_args, ref IntPtr arg_names, ref IntPtr arg_type_infos, ref IntPtr arg_descriptions, ref IntPtr return_type);


        /// Return Type: int
        ///fun: FunctionHandle->void*
        ///num_use_vars: mx_uint*
        ///num_scalars: mx_uint*
        ///num_mutate_vars: mx_uint*
        ///type_mask: int*
        [DllImport("libmxnet.dll", EntryPoint = "MXFuncDescribe")]
        public static extern int MXFuncDescribe(IntPtr fun, ref uint num_use_vars, ref uint num_scalars, ref uint num_mutate_vars, ref int type_mask);


        /// Return Type: int
        ///fun: FunctionHandle->void*
        ///use_vars: NDArrayHandle*
        ///scalar_args: mx_float*
        ///mutate_vars: NDArrayHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXFuncInvoke")]
        public static extern int MXFuncInvoke(IntPtr fun, 
            ref IntPtr use_vars,
                [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]  float[] scalar_args, 
            ref IntPtr mutate_vars);


        /// Return Type: int
        ///fun: FunctionHandle->void*
        ///use_vars: NDArrayHandle*
        ///scalar_args: mx_float*
        ///mutate_vars: NDArrayHandle*
        ///num_params: int
        ///param_keys: char**
        ///param_vals: char**
        [DllImport("libmxnet.dll", EntryPoint = "MXFuncInvokeEx")]
        public static extern int MXFuncInvokeEx(IntPtr fun,
            ref IntPtr use_vars,
             [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.R4)]  float[] scalar_args,
            ref IntPtr mutate_vars,
            int num_params,
            [In] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] param_keys,
            [In] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] param_vals);


        /// Return Type: int
        ///out_size: mx_uint*
        ///out_array: AtomicSymbolCreator**
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolListAtomicSymbolCreators")]
        public static extern int MXSymbolListAtomicSymbolCreators(out uint out_size,
            out IntPtr out_array_ptr);


        /// Return Type: int
        ///creator: AtomicSymbolCreator->void*
        ///name: char**
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolGetAtomicSymbolName")]
        public static extern int MXSymbolGetAtomicSymbolName(IntPtr creator, ref IntPtr name);


        /// Return Type: int
        ///creator: AtomicSymbolCreator->void*
        ///name: char**
        ///description: char**
        ///num_args: mx_uint*
        ///arg_names: char***
        ///arg_type_infos: char***
        ///arg_descriptions: char***
        ///key_var_num_args: char**
        ///return_type: char**
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolGetAtomicSymbolInfo")]
        public static extern int MXSymbolGetAtomicSymbolInfo(IntPtr creator,
          [Out]out IntPtr name,
          [Out]out IntPtr description,
          [Out]out uint num_args,
          [Out]out IntPtr arg_names,
          [Out]out IntPtr arg_type_infos,
          [Out]out IntPtr arg_descriptions,
          [Out]out IntPtr key_var_num_args,
          [Out]out IntPtr return_type);


        /// Return Type: int
        ///creator: AtomicSymbolCreator->void*
        ///num_param: mx_uint->unsigned int
        ///keys: char**
        ///vals: char**
        ///out: SymbolHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolCreateAtomicSymbol")]
        public static extern int MXSymbolCreateAtomicSymbol(IntPtr creator, 
            uint num_param,
         [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] keys ,
         [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] vals, 
            out IntPtr @out);


        /// Return Type: int
        ///name: char*
        ///out: SymbolHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolCreateVariable")]
        public static extern int MXSymbolCreateVariable([In] [MarshalAs(UnmanagedType.LPStr)] string name, out IntPtr @out);


        /// Return Type: int
        ///num_symbols: mx_uint->unsigned int
        ///symbols: SymbolHandle*
        ///out: SymbolHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolCreateGroup")]
        public static extern int MXSymbolCreateGroup(uint num_symbols,
           [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt)] IntPtr[] symbols, out IntPtr @out);


        /// Return Type: int
        ///fname: char*
        ///out: SymbolHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolCreateFromFile")]
        public static extern int MXSymbolCreateFromFile([In] [MarshalAs(UnmanagedType.LPStr)] string fname, out IntPtr @out);


        /// Return Type: int
        ///json: char*
        ///out: SymbolHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolCreateFromJSON")]
        public static extern int MXSymbolCreateFromJSON([In] [MarshalAs(UnmanagedType.LPStr)] string json, out IntPtr @out);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///fname: char*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolSaveToFile")]
        public static extern int MXSymbolSaveToFile(IntPtr symbol, [In] [MarshalAs(UnmanagedType.LPStr)] string fname);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///out_json: char**
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolSaveToJSON")]
        public static extern int MXSymbolSaveToJSON(IntPtr symbol, out IntPtr out_json);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolFree")]
        public static extern int MXSymbolFree(IntPtr symbol);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///out: SymbolHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolCopy")]
        public static extern int MXSymbolCopy(IntPtr symbol, out IntPtr @out);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///out_str: char**
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolPrint")]
        public static extern int MXSymbolPrint(IntPtr symbol, ref IntPtr out_str);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///out: char**
        ///success: int*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolGetName")]
        public static extern int MXSymbolGetName(IntPtr symbol, ref IntPtr @out, ref int success);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///key: char*
        ///out: char**
        ///success: int*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolGetAttr")]
        public static extern int MXSymbolGetAttr(IntPtr symbol, [In] [MarshalAs(UnmanagedType.LPStr)] string key, ref IntPtr @out, ref int success);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///key: char*
        ///value: char*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolSetAttr")]
        public static extern int MXSymbolSetAttr(IntPtr symbol, [In] [MarshalAs(UnmanagedType.LPStr)] string key, [In] [MarshalAs(UnmanagedType.LPStr)] string value);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///out_size: mx_uint*
        ///out: char***
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolListAttr")]
        public static extern int MXSymbolListAttr(IntPtr symbol, out uint out_size, out IntPtr @out);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///out_size: mx_uint*
        ///out: char***
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolListAttrShallow")]
        public static extern int MXSymbolListAttrShallow(IntPtr symbol, out uint out_size, out IntPtr @out);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///out_size: mx_uint*
        ///out_str_array: char***
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolListArguments")]
        public static extern int MXSymbolListArguments(IntPtr symbol, out uint out_size, out IntPtr out_str_array);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///out_size: mx_uint*
        ///out_str_array: char***
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolListOutputs")]
        public static extern int MXSymbolListOutputs(IntPtr symbol, out uint out_size, out IntPtr out_str_array);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///out: SymbolHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolGetInternals")]
        public static extern int MXSymbolGetInternals(IntPtr symbol, out IntPtr @out);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///index: mx_uint->unsigned int
        ///out: SymbolHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolGetOutput")]
        public static extern int MXSymbolGetOutput(IntPtr symbol, uint index, out IntPtr @out);


        /// Return Type: int
        ///symbol: SymbolHandle->void*
        ///out_size: mx_uint*
        ///out_str_array: char***
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolListAuxiliaryStates")]
        public static extern int MXSymbolListAuxiliaryStates(IntPtr symbol, out uint out_size, out IntPtr out_str_array);


        /// Return Type: int
        ///sym: SymbolHandle->void*
        ///name: char*
        ///num_args: mx_uint->unsigned int
        ///keys: char**
        ///args: SymbolHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolCompose")]
        public static extern int MXSymbolCompose(IntPtr sym, 
            [In] [MarshalAs(UnmanagedType.LPStr)] string name,
            uint num_args,
           [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] keys,
           [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt)] IntPtr[] args);

        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolCompose")]
        public static extern int MXSymbolCompose(IntPtr sym,
          [In] [MarshalAs(UnmanagedType.LPStr)] string name,
          uint num_args,
         [In]  IntPtr keys,
         [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt)] IntPtr[] args);


        /// Return Type: int
        ///sym: SymbolHandle->void*
        ///num_wrt: mx_uint->unsigned int
        ///wrt: char**
        ///out: SymbolHandle*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolGrad")]
        public static extern int MXSymbolGrad(IntPtr sym, uint num_wrt, ref IntPtr wrt, ref IntPtr @out);


        /// Return Type: int
        ///sym: SymbolHandle->void*
        ///num_args: mx_uint->unsigned int
        ///keys: char**
        ///arg_ind_ptr: mx_uint*
        ///arg_shape_data: mx_uint*
        ///in_shape_size: mx_uint*
        ///in_shape_ndim: mx_uint**
        ///in_shape_data: mx_uint***
        ///out_shape_size: mx_uint*
        ///out_shape_ndim: mx_uint**
        ///out_shape_data: mx_uint***
        ///aux_shape_size: mx_uint*
        ///aux_shape_ndim: mx_uint**
        ///aux_shape_data: mx_uint***
        ///complete: int*
        [DllImport("libmxnet.dll", EntryPoint = "MXSymbolInferShape")]
        public static extern int MXSymbolInferShape(IntPtr sym, 
            uint num_args,
                  [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] keys,
         [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)] uint[]     arg_ind_ptr,
                [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)] uint[] arg_shape_data, 
            out uint in_shape_size,
            out IntPtr in_shape_ndim,
            out IntPtr in_shape_data,
            out uint out_shape_size,
            out IntPtr out_shape_ndim,
            out IntPtr out_shape_data,
            out uint aux_shape_size,
            out IntPtr aux_shape_ndim,
            out IntPtr aux_shape_data,
            out int complete);




        /// Return Type: int
        ///sym: SymbolHandle->void*
        ///num_args: mx_uint->unsigned int
        ///keys: char**
        ///arg_ind_ptr: mx_uint*
        ///arg_shape_data: mx_uint*
        ///in_shape_size: mx_uint*
        ///in_shape_ndim: mx_uint**
        ///in_shape_data: mx_uint***
        ///out_shape_size: mx_uint*
        ///out_shape_ndim: mx_uint**
        ///out_shape_data: mx_uint***
        ///aux_shape_size: mx_uint*
        ///aux_shape_ndim: mx_uint**
        ///aux_shape_data: mx_uint***
        ///complete: int*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXSymbolInferShapePartial")]
        public static extern int MXSymbolInferShapePartial(IntPtr sym, uint num_args, ref IntPtr keys, ref uint arg_ind_ptr, ref uint arg_shape_data, ref uint in_shape_size, ref IntPtr in_shape_ndim, ref IntPtr in_shape_data, ref uint out_shape_size, ref IntPtr out_shape_ndim, ref IntPtr out_shape_data, ref uint aux_shape_size, ref IntPtr aux_shape_ndim, ref IntPtr aux_shape_data, ref int complete);


        /// Return Type: int
        ///sym: SymbolHandle->void*
        ///num_args: mx_uint->unsigned int
        ///keys: char**
        ///arg_type_data: int*
        ///in_type_size: mx_uint*
        ///in_type_data: int**
        ///out_type_size: mx_uint*
        ///out_type_data: int**
        ///aux_type_size: mx_uint*
        ///aux_type_data: int**
        ///complete: int*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXSymbolInferType")]
        public static extern int MXSymbolInferType(IntPtr sym,
            uint num_args,
            [In] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] keys,
            [In] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)] int[] arg_type_data,
            out uint in_type_size,
            out IntPtr in_type_data,
            out uint out_type_size,
            out IntPtr out_type_data,
            out uint aux_type_size,
            out IntPtr aux_type_data,
            out int complete);


        /// Return Type: int
        ///handle: ExecutorHandle->void*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXExecutorFree")]
        public static extern int MXExecutorFree(IntPtr handle);


        /// Return Type: int
        ///handle: ExecutorHandle->void*
        ///out_str: char**
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXExecutorPrint")]
        public static extern int MXExecutorPrint(IntPtr handle, out IntPtr out_str);


        /// Return Type: int
        ///handle: ExecutorHandle->void*
        ///is_train: int
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXExecutorForward")]
        public static extern int MXExecutorForward(IntPtr handle, int is_train);


        /// Return Type: int
        ///handle: ExecutorHandle->void*
        ///len: mx_uint->unsigned int
        ///head_grads: NDArrayHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXExecutorBackward")]
        public static extern int MXExecutorBackward(IntPtr handle, uint len, [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt)] IntPtr[] head_grads);

        /// Return Type: int
        ///handle: ExecutorHandle->void*
        ///len: mx_uint->unsigned int
        ///head_grads: NDArrayHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXExecutorBackward")]
        public static extern int MXExecutorBackward(IntPtr handle, uint len, IntPtr head_grads);

        /// Return Type: int
        ///handle: ExecutorHandle->void*
        ///out_size: mx_uint*
        ///out: NDArrayHandle**
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXExecutorOutputs")]
        public static extern int MXExecutorOutputs(IntPtr handle, out uint out_size, out IntPtr @out);


        /// Return Type: int
        ///symbol_handle: SymbolHandle->void*
        ///dev_type: int
        ///dev_id: int
        ///len: mx_uint->unsigned int
        ///in_args: NDArrayHandle*
        ///arg_grad_store: NDArrayHandle*
        ///grad_req_type: mx_uint*
        ///aux_states_len: mx_uint->unsigned int
        ///aux_states: NDArrayHandle*
        ///out: ExecutorHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXExecutorBind")]
        public static extern int MXExecutorBind(IntPtr symbol_handle, int dev_type, int dev_id, uint len, ref IntPtr in_args, ref IntPtr arg_grad_store, ref uint grad_req_type, uint aux_states_len, ref IntPtr aux_states, ref IntPtr @out);


        /// Return Type: int
        ///symbol_handle: SymbolHandle->void*
        ///dev_type: int
        ///dev_id: int
        ///num_map_keys: mx_uint->unsigned int
        ///map_keys: char**
        ///map_dev_types: int*
        ///map_dev_ids: int*
        ///len: mx_uint->unsigned int
        ///in_args: NDArrayHandle*
        ///arg_grad_store: NDArrayHandle*
        ///grad_req_type: mx_uint*
        ///aux_states_len: mx_uint->unsigned int
        ///aux_states: NDArrayHandle*
        ///out: ExecutorHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXExecutorBindX")]
        public static extern int MXExecutorBindX(IntPtr symbol_handle, int dev_type, int dev_id, uint num_map_keys, ref IntPtr map_keys, ref int map_dev_types, ref int map_dev_ids, uint len, ref IntPtr in_args, ref IntPtr arg_grad_store, ref uint grad_req_type, uint aux_states_len, ref IntPtr aux_states, ref IntPtr @out);


        /// Return Type: int
        ///symbol_handle: SymbolHandle->void*
        ///dev_type: int
        ///dev_id: int
        ///num_map_keys: mx_uint->unsigned int
        ///map_keys: char**
        ///map_dev_types: int*
        ///map_dev_ids: int*
        ///len: mx_uint->unsigned int
        ///in_args: NDArrayHandle*
        ///arg_grad_store: NDArrayHandle*
        ///grad_req_type: mx_uint*
        ///aux_states_len: mx_uint->unsigned int
        ///aux_states: NDArrayHandle*
        ///shared_exec: ExecutorHandle->void*
        ///out: ExecutorHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXExecutorBindEX")]
        public static extern int MXExecutorBindEX(IntPtr symbolHandle,
            int dev_type,
            int dev_id,
            uint num_map_keys,
            [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] map_keys,
            [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)] int[] map_dev_types,
            [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)] int[] map_dev_ids,
            uint len,
            [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt)] IntPtr[] in_args,
            [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt)] IntPtr[] arg_grad_store,
            [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)] uint[] grad_req_type,
            uint aux_states_len,
            [In]  [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt)] IntPtr[] aux_states,
            IntPtr shared_exec,
            out IntPtr @out);

        /// Return Type: int
        ///handle: ExecutorHandle->void*
        ///callback: ExecutorMonitorCallback
        ///callback_handle: void*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXExecutorSetMonitorCallback")]
        public static extern int MXExecutorSetMonitorCallback(IntPtr handle, ExecutorMonitorCallback callback, IntPtr callback_handle);


        /// Return Type: int
        ///out_size: mx_uint*
        ///out_array: DataIterCreator**
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXListDataIters")]
        public static extern int MXListDataIters(ref uint out_size, ref IntPtr out_array);


        /// Return Type: int
        ///handle: DataIterCreator->void*
        ///num_param: mx_uint->unsigned int
        ///keys: char**
        ///vals: char**
        ///out: DataIterHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXDataIterCreateIter")]
        public static extern int MXDataIterCreateIter(IntPtr handle, uint num_param, ref IntPtr keys, ref IntPtr vals, ref IntPtr @out);


        /// Return Type: int
        ///creator: DataIterCreator->void*
        ///name: char**
        ///description: char**
        ///num_args: mx_uint*
        ///arg_names: char***
        ///arg_type_infos: char***
        ///arg_descriptions: char***
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXDataIterGetIterInfo")]
        public static extern int MXDataIterGetIterInfo(IntPtr creator, ref IntPtr name, ref IntPtr description, ref uint num_args, ref IntPtr arg_names, ref IntPtr arg_type_infos, ref IntPtr arg_descriptions);


        /// Return Type: int
        ///handle: DataIterHandle->void*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXDataIterFree")]
        public static extern int MXDataIterFree(IntPtr handle);


        /// Return Type: int
        ///handle: DataIterHandle->void*
        ///out: int*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXDataIterNext")]
        public static extern int MXDataIterNext(IntPtr handle, ref int @out);


        /// Return Type: int
        ///handle: DataIterHandle->void*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXDataIterBeforeFirst")]
        public static extern int MXDataIterBeforeFirst(IntPtr handle);


        /// Return Type: int
        ///handle: DataIterHandle->void*
        ///out: NDArrayHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXDataIterGetData")]
        public static extern int MXDataIterGetData(IntPtr handle, ref IntPtr @out);


        /// Return Type: int
        ///handle: DataIterHandle->void*
        ///out_index: uint64_t**
        ///out_size: uint64_t*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXDataIterGetIndex")]
        public static extern int MXDataIterGetIndex(IntPtr handle, ref IntPtr out_index, ref ulong out_size);


        /// Return Type: int
        ///handle: DataIterHandle->void*
        ///pad: int*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXDataIterGetPadNum")]
        public static extern int MXDataIterGetPadNum(IntPtr handle, ref int pad);


        /// Return Type: int
        ///handle: DataIterHandle->void*
        ///out: NDArrayHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXDataIterGetLabel")]
        public static extern int MXDataIterGetLabel(IntPtr handle, ref IntPtr @out);


        /// Return Type: int
        ///num_vars: mx_uint->unsigned int
        ///keys: char**
        ///vals: char**
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXInitPSEnv")]
        public static extern int MXInitPSEnv(uint num_vars, ref IntPtr keys, ref IntPtr vals);


        /// Return Type: int
        ///type: char*
        ///out: KVStoreHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreCreate")]
        public static extern int MXKVStoreCreate([InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string type, out IntPtr @out);


        /// Return Type: int
        ///handle: KVStoreHandle->void*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreFree")]
        public static extern int MXKVStoreFree(IntPtr handle);


        /// Return Type: int
        ///handle: KVStoreHandle->void*
        ///num: mx_uint->unsigned int
        ///keys: int*
        ///vals: NDArrayHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreInit")]
        public static extern int MXKVStoreInit(IntPtr handle, uint num,
                 [In] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)] int[]   keys,
                 [In] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt)] IntPtr[] vals);


        /// Return Type: int
        /// handle: KVStoreHandle->void*
        /// num: mx_uint->unsigned int
        /// keys: int*
        /// vals: NDArrayHandle*
        /// priority: int
        [DllImport("libmxnet.dll", EntryPoint = "MXKVStorePush")]
        public static extern int MXKVStorePush(IntPtr handle, uint num,
            [In] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)] int[] keys,
            [In] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt)] IntPtr[] vals
            , int priority);


        /// Return Type: int
        ///handle: KVStoreHandle->void*
        ///num: mx_uint->unsigned int
        ///keys: int*
        ///vals: NDArrayHandle*
        ///priority: int
        [DllImport("libmxnet.dll", EntryPoint = "MXKVStorePull")]
        public static extern int MXKVStorePull(IntPtr handle, uint num,
            [In] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)] int[] keys,
            [In] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt)] IntPtr[] vals, int priority);


        /// Return Type: int
        ///handle: KVStoreHandle->void*
        ///updater: MXKVStoreUpdater
        ///updater_handle: void*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreSetUpdater")]
        public static extern int MXKVStoreSetUpdater(IntPtr handle,
            [MarshalAs(UnmanagedType.FunctionPtr)]MXKVStoreUpdater updater,
            IntPtr updater_handle);


        /// Return Type: int
        ///handle: KVStoreHandle->void*
        ///type: char**
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreGetType")]
        public static extern int MXKVStoreGetType(IntPtr handle, out IntPtr type);


        /// Return Type: int
        ///handle: KVStoreHandle->void*
        ///ret: int*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreGetRank")]
        public static extern int MXKVStoreGetRank(IntPtr handle, out int ret);


        /// Return Type: int
        ///handle: KVStoreHandle->void*
        ///ret: int*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreGetGroupSize")]
        public static extern int MXKVStoreGetGroupSize(IntPtr handle, out int ret);


        /// Return Type: int
        ///ret: int*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreIsWorkerNode")]
        public static extern int MXKVStoreIsWorkerNode(out int ret);


        /// Return Type: int
        ///ret: int*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreIsServerNode")]
        public static extern int MXKVStoreIsServerNode(out int ret);


        /// Return Type: int
        ///ret: int*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreIsSchedulerNode")]
        public static extern int MXKVStoreIsSchedulerNode(out int ret);


        /// Return Type: int
        ///handle: KVStoreHandle->void*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreBarrier")]
        public static extern int MXKVStoreBarrier(IntPtr handle);


        /// Return Type: int
        ///handle: KVStoreHandle->void*
        ///barrier_before_exit: int
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreSetBarrierBeforeExit")]
        public static extern int MXKVStoreSetBarrierBeforeExit(IntPtr handle, int barrier_before_exit);


        /// Return Type: int
        ///handle: KVStoreHandle->void*
        ///controller: MXKVStoreServerController
        ///controller_handle: void*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreRunServer")]
        public static extern int MXKVStoreRunServer(IntPtr handle, MXKVStoreServerController controller, IntPtr controller_handle);


        /// Return Type: int
        ///handle: KVStoreHandle->void*
        ///cmd_id: int
        ///cmd_body: char*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreSendCommmandToServers")]
        public static extern int MXKVStoreSendCommmandToServers(IntPtr handle, int cmd_id,
            [In(), MarshalAs(UnmanagedType.LPStr)]  string cmd_body);


        /// Return Type: int
        ///handle: KVStoreHandle->void*
        ///node_id: int
        ///number: int*
        ///timeout_sec: int
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXKVStoreGetNumDeadNode")]
        public static extern int MXKVStoreGetNumDeadNode(IntPtr handle, int node_id, ref int number, int timeout_sec);


        /// Return Type: int
        ///uri: char*
        ///out: RecordIOHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXRecordIOWriterCreate")]
        public static extern int MXRecordIOWriterCreate([InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string uri, ref IntPtr @out);


        /// Return Type: int
        ///handle: RecordIOHandle->void*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXRecordIOWriterFree")]
        public static extern int MXRecordIOWriterFree(IntPtr handle);


        /// Return Type: int
        ///handle: RecordIOHandle*
        ///buf: char*
        ///size: size_t->unsigned int
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXRecordIOWriterWriteRecord")]
        public static extern int MXRecordIOWriterWriteRecord(ref IntPtr handle, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string buf, [MarshalAsAttribute(UnmanagedType.SysUInt)] uint size);


        /// Return Type: int
        ///handle: RecordIOHandle*
        ///pos: size_t*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXRecordIOWriterTell")]
        public static extern int MXRecordIOWriterTell(ref IntPtr handle, ref uint pos);


        /// Return Type: int
        ///uri: char*
        ///out: RecordIOHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXRecordIOReaderCreate")]
        public static extern int MXRecordIOReaderCreate([InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string uri, ref IntPtr @out);


        /// Return Type: int
        ///handle: RecordIOHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXRecordIOReaderFree")]
        public static extern int MXRecordIOReaderFree(ref IntPtr handle);


        /// Return Type: int
        ///handle: RecordIOHandle*
        ///buf: char**
        ///size: size_t*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXRecordIOReaderReadRecord")]
        public static extern int MXRecordIOReaderReadRecord(ref IntPtr handle, ref IntPtr buf, ref uint size);


        /// Return Type: int
        ///handle: RecordIOHandle*
        ///pos: size_t->unsigned int
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXRecordIOReaderSeek")]
        public static extern int MXRecordIOReaderSeek(ref IntPtr handle, [MarshalAsAttribute(UnmanagedType.SysUInt)] uint pos);


        /// Return Type: int
        ///name: char*
        ///num_input: mx_uint->unsigned int
        ///num_output: mx_uint->unsigned int
        ///input_names: char**
        ///output_names: char**
        ///inputs: NDArrayHandle*
        ///outputs: NDArrayHandle*
        ///kernel: char*
        ///out: RtcHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXRtcCreate")]
        public static extern int MXRtcCreate(IntPtr name, uint num_input, uint num_output, ref IntPtr input_names, ref IntPtr output_names, ref IntPtr inputs, ref IntPtr outputs, IntPtr kernel, ref IntPtr @out);


        /// Return Type: int
        ///handle: RtcHandle->void*
        ///num_input: mx_uint->unsigned int
        ///num_output: mx_uint->unsigned int
        ///inputs: NDArrayHandle*
        ///outputs: NDArrayHandle*
        ///gridDimX: mx_uint->unsigned int
        ///gridDimY: mx_uint->unsigned int
        ///gridDimZ: mx_uint->unsigned int
        ///blockDimX: mx_uint->unsigned int
        ///blockDimY: mx_uint->unsigned int
        ///blockDimZ: mx_uint->unsigned int
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXRtcPush")]
        public static extern int MXRtcPush(IntPtr handle, uint num_input, uint num_output, ref IntPtr inputs, ref IntPtr outputs, uint gridDimX, uint grid_dim_y, uint grid_dim_z, uint block_dim_x, uint block_dim_y, uint block_dim_z);


        /// Return Type: int
        ///handle: RtcHandle->void*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXRtcFree")]
        public static extern int MXRtcFree(IntPtr handle);


        /// Return Type: int
        ///key: char*
        ///out: OptimizerCreator*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXOptimizerFindCreator")]
        public static extern int MXOptimizerFindCreator([InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string key, out IntPtr @out);


        /// Return Type: int
        ///creator: OptimizerCreator->void*
        ///num_param: mx_uint->unsigned int
        ///keys: char**
        ///vals: char**
        ///out: OptimizerHandle*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXOptimizerCreateOptimizer")]
        public static extern int MXOptimizerCreateOptimizer(IntPtr creator, uint num_param,
            [In] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] keys,
            [In] [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] vals,
            out IntPtr @out);


        /// Return Type: int
        ///handle: OptimizerHandle->void*
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXOptimizerFree")]
        public static extern int MXOptimizerFree(IntPtr handle);


        /// Return Type: int
        ///handle: OptimizerHandle->void*
        ///index: int
        ///weight: NDArrayHandle->void*
        ///grad: NDArrayHandle->void*
        ///lr: mx_float->float
        ///wd: mx_float->float
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXOptimizerUpdate")]
        public static extern int MXOptimizerUpdate(IntPtr handle, int index, IntPtr weight, IntPtr grad, float lr, float wd);


        /// Return Type: int
        ///op_type: char*
        ///creator: CustomOpPropCreator
        [DllImportAttribute("libmxnet.dll", EntryPoint = "MXCustomOpRegister")]
        public static extern int MXCustomOpRegister([InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string op_type, CustomOpPropCreator creator);

    

    }

}
