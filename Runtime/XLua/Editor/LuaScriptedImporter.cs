using System.IO;
using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEngine;

/// <summary>
/// 작성자 김예찬
/// lua를 확장자로 가지고 있는 텍스트 스크립트를 에디터 Project창에 Type화 하여 호환가능하게 기능 지원
/// </summary>
[ScriptedImporter(0, "lua")]
public class LuaScriptedImporter : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        // 스크립트 오브젝트기반 LuaScriptAsset 타입화
        // 인스펙터 창에서 LuaScriptAsset 프로퍼티에 Drag&Drop이 가능함
        var instance = ScriptableObject.CreateInstance<LuaScriptAsset>();
        instance.assetPath = ctx.assetPath; // 스크립트의 경로
        instance.src = File.ReadAllText(ctx.assetPath); // 스크립트의 내용

        // lua를 GameObject 타입화
        // 인스펙터 창에서 GameObject 프로퍼티에 Drag&Drop이 가능함
        //GameObject instance = ObjectFactory.CreateGameObject(Path.GetFileNameWithoutExtension(ctx.assetPath));

        // lua를 TextAsset(.txt) 타입화
        // 인스펙터 창에서 TextAsset 프로퍼티에 Drag&Drop이 가능함
        //var instance = new TextAsset(File.ReadAllText(ctx.assetPath));

        ctx.AddObjectToAsset("MainObject", instance as Object);
        ctx.SetMainObject(instance as Object);
    }
}
