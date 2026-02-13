using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSaveManager : MonoBehaviour
{
    public static WorldSaveManager instance;

    [SerializeField] int worldSceneindex = 1;

    private void Awakake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public IEnumerator LoadNewGame()
    {
        AsyncOperation loadOperator = SceneManager.LoadSceneAsync(worldSceneindex);

        yield return null;
    }
}
