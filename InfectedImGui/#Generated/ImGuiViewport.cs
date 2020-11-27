// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 104)]
public unsafe partial struct ImGuiViewport
{
    [FieldOffset(0)] public uint ID;

    [FieldOffset(4)] public ImGuiViewportFlags Flags;

    [FieldOffset(8)] public ImVec2 Pos;

    [FieldOffset(16)] public ImVec2 Size;

    [FieldOffset(24)] public ImVec2 WorkOffsetMin;

    [FieldOffset(32)] public ImVec2 WorkOffsetMax;

    [FieldOffset(40)] public float DpiScale;

    [FieldOffset(48)] public ImDrawData* DrawData;

    [FieldOffset(56)] public uint ParentViewportId;

    [FieldOffset(64)] public void* RendererUserData;

    [FieldOffset(72)] public void* PlatformUserData;

    [FieldOffset(80)] public void* PlatformHandle;

    [FieldOffset(88)] public void* PlatformHandleRaw;

    [FieldOffset(96)] [MarshalAs(UnmanagedType.I1)] public bool PlatformRequestMove;

    [FieldOffset(97)] [MarshalAs(UnmanagedType.I1)] public bool PlatformRequestResize;

    [FieldOffset(98)] [MarshalAs(UnmanagedType.I1)] public bool PlatformRequestClose;

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0ImGuiViewport@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(ImGuiViewport* @this);

    public unsafe void Constructor()
    {
        fixed (ImGuiViewport* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??_DImGuiViewport@@QEAAXXZ", ExactSpelling = true)]
    private static extern void Destructor_PInvoke(ImGuiViewport* @this);

    public unsafe void Destructor()
    {
        fixed (ImGuiViewport* @this = &this)
        { Destructor_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetCenter@ImGuiViewport@@QEAA?AUImVec2@@XZ", ExactSpelling = true)]
    private static extern ImVec2 GetCenter_PInvoke(ImGuiViewport* @this);

    public unsafe ImVec2 GetCenter()
    {
        fixed (ImGuiViewport* @this = &this)
        { return GetCenter_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetWorkPos@ImGuiViewport@@QEAA?AUImVec2@@XZ", ExactSpelling = true)]
    private static extern ImVec2 GetWorkPos_PInvoke(ImGuiViewport* @this);

    public unsafe ImVec2 GetWorkPos()
    {
        fixed (ImGuiViewport* @this = &this)
        { return GetWorkPos_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetWorkSize@ImGuiViewport@@QEAA?AUImVec2@@XZ", ExactSpelling = true)]
    private static extern ImVec2 GetWorkSize_PInvoke(ImGuiViewport* @this);

    public unsafe ImVec2 GetWorkSize()
    {
        fixed (ImGuiViewport* @this = &this)
        { return GetWorkSize_PInvoke(@this); }
    }
}
