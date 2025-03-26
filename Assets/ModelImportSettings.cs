using UnityEditor;
using UnityEngine;

class ModelImportSettings : AssetPostprocessor
{
    void OnPreprocessModel()
    {
        ModelImporter modelImporter = assetImporter as ModelImporter;

        if (modelImporter != null)
        {
            modelImporter.isReadable = true; // Enable Read/Write
            Debug.Log($"Read/Write Enabled for: {assetPath}");
        }
    }
}
