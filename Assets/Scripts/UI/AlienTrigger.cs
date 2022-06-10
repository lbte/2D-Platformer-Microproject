using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Platformer.UI
{
    /// <summary>
    /// The AlienTrigger class is responsible for triggering the canvas prefab for the second trigger
    /// </summary>
    public class AlienTrigger : MonoBehaviour
    {
        [SerializeField] private string additiveScene;

        /// <summary>
        /// Loads the additive scene when the collider is triggered
        /// </summary>
        /// <param name="playerCollision"></param>
        private void OnTriggerEnter2D(Collider2D playerCollision)
        {
            if (playerCollision.gameObject.name == "Player")
            {
                Time.timeScale = 0;
                SceneManager.LoadSceneAsync(additiveScene, LoadSceneMode.Additive);
            }
        }
    }
}
