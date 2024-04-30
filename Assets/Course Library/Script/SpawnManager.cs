using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{

    private float spawnRate = 1;
    [SerializeField] GameObject[] targets;
    [SerializeField] TextMeshProUGUI text;
    public int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score : " + Score;
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Length);
            Instantiate(targets[index], transform.position, transform.rotation, transform);
        }
    }
}
