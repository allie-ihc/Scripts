using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    Singleton ms;
    private Player thePlayer;
    public TextMeshPro gameTag;
    private void SetGameTag()
    {
        gameTag.text = this.thePlayer.getName() + ": " + this.thePlayer.getHP();
    }
    // Start is called before the first frame update
    void Start()
    {
        ms = new Singleton('o');
        thePlayer = new Player("Dave");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.thePlayer.display();
        int tempCount = ms.countUp();
        if(tempCount != -1)
        {
            print("Player 2: " + tempCount);
        }
        SetGameTag();
    }

}
