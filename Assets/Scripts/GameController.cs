using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //spawn balls

    public GameObject playerPrefab;
    public Transform _playerSpawnPosition;

    
    private void Start()
    {
        SpawnPlayerBall();
    }
    private void OnEnable()
    {
        BallController.onStickModeChanged += SpawnPlayerBall;
    }

    private void OnDisable()
    {
        BallController.onStickModeChanged -= SpawnPlayerBall;
    }
    
    public void SpawnPlayerBall()
    {
        StartCoroutine(SpawnAfterSomeTime());
    }

    IEnumerator SpawnAfterSomeTime()
    {
        yield return new WaitForSeconds(1);
        print("Spawn Ball");
        GameObject myPlayer = Instantiate(playerPrefab, _playerSpawnPosition.transform.position,
            _playerSpawnPosition.transform.rotation);
    }
}
