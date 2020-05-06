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
    public Coroutine corountine;
    private int randomNum;

    private GameObject selectedPickUp;

    // Start is called before the first frame update
    void Start()
    {
        corountine = StartCoroutine("changeColor");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //Corutine para cambiar el color que se ejecuta cada timeBetweenChanges.
    private IEnumerator changeColor()
    {
        while (canChange)
        {
            changePickUpColor(); // 3
            yield return new WaitForSeconds(timeBetweenChanges); // 4
        }
    }

    //Funcion que cambia el color de un pickup.
    private void changePickUpColor()
    {
        if (selectedPickUp)
        {
            selectedPickUp.GetComponent<MeshRenderer>().material = pickUpMaterial;
        }
        int new_random = Random.Range(0, pickUpsList.Count);
        while (new_random == randomNum) //Para que el siguiente pick up seleccionado sea distinto al anterior.
        {
            new_random = Random.Range(0, pickUpsList.Count);
        }
        randomNum = new_random;
        selectedPickUp = pickUpsList[new_random];
        selectedPickUp.GetComponent<MeshRenderer>().material = activePickUpMaterial; //Activamos el material especifico para el pick up activo.
        selectedPickUp.GetComponent<PickUpScript>().isActivated = true; //Cambiamos la variable isActived del script de ese PickUp a true.
    }
}

