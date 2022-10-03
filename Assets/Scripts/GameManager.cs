using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
