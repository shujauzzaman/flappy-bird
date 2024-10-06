using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake()
    {
        // Ensure there is only one instance of the GameManager
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep the GameManager across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate
        }

    }

}
