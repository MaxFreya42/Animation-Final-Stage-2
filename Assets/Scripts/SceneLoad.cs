using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{

    [SerializeField] RectTransform fader;

    private void Start()
    {
        fader.gameObject.SetActive(true);

        LeanTween.alpha(fader, 1, 0);
        LeanTween.alpha(fader, 0, 0.5f).setOnComplete(() =>
        {
            fader.gameObject.SetActive (false);
        });
    }
    public void LoadAnim()
    {
        fader.gameObject.SetActive(true);
        LeanTween.alpha (fader, 0, 0);
        LeanTween.alpha(fader, 1, 0.5f).setOnComplete(() =>
        {
            Invoke("LoadGame", 0.5f);
            SceneManager.LoadScene(0);
        });
        
    }
    public void LoadMenu()
    {
        fader.gameObject.SetActive(true);
        LeanTween.alpha(fader, 0, 0);
        LeanTween.alpha(fader, 1, 0.5f).setOnComplete(() =>
        {
            Invoke("LoadGame", 0.5f);
            SceneManager.LoadScene(1);
        });

    }
    public void GameExit()
    {
        Application.Quit();
    }
}
