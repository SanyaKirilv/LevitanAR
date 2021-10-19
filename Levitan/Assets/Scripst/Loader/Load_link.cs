using UnityEngine;

public class Load_link : MonoBehaviour
{
    [Header("Objects")]
    public Animation Button;
    [Header("Animation")]
    public string name_animation;
    [Header("Link name")]
    public string code_name;
    public void Click()
    {
        Button.Play(name_animation);
    }
    public void Load()
    {
        Application.OpenURL(code_name);
    }
}
