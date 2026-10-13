namespace AppEngine.Core
{
    public abstract class Node
    {
        #region Private
        private bool _isVisible;
        private string _pixel;
        #endregion
        #region Internal Abstract
        internal abstract bool IsColliding();
        internal abstract void Destroy();
        #endregion
        #region Internal
        internal void SetVisibility(bool toggle)
        { _isVisible = toggle; }
        internal void SetPixel(string pixel)
        { _pixel = pixel; }
        #endregion

        public Node(string pixel = "!", bool isVisible = true)
        {
            _pixel = pixel;
            _isVisible = isVisible;
        }

        ~Node()
        {}
    }
}