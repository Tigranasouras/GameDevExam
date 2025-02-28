using UnityEngine;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class CandiesCalculator : MonoBehaviour
{
public TextMeshProUGUI startText;
public int count = 1;
public bool added = false;



void Start(){
    GameObject candy = GameObject.FindWithTag("Candy");
    //int plus = candy.GetComponentInChildren<CanyPlus>().plus;


    if (candy == null){
        Debug.Log("No Candies found");
    }else{
        count = count + 1;
    }
    

    startText.text = "Candies: " + count;
}

void Update(){
    GameObject candy = GameObject.FindWithTag("Candy");
    if (candy == null){
        Debug.Log("No Candies found");
    }else{
        count = count + 1;
    }
  //  if(added != false ){
   //     count = count + plus;
   // }

    startText.text = "Candies: " + count;
}


}
