using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovements : MonoBehaviour
{

Animation cameraanimacao;

    // Start is called before the first frame update
    void Start()
    {
        cameraanimacao = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraanimacao.Stop();
    }
}
