using UnityEngine;

namespace MonoBase
{
    public class Loader
    {
        public static void Load()
        {
            // Create new gameobject
            gameObject = new GameObject();

            // Add menu component
            gameObject.AddComponent<Menu>();

            // Add features component
            gameObject.AddComponent<Features>();

            // Make sure our game object dont get destroyed
            GameObject.DontDestroyOnLoad(gameObject);
        }

        public static void Unload()
        {
            // Destroy our game object when this function is called.
            GameObject.Destroy(gameObject);
        }
        
        // defines
        public static GameObject gameObject;
    }
}
