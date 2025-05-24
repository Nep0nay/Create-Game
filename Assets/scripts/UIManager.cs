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


    // 컨테이너에 저장해서 관리하면 된다. 
    private Dictionary<string, UIBase> _container = new Dictionary<string, UIBase>();

    private string _uiPath = "Prefab/";

    public void CreateLobbyUI()
    {
        // Lobby 프리팹을 리소스를 로드해서, Instantiate한다. 
        GameObject resGO = Resources.Load<GameObject>("Prefab/LobbyUI");
        GameObject sceanGO = Instantiate(resGO, _canvasTrasn, false);
        LobbyUI comp = sceanGO.GetComponent<LobbyUI>();

        _container.Add(typeof(LobbyUI).ToString(), comp); //_container에 LobbyUI추가
    }

    public void CreateSelectbuttonUI()
    {
        GameObject SBUI = Resources.Load<GameObject>("Prefab/Selectbutton");
        GameObject SBGO = Instantiate(SBUI, _canvasTrasn, false);
        Selectbutton comp1 = SBGO.GetComponent<Selectbutton> ();
        SBGO.transform.position = new Vector3(0, -450f, 0);

        _container.Add(typeof(Selectbutton).ToString(), comp1); //_container에 Selectbutton추가

    }
    public void CreateStageUI()
    {
        GameObject StageUI = Resources.Load<GameObject>("Prefab/StageUI");
        GameObject StageGO = Instantiate(StageUI, _canvasTrasn, false);
        StageUI comp2 = StageGO.GetComponent<StageUI>();

        _container.Add(typeof(StageUI).ToString(), comp2); //_container에 StageUI추가

    }

    public void RemoveSelectbuttonUI()
    {
        RemoveSBUI("Selectbutton");
    }

    public void RemoveLobbyUI(string uiName) //_container에 있는 LobbyUI삭제 -> 씬 전환할때
    {
        UIBase lobbyui;
        if (_container.TryGetValue(typeof(LobbyUI).ToString(), out lobbyui))
        {
            Destroy(lobbyui.gameObject);
            _container.Remove(typeof(LobbyUI).ToString());
        }
    }
    public void RemoveSBUI(string uiName) //_container에 있는 Selectbutton삭제 -> 버튼을 눌렀을때
    {
        UIBase sbui;
        if (_container.TryGetValue(typeof(Selectbutton).ToString(), out sbui))
        {
            Destroy(sbui.gameObject);
            _container.Remove(typeof(Selectbutton).ToString());
        }
    }
    public void RemoveFirstStageUI(string uiName) //_container에 있는 LobbyUI삭제 -> 씬 전환할때
    {
        UIBase stageui;
        if (_container.TryGetValue(typeof(StageUI).ToString(), out stageui))
        {
            Destroy(stageui.gameObject);
            _container.Remove(typeof(StageUI).ToString());
        }
    }

}
