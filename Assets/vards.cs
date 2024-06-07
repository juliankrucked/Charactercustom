using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class vards : MonoBehaviour {
    
    public string teksts;
    public int birth;
    public TMP_InputField birthyear;
    public GameObject name_text;
    public GameObject exitingname;

    public void savedata() {
        if (name_text != null && birthyear != null && exitingname != null) {
            teksts = name_text.GetComponent<Text>().text;
            string birthyearString = birthyear.text;

            birthyearString = birthyearString.Trim();

            if (int.TryParse(birthyearString, out birth)) {
                int currentYear = DateTime.Now.Year;
                int age = currentYear - birth;

                exitingname.GetComponent<Text>().text = "Hi there, they call me " + teksts.ToUpper() + " and I am Rouge! I was born in " + birth + ". I am " + age + " years old.";
            } else {
                Debug.LogError("The birthyear text is not a valid integer.");
                exitingname.GetComponent<Text>().text = "Invalid birth year!";
            }
        } else {
            Debug.LogError("Please assign the name_text, birthyear, and exitingname GameObjects in the Inspector.");
        }
    }
}
