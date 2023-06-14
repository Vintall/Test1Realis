using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] int sceneIndex;
    public void LoadScene() => SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
}
