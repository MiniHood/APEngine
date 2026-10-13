using System.Numerics;

namespace AppEngine.Core.Graphics
{
    public static class Graphics
    {
        /*
         * This class needs new abilities.
         * 1. Count frames printed per second
         * 2. Restrict frames printed per second
         * 3. Inspect each frame when in a debug mode? (Optional, might not be needed at all)
         * */

        private static int _cWidth = Console.WindowWidth;
        private static int _cHeight = Console.WindowHeight;
        //private int _frame;
        //private int _fps;
        private static List<KeyValuePair<Vector2, string>> _dQ = [];
        private static void _drawQueue()
        {
            // not sure if this will cause issues later?
            // EDIT: https://stackoverflow.com/questions/6029804/what-does-a-lock-statement-do-under-the-hood
            // never mind, it makes the thread wait until it's no longer locked before accessing.
            lock (_dQ)
            {
                foreach (KeyValuePair<Vector2, string> valuePair in _dQ)
                {
                    Vector2 v = valuePair.Key;
                    string c = valuePair.Value;
                    Console.SetCursorPosition((int)v.X, (int)v.Y);
                    Console.Write(c);
                }

                _dQ.Clear();
            }
        }
        public static void _startFrame()
        {
            Console.Clear();
            _drawQueue();
        }

        public static void Draw(string content, Vector2 pos)
        {
            if (pos.X < 0 || pos.Y < 0)
                throw new Exception("Out of bounds.");
            if (pos.X > _cWidth || pos.Y > _cHeight)
                throw new Exception("Out of bounds.");
            if (content == null)
                throw new Exception("Content cannot be empty for draw");
            lock(_dQ)
                _dQ.Add(new KeyValuePair<Vector2, string>(pos, content));
        }
    }
}