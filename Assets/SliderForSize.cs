using UnityEngine;
using UnityEngine.UI;

public class SliderForSize : MonoBehaviour
{
    public Slider SliderHeight;
    public Slider SliderWidth;
    public GameObject Rogue_01;

    private Transform rogueTransform;

    void Start()
    {
        if (Rogue_01 != null)
        {
            rogueTransform = Rogue_01.transform;
        }

        if (SliderHeight != null)
        {
            SliderHeight.onValueChanged.AddListener(delegate { SizeChanger(); });
        }

        if (SliderWidth != null)
        {
            SliderWidth.onValueChanged.AddListener(delegate { SizeChanger(); });
        }
    }

    public void SizeChanger()
    {
        if (rogueTransform != null)
        {
            float currentHeight = SliderHeight.value;
            float currentWidth = SliderWidth.value;

            rogueTransform.localScale = new Vector3(currentWidth, currentHeight, rogueTransform.localScale.z);
        }
    }
}
