using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public void GoToLevelOne()
    {
        SceneManager.LoadScene("Level1");
    }
}
