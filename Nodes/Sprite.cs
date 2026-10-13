using AppEngine.Core;

namespace AppEngine.Nodes
{
    internal class Sprite : Node
    {
        public Sprite(int id, string pixel = "!", bool isVisible = true) : base(id, pixel, isVisible)
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
