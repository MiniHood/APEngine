namespace AppEngine.Core
{
    public abstract class Node
    {
        #region Private Protected
        private protected int _id;
        #endregion
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
        #region Public
        public int GetID()
        { return _id; }
        #endregion

        public Node(int id, string pixel = "!", bool isVisible = true)
        {
            _id = id;
            _pixel = pixel;
            _isVisible = isVisible;
        }
    }
}