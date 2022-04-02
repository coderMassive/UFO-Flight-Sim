using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shript : MonoBehaviour
{
    int score = 0;
    public Text t;
    public AudioSource audio;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        var starX = Random.Range(player.transform.position.x - 25, player.transform.position.x + 25);
        var starZ = Random.Range(player.transform.position.z - 25, player.transform.position.z + 25);
        var starY = Random.Range(player.transform.position.y - 25, player.transform.position.y + 25);
        transform.position = new Vector3(starX, starY, starZ);
        score++;
        t.text = score.ToString();
        audio.Play();
    }
}
