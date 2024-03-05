using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void GameOver()
    {
        Debug.Log("Game Over!");
        SceneManager.LoadScene(2);
    }

    public void Play()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
