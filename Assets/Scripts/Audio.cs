using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    private bool audioEnabled = true;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void ToggleAudio()
    {
        audioEnabled = !audioEnabled;

        // Recorremos todas las escenas
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

                    Debug.Log("Audio " + audioSource.clip.name + " in scene " + scene.name + " is now " + audioEnabled);
                }
            }
        }
    }
}

