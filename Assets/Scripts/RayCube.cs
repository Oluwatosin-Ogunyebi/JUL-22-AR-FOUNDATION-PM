using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCube : MonoBehaviour
{
    RaycastHit hit;
    // Update is called once per frame
    void Update()
    {
        
        Ray cubeRayValue = new Ray(transform.position, Vector3.forward);
        if (Physics.Raycast(cubeRayValue, out hit, 5f))
        {
            if (hit.collider.tag == "Cube")
            {
                Debug.Log(hit.collider.tag);
                this.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
            }
        } 
        Debug.DrawRay(transform.position, Vector3.forward * 10f, Color.green);
    }
}
