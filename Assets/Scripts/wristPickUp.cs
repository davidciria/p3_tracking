using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wristPickUp : MonoBehaviour
{

    public Material activePickUpMaterial;
    public Material pickUpMaterial;
    public GameObject pickUps;
    public GameObject UI;

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
                UI.GetComponent<UIScript>().elevateCounter();
                other.gameObject.GetComponent<MeshRenderer>().material = pickUpMaterial;
                other.gameObject.GetComponent<PickUpScript>().isActivated = false;
                pickUps.GetComponent<PickUpColorChange>().StopCoroutine("changeColor");
                pickUps.GetComponent<PickUpColorChange>().StartCoroutine("changeColor");
            }
        }
    }
}
