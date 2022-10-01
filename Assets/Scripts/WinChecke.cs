using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinChecke : MonoBehaviour
{
    public GameObject PhenotypicFlexibility1;
    public GameObject Chemosynthesis1;
    public GameObject HypobaricTolerance1;
    public GameObject Cryobiosis1;
    public GameObject ColdHeatShockResistance1;
    public GameObject Psychrophily1;
    public GameObject IonizingRadiationResistance1;
    public GameObject CO2Tolerance1;
    public GameObject HypoxiaTolerance1;
    public GameObject AnaerobicRespiration1;
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void PhenotypicFlexibility()
    {
        PhenotypicFlexibility1.SetActive(true);
    }
    public void Chemosynthesis()
    {
        Chemosynthesis1.SetActive(true);
    }
    public void HypobaricTolerance()
    {
        HypobaricTolerance1.SetActive(true);
    }
    public void Cryobiosis()
    {
        Cryobiosis1.SetActive(true);
    }
    public void ColdHeatShockResistance()
    {
        ColdHeatShockResistance1.SetActive(true);
    }
    public void Psychrophily()
    {
        Psychrophily1.SetActive(true);
    }
    public void IonizingRadiationResistance()
    {
        IonizingRadiationResistance1.SetActive(true);
    }
    public void CO2Tolerance()
    {
        CO2Tolerance1.SetActive(true);
    }
    public void HypoxiaTolerance()
    {
        HypoxiaTolerance1.SetActive(true);
    }
    public void AnaerobicRespiration()
    {
        AnaerobicRespiration1.SetActive(true);
    }
}
