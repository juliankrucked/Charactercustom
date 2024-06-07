using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public Button muteButton;
    public Sprite muteSprite;
    public Sprite unmuteSprite;

    private bool isMuted = false;

    void Start()
    {
        muteButton.image.sprite = isMuted ? unmuteSprite : muteSprite;

 
        muteButton.onClick.AddListener(ToggleMute);
    }

    void ToggleMute()
    {
        isMuted = !isMuted;

 
        muteButton.image.sprite = isMuted ? unmuteSprite : muteSprite;

        audioSource.mute = isMuted;
    }
}
