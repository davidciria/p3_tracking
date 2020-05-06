using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wristPickUp : MonoBehaviour
{

    public Material activePickUpMaterial;
    public Material pickUpMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            if (other.gameObject.GetComponent<MeshRenderer>().sharedMaterial.Equals(activePickUpMaterial))
            {
                other.gameObject.GetComponent<MeshRenderer>().material = pickUpMaterial;
            }
        }
    }
}
