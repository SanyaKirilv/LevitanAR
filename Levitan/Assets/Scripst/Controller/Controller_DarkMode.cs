using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller_DarkMode : MonoBehaviour
{
    [Header("Dark Mode")]
    public Color d_color_1;
    public Color d_color_2;
    public Color d_color_3;
    public Color d_color_4;
    [Header("White Mode")]
    public Color w_color_1;
    public Color w_color_2;
    public Color w_color_3;
    public Color w_color_4;
    [Header("Objects")]
    public Image[] object_1;
    public Image[] object_2;
    public Image[] object_3;
    public Text[] object_4;
    public GameObject[] Button;
    [Header("Switchers")]
    public string theme_mode;
    public bool bt;


    void Start()
    {
        Mode_Check();
    }
    private void Mode_Check()
    {
        if (!PlayerPrefs.HasKey("ThemeMode"))
        {
            PlayerPrefs.SetString("ThemeMode", "White");
            White_theme();
        }
        else
        {
            theme_mode = PlayerPrefs.GetString("ThemeMode");
            if (theme_mode == "Dark")
            {
                Dark_theme();
            }
            if (theme_mode == "White")
            {
                White_theme();
            }
        }
    }
    public void Change_Mode()
    {
        if (theme_mode == "Dark")
        {
            PlayerPrefs.SetString("ThemeMode", "White");
            White_theme();
        }
        if (theme_mode == "White")
        {
            PlayerPrefs.SetString("ThemeMode", "Dark");
            Dark_theme();
        }
        SceneManager.LoadScene("Settings");
    }
    private void Dark_theme()
    {
        if (object_1.Length > 0)
        {
            for (int i = 0; i < object_1.Length; i++)
            {
                object_1[i].color = d_color_1;
            }
        }
        if (object_2.Length > 0)
        {
            for (int i = 0; i < object_2.Length; i++)
            {
                object_2[i].color = d_color_2;
            }
        }
        if (object_3.Length > 0)
        {
            for (int i = 0; i < object_3.Length; i++)
            {
                object_3[i].color = d_color_3;
            }
        }
        if (object_4.Length > 0)
        { 
            for (int i = 0; i < object_4.Length; i++)
            {
                object_4[i].color = d_color_4;
            }
        }
        if (bt)
        {
            Button[0].SetActive(true);
            Button[1].SetActive(false);
        }
    }
    private void White_theme()
    {
        if (object_1.Length > 0)
        {
            for (int i = 0; i < object_1.Length; i++)
            {
                object_1[i].color = w_color_1;
            }
        }
        if (object_2.Length > 0)
        {
            for (int i = 0; i < object_2.Length; i++)
            {
                object_2[i].color = w_color_2;
            }
        }
        if (object_3.Length > 0)
        {
            for (int i = 0; i < object_3.Length; i++)
            {
                object_3[i].color = w_color_3;
            }
        }
        if (object_4.Length > 0)
        {
            for (int i = 0; i < object_4.Length; i++)
            {
                object_4[i].color = w_color_4;
            }
        }
        if (bt)
        {
            Button[0].SetActive(false);
            Button[1].SetActive(true);
        }
    }
}
