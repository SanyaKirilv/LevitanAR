using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller_Language : MonoBehaviour
{
    [Header("Russian Text")]
    [TextArea]
    public string[] Ru;
    [Header("English Text")]
    [TextArea]
    public string[] En;
    [Header("Objects")]
    public Text[] text;
    public GameObject[] Button;
    [Header("Switchers")]
    public string language_mode;
    public bool bt;

    void Start()
    {
        Mode_Check();
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
    public void Change_Mode()
    {
        if (language_mode == "En")
        {
            PlayerPrefs.SetString("LanguageMode", "Ru");
            Rus();
        }
        if (language_mode == "Ru")
        {
            PlayerPrefs.SetString("LanguageMode", "En");
            Eng();
        }
        SceneManager.LoadScene("Settings");
    }
    private void Eng()
    {
        if (text.Length > 0)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].text = En[i];
            }
        }
        if (bt)
        {
            Button[0].SetActive(true);
            Button[1].SetActive(false);
        }

    }
    private void Rus()
    {
        if (text.Length > 0)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].text = Ru[i];
            }
        }
        if (bt)
        {
            Button[0].SetActive(false);
            Button[1].SetActive(true);
        }
    }
}
