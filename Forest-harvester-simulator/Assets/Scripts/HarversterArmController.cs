using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// TODO: THIS IS FAST PROTO TYPE
/// </summary>

public class HarversterArmController : MonoBehaviour
{
    [SerializeField]
    private AxisHandler baseAxis;

    [SerializeField]
    private AxisHandler secondAxis;

    [SerializeField]
    private AxisHandler thirdAxis;

    [SerializeField]
    private float axisSensitivity = 1f;

    // Start is called before the first frame update
    void Start()
    {
        if(null== baseAxis)
        {
            Debug.LogError("HarversterArmController - Start() ---> null!= baseAxis");
            this.enabled = false;
        }
        if (null == secondAxis)
        {
            Debug.LogError("HarversterArmController - Start() ---> null!= secondAxis");
            this.enabled = false;
        }
        if (null == thirdAxis)
        {
            Debug.LogError("HarversterArmController - Start() ---> null!= thirdAxis");
            this.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        // FIXME : User inputs mayby better read in custom input manager (One place)

        if (Input.GetKey(KeyCode.O))
        {
            baseAxis.RotateAxis(axisSensitivity*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.L))
        {
            baseAxis.RotateAxis(-axisSensitivity * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.I))
        {
            secondAxis.RotateAxis(axisSensitivity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.K))
        {
            secondAxis.RotateAxis(-axisSensitivity * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.U))
        {
            thirdAxis.RotateAxis(axisSensitivity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.J))
        {
            thirdAxis.RotateAxis(-axisSensitivity * Time.deltaTime);
        }

    }
}
