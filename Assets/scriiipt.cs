using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriiipt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Easy()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Medium()
    {
        SceneManager.LoadScene("medium");
    }

    public void Hard()
    {
        SceneManager.LoadScene("hard");
    }
}
