using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEditor;

public class PlayerController : MonoBehaviour
{
    public GameObject roomExit;
    public GameObject roomEnter;
    public static bool hasExited;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //print("Secret Number = " + MySingleton.secretNumber);
        //MySingleton.secretNumber = 5;
        if(!hasExited)
        {
           EditorSceneManager.LoadScene("Scene3");
            hasExited = true;
        }
 
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float step = 2.0f * Time.deltaTime;
             if (this.gameObject.transform.position != roomExit.transform.position)
            {
            this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, this.roomExit.transform.position, step);
             }
       
    }
}
