using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Platformer.UI
{
    public class AlienTriggerOff : MonoBehaviour
    {
        [SerializeField] string additiveScene;

        /// <summary>
        /// Listener for the button in the additive scene canvas
        /// </summary>
        public void SalirAdditiveSceneButton()
        {
            Time.timeScale = 1;
            SceneManager.UnloadSceneAsync(additiveScene);
        }
    }
}
