using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_level : MonoBehaviour
{
    [Header("Objects")]
    public Animation Button;
    [Header("Animation")]
    public string name_animation;
    [Header("Level name")]
    public string code_name;
    public void Click()
    {
        Button.Play(name_animation);
    }
    public void Load()
    {
        SceneManager.LoadScene(code_name);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
