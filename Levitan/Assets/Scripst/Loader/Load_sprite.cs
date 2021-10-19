using UnityEngine;
using UnityEngine.UI;

public class Load_sprite : MonoBehaviour
{
    [Header("Object")]
    public Image Button;
    [Header("Sprites")]
    public Sprite sprite_1;
    public Sprite sprite_2;
    [Header("Switch")]
    public bool switcher;

    private void Start()
    {
        Button = GetComponent<Image>();
    }

    public void Load()
    {        
        if (switcher)
        {
            Button.sprite = sprite_1;
        }
        else if (!switcher)
        {
            Button.sprite = sprite_2;

        }
        switcher = !switcher;
    }
}
