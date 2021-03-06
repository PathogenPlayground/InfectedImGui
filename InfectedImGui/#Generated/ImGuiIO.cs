// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 5456)]
public unsafe partial struct ImGuiIO
{
    [FieldOffset(0)] public ImGuiConfigFlags ConfigFlags;

    [FieldOffset(4)] public ImGuiBackendFlags BackendFlags;

    [FieldOffset(8)] public ImVec2 DisplaySize;

    [FieldOffset(16)] public float DeltaTime;

    [FieldOffset(20)] public float IniSavingRate;

    [FieldOffset(24)] public byte* IniFilename;

    [FieldOffset(32)] public byte* LogFilename;

    [FieldOffset(40)] public float MouseDoubleClickTime;

    [FieldOffset(44)] public float MouseDoubleClickMaxDist;

    [FieldOffset(48)] public float MouseDragThreshold;

    [FieldOffset(52)] public ConstantArray_int_22 KeyMap;

    [FieldOffset(140)] public float KeyRepeatDelay;

    [FieldOffset(144)] public float KeyRepeatRate;

    [FieldOffset(152)] public void* UserData;

    [FieldOffset(160)] public ImFontAtlas* Fonts;

    [FieldOffset(168)] public float FontGlobalScale;

    [FieldOffset(172)] [MarshalAs(UnmanagedType.I1)] public bool FontAllowUserScaling;

    [FieldOffset(176)] public ImFont* FontDefault;

    [FieldOffset(184)] public ImVec2 DisplayFramebufferScale;

    [FieldOffset(192)] [MarshalAs(UnmanagedType.I1)] public bool ConfigDockingNoSplit;

    [FieldOffset(193)] [MarshalAs(UnmanagedType.I1)] public bool ConfigDockingWithShift;

    [FieldOffset(194)] [MarshalAs(UnmanagedType.I1)] public bool ConfigDockingAlwaysTabBar;

    [FieldOffset(195)] [MarshalAs(UnmanagedType.I1)] public bool ConfigDockingTransparentPayload;

    [FieldOffset(196)] [MarshalAs(UnmanagedType.I1)] public bool ConfigViewportsNoAutoMerge;

    [FieldOffset(197)] [MarshalAs(UnmanagedType.I1)] public bool ConfigViewportsNoTaskBarIcon;

    [FieldOffset(198)] [MarshalAs(UnmanagedType.I1)] public bool ConfigViewportsNoDecoration;

    [FieldOffset(199)] [MarshalAs(UnmanagedType.I1)] public bool ConfigViewportsNoDefaultParent;

    [FieldOffset(200)] [MarshalAs(UnmanagedType.I1)] public bool MouseDrawCursor;

    [FieldOffset(201)] [MarshalAs(UnmanagedType.I1)] public bool ConfigMacOSXBehaviors;

    [FieldOffset(202)] [MarshalAs(UnmanagedType.I1)] public bool ConfigInputTextCursorBlink;

    [FieldOffset(203)] [MarshalAs(UnmanagedType.I1)] public bool ConfigDragClickToInputText;

    [FieldOffset(204)] [MarshalAs(UnmanagedType.I1)] public bool ConfigWindowsResizeFromEdges;

    [FieldOffset(205)] [MarshalAs(UnmanagedType.I1)] public bool ConfigWindowsMoveFromTitleBarOnly;

    [FieldOffset(208)] public float ConfigMemoryCompactTimer;

    [FieldOffset(216)] public byte* BackendPlatformName;

    [FieldOffset(224)] public byte* BackendRendererName;

    [FieldOffset(232)] public void* BackendPlatformUserData;

    [FieldOffset(240)] public void* BackendRendererUserData;

    [FieldOffset(248)] public void* BackendLanguageUserData;

    [FieldOffset(256)] public delegate* unmanaged[Cdecl]<void*, byte*> GetClipboardTextFn;

    [FieldOffset(264)] public delegate* unmanaged[Cdecl]<void*, byte*, void> SetClipboardTextFn;

    [FieldOffset(272)] public void* ClipboardUserData;

    [FieldOffset(280)] public ImVec2 MousePos;

    [FieldOffset(288)] public ConstantArray_bool_5 MouseDown;

    [FieldOffset(296)] public float MouseWheel;

    [FieldOffset(300)] public float MouseWheelH;

    [FieldOffset(304)] public uint MouseHoveredViewport;

    [FieldOffset(308)] [MarshalAs(UnmanagedType.I1)] public bool KeyCtrl;

    [FieldOffset(309)] [MarshalAs(UnmanagedType.I1)] public bool KeyShift;

    [FieldOffset(310)] [MarshalAs(UnmanagedType.I1)] public bool KeyAlt;

    [FieldOffset(311)] [MarshalAs(UnmanagedType.I1)] public bool KeySuper;

    [FieldOffset(312)] public ConstantArray_bool_512 KeysDown;

