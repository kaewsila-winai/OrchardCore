﻿using System;
using OrchardVNext.Security;
using System.Security;
using System.Runtime.InteropServices;

namespace OrchardVNext.Exceptions {
    public static class ExceptionExtensions {
        public static bool IsFatal(this Exception ex) {
            return ex is OrchardSecurityException ||
                ex is OutOfMemoryException ||
                ex is SecurityException ||
                ex is SEHException;
        }
    }
}
