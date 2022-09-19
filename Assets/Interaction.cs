using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward, Color.red, 10f);

        //var myLayerMask = LayerMask.GetMask ("Joueur", "Default");

        if (Physics.Raycast (transform.position, transform.forward, out RaycastHit hitInfo, 10f))
        {
            Debug.Log ($"j'ai touché quelqu'un qui ne sait pas qu'il va creuver, il s'appelle {hitInfo.collider.name}");
        }
    }
}
