using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;
using UnityEngine.EventSystems;

public class UnitSpawner : NetworkBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _unitPrefab = null;
    [SerializeField] private Transform _unitSpawnPoint = null;

    [Command]
    private void CmdSpawnUnit()
    {
        GameObject unitInstance = Instantiate(
            _unitPrefab, 
            _unitSpawnPoint.position,
            _unitSpawnPoint.rotation);
        
        NetworkServer.Spawn(unitInstance, connectionToClient);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button != PointerEventData.InputButton.Left)
            return;

        if (!isOwned)
            return;
        
        CmdSpawnUnit();
    }
}
