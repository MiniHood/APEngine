using AppEngine.Core;

namespace AppEngine.Nodes
{
    internal class Sprite : Node
    {
        // TODO
        public Sprite(string pixel = "!", bool isVisible = true) : base(pixel, isVisible)
        {
        }

        internal override void Destroy()
        {
            throw new NotImplementedException();
        }

        internal override bool IsColliding()
        {
            throw new NotImplementedException();
        }
    }
}
