using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

[RequireComponent(typeof(DataLogger))]
public class OculusLogging
{

    public List<string[]> datasList1 = new List<string[]>();
    public List<string[]> datasList2 = new List<string[]>();
    public string[] datasToLog = new string[73];
    private LogOnSee eyesFixationPoints = new LogOnSee();

    //On liste les capteurs pour l'oculus
    /*** Left controller ***/
    private bool leftPrimary2DAxis;
    private bool leftGrip;
    private bool leftGripButton;
    private bool leftMenuButton;
    private bool leftPrimaryButton;
    private bool leftPrimaryTouch;
    private bool leftSecondaryButton;
    private bool leftSecondaryTouch;
    private bool leftTrigger;
    private bool leftTriggerButton;
    private bool leftPrimary2DAxisClick;
    private bool leftPrimary2DAxisTouch;
    private bool leftIsTracked;
    private bool leftTrackingState;
    private bool leftDevicePosition;
    private bool leftDeviceRotation;
    private bool leftDeviceVelocity;
    private bool leftDeviceAngularVelocity;

    /*** Right controller ***/

    private bool rightPrimary2DAxis;
    private bool rightGrip;
    private bool rightGripButton;
    private bool rightMenuButton;
    private bool rightPrimaryButton;
    private bool rightPrimaryTouch;
    private bool rightSecondaryButton;
    private bool rightSecondaryTouch;
    private bool rightTrigger;
    private bool rightTriggerButton;
    private bool rightPrimary2DAxisClick;
    private bool rightPrimary2DAxisTouch;
    private bool rightIsTracked;
    private bool rightTrackingState;
    private bool rightDevicePosition;
    private bool rightDeviceRotation;
    private bool rightDeviceVelocity;
    private bool rightDeviceAngularVelocity;

    /*** Headset ***/
    private bool isUserPresence;
    private bool isHeadSetTracked;
    private bool isHeadSetTrackingState;
    private bool isHeadSetDevicePosition;
    private bool isHeadSetDeviceRotation;
    private bool isHeadSetDeviceVelocity;
    private bool isHeadSetDeviceAngularVelocity;
    private bool isHeadSetDeviceAcceleration;
    private bool isHeadSetDeviceAngularAcceleration;
    private bool isHeadSetLeftEyePosition;
    private bool isHeadSetLeftEyeRotation;
    private bool isHeadSetLeftEyeVelocity;
    private bool isHeadSetLeftEyeAngularVelocity;
    private bool isHeadSetLeftEyeAcceleration;
    private bool isHeadSetLeftEyeAngularAcceleration;
    private bool isHeadSetRightEyePosition;
    private bool isHeadSetRightEyeRotation;
    private bool isHeadSetRightEyeVelocity;
    private bool isHeadSetRightEyeAngularVelocity;
    private bool isHeadSetRightEyeAcceleration;
    private bool isHeadSetRightEyeAngularAcceleration;
    private bool isHeadSetCenterEyePosition;
    private bool isHeadSetCenterEyeRotation;
    private bool isHeadSetCenterEyeVelocity;
    private bool isHeadSetCenterEyeAngularVelocity;
    private bool isHeadSetCenterEyeAcceleration;
    private bool isHeadSetCenterEyeAngularAcceleration;
    private bool isHeadSetBatterieLevel;
    private bool isHeadSetColorCameraAcceleration;
    private bool isHeadSetColorCameraAngularAcceleration;
    private bool isHeadSetColorCameraAngularVelocity;
    private bool isHeadSetColorCameraPosition;
    private bool isHeadSetColorCameraRotation;
    private bool isHeadSetColorCameraVelocity;
    private bool isLeftFixationPoint;
    private bool isRightFixationPoint;

