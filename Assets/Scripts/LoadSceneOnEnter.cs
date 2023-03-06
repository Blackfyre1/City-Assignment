using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneOnEnter : MonoBehaviour
{
    [SerializeField]
    string SceneName;
    private GameObject GameManager;
    public void Start()
    {
        GameManager = GameObject.Find("GameManager");
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "PlayerModel")
        {
            if(GameManager == null)
            {
                GameManager = GameObject.Find("GameManager");
            }
            GameManager.GetComponent<LoadScene>().LoadSceneByString(SceneName);
        }
    }
}
