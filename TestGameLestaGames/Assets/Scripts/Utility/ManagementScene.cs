using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagementScene : MonoBehaviour
{
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
