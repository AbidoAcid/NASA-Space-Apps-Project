using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public GameObject PhenotypicFlexibility;
    public GameObject HypobaricTolerance;
    public GameObject ColdHeatShockResistance;
    public GameObject IonizingRadiationResistance;
    public GameObject AnaerobicRespiration;
    public GameObject YouWon;
    public GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel()
    {
        if (PhenotypicFlexibility.activeInHierarchy == true &&
            HypobaricTolerance.activeInHierarchy == true &&
            ColdHeatShockResistance.activeInHierarchy == true &&
            IonizingRadiationResistance.activeInHierarchy == true &&
            AnaerobicRespiration.activeInHierarchy == true)
        {
            YouWon.SetActive(true);
        }
        else
        {
            GameOver.SetActive(true);
        }
    }
}
