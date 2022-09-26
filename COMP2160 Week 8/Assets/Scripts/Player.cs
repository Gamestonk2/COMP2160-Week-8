using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalTranslation;
    private float verticalTranslation;

    private float horizontalRotation;
    private float verticalRotation;
    [SerializeField]private float turningRate;

    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalTranslation = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        verticalTranslation = Input.GetAxis("Vertical") * Time.deltaTime*speed;
        transform.Translate(horizontalTranslation, 0, verticalTranslation);

        horizontalRotation = Input.GetAxis("Horizontal") * Time.deltaTime * turningRate;
        //transform.Rotate(0, horizontalRotation, 0);
    }
}
