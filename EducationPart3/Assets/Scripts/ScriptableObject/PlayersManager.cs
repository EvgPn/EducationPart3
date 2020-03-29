using UnityEngine;

public class PlayersManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _players = null;    
    [SerializeField]
    private ScriptableObjectClass _playersData = null;

    private void Start()
    {        
        SetPlayersSetting();
    }

    private void SetPlayersSetting()
    {
        for (int i = 0; i < _players.Length; i++)
        {
            _players[i].name = _playersData.Players[i].Name;
            _players[i].GetComponent<MeshRenderer>().material.color = _playersData.Players[i].color;
        }
    }
}
