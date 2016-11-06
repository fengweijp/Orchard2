﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace Orchard.Environment.Extensions.Loaders
{
    public class ExtensionEntry
    {
        public IExtensionInfo ExtensionInfo { get; set; }
        public Assembly Assembly { get; set; }
        public IEnumerable<Type> ExportedTypes { get; set; }
    }

    public class FailedExtensionEntry : ExtensionEntry
    {
        public Exception Exception { get; set; }
    }
}