    public void SetLeftControllerBoolValues(
            bool leftPrimary2DAxis,
            bool leftGrip,
            bool leftGripButton,
            bool leftMenuButton,
            bool leftPrimaryButton,
            bool leftPrimaryTouch,
            bool leftSecondaryButton,
            bool leftSecondaryTouch,
            bool leftTrigger,
            bool leftTriggerButton,
            bool leftPrimary2DAxisClick,
            bool leftPrimary2DAxisTouch,
            bool leftIsTracked,
            bool leftTrackingState,
            bool leftDevicePosition,
            bool leftDeviceRotation,
            bool leftDeviceVelocity,
            bool leftDeviceAngularVelocity)
    {
        this.leftPrimary2DAxis = leftPrimary2DAxis;
        this.leftGrip = leftGrip;
        this.leftGripButton = leftGripButton;
        this.leftMenuButton = leftMenuButton;
        this.leftPrimaryButton = leftPrimaryButton;
        this.leftPrimaryTouch = leftPrimaryTouch;
        this.leftSecondaryButton = leftSecondaryButton;
        this.leftSecondaryTouch = leftSecondaryTouch;
        this.leftTrigger = leftTrigger;
        this.leftTriggerButton = leftTriggerButton;
        this.leftPrimary2DAxisClick = leftPrimary2DAxisClick;
        this.leftPrimary2DAxisTouch = leftPrimary2DAxisTouch;
        this.leftIsTracked = leftIsTracked;
        this.leftTrackingState = leftTrackingState;
        this.leftDevicePosition = leftDevicePosition;
        this.leftDeviceRotation = leftDeviceRotation;
        this.leftDeviceVelocity = leftDeviceVelocity;
        this.leftDeviceAngularVelocity = leftDeviceAngularVelocity;
    }

    public void SetRightControllerBoolValues(
        bool rightPrimary2DAxis,
        bool rightGrip,
        bool rightGripButton,
        bool rightMenuButton,
        bool rightPrimaryButton,
        bool rightPrimaryTouch,
        bool rightSecondaryButton,
        bool rightSecondaryTouch,
        bool rightTrigger,
        bool rightTriggerButton,
        bool rightPrimary2DAxisClick,
        bool rightPrimary2DAxisTouch,
        bool rightIsTracked,
        bool rightTrackingState,
        bool rightDevicePosition,
        bool rightDeviceRotation,
        bool rightDeviceVelocity,
        bool rightDeviceAngularVelocity)
    {
        this.rightPrimary2DAxis = rightPrimary2DAxis;
        this.rightGrip = rightGrip;
        this.rightGripButton = rightGripButton;
        this.rightMenuButton = rightMenuButton;
        this.rightPrimaryButton = rightPrimaryButton;
        this.rightPrimaryTouch = rightPrimaryTouch;
        this.rightSecondaryButton = rightSecondaryButton;
        this.rightSecondaryTouch = rightSecondaryTouch;
        this.rightTrigger = rightTrigger;
        this.rightTriggerButton = rightTriggerButton;
        this.rightPrimary2DAxisClick = rightPrimary2DAxisClick;
        this.rightPrimary2DAxisTouch = rightPrimary2DAxisTouch;
        this.rightIsTracked = rightIsTracked;
        this.rightTrackingState = rightTrackingState;
        this.rightDevicePosition = rightDevicePosition;
        this.rightDeviceRotation = rightDeviceRotation;
        this.rightDeviceVelocity = rightDeviceVelocity;
        this.rightDeviceAngularVelocity = rightDeviceAngularVelocity;
    }

