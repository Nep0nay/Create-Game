using UnityEngine;

public class AgentController : MonoBehaviour
{
    [SerializeField]
    GameObject PlayerAgentPrefab;

    [SerializeField]
    GameObject EnemyAgentPrefab;

   
    void Start()
    {
        SpawnStageAgent();
    }

    private void SpawnStageAgent()
    {
        GameObject player = Instantiate(PlayerAgentPrefab);
        GameObject enemyGO = Instantiate(EnemyAgentPrefab);

        enemy comp = enemyGO.gameObject.GetComponent<enemy>();

        comp.SetTarget(player.transform);

    }
}
