using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpColorChange : MonoBehaviour
{

    private bool canChange = true;
    public float timeBetweenChanges;
    public List<GameObject> pickUpsList = new List<GameObject>();
    public Material activePickUpMaterial;
    public Material pickUpMaterial;

    private GameObject selectedPickUp;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(changeColor());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator changeColor()
    {
        while (canChange)
        {
            changePickUpColor(); // 3
            yield return new WaitForSeconds(timeBetweenChanges); // 4
        }
    }

    private void changePickUpColor()
    {
        selectedPickUp = pickUpsList[Random.Range(0, pickUpsList.Count)];
        selectedPickUp.GetComponent<MeshRenderer>().material = activePickUpMaterial;
    }
}

