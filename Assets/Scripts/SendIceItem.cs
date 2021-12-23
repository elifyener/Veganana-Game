using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendIceItem : MonoBehaviour
{
    [SerializeField] GameObject IceItem;

    private void Start(){
            InvokeRepeating("CreateIce", 0.5f, 10f);
        }
    void CreateIce(){
        Instantiate(IceItem, transform.position = new Vector2(Random.Range(-0.6f, 0.6f), transform.position.y), Quaternion.identity);
    }
}
