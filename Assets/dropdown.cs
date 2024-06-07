using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownController : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject[] prefabs; 
    private GameObject currentPrefabInstance; 
    
    void Start()
    {
        dropdown.ClearOptions();

        List<string> options = new List<string>();

        foreach (GameObject prefab in prefabs)
        {
            options.Add(prefab.name);
        }

        dropdown.AddOptions(options);

        dropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(dropdown);
        });
    }

    void DropdownValueChanged(Dropdown dropdown)
    {
        int selectedIndex = dropdown.value;

        if (selectedIndex >= 0 && selectedIndex < prefabs.Length)
        {
            if (currentPrefabInstance != null)
            {
                Destroy(currentPrefabInstance);
            }

            currentPrefabInstance = Instantiate(prefabs[selectedIndex], Vector3.zero, Quaternion.identity);
        }
    }
}