    public void SetHeadsetBoolValues(
        bool isUserPresence,
        bool isHeadSetTracked,
        bool isHeadSetTrackingState,
        bool isHeadSetDevicePosition,
        bool isHeadSetDeviceRotation,
        bool isHeadSetDeviceVelocity,
        bool isHeadSetDeviceAngularVelocity,
        bool isHeadSetDeviceAcceleration,
        bool isHeadSetDeviceAngularAcceleration,
        bool isHeadSetLeftEyePosition,
        bool isHeadSetLeftEyeRotation,
        bool isHeadSetLeftEyeVelocity,
        bool isHeadSetLeftEyeAngularVelocity,
        bool isHeadSetLeftEyeAcceleration,
        bool isHeadSetLeftEyeAngularAcceleration,
        bool isHeadSetRightEyePosition,
        bool isHeadSetRightEyeRotation,
        bool isHeadSetRightEyeVelocity,
        bool isHeadSetRightEyeAngularVelocity,
        bool isHeadSetRightEyeAcceleration,
        bool isHeadSetRightEyeAngularAcceleration,
        bool isHeadSetCenterEyePosition,
        bool isHeadSetCenterEyeRotation,
        bool isHeadSetCenterEyeVelocity,
        bool isHeadSetCenterEyeAngularVelocity,
        bool isHeadSetCenterEyeAcceleration,
        bool isHeadSetCenterEyeAngularAcceleration,
        bool isHeadSetBatterieLevel,
        bool isHeadSetColorCameraAcceleration,
        bool isHeadSetColorCameraAngularAcceleration,
        bool isHeadSetColorCameraAngularVelocity,
        bool isHeadSetColorCameraPosition,
        bool isHeadSetColorCameraRotation,
        bool isHeadSetColorCameraVelocity,
        bool isLeftFixationPoint,
        bool isRightFixationPoint)
    {
        this.isUserPresence = isUserPresence;
        this.isHeadSetTracked = isHeadSetTracked;
        this.isHeadSetTrackingState = isHeadSetTrackingState;
        this.isHeadSetDevicePosition = isHeadSetDevicePosition;
        this.isHeadSetDeviceRotation = isHeadSetDeviceRotation;
        this.isHeadSetDeviceVelocity = isHeadSetDeviceVelocity;
        this.isHeadSetDeviceAngularVelocity = isHeadSetDeviceAngularVelocity;
        this.isHeadSetDeviceAcceleration = isHeadSetDeviceAcceleration;
        this.isHeadSetDeviceAngularAcceleration = isHeadSetDeviceAngularAcceleration;
        this.isHeadSetLeftEyePosition = isHeadSetLeftEyePosition;
        this.isHeadSetLeftEyeRotation = isHeadSetLeftEyeRotation;
        this.isHeadSetLeftEyeVelocity = isHeadSetLeftEyeVelocity;
        this.isHeadSetLeftEyeAngularVelocity = isHeadSetLeftEyeAngularVelocity;
        this.isHeadSetLeftEyeAcceleration = isHeadSetLeftEyeAcceleration;
        this.isHeadSetLeftEyeAngularAcceleration = isHeadSetLeftEyeAngularAcceleration;
        this.isHeadSetRightEyePosition = isHeadSetRightEyePosition;
        this.isHeadSetRightEyeRotation = isHeadSetRightEyeRotation;
        this.isHeadSetRightEyeVelocity = isHeadSetRightEyeVelocity;
        this.isHeadSetRightEyeAngularVelocity = isHeadSetRightEyeAngularVelocity;
        this.isHeadSetRightEyeAcceleration = isHeadSetRightEyeAcceleration;
        this.isHeadSetRightEyeAngularAcceleration = isHeadSetRightEyeAngularAcceleration;
        this.isHeadSetCenterEyePosition = isHeadSetCenterEyePosition;
        this.isHeadSetCenterEyeRotation = isHeadSetCenterEyeRotation;
        this.isHeadSetCenterEyeVelocity = isHeadSetCenterEyeVelocity;
        this.isHeadSetCenterEyeAngularVelocity = isHeadSetCenterEyeAngularVelocity;
        this.isHeadSetCenterEyeAcceleration = isHeadSetCenterEyeAcceleration;
        this.isHeadSetCenterEyeAngularAcceleration = isHeadSetCenterEyeAngularAcceleration;
        this.isHeadSetBatterieLevel = isHeadSetBatterieLevel;
        this.isHeadSetColorCameraAcceleration = isHeadSetColorCameraAcceleration;
        this.isHeadSetColorCameraAngularAcceleration = isHeadSetColorCameraAngularAcceleration;
        this.isHeadSetColorCameraAngularVelocity = isHeadSetColorCameraAngularVelocity;
        this.isHeadSetColorCameraPosition = isHeadSetColorCameraPosition;
        this.isHeadSetColorCameraRotation = isHeadSetColorCameraRotation;
        this.isHeadSetColorCameraVelocity = isHeadSetColorCameraVelocity;
        this.isLeftFixationPoint = isLeftFixationPoint;
        this.isRightFixationPoint = isRightFixationPoint;

}

