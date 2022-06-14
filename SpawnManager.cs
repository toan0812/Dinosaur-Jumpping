using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerMovement PlayerMovement;
    public GameObject[] CactusPreFab;
    public float TimeSpawner = 1.5f;
    public float xtrans;//vi tri spawn x 
    public float ytrans;//vi tri spawn y
    private void Awake()
    {
        PlayerMovement = GetComponent<PlayerMovement>();
    }
    private void Start()
    {        
            StartCoroutine(SpawnObj());                
    }
    IEnumerator SpawnObj()
    {
        while ( true)
        {
            Vector2 pos = new Vector2(xtrans,ytrans);
            GameObject Cactus = Instantiate(CactusPreFab[Random.Range(0, CactusPreFab.Length)], pos, Quaternion.identity);
            yield return new WaitForSeconds(TimeSpawner);
            Destroy(Cactus, 3f);   
        }
    }
}
