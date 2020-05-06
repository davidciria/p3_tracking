using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wristPickUp : MonoBehaviour
{

    public Material activePickUpMaterial;
    public Material pickUpMaterial;
    public GameObject pickUps;

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
            if (other.gameObject.GetComponent<PickUpScript>().isActivated)
            {
                other.gameObject.GetComponent<MeshRenderer>().material = pickUpMaterial;
                other.gameObject.GetComponent<PickUpScript>().isActivated = false;
                pickUps.GetComponent<PickUpColorChange>().StopCoroutine("changeColor");
                pickUps.GetComponent<PickUpColorChange>().StartCoroutine("changeColor");
            }
        }
    }
}
