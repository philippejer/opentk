﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CustomOpenTK.Graphics.ES11
{
    /// <summary>
    /// Provides access to OpenGL ES 1.1 methods.
    /// </summary>

    public sealed partial class GL : GraphicsBindingsBase
    {
#if IPHONE
        const string Library = "/System/Library/Frameworks/OpenGLES.framework/OpenGLES";
#else
        const string Library = "GLESv1_CM";
#endif
        static readonly object sync_root = new object();

        static IntPtr[] EntryPoints;
        static byte[] EntryPointNames;
        static int[] EntryPointNameOffsets;

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GL()
        {
            _EntryPointsInstance = EntryPoints;
            _EntryPointNamesInstance = EntryPointNames;
            _EntryPointNameOffsetsInstance = EntryPointNameOffsets;
        }

        #endregion

        #region --- Protected Members ---

        /// <summary>
        /// Returns a synchronization token unique for the GL class.
        /// </summary>
        protected override object SyncRoot
        {
            get { return sync_root; }
        }

        #endregion

    }
}
