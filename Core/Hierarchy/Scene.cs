using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AppEngine.Core
{
    public static class scene
    {
        // Register root node
        // Provide GetNode functions inside root node. This is just for later.
        // Not sure why scene node is present in other game engines
        // But probably a good reason for it.

        #region Internal
        internal static Root root = new Root();
        #endregion
    }
}
