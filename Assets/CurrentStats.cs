using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentStats : MonoBehaviour
{
    public Text currentStats;
    public GameScore gameScore;
    
    public static string ctext;


    // Start is called before the first frame update
    void Start()

    {
        ctext = gameScore.currentText;
   
        currentStats.text = ctext;
      
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

   
