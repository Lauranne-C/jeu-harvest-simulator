using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum SelectedAxis
{
    EXAxis,
    EYAxis,
    EZAxis
};


/// <summary>
/// TODO: THIS IS FAST PROTO TYPE
/// </summary>
public class AxisHandler : MonoBehaviour
{

    [SerializeField]
    private SelectedAxis selectedAxis = SelectedAxis.EXAxis;


    private Transform objectTransform;


    private void Start()
    {
        objectTransform = gameObject.transform;
    }


    public void RotateAxis(float aValue)
    {

        if(selectedAxis==SelectedAxis.EXAxis)
            objectTransform.Rotate(new Vector3(0, aValue, 0));

        if (selectedAxis == SelectedAxis.EYAxis)
            objectTransform.Rotate(new Vector3(aValue, 0, 0));


        if (selectedAxis == SelectedAxis.EZAxis)
            objectTransform.Rotate(new Vector3(0, 0, aValue));
    }

}
