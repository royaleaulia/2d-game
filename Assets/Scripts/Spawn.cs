using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject[] friutPrefab;
    [SerializeField] float secondSpawn;
    [SerializeField] float maxSecondSpawn;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    private bool stopspawn = false;

    public Nyawa nyawa;
    void Start()
    {

        StartCoroutine(FruitSpawn());
        if (nyawa.count <= 0)
        {
            StopCoroutine(FruitSpawn());
        }
    }
    private void Update()
    {
        if (secondSpawn > maxSecondSpawn)
        {
            secondSpawn -= 0.001f * Time.deltaTime;
        }

 

    }

    // Update is called once per frame
    IEnumerator FruitSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(friutPrefab[Random.Range(0, friutPrefab.Length)],
                position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 1000f);
        }
    }
}
