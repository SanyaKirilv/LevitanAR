using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Load_Ar : MonoBehaviour
{
    [Header("Video Quad")]
    public GameObject[] video;
    [Header("Text Area")]
    public Text textArea;
    public GameObject text;
    [Header("Switchers")]
    public bool bt;
    public string language_mode;
    [Header("Russian Text")]
    [TextArea]
    public string Ru;
    [Header("English Text")]
    [TextArea]
    public string En;
    private void Start()
    {
        Mode_Check();
    }


    public void Load()
    {
        
        if (bt)
        {
            video[0].SetActive(true);
            video[0].GetComponent<VideoPlayer>().Play();
            video[0].GetComponent<AudioSource>().Play();
        }
        text.SetActive(true);
        Mode_Check();
    }

    public void Unload()
    {
        if (bt)
        {
            video[0].SetActive(false);
            video[0].GetComponent<VideoPlayer>().Stop();
            video[0].GetComponent<AudioSource>().Stop();
        }
        text.SetActive(false);
    }
    private void Mode_Check()
    {
        if (!PlayerPrefs.HasKey("LanguageMode"))
        {
            PlayerPrefs.SetString("LanguageMode", "Ru");
            Rus();
        }
        else
        {
            language_mode = PlayerPrefs.GetString("LanguageMode");
            if (language_mode == "En")
            {
                Eng();
            }
            if (language_mode == "Ru")
            {
                Rus();
            }
        }
    }
    private void Eng()
    {
        textArea.text = En;
    }
    private void Rus()
    {
        textArea.text = Ru;
    }
}
