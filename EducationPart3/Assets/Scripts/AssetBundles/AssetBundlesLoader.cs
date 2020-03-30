using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetBundlesLoader : MonoBehaviour
{
    private AssetBundle _loadedAssetBundle;

    private void Start()
    {
        LoadAssetBundle();
    }

    private void LoadAssetBundle()
    {
        _loadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/katana");
        if(_loadedAssetBundle != null)
        {
            Debug.Log("AssetBundle succesfully loaded");
        }
    }
}
