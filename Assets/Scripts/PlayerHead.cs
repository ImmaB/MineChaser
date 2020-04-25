using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHead : MonoBehaviour
{
    public int bumpCount;
    [SerializeField]
    private int bumpMax = 3;

    public int BumpMax
    {
        get { return bumpMax; }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            bumpCount = 3;
        }
        else
        {
            bumpCount++;
        }
        //Better use if else
        switch (bumpCount)
        {
            case 1:
                //graphic change crack 1
                break;
            case 2:
                //Graphic no Helmet
                break;
            case 3:
                Dead();
                break;
            default:
                break;
        }
        SoundManager.PlayHeadHit();
        Debug.Log(bumpCount);
    }
    private void Dead()
    {
        // Not Tested
        FindObjectOfType<ResultScreen>().gameObject.SetActive(true);
        //Animation?/Graphic change?
        gameObject.SetActive(false);
        //Stop Camera Movement
        Debug.LogError("DEADSCREEN NEEDED");
    }
}

