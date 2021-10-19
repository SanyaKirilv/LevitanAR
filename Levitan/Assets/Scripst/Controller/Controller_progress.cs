using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller_progress : MonoBehaviour
{
    [Header("Level name")]
    public string code_name;
    [Header("Progress circle")]
    public Image loading_circle;
    [Header("Progress text")]
    public Text loading_text;

    void Start()
    {
        StartCoroutine(AsyncLoad());
    }

    IEnumerator AsyncLoad()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(code_name);
        while (!operation.isDone)
        {
            float progress = operation.progress / 0.9f;
            loading_circle.fillAmount = progress;
            loading_text.text = string.Format("{0:0}%", progress * 100);
            yield return null;
        }
    }
}
