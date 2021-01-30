/*
 * Authored by Funika Games
Created by Arif Duman
Copyright 2020 
www.funikagames.com
*/


using UnityEngine;

public class FolderCreatorStarterKit : MonoBehaviour
{
	[UnityEditor.MenuItem("GameObject/Create Folder")]
	static void CreateFolder()
	{
		string guid1 = UnityEditor.AssetDatabase.CreateFolder("Assets", "3rd-Party");
		string guid2 = UnityEditor.AssetDatabase.CreateFolder("Assets", "Animations");
		string guid3 = UnityEditor.AssetDatabase.CreateFolder("Assets", "Audio");
		string guid4 = UnityEditor.AssetDatabase.CreateFolder("Assets", "Materials");
		string guid5 = UnityEditor.AssetDatabase.CreateFolder("Assets", "Models");
		string guid6 = UnityEditor.AssetDatabase.CreateFolder("Assets", "Plugins");
		string guid7 = UnityEditor.AssetDatabase.CreateFolder("Assets", "Prefabs");
		string guid8 = UnityEditor.AssetDatabase.CreateFolder("Assets", "Resources");
		string guid9 = UnityEditor.AssetDatabase.CreateFolder("Assets", "Textures");
		string guid10 = UnityEditor.AssetDatabase.CreateFolder("Assets", "Sandbox");
		string guid11 = UnityEditor.AssetDatabase.CreateFolder("Assets", "Scenes");
		string guid12 = UnityEditor.AssetDatabase.CreateFolder("Assets", "Scripts");
		string guid13 = UnityEditor.AssetDatabase.CreateFolder("Assets", "Shaders");
		string guid15 = UnityEditor.AssetDatabase.CreateFolder("Assets/Audio", "Music");
		string guid16 = UnityEditor.AssetDatabase.CreateFolder("Assets/Audio", "SFX");
		string guid17 = UnityEditor.AssetDatabase.CreateFolder("Assets/Scenes", "Levels");
		string guid18 = UnityEditor.AssetDatabase.CreateFolder("Assets/Scenes", "Other");
		string guid19 = UnityEditor.AssetDatabase.CreateFolder("Assets/Scripts", "Editor");

		for (int i = 0; i < 20; i++)
        {
			string newFolderPath = UnityEditor.AssetDatabase.GUIDToAssetPath("guid"+i);
		}
	}
	
}
