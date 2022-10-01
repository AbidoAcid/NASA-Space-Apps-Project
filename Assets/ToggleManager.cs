using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleManager : MonoBehaviour
{
    public GameObject UploadButton;
    public List<Toggle>toggles = new List<Toggle>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Check()
    {
        int check = 0;
        foreach (Toggle toggle in toggles)
        {
            if (toggle.isOn)
            {
                check++;
            }
        }
        if (check == 5)
        {
            UploadButton.SetActive(true);
        }
    }
}
