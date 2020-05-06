using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleRespawn : MonoBehaviour
{
    [SerializeField]
    GameObject collectibleParent;

    [SerializeField]
    GameObject blockade;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        for (int i = 0; i < collectibleParent.transform.childCount; i++)
        {
            collectibleParent.transform.GetChild(i).gameObject.SetActive(true);
        }
        blockade.SetActive(false);
    }
}
