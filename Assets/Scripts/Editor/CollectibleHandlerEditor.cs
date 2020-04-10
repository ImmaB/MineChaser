using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(CollectibleHandler))]
public class CollectibleHandlerEditor : Editor
{
    CollectibleHandler handler;

    private void OnEnable()
    {
        handler = (CollectibleHandler)target;
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        bool spawnClick = GUILayout.Toggle(handler.spawnClick, "Spawn Click");
        if(spawnClick != handler.spawnClick)
        {
            Undo.RecordObject(handler, "Toggled");
            handler.spawnClick = spawnClick;
        }
        if(GUILayout.Button("Correct Spawned"))
        {
            handler.CorrectSpawned();
        }
    }

    private void OnSceneGUI()
    {
        if(handler.spawnClick)
            Input();
    }

    private void Input()
    {
        Event guiEvent = Event.current;
        Vector2 mousePos = HandleUtility.GUIPointToWorldRay(guiEvent.mousePosition).origin;

        if (guiEvent.type == EventType.MouseDown && guiEvent.button == 0)
        {
            GameObject item = Instantiate(handler.collectible, handler.transform);
            item.transform.position = mousePos;
            Undo.RegisterCreatedObjectUndo(item, "Created Collectible");
        }

        HandleUtility.AddDefaultControl(0);
    }
}
