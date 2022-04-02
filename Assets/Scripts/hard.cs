using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class hard : MonoBehaviour
{
    float xRotation = 0f;
    public Transform playerBody;
    public Rigidbody playerRigid;
    public Transform coin;
    public Text text;
    public Text counter;
    public Image fade;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
            Screen.fullScreen = !Screen.fullScreen;
        float distance = Mathf.Floor(Vector3.Distance(playerBody.position, coin.position));
        counter.text = distance.ToString();
        if (distance >= 100)
        {
            SceneManager.LoadScene("Unalive");
        }
        if (distance > 70)
        {
            var tempColor = fade.color;
            tempColor.a = (distance - 70)/100;
            fade.color = tempColor;
        }
        float mouseX = Input.GetAxis("Mouse X") * 100f * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * 100f * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
        double stuff = int.Parse(text.text) * 200 + 1000;
        int stuff2 = (int)stuff;
        Debug.Log(stuff2);
        if (Input.GetMouseButton(0))
        {
            playerRigid.AddForce(Camera.main.transform.forward * stuff2 * Time.deltaTime, ForceMode.Acceleration);
        }
    }
}
