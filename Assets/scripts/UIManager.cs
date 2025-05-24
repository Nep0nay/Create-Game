using UnityEngine;
using System.Collections.Generic;
using static Unity.Burst.Intrinsics.X86.Avx;
using System.Xml.Linq;
using UnityEngine.UI;
//using Gpm.Common.ThirdParty.MessagePack.Resolvers;

public class UIBase : MonoBehaviour
{

}
public class UIManager : MonoSingletone<UIManager> 
{
    [SerializeField]
    private Transform _canvasTrasn;


    // �����̳ʿ� �����ؼ� �����ϸ� �ȴ�. 
    private Dictionary<string, UIBase> _container = new Dictionary<string, UIBase>();

    private string _uiPath = "Prefab/";

    public void CreateLobbyUI()
    {
        // Lobby �������� ���ҽ��� �ε��ؼ�, Instantiate�Ѵ�. 
        GameObject resGO = Resources.Load<GameObject>("Prefab/LobbyUI");
        GameObject sceanGO = Instantiate(resGO, _canvasTrasn, false);
        LobbyUI comp = sceanGO.GetComponent<LobbyUI>();

        _container.Add(typeof(LobbyUI).ToString(), comp); //_container�� LobbyUI�߰�
    }

    public void CreateSelectbuttonUI()
    {
        GameObject SBUI = Resources.Load<GameObject>("Prefab/Selectbutton");
        GameObject SBGO = Instantiate(SBUI, _canvasTrasn, false);
        Selectbutton comp1 = SBGO.GetComponent<Selectbutton> ();
        SBGO.transform.position = new Vector3(0, -450f, 0);

        _container.Add(typeof(Selectbutton).ToString(), comp1); //_container�� Selectbutton�߰�

    }
    public void CreateStageUI()
    {
        GameObject StageUI = Resources.Load<GameObject>("Prefab/StageUI");
        GameObject StageGO = Instantiate(StageUI, _canvasTrasn, false);
        StageUI comp2 = StageGO.GetComponent<StageUI>();

        _container.Add(typeof(StageUI).ToString(), comp2); //_container�� StageUI�߰�

    }

    public void RemoveSelectbuttonUI()
    {
        RemoveSBUI("Selectbutton");
    }

    public void RemoveLobbyUI(string uiName) //_container�� �ִ� LobbyUI���� -> �� ��ȯ�Ҷ�
    {
        UIBase lobbyui;
        if (_container.TryGetValue(typeof(LobbyUI).ToString(), out lobbyui))
        {
            Destroy(lobbyui.gameObject);
            _container.Remove(typeof(LobbyUI).ToString());
        }
    }
    public void RemoveSBUI(string uiName) //_container�� �ִ� Selectbutton���� -> ��ư�� ��������
    {
        UIBase sbui;
        if (_container.TryGetValue(typeof(Selectbutton).ToString(), out sbui))
        {
            Destroy(sbui.gameObject);
            _container.Remove(typeof(Selectbutton).ToString());
        }
    }
    public void RemoveFirstStageUI(string uiName) //_container�� �ִ� LobbyUI���� -> �� ��ȯ�Ҷ�
    {
        UIBase stageui;
        if (_container.TryGetValue(typeof(StageUI).ToString(), out stageui))
        {
            Destroy(stageui.gameObject);
            _container.Remove(typeof(StageUI).ToString());
        }
    }

}
