using System.IO;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

public class GameManager : MonoSingletone<GameManager>
{

    [SerializeField]
    private Transform _canvasTrasn; // 씬이 바뀌면 사라짐 

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

    public void OnClickSelectButton()
    {
        UIManager.Instance.CreateStageUI();
        UIManager.Instance.RemoveSelectbuttonUI();
    }

    private IEnumerator LoadSceneAsync(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);

        Debug.Log("RemoveContainerUI");
        UIManager.Instance.RemoveContainerUI("LobbyUI"); // 씬 전환하고 LobbyUI삭제

        // 씬 로딩 이후 바로 Selectbutton UI 생성
        UIManager.Instance.CreateSelectbuttonUI();
    }
  


}
