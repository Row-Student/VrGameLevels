using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEATHPLANE : MonoBehaviour
{
    public int DeathPlaneHeight = -30;
    GameStateVariables gameStateVariables;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = this.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.y <= DeathPlaneHeight)
        {
            
        }
    }
}
