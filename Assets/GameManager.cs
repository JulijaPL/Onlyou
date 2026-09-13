using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
   public static GameManager Instance;

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TMPro.TextMeshProUGUI gameOverText;


    void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        gameOverPanel.SetActive(false);
    }

    public void GameOver()
    {
       gameOverPanel.SetActive(true);
        // gameOverText.SetActive(true);   
        Time.timeScale = 0f;

    }


    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
