using UnityEngine;
using UnityEngine.UI;

public class ToggleImages : MonoBehaviour
{
    public Toggle toggle;
    public GameObject Rogue_hood_01;
    void Start()
    {
        // Ensure the toggle is set to the correct initial state
        toggle.onValueChanged.AddListener(delegate { ToggleImagesVisibility(); });
    }

    void ToggleImagesVisibility()
    {
        bool isVisible = toggle.isOn;

        Rogue_hood_01.SetActive(isVisible);

    }
}