using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Method to change between the start and game scenes
/// Code retrieved from: https://www.youtube.com/watch?v=QJBL9eHBsso
/// </summary>
public class MoveScenes : MonoBehaviour
{
    [SerializeField] private string gameScene;

    private void OnTriggerEnter2D(Collider2D playerCollision)
    {
        SceneManager.LoadScene(gameScene);
    }
}