    //On fait une fonction par materiel pour le cas où l'on utiliserait pas forcement tous les appareil
    /* Pour chaque fonction on prend les capteurs et on regarde si leur valeur est à true ou non.
     * Si c'est le cas, cela veut dire qu'on veut log la valeur et on get feature associée au capteur puis sa valeur.
     * Pour finir, on stock la valeur dans la liste
     */

    /*** Controllers ***/

    private void GetLeftControllerData(InputDevice leftController)
    {
         /*** Left Controller ***/

        if (leftPrimary2DAxis)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 leftControllerPrimary2DAxis))
            {
                this.datasToLog[1] = leftControllerPrimary2DAxis.ToString();
            }
        }

        if (leftGrip)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.grip, out System.Single leftControllerGrip))
            {
                this.datasToLog[2] = leftControllerGrip.ToString();
            }
        }

        if (leftGripButton)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.gripButton, out bool leftControllerGripButton))
            {
                if (leftControllerGripButton)
                {
                    this.datasToLog[3] = "1";
                }
                else
                {
                    this.datasToLog[3] = "0";
                }
            }
        }

        if (leftMenuButton)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.menuButton, out bool leftControllerMenuButton))
            {
                if (leftControllerMenuButton)
                {
                    this.datasToLog[4] = "1";
                }
                else
                {
                    this.datasToLog[4] = "0";
                }
            }
        }

        if (leftPrimaryButton)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.primaryButton, out bool leftControllerPrimaryButton))
            {
                if (leftControllerPrimaryButton)
                {
                    this.datasToLog[5] = "1";
                }
                else
                {
                    this.datasToLog[5] = "0";
                }
            }
        }

        if (leftPrimaryTouch)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.primaryTouch, out bool leftControllerLeftPrimaryTouch))
            {
                if (leftControllerLeftPrimaryTouch)
                {
                    this.datasToLog[6] = "1";
                }
                else
                {
                    this.datasToLog[6] = "0";
                }
            }
        }

        if (leftSecondaryButton)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool leftControllerPrimaryButton))
            {
                if (leftControllerPrimaryButton)
                {
                    this.datasToLog[7] = "1";
                }
                else
                {
                    this.datasToLog[7] = "0";
                }
            }
        }

        if (leftSecondaryTouch)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.secondaryTouch, out bool leftControllerPrimaryTouch))
            {
                if (leftControllerPrimaryTouch)
                {
                    this.datasToLog[8] = "1";
                }
                else
                {
                    this.datasToLog[8] = "0";
                }
            }
        }

        if (leftTrigger)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.trigger, out System.Single leftControllerTrigger))
            {
                this.datasToLog[9] = leftControllerTrigger.ToString();
            }
        }

        if (leftTriggerButton)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.triggerButton, out bool leftControllerTriggerButton))
            {
                if (leftControllerTriggerButton)
                {
                    this.datasToLog[10] = "1";
                }
                else
                {
                    this.datasToLog[10] = "0";
                }
            }
        }

        if (leftPrimary2DAxisClick)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out bool leftControllerPrimary2DAxisClick))
            {
                if (leftControllerPrimary2DAxisClick)
                {
                    this.datasToLog[11] = "1";
                }
                else
                {
                    this.datasToLog[11] = "0";
                }
            }
        }

        if (leftPrimary2DAxisTouch)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.primary2DAxisTouch, out bool leftControllerPrimary2DAxisTouch))
            {
                if (leftControllerPrimary2DAxisTouch)
                {
                    this.datasToLog[12] = "1";
                }
                else
                {
                    this.datasToLog[12] = "0";
                }
            }
        }

        if (leftIsTracked)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.isTracked, out bool leftControllerIsTracked))
            {
                if (leftControllerIsTracked)
                {
                    this.datasToLog[13] = "1";
                }
                else
                {
                    this.datasToLog[13] = "0";
                }
            }
        }

        if (leftTrackingState)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.trackingState, out InputTrackingState leftControllerTrackingState))
            {
                this.datasToLog[14] = leftControllerTrackingState.ToString();
            }
        }

        if (leftDevicePosition)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 leftControllerDevicePosition))
            {
                this.datasToLog[15] = leftControllerDevicePosition.ToString();
            }
        }

        if (leftDeviceRotation)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion leftControllerDeviceRotation))
            {
                this.datasToLog[16] = leftControllerDeviceRotation.ToString();
            }
        }

        if (leftDeviceVelocity)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 leftControllerDeviceVelocity))
            {
                this.datasToLog[17] = leftControllerDeviceVelocity.ToString();
            }
        }

        if (leftDeviceAngularVelocity)
        {
            if (leftController.TryGetFeatureValue(CommonUsages.deviceAngularVelocity, out Vector3 leftControllerDeviceAngularVelocity))
            {
                this.datasToLog[18] = leftControllerDeviceAngularVelocity.ToString();
            }
        }
    }

    private void GetRightControllerData(InputDevice rightController)
    {
        /*** Left Controller ***/

        if (rightPrimary2DAxis)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 rightControllerPrimary2DAxis))
            {
                this.datasToLog[19] = rightControllerPrimary2DAxis.ToString();
            }
        }

        if (rightGrip)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.grip, out System.Single rightControllerGrip))
            {
                this.datasToLog[20] = rightControllerGrip.ToString();
            }
        }

        if (rightGripButton)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.gripButton, out bool rightControllerGripButton))
            {
                if (rightControllerGripButton)
                {
                    this.datasToLog[21] = "1";
                }
                else
                {
                    this.datasToLog[21] = "0";
                }
            }
        }

        if (rightMenuButton)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.menuButton, out bool rightControllerMenuButton))
            {
                if (rightControllerMenuButton)
                {
                    this.datasToLog[22] = "1";
                }
                else
                {
                    this.datasToLog[22] = "0";
                }
            }
        }

        if (rightPrimaryButton)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool rightControllerPrimaryButton))
            {
                if (rightControllerPrimaryButton)
                {
                    this.datasToLog[23] = "1";
                }
                else
                {
                    this.datasToLog[23] = "0";
                }
            }
        }

        if (rightPrimaryTouch)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.primaryTouch, out bool rightControllerLeftPrimaryTouch))
            {
                if (rightControllerLeftPrimaryTouch)
                {
                    this.datasToLog[24] = "1";
                }
                else
                {
                    this.datasToLog[24] = "0";
                }
            }
        }

        if (rightSecondaryButton)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool rightControllerPrimaryButton))
            {
                if (rightControllerPrimaryButton)
                {
                    this.datasToLog[25] = "1";
                }
                else
                {
                    this.datasToLog[25] = "0";
                }
            }
        }

        if (rightSecondaryTouch)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.secondaryTouch, out bool rightControllerPrimaryTouch))
            {
                if (rightControllerPrimaryTouch)
                {
                    this.datasToLog[26] = "1";
                }
                else
                {
                    this.datasToLog[26] = "0";
                }
            }
        }

        if (rightTrigger)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.trigger, out System.Single rightControllerTrigger))
            {
                this.datasToLog[27] = rightControllerTrigger.ToString();
            }
        }

        if (rightTriggerButton)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.triggerButton, out bool rightControllerTriggerButton))
            {
                if (rightControllerTriggerButton)
                {
                    this.datasToLog[28] = "1";
                }
                else
                {
                    this.datasToLog[28] = "0";
                }
            }
        }

        if (rightPrimary2DAxisClick)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out bool rightControllerPrimary2DAxisClick))
            {
                if (rightControllerPrimary2DAxisClick)
                {
                    this.datasToLog[29] = "1";
                }
                else
                {
                    this.datasToLog[29] = "0";
                }
            }
        }

        if (rightPrimary2DAxisTouch)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.primary2DAxisTouch, out bool rightControllerPrimary2DAxisTouch))
            {
                if (rightControllerPrimary2DAxisTouch)
                {
                    this.datasToLog[30] = "1";
                }
                else
                {
                    this.datasToLog[30] = "0";
                }
            }
        }

        if (rightIsTracked)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.isTracked, out bool rightControllerIsTracked))
            {
                if (rightControllerIsTracked)
                {
                    this.datasToLog[31] = "1";
                }
                else
                {
                    this.datasToLog[31] = "0";
                }
            }
        }

        if (rightTrackingState)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.trackingState, out InputTrackingState rightControllerTrackingState))
            {
                this.datasToLog[32] = rightControllerTrackingState.ToString();
            }
        }

        if (rightDevicePosition)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 rightControllerDevicePosition))
            {
                this.datasToLog[33] = rightControllerDevicePosition.ToString();
            }
        }

        if (rightDeviceRotation)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion rightControllerDeviceRotation))
            {
                this.datasToLog[34] = rightControllerDeviceRotation.ToString();
            }
        }

        if (rightDeviceVelocity)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 rightControllerDeviceVelocity))
            {
                this.datasToLog[35] = rightControllerDeviceVelocity.ToString();
            }
        }

        if (rightDeviceAngularVelocity)
        {
            if (rightController.TryGetFeatureValue(CommonUsages.deviceAngularVelocity, out Vector3 rightControllerDeviceAngularVelocity))
            {
                this.datasToLog[36] = rightControllerDeviceAngularVelocity.ToString();
            }
        }
    }

    private void GetHeadsetData(InputDevice headMountedDisplay)
    {
        if (isUserPresence)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.userPresence, out bool userPresence))
            {
                if (userPresence)
                {
                    this.datasToLog[37] = "1";
                }
                else
                {
                    this.datasToLog[37] = "0";
                }
            }
        }

        if (isHeadSetTracked)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.isTracked, out bool headsetTracked))
            {
                if (headsetTracked)
                {
                    this.datasToLog[38] = "1";
                }
                else
                {
                    this.datasToLog[38] = "0";
                }
            }
        }

        if (isHeadSetTrackingState)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.trackingState, out InputTrackingState headsetTrackingState))
            {
                this.datasToLog[39] = headsetTrackingState.ToString();
            }
        }

        if (isHeadSetDevicePosition)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 headsetDevicePosition))
            {
                this.datasToLog[40] = headsetDevicePosition.ToString();
            }
        }

        if (isHeadSetDeviceRotation)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion headsetDeviceRotation))
            {
                this.datasToLog[41] = headsetDeviceRotation.ToString();
            }
        }

        if (isHeadSetDeviceVelocity)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 headsetDeviceVelocity))
            {
                this.datasToLog[42] = headsetDeviceVelocity.ToString();
            }
        }

        if (isHeadSetDeviceAngularVelocity)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.deviceAngularVelocity, out Vector3 headsetDeviceAngularVelocity))
            {
                this.datasToLog[43] = headsetDeviceAngularVelocity.ToString();
            }
        }

        if (isHeadSetDeviceAcceleration)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.deviceAcceleration, out Vector3 headsetDeviceAcceleration))
            {
                this.datasToLog[44] = headsetDeviceAcceleration.ToString();
            }
        }

        if (isHeadSetDeviceAngularAcceleration)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.deviceAngularAcceleration, out Vector3 headsetDeviceAngularAcceleration))
            {
                this.datasToLog[45] = headsetDeviceAngularAcceleration.ToString();
            }
        }

        if (isHeadSetLeftEyePosition)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.leftEyePosition, out Vector3 headsetLeftEyePosition))
            {
                this.datasToLog[46] = headsetLeftEyePosition.ToString();
            }
        }

        if (isHeadSetLeftEyeRotation)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.leftEyeRotation, out Quaternion headsetLeftEyeRotation))
            {
                this.datasToLog[47] = headsetLeftEyeRotation.ToString();
            }
        }

        if (isHeadSetLeftEyeVelocity)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.leftEyeVelocity, out Vector3 headsetLeftEyeVelocity))
            {
                this.datasToLog[48] = headsetLeftEyeVelocity.ToString();
            }
        }

        if (isHeadSetLeftEyeAngularVelocity)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.leftEyeAngularVelocity, out Vector3 headsetLeftEyeAngularVelocity))
            {
                this.datasToLog[49] = headsetLeftEyeAngularVelocity.ToString();
            }
        }

        if (isHeadSetLeftEyeAcceleration)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.leftEyeAcceleration, out Vector3 headsetLeftEyeAcceleration))
            {
                this.datasToLog[50] = headsetLeftEyeAcceleration.ToString();
            }
        }

        if (isHeadSetLeftEyeAngularAcceleration)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.leftEyeAngularAcceleration, out Vector3 headsetLeftEyeAngularAcceleration))
            {
                this.datasToLog[51] = headsetLeftEyeAngularAcceleration.ToString();
            }
        }

        if (isHeadSetRightEyePosition)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.rightEyePosition, out Vector3 headsetRightEyePosition))
            {
                this.datasToLog[52] = headsetRightEyePosition.ToString();
            }
        }

        if (isHeadSetRightEyeRotation)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.rightEyeRotation, out Quaternion headsetRightEyeRotation))
            {
                this.datasToLog[53] = headsetRightEyeRotation.ToString();
            }
        }

        if (isHeadSetRightEyeVelocity)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.rightEyeVelocity, out Vector3 headsetRightEyeVelocity))
            {
                this.datasToLog[54] = headsetRightEyeVelocity.ToString();
            }
        }

        if (isHeadSetRightEyeAngularVelocity)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.rightEyeAngularVelocity, out Vector3 headsetRightEyeAngularVelocity))
            {
                this.datasToLog[55] = headsetRightEyeAngularVelocity.ToString();
            }
        }

        if (isHeadSetRightEyeAcceleration)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.rightEyeAcceleration, out Vector3 headsetRightEyeAcceleration))
            {
                this.datasToLog[56] = headsetRightEyeAcceleration.ToString();
            }
        }

        if (isHeadSetRightEyeAngularAcceleration)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.rightEyeAngularAcceleration, out Vector3 headsetRightEyeAngularAcceleration))
            {
                this.datasToLog[57] = headsetRightEyeAngularAcceleration.ToString();
            }
        }

        if (isHeadSetCenterEyePosition)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.centerEyePosition, out Vector3 headsetCenterEyePosition))
            {
                this.datasToLog[58] = headsetCenterEyePosition.ToString();
            }
        }

        if (isHeadSetCenterEyeRotation)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.centerEyeRotation, out Quaternion headsetCenterEyeRotation))
            {
                this.datasToLog[59] = headsetCenterEyeRotation.ToString();
            }
        }

        if (isHeadSetCenterEyeVelocity)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.centerEyeVelocity, out Vector3 headsetCenterEyeVelocity))
            {
                this.datasToLog[60] = headsetCenterEyeVelocity.ToString();
            }
        }

        if (isHeadSetCenterEyeAngularVelocity)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.centerEyeAngularVelocity, out Vector3 headsetCenterEyeAngularVelocity))
            {
                this.datasToLog[61] = headsetCenterEyeAngularVelocity.ToString();
            }
        }

        if (isHeadSetCenterEyeAcceleration)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.centerEyeAcceleration, out Vector3 headsetCenterEyeAcceleration))
            {
                this.datasToLog[62] = headsetCenterEyeAcceleration.ToString();
            }
        }

        if (isHeadSetCenterEyeAngularAcceleration)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.centerEyeAngularAcceleration, out Vector3 headsetCenterEyeAngularAcceleration))
            {
                this.datasToLog[63] = headsetCenterEyeAngularAcceleration.ToString();
            }
        }

        if (isHeadSetBatterieLevel)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.batteryLevel, out float batteryLevel))
            {
                this.datasToLog[64] = batteryLevel.ToString();
            }
        }

        if (isHeadSetColorCameraAcceleration)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.colorCameraAcceleration, out Vector3 colorCameraAcceleration))
            {
                this.datasToLog[65] = colorCameraAcceleration.ToString();
            }
        }

        if (isHeadSetColorCameraAngularAcceleration)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.colorCameraAngularAcceleration, out Vector3 colorCameraAngularAcceleration))
            {
                this.datasToLog[66] = colorCameraAngularAcceleration.ToString();
            }
        }

        if (isHeadSetColorCameraAngularVelocity)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.colorCameraAngularVelocity, out Vector3 colorCameraAngularVelocity))
            {
                this.datasToLog[67] = colorCameraAngularVelocity.ToString();
            }
        }

        if (isHeadSetColorCameraPosition)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.colorCameraPosition, out Vector3 colorCameraPosition))
            {
                this.datasToLog[68] = colorCameraPosition.ToString();
            }
        }

        if (isHeadSetColorCameraRotation)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.colorCameraRotation, out Quaternion colorCameraRotation))
            {
                this.datasToLog[69] = colorCameraRotation.ToString();
            }
        }

        if (isHeadSetColorCameraVelocity)
        {
            if (headMountedDisplay.TryGetFeatureValue(CommonUsages.colorCameraVelocity, out Vector3 colorCameraVelocity))
            {
                this.datasToLog[70] = colorCameraVelocity.ToString();
            }
        }

        if (isLeftFixationPoint)
        {
            Debug.Log("on passe dans le if");
            GameObject leftEyeInteractor = GameObject.Find("LeftEyeInteractor");


            Vector3 leftPoint = eyesFixationPoints.GetLeftEyeFixationPoint(leftEyeInteractor);
            if (leftPoint == Vector3.zero)
            {
                this.datasToLog[71] = "null";
            }
            else
            {
                this.datasToLog[71] = leftPoint.ToString();
            }
        }

        if (isRightFixationPoint)
        {
            GameObject rightEyeInteractor = GameObject.Find("RightEyeInteractor"); ;
            Vector3 rightPoint = eyesFixationPoints.GetRightEyeFixationPoint(rightEyeInteractor);
            if (rightPoint == Vector3.zero)
            {
                this.datasToLog[72] = "null";
            }
            else
            {
                this.datasToLog[72] = rightPoint.ToString();
            }
        }

    }

    /**
     * Stock dans la bonne liste les datas a l'instant X
     **/
    public void GetData(InputDevice leftController, InputDevice rightController, InputDevice headMountedDisplay, int listWhereStockData)
    {
        DateTime epochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        int cur_time = (int)(DateTime.UtcNow - epochStart).TotalSeconds;
        this.datasToLog[0] = cur_time.ToString();

        this.GetLeftControllerData(leftController);
        this.GetRightControllerData(rightController);
        this.GetHeadsetData(headMountedDisplay);

        if(listWhereStockData == 1)
        {
            AddDataList1();
        }
        else
        {
            AddDataList2();
        }
    }

    private void AddDataList1()
    {
        this.datasList1.Add(datasToLog);
        ClearDatasToLogList();
    }

    private void AddDataList2()
    {
        this.datasList2.Add(datasToLog);
    }

    public void ClearDatasList1()
    {
        datasList1 = new List<string[]>();
    }

    public void ClearDatasList2()
    {
        datasList2 = new List<string[]>();
    }

    public void ClearDatasToLogList()
    {
        this.datasToLog = new string[73];
    }
}
