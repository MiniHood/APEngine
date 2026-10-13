using System;
using System.Collections.Generic;
using System.Text;

namespace AppEngine.Core
{
    internal class Root
    {
        // Nodes should register themselves with the root hierarchy upon creation.
        // A node by itself should... Not? Ever be made.
        // A node should always be made according to the nodes outlined in the 'Nodes' namespace
        // For example since Sprite is our only current node, a sprite should be the
        // only way to actually create a node. I think?
        // The Root class will act as the NodeRegistery

        private List<KeyValuePair<Guid, object>> _nodeRegistery = [];

        #region Internal
        // TODO: This is wrong, I need to figure out why though.
        internal Node GetNode(Guid nodeID)
        {
            // This is for sure going to break something, need to come back to this later
            // Specifically the fact that I'm casting to Node, instead of the Nodes inherited object.
            return (Node)_nodeRegistery.Find(x => x.Key == nodeID).Value;
        }

        internal Guid RegisterNode(object _node)
        {
            Type? _inherit = _node.GetType().BaseType;
            if (_inherit == null || _inherit != typeof(Node))
                throw new Exception("Cannot register non or non inherited node.");
            Guid _newGuid = Guid.NewGuid();
            _nodeRegistery.Add(new KeyValuePair<Guid, object>(_newGuid, _node));
            return _newGuid;
        }
        #endregion

        internal Root()
        {}
    }
}
