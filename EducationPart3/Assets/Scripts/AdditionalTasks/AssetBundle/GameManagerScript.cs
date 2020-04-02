using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    private AssetBundle _loadedAssetBundleObject;
    private GameObject _loadedGO;
    private bool _assetBundleIsLoaded = false;
    private List<GameObject> _spawnedObjects = new List<GameObject>();

    public void OnSpawnButtonClick()
    {
        if (!_assetBundleIsLoaded) LoadAssetBundleObject();
        SpawnObject();
    }
    
    public void OnDestroyButtonClick()
    {
        try
        {
            Destroy(_spawnedObjects[0]);
            _spawnedObjects.RemoveAt(0);
        }
        catch
        {
            Debug.Log("No objects to destroy");
        }
    }

    private void LoadAssetBundleObject()
    {        
        _loadedAssetBundleObject = AssetBundle.LoadFromFile("Assets/AssetBundles/cube");
        if (_loadedAssetBundleObject != null)
        {
            _loadedGO = _loadedAssetBundleObject.LoadAsset<GameObject>(_loadedAssetBundleObject.GetAllAssetNames()[0]);
            _assetBundleIsLoaded = true;
        }
    }

    private void SpawnObject()
    {
        GameObject currentObject = Instantiate(_loadedGO) as GameObject;
        SelectPositionForObject(currentObject);
        _spawnedObjects.Add(currentObject);
    }

    private void SelectPositionForObject(GameObject currentObject)
    {
        currentObject.transform.position = new Vector3(Random.Range(-20f, 20f), 1f, Random.Range(-20f, 20f));
    }
}
