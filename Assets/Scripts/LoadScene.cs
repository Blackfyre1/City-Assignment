using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene: MonoBehaviour
{
    [SerializeField]
    Animator Fade;
    AnimatorControllerParameter SceneTransition;
    // Use this for initialization
    public void LoadSceneByString(string load)
    {
        Fade.SetBool("SceneTransition", true);
        StartCoroutine(Counter(load));
    }
    IEnumerator Counter(string load)
    {
        yield return new WaitForSeconds(0.99f);
        SceneManager.LoadScene(load, LoadSceneMode.Single);
    }
}
