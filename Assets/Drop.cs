using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drop : MonoBehaviour
{
    Dropdown dropdown;
    Dropdown dropdown1;
    public string sizeValue = "test1";

    // Start is called before the first frame update
    void Start()
    {
        dropdown = GetComponent<Dropdown>();
        dropdown.onValueChanged.AddListener(delegate
        {
            DropdownValueChanged(dropdown);
        });
    }

    

    public void DropdownValueChanged(Dropdown change)
    {

        sizeValue = "Small" + change.value;
        Debug.Log(sizeValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
