using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ItemTest))]
public class ItemTestEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ItemTest itemTest = (ItemTest)target;
        if (GUILayout.Button("AddItem"))
        {
            itemTest.AddItem();
        }
    }
}
