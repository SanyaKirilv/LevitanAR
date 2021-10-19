using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller_Audio : MonoBehaviour
{
    [Header("Objects")]
    public AudioSource[] audio_src;
    public GameObject[] Button;
    [Header("Switchers")]
    public string audio_mode;
    public bool bt;

    void Start()
    {
        Mode_Check();
    }
    private void Mode_Check()
    {
        if (!PlayerPrefs.HasKey("AudioMode"))
        {
            PlayerPrefs.SetString("AudioMode", "On");
        }
        else
        {
            audio_mode = PlayerPrefs.GetString("AudioMode");
            if (audio_mode == "Off")
            {
                Audio_Off();
            }
            if (audio_mode == "On")
            {
                Audio_On();
            }
        }
    }
    public void Change_Mode()
    {
        if (audio_mode == "Off")
        {
            PlayerPrefs.SetString("AudioMode", "On");
        }
        if (audio_mode == "On")
        {
            PlayerPrefs.SetString("AudioMode", "Off");
        }
        SceneManager.LoadScene("Settings");
    }
    private void Audio_On()
    {
        if (bt)
        {
            Button[0].SetActive(true);
            Button[1].SetActive(false);
        }
        for (int i = 0; i < audio_src.Length; i++)
        {
            audio_src[i].volume = 1f;
        }
    }
    private void Audio_Off()
    {
        if (bt)
        {
            Button[0].SetActive(false);
            Button[1].SetActive(true);
        }
        for (int i = 0; i < audio_src.Length; i++)
        {
            audio_src[i].volume = 0f;
        }
    }
}
