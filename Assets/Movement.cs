using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject PhenotypicFlexibility;
    public GameObject HypobaricTolerance;
    public GameObject ColdHeatShockResistance;
    public GameObject IonizingRadiationResistance;
    public GameObject AnaerobicRespiration;
    public float movementSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        if(PhenotypicFlexibility.activeInHierarchy == true &&
            HypobaricTolerance.activeInHierarchy == true &&
            ColdHeatShockResistance.activeInHierarchy == true &&
            IonizingRadiationResistance.activeInHierarchy == true &&
            AnaerobicRespiration.activeInHierarchy == true)
        {
            Debug.Log("You Won");
        }
        else
        {
            Debug.Log("You Lost");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * movementSpeed);
    }
}
