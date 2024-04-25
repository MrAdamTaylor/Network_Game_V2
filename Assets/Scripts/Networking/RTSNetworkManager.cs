using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class RTSNetworkManager : NetworkBehaviour
{
    [SerializeField] private GameObject _unitSpawnerPrefab = null;

    
    void OnCreateCharacter(NetworkConnectionToClient conn)
    {
        // playerPrefab is the one assigned in the inspector in Network
        // Manager but you can use different prefabs per race for example
        
        //GameObject gameobject = Instantiate(playerPrefab);

        // Apply data from the message however appropriate for your game
        // Typically Player would be a component you write with syncvars or properties
        
        //Player player = gameobject.GetComponent();
        //player.hairColor = message.hairColor;
        //player.eyeColor = message.eyeColor;
        //player.name = message.name;
        //player.race = message.race;

        // call this to use this gameobject as the primary controller
        //NetworkServer.AddPlayerForConnection(conn, gameobject);
    }
}
