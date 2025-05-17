using System.IO;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;

public class GameManager : MonoSingletone<GameManager>
{

    [SerializeField]
    private Transform _canvasTrasn; // æ¿¿Ã πŸ≤Ó∏È ªÁ∂Û¡¸ 

    public bool _isPlay = false;
    void Start()
    {
        var temp = Instance;

        UIManager.Instance.CreateLobbyUI();
    }

    public void OnClickStartButton()
    {
        StartCoroutine(LoadSceneAsync("StartScene"));
    }

    private IEnumerator LoadSceneAsync(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);

        Debug.Log("RemoveContainerUI");
        UIManager.Instance.RemoveContainerUI("LobbyUI"); // æ¿ ¿¸»Ø«œ∞Ì LobbyUIªË¡¶


    }

}
