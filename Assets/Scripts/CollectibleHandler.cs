using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleHandler : MonoBehaviour
{

    public GameObject collectible;
    [HideInInspector]
    public bool spawnClick;

    //public List<GameObject> collectibles = new List<GameObject>();

   //If Prefab is Updated
    public void CorrectSpawned()
    {
        Collectible prefValue = collectible.GetComponent<Collectible>();
        SpriteRenderer prefRenderer = collectible.GetComponent<SpriteRenderer>();
        SphereCollider prefCollider = collectible.GetComponent<SphereCollider>();

        foreach (Collectible item in transform.GetComponentsInChildren<Collectible>())
        {
            item.score = prefValue.score;

            SpriteRenderer renderer = item.gameObject.GetComponent<SpriteRenderer>();
            SphereCollider collider = item.gameObject.GetComponent<SphereCollider>();

            renderer.sprite = prefRenderer.sprite;
            renderer.material = prefRenderer.material;
            renderer.sortingOrder = prefRenderer.sortingOrder;
            renderer.sortingLayerID = prefRenderer.sortingLayerID;
            renderer.flipX = prefRenderer.flipX;
            renderer.flipY = prefRenderer.flipY;
            renderer.drawMode = prefRenderer.drawMode;
            renderer.maskInteraction = prefRenderer.maskInteraction;
            renderer.color = prefRenderer.color;
            renderer.spriteSortPoint = prefRenderer.spriteSortPoint;


            collider.sharedMaterial = prefCollider.sharedMaterial;
            collider.isTrigger = prefCollider.isTrigger;
            collider.contactOffset = prefCollider.contactOffset;
            collider.radius = prefCollider.radius;

        }
    }
}
