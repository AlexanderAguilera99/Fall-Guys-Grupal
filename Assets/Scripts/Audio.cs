using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    private bool audioEnabled = true;

    private static Audio instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ToggleAudio()
    {
        audioEnabled = !audioEnabled;

        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);

            GameObject[] objectsInScene = scene.GetRootGameObjects();

            foreach (GameObject obj in objectsInScene)
            {
                AudioSource audioSource = obj.GetComponent<AudioSource>();

                if (audioSource != null)
                {
                    audioSource.enabled = audioEnabled;
                }
            }
        }
    }
}


