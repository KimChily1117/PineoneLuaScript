using UnityEditor;

[InitializeOnLoad]
[CustomEditor(typeof(LuaScriptAsset))]
public class LuaScriptAssetEditor : Editor
{
    LuaScriptAsset thisAsset;
    public override void OnInspectorGUI()
    {
        thisAsset = target as LuaScriptAsset;
        EditorGUILayout.TextArea(thisAsset.src);
    }
}