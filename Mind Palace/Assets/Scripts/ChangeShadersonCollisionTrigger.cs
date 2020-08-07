using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ChangeShadersonCollisionTrigger : MonoBehaviour
{
    [SerializeField] Shader normalShader;
    [SerializeField] Shader highlightedShader;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.shader = normalShader;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        GetComponent<MeshRenderer>().material.shader = highlightedShader;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
        GetComponent<MeshRenderer>().material.shader = normalShader;
    }


}
