﻿//---------------------------------------------------------------------------- 
//
//  Copyright (C) Jason Graham.  All rights reserved.
// 
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// 
// History
//  08/21/13    Created 
//
//---------------------------------------------------------------------------

namespace System.Windows.Forms
{
    /// <summary>
    /// Defines event data for clipboard data changed events.
    /// </summary>
    /// <typeparam name="T">The type of clipboard value that changed.</typeparam>
    public sealed class ClipboardChangedEventArgs<T> : EventArgs
    {
        /// <summary>
        /// Defines the value that was added to the clipboard.
        /// </summary>
        public readonly T Value;

        /// <summary>
        /// Initializes the event data with the value that changed.
        /// </summary>
        /// <param name="value">The value that was added to the clipboard.</param>
        public ClipboardChangedEventArgs(T value)
        {
            Value = value;
        }
    }
}
