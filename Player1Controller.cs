using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    Singleton ms;
    private Player thePlayer;
    public TextMeshPro gameTag;
    public GameObject destinationGO;
    // Start is called before the first frame update
    private void SetGameTag()
    {
        gameTag.text = this.thePlayer.getName() + ": " + this.thePlayer.getHP();
    }
    void Start()
    {
        ms = new Singleton('e');
        this.thePlayer = new Player("Mike");
        //this.gameObject.transform.position = destinationGO.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = 2.0f * Time.deltaTime;
        if (this.gameObject.transform.position != destinationGO.transform.position)
        {
            this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, this.destinationGO.transform.position, step);
        }
        /*
        this.thePlayer.display();
        int tempCount = ms.countUp();
        if (tempCount != -1)
        {
            print("Player 1: " + tempCount);
        }
        SetGameTag();
    }
        */
    }
}