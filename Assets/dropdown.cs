using UnityEngine;
using UnityEngine.UI;

public class dropdown : MonoBehaviour
{
    public Dropdown Dropdown;

    public GameObject Rogue_01;
    public GameObject Rogue_02;
    public GameObject Rogue_03;
    public GameObject Rogue_04;
    public GameObject Rogue_05;
    public GameObject Rogue_06;

    private GameObject selectedPrefab;

    public void change()
    {
        // Initialize the dropdown with options
        Dropdown.options.Clear();
        Dropdown.options.Add(new Dropdown.OptionData() { text = "Rogue_01" });
        Dropdown.options.Add(new Dropdown.OptionData() { text = "Rogue_02" });
        Dropdown.options.Add(new Dropdown.OptionData() { text = "Rogue_03" });
        Dropdown.options.Add(new Dropdown.OptionData() { text = "Rogue_04" });
        Dropdown.options.Add(new Dropdown.OptionData() { text = "Rogue_05" });
        Dropdown.options.Add(new Dropdown.OptionData() { text = "Rogue_06" });

        Dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(Dropdown); });


        selectedPrefab = Rogue_01;
    }

    public void DropdownItemSelected(Dropdown dropdown)
    {
        int index = dropdown.value;

        switch (index)
        {
            case 0:
                selectedPrefab = Rogue_01;
                break;
            case 1:
                selectedPrefab = Rogue_02;
                break;
            case 2:
                selectedPrefab = Rogue_03;
                break;
            case 3:
                selectedPrefab = Rogue_04;
                break;
            case 4:
                selectedPrefab = Rogue_05;
                break;
            case 5:
                selectedPrefab = Rogue_06;
                break;
        }
         selectedPrefab.transform.localScale = new Vector3(selectedPrefab.transform.localScale.z);
        
    }

    
}
