using UnityEngine;
using UnityEngine.AddressableAssets;

public class AssetLoader : MonoBehaviour
{
	private void Start()
	{
		Addressables.InstantiateAsync("Cube");
	}
}