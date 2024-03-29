using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBeat : MonoBehaviour
{
    public float bpm = 120f;
    float spawnrate;
    public GameObject go; // object to spawn...

    // Start is called before the first frame update
    void Start()
    {
        spawnrate = 120.0f / bpm;
        InvokeRepeating("SpawnObject", 0, spawnrate);
        Debug.Log(spawnrate);

    }

    public void SpawnObject()
    {
        GameObject g = Instantiate(go, transform.position, Quaternion.identity);
        //g.GetComponent<Rigidbody2D>().velocity = new Vector2(3.5f, 0);
        //g.GetComponent<Rigidbody2D>().gravityScale = Random.Range(-0.25f, 0.25f);
        float s = Random.Range(0.1f, 0.8f);
        g.transform.position = new Vector3(Random.Range(-6.63f, 6.72f), g.transform.position.y, g.transform.position.z);
    }

}
