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
        StartCoroutine(LoadStartScene("StartScene"));
    }

    public void OnClickSelectButton()
    {
        UIManager.Instance.CreateStageUI();
        UIManager.Instance.RemoveSelectbuttonUI();
    }

    public void OnFirstStageButton()
    {
        StartCoroutine(LoadFirstStageScene("GameScene"));

        UIManager.Instance.CreateArmyHealthbar();
        UIManager.Instance.CreateEnemyHealthbar();
        UIManager.Instance.CreateTimer();
    }

    private IEnumerator LoadStartScene(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);

        Debug.Log("RemoveContainerUI");
        UIManager.Instance.RemoveLobbyUI("LobbyUI"); // 씬 전환하고 LobbyUI삭제

        // 씬 전환 이후 바로 Selectbutton UI 생성
        UIManager.Instance.CreateSelectbuttonUI();
    }
  
    private IEnumerator LoadFirstStageScene(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);

        UIManager.Instance.RemoveFirstStageUI("StageUI");

    }

    

}
