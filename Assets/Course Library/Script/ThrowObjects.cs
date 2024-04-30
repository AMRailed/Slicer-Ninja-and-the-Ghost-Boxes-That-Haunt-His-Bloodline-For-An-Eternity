using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObjects : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float maxpower = 20f;
    [SerializeField] float minpower = 8f;
    [SerializeField] SpawnManager spawnmanager;
    [SerializeField] Pause pause;
    [SerializeField] int scoreEdit = 1;
    [SerializeField] AudioSource audiosource;
    [SerializeField] AudioClip slash;
    // Start is called before the first frame update
    void Start()
    {
        //Set Position
        transform.position = new Vector3(Random.Range(-4, 4), 0);
        //Set Script 📜📜📜
        spawnmanager = GameObject.Find("SpawnManagerE").GetComponent<SpawnManager>();
        pause = GameObject.Find("MainGame").GetComponent<Pause>();
        audiosource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        //Throw up 🤮🤮🤮
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * Random.Range(minpower, maxpower), ForceMode.Impulse);
        rb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (pause.Paused == false)
        {
            Destroy(gameObject);
            spawnmanager.Score += scoreEdit;
            audiosource.PlayOneShot(slash);
        }
    }
}
