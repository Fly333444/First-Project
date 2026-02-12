using UnityEngine;

/// <summary>
/// A utility script that provides helpful game management functions.
/// This can be attached to a GameManager GameObject.
/// </summary>
public class GameManager : MonoBehaviour
{
    // Singleton instance
    public static GameManager Instance { get; private set; }

    [Header("Game State")]
    public bool isPaused = false;
    
    [Header("Score")]
    public int currentScore = 0;

    void Awake()
    {
        // Implement singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Toggle pause with Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    /// <summary>
    /// Toggles the pause state of the game
    /// </summary>
    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0f : 1f;
        Debug.Log("Game " + (isPaused ? "Paused" : "Unpaused"));
    }

    /// <summary>
    /// Adds points to the current score
    /// </summary>
    /// <param name="points">Number of points to add</param>
    public void AddScore(int points)
    {
        currentScore += points;
        Debug.Log("Score: " + currentScore);
    }

    /// <summary>
    /// Resets the score to zero
    /// </summary>
    public void ResetScore()
    {
        currentScore = 0;
        Debug.Log("Score Reset");
    }

    /// <summary>
    /// Quits the application
    /// </summary>
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
        
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
