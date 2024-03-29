using UnityEngine;
using UnityEngine.InputSystem;

namespace Managers
{
    public class GameManager: MonoBehaviour
    {
        [Scene] public string winScene, mainMenu;

        [SerializeField] private float scoreToWin;
        public void Update()
        {
            if (ScoreManager.Score >= scoreToWin)
            {
                SceneController.LoadSceneStatic(winScene);
            }
        
            if (HealthManager.lives <= 0)
            {
                SceneController.LoadSceneStatic(mainMenu);
            }

            if (Keyboard.current.escapeKey.wasPressedThisFrame)
            {
                SceneController.LoadSceneStatic(mainMenu);
            }
        }
    }
}