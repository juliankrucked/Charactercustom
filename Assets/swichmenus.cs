using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class swichmenus : MonoBehaviour
{
    public void ToStart(){
        SceneManager.LoadScene("MainMenu",LoadSceneMode.Single);
    }
}
