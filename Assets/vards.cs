using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class vards : MonoBehaviour {
    
    public string teksts;
    public GameObject name_text;
    public GameObject exitingname;

    public void uzglabaTekstu(){
        teksts = name_text.GetComponent<Text>().text;
        exitingname.GetComponent<Text>().text = "Hi there, they call me "+ teksts.ToUpper() +" and I am Rogue!";
    }
}
