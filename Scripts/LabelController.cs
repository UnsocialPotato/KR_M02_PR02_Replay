using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelController : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        if (player.GetComponent<InputHandler>().getReplaying() == true)
        {
            this.GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        }
        else
        {
            this.GetComponent<TMPro.TextMeshProUGUI>().enabled = false;
        }
    }
}
