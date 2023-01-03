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
        spawnrate = 60 / bpm;
        InvokeRepeating("SpawnObject", 0, spawnrate);

    }

    public void SpawnObject()
    {
        GameObject g = Instantiate(go, transform.position, Quaternion.identity);
        g.GetComponent<Rigidbody2D>().velocity = new Vector2(3.5f, 0);
        g.GetComponent<Rigidbody2D>().gravityScale = Random.Range(-0.25f, 0.25f);
        g.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        float s = Random.Range(0.1f, 0.8f);
        g.transform.localScale = new Vector3(s, s, s);
        Destroy(g, 6f);
    }

}
