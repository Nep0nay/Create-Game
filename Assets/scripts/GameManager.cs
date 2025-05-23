using System.IO;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

public class GameManager : MonoSingletone<GameManager>
{

    [SerializeField]
    private Transform _canvasTrasn; // ���� �ٲ�� ����� 

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
        UIManager.Instance.RemoveContainerUI("LobbyUI"); // �� ��ȯ�ϰ� LobbyUI����

        // �� �ε� ���� �ٷ� Selectbutton UI ����
        UIManager.Instance.CreateSelectbuttonUI();
    }
  


}
