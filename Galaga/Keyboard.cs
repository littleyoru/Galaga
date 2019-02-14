using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaga
{
    public static class Keyboard
    {
        private static readonly HashSet<Keys> keys = new HashSet<Keys>();

        public static void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (keys.Contains(e.KeyCode) == false)
            {
                keys.Add(e.KeyCode);
            }
        }
        public static void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (keys.Contains(e.KeyCode))
            {
                keys.Remove(e.KeyCode);
            }
        }
        public static bool IsKeyDown(Keys key)
        {
            return keys.Contains(key);
        }
    }
}
