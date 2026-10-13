using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AppEngine.Core
{
    public class scene
    {
        // Register root node
        // Provide GetNode functions inside root node. This is just for later.
        // Not sure why scene node is present in other game engines
        // But probably a good reason for it.

        internal Root Root { get; }

        public scene()
        {
            Root = new Root();
        }
    }
}
