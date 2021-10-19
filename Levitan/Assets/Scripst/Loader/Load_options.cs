using UnityEngine;

public class Load_options : MonoBehaviour
{
    [Header("Objects")]
    public Animation Options;
    public Animation Settings;
    public Animation Information;
    public Animation Questions;
    public Animation Exit;
    public Animation Background;
    public Animation Background_button;
    [Header("Switch")]
    public bool switcher;

    public void Load()
    {
        switch(switcher)
        {
            case true:
                Options.Play("Click_0");
                Settings.Play("Up_1");
                Information.Play("Up_2");
                Questions.Play("Up_3");
                Exit.Play("Up_4");
                Background.Play("Up_5");
                Background_button.Play("Up_6");
                break;
            case false:
                Options.Play("Click_0");
                Settings.Play("Down_1");
                Information.Play("Down_2");
                Questions.Play("Down_3");
                Exit.Play("Down_4");
                Background.Play("Down_5");
                Background_button.Play("Down_6");
                break;
        }
        switcher = !switcher;
    }
}
