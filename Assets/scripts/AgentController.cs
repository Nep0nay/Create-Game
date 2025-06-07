using UnityEngine;

public class AgentController : MonoBehaviour
{
    [SerializeField]
    GameObject PlayerAgentPrefab;

    [SerializeField]
    GameObject EnemyAgentPrefab;


   
    void Start()
    {
        SpawnObjects();
    }

    public void SpawnObjects()
    {
        GameObject player = Instantiate(PlayerAgentPrefab);
        GameObject enmey = Instantiate(EnemyAgentPrefab);

        enemyAnimator enmeyGO = enmey.GetComponent<enemyAnimator>();

        //Transform GO = PlayerAgentPrefab.transform;
        //enemyAnimator comp = player.gameObject.GetComponent<enemyAnimator>();
        enmeyGO.TargetTransform(player.transform);




    }
}
