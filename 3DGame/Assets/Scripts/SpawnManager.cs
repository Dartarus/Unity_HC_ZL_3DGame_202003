using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    [Header("生成資料")]
    public SpawnData data;

    private void Start()
    {
        StartCoroutine(StartSpawn());
    }
    private IEnumerator StartSpawn()
    {
        for (int i = 0; i < data.spawn.Length; i++)
        {
            yield return new WaitForSeconds(data.spawn[i].time);
            print(data.spawn[i]).name);
        }
    }

}
