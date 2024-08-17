using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SelectionController : MonoBehaviour
{
    public XRController leftController;
    public XRController rightController;
    public InputHelpers.Button teleportRayButton;
    public float activationThreshold = 0.1f;

    private XRInteractorLineVisual rightRay;

    private XRInteractorLineVisual leftRay;



    // Start is called before the first frame update
    void Start()
    {
        leftRay = leftController.gameObject.GetComponent<XRInteractorLineVisual>();

        rightRay = rightController.gameObject.GetComponent<XRInteractorLineVisual>();

    }

    // Update is called once per frame
    void Update()
    {
        bool leftIsPressed = CheckIfButtonDown(leftController);
        leftRay.enabled = leftIsPressed;

        bool rightIsPressed = CheckIfButtonDown(rightController);
        rightRay.enabled = rightIsPressed;

    }

    public bool CheckIfButtonDown(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportRayButton, out bool isPressed, activationThreshold);
        return isPressed;
    }


}
