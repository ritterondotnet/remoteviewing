﻿#region License
/*
RemoteViewing VNC Client Library for .NET
Copyright (c) 2013 James F. Bellinger <http://www.zer7.com>
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met: 

1. Redistributions of source code must retain the above copyright notice, this
   list of conditions and the following disclaimer. 
2. Redistributions in binary form must reproduce the above copyright notice,
   this list of conditions and the following disclaimer in the documentation
   and/or other materials provided with the distribution. 

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
#endregion

using System;

namespace RemoteViewing.Vnc
{
    /// <summary>
    /// Provides data for the <see cref="VncClient.PasswordRequired"/> event.
    /// </summary>
    public class PasswordRequiredEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordRequiredEventArgs"/> class.
        /// </summary>
        /// <param name="options">The connection options.</param>
        public PasswordRequiredEventArgs(VncClientConnectOptions options)
        {
            Throw.If.Null(options, "options");

            Options = options;
        }

        /// <summary>
        /// The connection options.
        /// 
        /// To supply a password, set the <see cref="VncClientConnectOptions.Password"/> property.
        /// </summary>
        public VncClientConnectOptions Options
        {
            get;
            private set;
        }
    }
}
