﻿using System;

namespace Ares.Platform.Windows.Interop
{
    [Flags]
    public enum PeekMessageFlags : uint
    {
        // Removal mode
        PM_NOREMOVE = 0x0000,
        PM_REMOVE = 0x0001,
        PM_NOYIELD = 0x0002,
        // Message type selection
        PM_QS_INPUT = QueueStatusFlags.QS_INPUT << 16,
        PM_QS_POSTMESSAGE = (QueueStatusFlags.QS_POSTMESSAGE | QueueStatusFlags.QS_HOTKEY | QueueStatusFlags.QS_TIMER) << 16,
        PM_QS_PAINT = QueueStatusFlags.QS_PAINT << 16,
        PM_QS_SENDMESSAGE = QueueStatusFlags.QS_SENDMESSAGE << 16,
    }
}
