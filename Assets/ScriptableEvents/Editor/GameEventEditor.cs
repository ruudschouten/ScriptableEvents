using ScriptableEvents;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GenericEvent), true)]
public class GameEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        var e = target as GenericEvent;

        if (GUILayout.Button("Raise"))
        {
            e.Raise();
        }
    }
}
