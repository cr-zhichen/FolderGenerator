using UnityEngine;
using System.Collections;
using System.IO;
#if UNITY_EDITOR 
using UnityEditor;
#endif
public class FolderGenerator
{
#if UNITY_EDITOR
    [MenuItem("Tools/GenerateBasicFolders")]
    private static void GenerateBasicFolder()
    {
        string path = Application.dataPath + "/";//路径 

        Directory.CreateDirectory(path + "Audio");
        Directory.CreateDirectory(path + "Editor");
        Directory.CreateDirectory(path + "Environment");
        Directory.CreateDirectory(path + "Materials");
        Directory.CreateDirectory(path + "Models");
        Directory.CreateDirectory(path + "Others");
        Directory.CreateDirectory(path + "Prefabs");
        Directory.CreateDirectory(path + "Resources");
        Directory.CreateDirectory(path + "Scenes");
        Directory.CreateDirectory(path + "Scripts");
        Directory.CreateDirectory(path + "Shaders");
        Directory.CreateDirectory(path + "StreamingAssets");
        Directory.CreateDirectory(path + "Textures");
        Directory.CreateDirectory(path + "Tools");
        Directory.CreateDirectory(path + "UI");

        AssetDatabase.Refresh();

        Debug.Log("Folders Created");
    }
#endif
}