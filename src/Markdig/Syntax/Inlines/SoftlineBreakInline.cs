// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.

using System.Diagnostics;

namespace Markdig.Syntax.Inlines
{
    /// <summary>
    /// A soft line break (Section 6.10 CommonMark specs)
    /// </summary>
    /// <seealso cref="Markdig.Syntax.Inlines.LineBreakInline" />
    [DebuggerDisplay("\\n")]
    public class SoftlineBreakInline : LineBreakInline
    {
    }
}