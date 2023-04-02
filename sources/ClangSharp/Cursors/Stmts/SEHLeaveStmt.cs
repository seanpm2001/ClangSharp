// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Diagnostics;
using ClangSharp.Interop;
using static ClangSharp.Interop.CXCursorKind;
using static ClangSharp.Interop.CX_StmtClass;

namespace ClangSharp;

public sealed class SEHLeaveStmt : Stmt
{
    internal SEHLeaveStmt(CXCursor handle) : base(handle, CXCursor_SEHLeaveStmt, CX_StmtClass_SEHLeaveStmt)
    {
        Debug.Assert(NumChildren is 0);
    }
}
