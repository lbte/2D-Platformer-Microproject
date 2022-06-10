using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Platformer.UI
{
    /// <summary>
    /// The Portal class is responsible for triggering the canvas prefab for the first trigger
    /// </summary>
    public class Portal : MonoBehaviour
    {
        private MetaGameController metaGameControllerScript;
        public Button DestroyButton;

        /// <summary>
        /// Get the script that controlls the canvas and add the listener to the button to destroy the canvas prefab
        /// </summary>
        void Start()
        {
            metaGameControllerScript = GameObject.Find("GameController").GetComponent<MetaGameController>();
            DestroyButton.onClick.AddListener(DestroyPrefabButton);
        }

        /// <summary>
        /// Show the canvas when the player collides with the portal
        /// </summary>
        /// <param name="playerCollision"></param>
        private void OnTriggerEnter2D(Collider2D playerCollision)
        {
            // check if the prefab still exists in order to display it
            if (metaGameControllerScript.mainMenu != null)
            {
                metaGameControllerScript.ToggleMainMenu(show: !metaGameControllerScript.showMainCanvas);
            } 
        }

        void DestroyPrefabButton()
        {
            metaGameControllerScript.ToggleMainMenu(show: !metaGameControllerScript.showMainCanvas);
            Destroy(metaGameControllerScript.mainMenu);
        }
    }
}
