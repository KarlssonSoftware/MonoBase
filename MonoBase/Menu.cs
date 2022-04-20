using UnityEngine;

namespace MonoBase
{
    public class Menu : MonoBehaviour
    {
        // Defines
        private Rect m_rect;
        private bool m_toggle;

        // Start is called on the frame when a script is enabled just before any of the Update
        // https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html

        public void Start()
        {
            // Setup rect position and size
            m_rect = new Rect(10, 10, 400, 400);
        }

        // Very ghetto way to toggle ui
        private void Toggle()
        {
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                m_toggle = !m_toggle;
            }
        }

        // Update is called every frame, if the MonoBehaviour is enabled.
        // https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html

        public void Update()
        {
            Toggle();
        }

        // OnGUI is called for rendering and handling GUI events.
        // https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnGUI.html

        public void OnGUI()
        {
            if (!m_toggle)
                return;

            m_rect = GUILayout.Window(0, m_rect, new GUI.WindowFunction(CreateMainWindow), "MonoBase", new GUILayoutOption[0]);
        }

        // Create main window
        private void CreateMainWindow(int id)
        {
            // Add gui elements here
            Options.bEnable = GUILayout.Toggle(Options.bEnable, "Bool", new GUILayoutOption[0]);

            GUILayout.Label($"Slider {Options.flSlider}", new GUILayoutOption[0]);
            Options.flSlider = GUILayout.HorizontalSlider(Options.flSlider, 0, 100, new GUILayoutOption[0]);

            // Drag window
            GUI.DragWindow();
        }
    }
}
