using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagManager : MonoBehaviour
{
    public UAVPathfinding pathfinding;
    public TextMesh txt;


    void Start()
    {
        txt.text = gameObject.name + "  X : " + transform.position.x + "  Y : " + transform.position.y + "  Z : " + transform.position.z;
        pathfinding = GameObject.Find("attackBot").GetComponent<UAVPathfinding>();
        if (pathfinding != null) 
        {
            pathfinding.Target = gameObject;
        }
    }

   
}
