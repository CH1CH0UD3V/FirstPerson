using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] List<Target> target;
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward, Color.red);

        //var myLayerMask = LayerMask.GetMask ("Joueur", "Default");

        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, 2f))
        {
            hitInfo = Target;
        }
    }
}