    [FieldOffset(824)] public ConstantArray_float_21 NavInputs;

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddInputCharacter@ImGuiIO@@QEAAXI@Z", ExactSpelling = true)]
    private static extern void AddInputCharacter_PInvoke(ImGuiIO* @this, uint c);

    [DebuggerStepThrough, DebuggerHidden]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void AddInputCharacter(uint c)
    {
        fixed (ImGuiIO* @this = &this)
        { AddInputCharacter_PInvoke(@this, c); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddInputCharacterUTF16@ImGuiIO@@QEAAXG@Z", ExactSpelling = true)]
    private static extern void AddInputCharacterUTF16_PInvoke(ImGuiIO* @this, ushort c);

    [DebuggerStepThrough, DebuggerHidden]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void AddInputCharacterUTF16(ushort c)
    {
        fixed (ImGuiIO* @this = &this)
        { AddInputCharacterUTF16_PInvoke(@this, c); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddInputCharactersUTF8@ImGuiIO@@QEAAXPEBD@Z", ExactSpelling = true)]
    private static extern void AddInputCharactersUTF8_PInvoke(ImGuiIO* @this, byte* str);

    [DebuggerStepThrough, DebuggerHidden]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void AddInputCharactersUTF8(byte* str)
    {
        fixed (ImGuiIO* @this = &this)
        { AddInputCharactersUTF8_PInvoke(@this, str); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ClearInputCharacters@ImGuiIO@@QEAAXXZ", ExactSpelling = true)]
    private static extern void ClearInputCharacters_PInvoke(ImGuiIO* @this);

    [DebuggerStepThrough, DebuggerHidden]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void ClearInputCharacters()
    {
        fixed (ImGuiIO* @this = &this)
        { ClearInputCharacters_PInvoke(@this); }
    }

    [FieldOffset(908)] [MarshalAs(UnmanagedType.I1)] public bool WantCaptureMouse;

    [FieldOffset(909)] [MarshalAs(UnmanagedType.I1)] public bool WantCaptureKeyboard;

    [FieldOffset(910)] [MarshalAs(UnmanagedType.I1)] public bool WantTextInput;

    [FieldOffset(911)] [MarshalAs(UnmanagedType.I1)] public bool WantSetMousePos;

    [FieldOffset(912)] [MarshalAs(UnmanagedType.I1)] public bool WantSaveIniSettings;

    [FieldOffset(913)] [MarshalAs(UnmanagedType.I1)] public bool NavActive;

    [FieldOffset(914)] [MarshalAs(UnmanagedType.I1)] public bool NavVisible;

    [FieldOffset(916)] public float Framerate;

    [FieldOffset(920)] public int MetricsRenderVertices;

    [FieldOffset(924)] public int MetricsRenderIndices;

    [FieldOffset(928)] public int MetricsRenderWindows;

    [FieldOffset(932)] public int MetricsActiveWindows;

    [FieldOffset(936)] public int MetricsActiveAllocations;

    [FieldOffset(940)] public ImVec2 MouseDelta;

    [FieldOffset(948)] public ImGuiKeyModFlags KeyMods;

    [FieldOffset(952)] public ImVec2 MousePosPrev;

    [FieldOffset(960)] public ConstantArray_ImVec2_5 MouseClickedPos;

    [FieldOffset(1000)] public ConstantArray_double_5 MouseClickedTime;

    [FieldOffset(1040)] public ConstantArray_bool_5 MouseClicked;

    [FieldOffset(1045)] public ConstantArray_bool_5 MouseDoubleClicked;

    [FieldOffset(1050)] public ConstantArray_bool_5 MouseReleased;

    [FieldOffset(1055)] public ConstantArray_bool_5 MouseDownOwned;

    [FieldOffset(1060)] public ConstantArray_bool_5 MouseDownWasDoubleClick;

    [FieldOffset(1068)] public ConstantArray_float_5 MouseDownDuration;

    [FieldOffset(1088)] public ConstantArray_float_5 MouseDownDurationPrev;

    [FieldOffset(1108)] public ConstantArray_ImVec2_5 MouseDragMaxDistanceAbs;

    [FieldOffset(1148)] public ConstantArray_float_5 MouseDragMaxDistanceSqr;

    [FieldOffset(1168)] public ConstantArray_float_512 KeysDownDuration;

    [FieldOffset(3216)] public ConstantArray_float_512 KeysDownDurationPrev;

    [FieldOffset(5264)] public ConstantArray_float_21 NavInputsDownDuration;

    [FieldOffset(5348)] public ConstantArray_float_21 NavInputsDownDurationPrev;

    [FieldOffset(5432)] public float PenPressure;

    [FieldOffset(5436)] public ushort InputQueueSurrogate;

    [FieldOffset(5440)] public ImVector<ushort> InputQueueCharacters;

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0ImGuiIO@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(ImGuiIO* @this);

    [DebuggerStepThrough, DebuggerHidden]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe void Constructor()
    {
        fixed (ImGuiIO* @this = &this)
        { Constructor_PInvoke(@this); }
    }
}
