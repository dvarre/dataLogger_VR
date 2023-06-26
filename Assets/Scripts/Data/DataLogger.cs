using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class DataLogger : MonoBehaviour
{
    private InputDevice rightController;
    private InputDevice leftController;
    private InputDevice headMountedDisplay;
    private OculusLogging oculusLogging;
    private bool isList1ToWrite = true;

    [SerializeField]
    private string path;

    [SerializeField]
    private string fileName;

    CSVWriter csvWriter;
    private float timePassed;

    [SerializeField]
    private float timeBeforeLog;

    /*** Left Controller ***/
    [SerializeField]
    private bool leftPrimary2DAxis;
    [SerializeField]
    private bool leftGrip;
    [SerializeField]
    private bool leftGripButton;
    [SerializeField]
    private bool leftMenuButton;
    [SerializeField]
    private bool leftPrimaryButton;
    [SerializeField]
    private bool leftPrimaryTouch;
    [SerializeField]
    private bool leftSecondaryButton;
    [SerializeField]
    private bool leftSecondaryTouch;
    [SerializeField]
    private bool leftTrigger;
    [SerializeField]
    private bool leftTriggerButton;
    [SerializeField]
    private bool leftPrimary2DAxisClick;
    [SerializeField]
    private bool leftPrimary2DAxisTouch;
    [SerializeField]
    private bool leftIsTracked;
    [SerializeField]
    private bool leftTrackingState;
    [SerializeField]
    private bool leftDevicePosition;
    [SerializeField]
    private bool leftDeviceRotation;
    [SerializeField]
    private bool leftDeviceVelocity;
    [SerializeField]
    private bool leftDeviceAngularVelocity;


    /*** Right controller ***/
    [SerializeField]
    private bool rightPrimary2DAxis;
    [SerializeField]
    private bool rightGrip;
    [SerializeField]
    private bool rightGripButton;
    [SerializeField]
    private bool rightMenuButton;
    [SerializeField]
    private bool rightPrimaryButton;
    [SerializeField]
    private bool rightPrimaryTouch;
    [SerializeField]
    private bool rightSecondaryButton;
    [SerializeField]
    private bool rightSecondaryTouch;
    [SerializeField]
    private bool rightTrigger;
    [SerializeField]
    private bool rightTriggerButton;
    [SerializeField]
    private bool rightPrimary2DAxisClick;
    [SerializeField]
    private bool rightPrimary2DAxisTouch;
    [SerializeField]
    private bool rightIsTracked;
    [SerializeField]
    private bool rightTrackingState;
    [SerializeField]
    private bool rightDevicePosition;
    [SerializeField]
    private bool rightDeviceRotation;
    [SerializeField]
    private bool rightDeviceVelocity;
    [SerializeField]
    private bool rightDeviceAngularVelocity;

    /*** Headset ***/
    [SerializeField]
    private bool isUserPresence;
    [SerializeField]
    private bool isHeadSetTracked;
    [SerializeField]
    private bool isHeadSetTrackingState;
    [SerializeField]
    private bool isHeadSetDevicePosition;
    [SerializeField]
    private bool isHeadSetDeviceRotation;
    [SerializeField]
    private bool isHeadSetDeviceVelocity;
    [SerializeField]
    private bool isHeadSetDeviceAngularVelocity;
    [SerializeField]
    private bool isHeadSetDeviceAcceleration;
    [SerializeField]
    private bool isHeadSetDeviceAngularAcceleration;
    [SerializeField]
    private bool isHeadSetLeftEyePosition;
    [SerializeField]
    private bool isHeadSetLeftEyeRotation;
    [SerializeField]
    private bool isHeadSetLeftEyeVelocity;
    [SerializeField]
    private bool isHeadSetLeftEyeAngularVelocity;
    [SerializeField]
    private bool isHeadSetLeftEyeAcceleration;
    [SerializeField]
    private bool isHeadSetLeftEyeAngularAcceleration;
    [SerializeField]
    private bool isHeadSetRightEyePosition;
    [SerializeField]
    private bool isHeadSetRightEyeRotation;
    [SerializeField]
    private bool isHeadSetRightEyeVelocity;
    [SerializeField]
    private bool isHeadSetRightEyeAngularVelocity;
    [SerializeField]
    private bool isHeadSetRightEyeAcceleration;
    [SerializeField]
    private bool isHeadSetRightEyeAngularAcceleration;
    [SerializeField]
    private bool isHeadSetCenterEyePosition;
    [SerializeField]
    private bool isHeadSetCenterEyeRotation;
    [SerializeField]
    private bool isHeadSetCenterEyeVelocity;
    [SerializeField]
    private bool isHeadSetCenterEyeAngularVelocity;
    [SerializeField]
    private bool isHeadSetCenterEyeAcceleration;
    [SerializeField]
    private bool isHeadSetCenterEyeAngularAcceleration;
    [SerializeField]
    private bool isHeadSetBatterieLevel;
    [SerializeField]
    private bool isHeadSetColorCameraAcceleration;
    [SerializeField]
    private bool isHeadSetColorCameraAngularAcceleration;
    [SerializeField]
    private bool isHeadSetColorCameraAngularVelocity;
    [SerializeField]
    private bool isHeadSetColorCameraPosition;
    [SerializeField]
    private bool isHeadSetColorCameraRotation;
    [SerializeField]
    private bool isHeadSetColorCameraVelocity;
    [SerializeField]
    private bool isHeadSetFixationPoint;
    [SerializeField]
    private bool isHeadSetLeftEyeOpenAmount;
    [SerializeField]
    private bool isHeadSetRightEyeOpenAmount;
    [SerializeField]
    private bool isLeftFixationPoint;
    [SerializeField]
    private bool isRightFixationPoint;



    private void Start()
    {
        if (this.timeBeforeLog < 0f)
        {
            Debug.LogError(" Time between each logs in .csv file need to be bigger than 0 ");
        }
        this.timePassed = 0.0f;
        csvWriter = new CSVWriter();
        csvWriter.SetPath(path + "/" + fileName + System.DateTime.Now.ToString("yyyyMMddHHmm") + ".csv");
        csvWriter.WriteHeaderCSV();

        oculusLogging = new OculusLogging();
        
        oculusLogging.SetLeftControllerBoolValues(
            leftPrimary2DAxis,
            leftGrip,
            leftGripButton,
            leftMenuButton,
            leftPrimaryButton,
            leftPrimaryTouch,
            leftSecondaryButton,
            leftSecondaryTouch,
            leftTrigger,
            leftTriggerButton,
            leftPrimary2DAxisClick,
            leftPrimary2DAxisTouch,
            leftIsTracked,
            leftTrackingState,
            leftDevicePosition,
            leftDeviceRotation,
            leftDeviceVelocity,
            leftDeviceAngularVelocity);


        oculusLogging.SetRightControllerBoolValues(
             rightPrimary2DAxis,
             rightGrip,
             rightGripButton,
             rightMenuButton,
             rightPrimaryButton,
             rightPrimaryTouch,
             rightSecondaryButton,
             rightSecondaryTouch,
             rightTrigger,
             rightTriggerButton,
             rightPrimary2DAxisClick,
             rightPrimary2DAxisTouch,
             rightIsTracked,
             rightTrackingState,
             rightDevicePosition,
             rightDeviceRotation,
             rightDeviceVelocity,
             rightDeviceAngularVelocity);

        oculusLogging.SetHeadsetBoolValues(
            isUserPresence,
            isHeadSetTracked,
            isHeadSetTrackingState,
            isHeadSetDevicePosition,
            isHeadSetDeviceRotation,
            isHeadSetDeviceVelocity,
            isHeadSetDeviceAngularVelocity,
            isHeadSetDeviceAcceleration,
            isHeadSetDeviceAngularAcceleration,
            isHeadSetLeftEyePosition,
            isHeadSetLeftEyeRotation,
            isHeadSetLeftEyeVelocity,
            isHeadSetLeftEyeAngularVelocity,
            isHeadSetLeftEyeAcceleration,
            isHeadSetLeftEyeAngularAcceleration,
            isHeadSetRightEyePosition,
            isHeadSetRightEyeRotation,
            isHeadSetRightEyeVelocity,
            isHeadSetRightEyeAngularVelocity,
            isHeadSetRightEyeAcceleration,
            isHeadSetRightEyeAngularAcceleration,
            isHeadSetCenterEyePosition,
            isHeadSetCenterEyeRotation,
            isHeadSetCenterEyeVelocity,
            isHeadSetCenterEyeAngularVelocity,
            isHeadSetCenterEyeAcceleration,
            isHeadSetCenterEyeAngularAcceleration,
            isHeadSetBatterieLevel,
            isHeadSetColorCameraAcceleration,
            isHeadSetColorCameraAngularAcceleration,
            isHeadSetColorCameraAngularVelocity,
            isHeadSetColorCameraPosition,
            isHeadSetColorCameraRotation,
            isHeadSetColorCameraVelocity,
            isLeftFixationPoint,
            isRightFixationPoint);
    }

    private void Update()
    {
        System.DateTime epochStart = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);
        int cur_time = (int)(System.DateTime.UtcNow - epochStart).TotalSeconds;

        //GameObject leftEyeInteractor = GameObject.Find("LeftEyeInteractor");
        //RaycastHit leftHit;
        //Ray leftRay = new Ray(transform.position, Vector3.forward);

        //if (Physics.Raycast(leftRay, out leftHit))
        //{
        //    Debug.Log("Touché ");
        //    Debug.Log(leftHit.point);
        //}


        if (!rightController.isValid)
        {
            InitializeOculusInputs(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Right, ref rightController);
        }
        if (!leftController.isValid)
        {
            InitializeOculusInputs(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Left, ref leftController);
        }
        if (!headMountedDisplay.isValid)
        {
            InitializeOculusInputs(InputDeviceCharacteristics.HeadMounted, ref headMountedDisplay);
        }

        timePassed += Time.deltaTime;
        if (timePassed > timeBeforeLog)
        {
            timePassed = 0f;

            if (isList1ToWrite)
            {
                isList1ToWrite = false;
                csvWriter.WriteDataCSV(oculusLogging.datasList1);
                oculusLogging.ClearDatasList1();
            }
            else
            {
                isList1ToWrite = true;
                csvWriter.WriteDataCSV(oculusLogging.datasList2);
                oculusLogging.ClearDatasList2();
            }
        }
        else
        {
            if (isList1ToWrite)
            {
                oculusLogging.GetData(leftController, rightController, headMountedDisplay, 1);
            }
            else
            {
                oculusLogging.GetData(leftController, rightController, headMountedDisplay, 2);
            }
        }
    }

    private void InitializeOculusInputs(InputDeviceCharacteristics inputCharacteristics, ref InputDevice inputDevice)
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(inputCharacteristics, devices);

        if (devices.Count > 0)
        {
            inputDevice = devices[0];
        }
    }
}
