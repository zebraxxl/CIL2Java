// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

/*============================================================
**
** 
** 
**
**
** Purpose: Centralized error methods for the IO package.  
** Mostly useful for translating Win32 HRESULTs into meaningful
** error strings & exceptions.
**
**
===========================================================*/

using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Globalization;
using System.Security;
using System.Security.Permissions;
using System.Diagnostics.Contracts;

namespace System.IO {
    internal static class __Error
    {
        internal static void ReadNotSupported()
        {
            throw new NotSupportedException(Environment.GetResourceString("NotSupported_UnreadableStream"));
        }
    }
}
