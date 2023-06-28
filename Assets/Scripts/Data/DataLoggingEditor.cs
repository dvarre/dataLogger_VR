using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DataLogger))]

public class DataLoggingEditor : Editor
{
    private int optionSelected = -1;
    private string[] optionsList = { "Oculus", "Polar H10" }; // Liste des appareils

    private int optionOculusSelected = -1;
    private string[] optionsOculusList = { "Headset", "Left controller", "Right controller" }; //Listes des materiels de l'oculus

    SerializedProperty path;
    SerializedProperty fileName;
    SerializedProperty timeBeforeLog;

    /*** LeftController ***/
    SerializedProperty leftPrimary2DAxis;
    SerializedProperty leftGrip;
    SerializedProperty leftGripButton;
    SerializedProperty leftMenuButton;
    SerializedProperty leftPrimaryButton;
    SerializedProperty leftPrimaryTouch;
    SerializedProperty leftSecondaryButton;
    SerializedProperty leftSecondaryTouch;
    SerializedProperty leftTrigger;
    SerializedProperty leftTriggerButton;
    SerializedProperty leftPrimary2DAxisClick;
    SerializedProperty leftPrimary2DAxisTouch;
    SerializedProperty leftIsTracked;
    SerializedProperty leftTrackingState;
    SerializedProperty leftDevicePosition;
    SerializedProperty leftDeviceRotation;
    SerializedProperty leftDeviceVelocity;
    SerializedProperty leftDeviceAngularVelocity;

    /*** RightController ***/
    SerializedProperty rightPrimary2DAxis;
    SerializedProperty rightGrip;
    SerializedProperty rightGripButton;
    SerializedProperty rightMenuButton;
    SerializedProperty rightPrimaryButton;
    SerializedProperty rightPrimaryTouch;
    SerializedProperty rightSecondaryButton;
    SerializedProperty rightSecondaryTouch;
    SerializedProperty rightTrigger;
    SerializedProperty rightTriggerButton;
    SerializedProperty rightPrimary2DAxisClick;
    SerializedProperty rightPrimary2DAxisTouch;
    SerializedProperty rightIsTracked;
    SerializedProperty rightTrackingState;
    SerializedProperty rightDevicePosition;
    SerializedProperty rightDeviceRotation;
    SerializedProperty rightDeviceVelocity;
    SerializedProperty rightDeviceAngularVelocity;

    /*** Headset ***/
    SerializedProperty isUserPresence;
    SerializedProperty isHeadSetTracked;
    SerializedProperty isHeadSetTrackingState;
    SerializedProperty isHeadSetDevicePosition;
    SerializedProperty isHeadSetDeviceRotation;
    SerializedProperty isHeadSetDeviceVelocity;
    SerializedProperty isHeadSetDeviceAngularVelocity;
    SerializedProperty isHeadSetDeviceAcceleration;
    SerializedProperty isHeadSetDeviceAngularAcceleration;
    SerializedProperty isHeadSetLeftEyePosition;
    SerializedProperty isHeadSetLeftEyeRotation;
    SerializedProperty isHeadSetLeftEyeVelocity;
    SerializedProperty isHeadSetLeftEyeAngularVelocity;
    SerializedProperty isHeadSetLeftEyeAcceleration;
    SerializedProperty isHeadSetLeftEyeAngularAcceleration;
    SerializedProperty isHeadSetRightEyePosition;
    SerializedProperty isHeadSetRightEyeRotation;
    SerializedProperty isHeadSetRightEyeVelocity;
    SerializedProperty isHeadSetRightEyeAngularVelocity;
    SerializedProperty isHeadSetRightEyeAcceleration;
    SerializedProperty isHeadSetRightEyeAngularAcceleration;
    SerializedProperty isHeadSetCenterEyePosition;
    SerializedProperty isHeadSetCenterEyeRotation;
    SerializedProperty isHeadSetCenterEyeVelocity;
    SerializedProperty isHeadSetCenterEyeAngularVelocity;
    SerializedProperty isHeadSetCenterEyeAcceleration;
    SerializedProperty isHeadSetCenterEyeAngularAcceleration;
    SerializedProperty isHeadSetBatterieLevel;
    SerializedProperty isHeadSetColorCameraAcceleration;
    SerializedProperty isHeadSetColorCameraAngularAcceleration;
    SerializedProperty isHeadSetColorCameraAngularVelocity;
    SerializedProperty isHeadSetColorCameraPosition;
    SerializedProperty isHeadSetColorCameraRotation;
    SerializedProperty isHeadSetColorCameraVelocity;
    SerializedProperty isLeftFixationPoint;
    SerializedProperty isRightFixationPoint;


    private void OnEnable()
    {
        // Permet de bind les valeurs des champs aux variables dans le code
        path = serializedObject.FindProperty("path");
        fileName = serializedObject.FindProperty("fileName");
        timeBeforeLog = serializedObject.FindProperty("timeBeforeLog");

        /*** Left controller ***/
        leftPrimary2DAxis = serializedObject.FindProperty("leftPrimary2DAxis");
        leftGrip = serializedObject.FindProperty("leftGrip");
        leftGripButton = serializedObject.FindProperty("leftGripButton");
        leftMenuButton = serializedObject.FindProperty("leftMenuButton");
        leftPrimaryButton = serializedObject.FindProperty("leftPrimaryButton");
        leftPrimaryTouch = serializedObject.FindProperty("leftPrimaryTouch");
        leftSecondaryButton = serializedObject.FindProperty("leftSecondaryButton");
        leftSecondaryTouch = serializedObject.FindProperty("leftSecondaryTouch");
        leftTrigger = serializedObject.FindProperty("leftTrigger");
        leftTriggerButton = serializedObject.FindProperty("leftTriggerButton");
        leftPrimary2DAxisClick = serializedObject.FindProperty("leftPrimary2DAxisClick");
        leftPrimary2DAxisTouch = serializedObject.FindProperty("leftPrimary2DAxisTouch");
        leftIsTracked = serializedObject.FindProperty("leftIsTracked");
        leftTrackingState = serializedObject.FindProperty("leftTrackingState");
        leftDevicePosition = serializedObject.FindProperty("leftDevicePosition");
        leftDeviceRotation = serializedObject.FindProperty("leftDeviceRotation");
        leftDeviceVelocity = serializedObject.FindProperty("leftDeviceVelocity");
        leftDeviceAngularVelocity = serializedObject.FindProperty("leftDeviceAngularVelocity");

        /*** Right controller ***/
        rightPrimary2DAxis = serializedObject.FindProperty("rightPrimary2DAxis");
        rightGrip = serializedObject.FindProperty("rightGrip");
        rightGripButton = serializedObject.FindProperty("rightGripButton");
        rightMenuButton = serializedObject.FindProperty("rightMenuButton");
        rightPrimaryButton = serializedObject.FindProperty("rightPrimaryButton");
        rightPrimaryTouch = serializedObject.FindProperty("rightPrimaryTouch");
        rightSecondaryButton = serializedObject.FindProperty("rightSecondaryButton");
        rightSecondaryTouch = serializedObject.FindProperty("rightSecondaryTouch");
        rightTrigger = serializedObject.FindProperty("rightTrigger");
        rightTriggerButton = serializedObject.FindProperty("rightTriggerButton");
        rightPrimary2DAxisClick = serializedObject.FindProperty("rightPrimary2DAxisClick");
        rightPrimary2DAxisTouch = serializedObject.FindProperty("rightPrimary2DAxisTouch");
        rightIsTracked = serializedObject.FindProperty("rightIsTracked");
        rightTrackingState = serializedObject.FindProperty("rightTrackingState");
        rightDevicePosition = serializedObject.FindProperty("rightDevicePosition");
        rightDeviceRotation = serializedObject.FindProperty("rightDeviceRotation");
        rightDeviceVelocity = serializedObject.FindProperty("rightDeviceVelocity");
        rightDeviceAngularVelocity = serializedObject.FindProperty("rightDeviceAngularVelocity");

        /*** Headset ***/

        isUserPresence = serializedObject.FindProperty("isUserPresence");
        isHeadSetTracked = serializedObject.FindProperty("isHeadSetTracked");
        isHeadSetTrackingState = serializedObject.FindProperty("isHeadSetTrackingState");
        isHeadSetDevicePosition = serializedObject.FindProperty("isHeadSetDevicePosition");
        isHeadSetDeviceRotation = serializedObject.FindProperty("isHeadSetDeviceRotation");
        isHeadSetDeviceVelocity = serializedObject.FindProperty("isHeadSetDeviceVelocity");
        isHeadSetDeviceAngularVelocity = serializedObject.FindProperty("isHeadSetDeviceAngularVelocity");
        isHeadSetDeviceAcceleration = serializedObject.FindProperty("isHeadSetDeviceAcceleration");
        isHeadSetDeviceAngularAcceleration = serializedObject.FindProperty("isHeadSetDeviceAngularAcceleration");
        isHeadSetLeftEyePosition = serializedObject.FindProperty("isHeadSetLeftEyePosition");
        isHeadSetLeftEyeRotation = serializedObject.FindProperty("isHeadSetLeftEyeRotation");
        isHeadSetLeftEyeVelocity = serializedObject.FindProperty("isHeadSetLeftEyeVelocity");
        isHeadSetLeftEyeAngularVelocity = serializedObject.FindProperty("isHeadSetLeftEyeAngularVelocity");
        isHeadSetLeftEyeAcceleration = serializedObject.FindProperty("isHeadSetLeftEyeAcceleration");
        isHeadSetLeftEyeAngularAcceleration = serializedObject.FindProperty("isHeadSetLeftEyeAngularAcceleration");
        isHeadSetRightEyePosition = serializedObject.FindProperty("isHeadSetRightEyePosition");
        isHeadSetRightEyeRotation = serializedObject.FindProperty("isHeadSetRightEyeRotation");
        isHeadSetRightEyeVelocity = serializedObject.FindProperty("isHeadSetRightEyeVelocity");
        isHeadSetRightEyeAngularVelocity = serializedObject.FindProperty("isHeadSetRightEyeAngularVelocity");
        isHeadSetRightEyeAcceleration = serializedObject.FindProperty("isHeadSetRightEyeAcceleration");
        isHeadSetRightEyeAngularAcceleration = serializedObject.FindProperty("isHeadSetRightEyeAngularAcceleration");
        isHeadSetCenterEyePosition = serializedObject.FindProperty("isHeadSetCenterEyePosition");
        isHeadSetCenterEyeRotation = serializedObject.FindProperty("isHeadSetCenterEyeRotation");
        isHeadSetCenterEyeVelocity = serializedObject.FindProperty("isHeadSetCenterEyeVelocity");
        isHeadSetCenterEyeAngularVelocity = serializedObject.FindProperty("isHeadSetCenterEyeAngularVelocity");
        isHeadSetCenterEyeAcceleration = serializedObject.FindProperty("isHeadSetCenterEyeAcceleration");
        isHeadSetCenterEyeAngularAcceleration = serializedObject.FindProperty("isHeadSetCenterEyeAngularAcceleration");
        isHeadSetBatterieLevel = serializedObject.FindProperty("isHeadSetBatterieLevel");
        isHeadSetColorCameraAcceleration = serializedObject.FindProperty("isHeadSetColorCameraAcceleration");
        isHeadSetColorCameraAngularAcceleration = serializedObject.FindProperty("isHeadSetColorCameraAngularAcceleration");
        isHeadSetColorCameraAngularVelocity = serializedObject.FindProperty("isHeadSetColorCameraAngularVelocity");
        isHeadSetColorCameraPosition = serializedObject.FindProperty("isHeadSetColorCameraPosition");
        isHeadSetColorCameraRotation = serializedObject.FindProperty("isHeadSetColorCameraRotation");
        isHeadSetColorCameraVelocity = serializedObject.FindProperty("isHeadSetColorCameraVelocity");
        isLeftFixationPoint = serializedObject.FindProperty("isLeftFixationPoint");
        isRightFixationPoint = serializedObject.FindProperty("isRightFixationPoint");
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.PropertyField(path, new GUIContent("Path of logs"));
        EditorGUILayout.PropertyField(fileName, new GUIContent("Name of csv file"));
        EditorGUILayout.PropertyField(timeBeforeLog, new GUIContent("Time in sec between each logs writte in .CSV file"));
        EditorGUILayout.BeginVertical();
        optionSelected = GUILayout.Toolbar(optionSelected, optionsList);
        EditorGUILayout.EndVertical();

        
        // On fonction de l'onglet choisit, on affiche les caracteristiques des materiels
        if (optionSelected >= 0 && optionSelected < optionsList.Length)
        {
            switch (optionsList[optionSelected])
            {
                case "Oculus":
                    Oculus();
                    break;
                case "Polar H10":
                    PolarH10();
                    break;
            }
        }

        serializedObject.ApplyModifiedProperties();
    }

    private void Oculus()
    {
        EditorGUILayout.BeginVertical();
        optionOculusSelected = GUILayout.Toolbar(optionOculusSelected, optionsOculusList);
        EditorGUILayout.EndVertical();

        // En fonction de l'onglet selectionne, on affiche les capteurs voulus
        if (optionOculusSelected >= 0 && optionOculusSelected < optionsOculusList.Length)
        {
            switch (optionsOculusList[optionOculusSelected])
            {
                case "Headset":
                    OculusHeadset();
                    break;
                case "Left controller":
                    OculusLeftController();
                    break;
                case "Right controller":
                    OculusRightController();
                    break;
            }
        }
    }

    private void OculusHeadset()
    {
        EditorGUILayout.LabelField("Headset", EditorStyles.boldLabel);

        EditorGUILayout.PropertyField(isUserPresence, new GUIContent("User presence"));
        EditorGUILayout.PropertyField(isHeadSetTracked, new GUIContent("Is tracked"));
        EditorGUILayout.PropertyField(isHeadSetTrackingState, new GUIContent("Tracking state"));
        EditorGUILayout.PropertyField(isHeadSetDevicePosition, new GUIContent("Device position"));
        EditorGUILayout.PropertyField(isHeadSetDeviceRotation, new GUIContent("Device rotation"));
        EditorGUILayout.PropertyField(isHeadSetDeviceVelocity, new GUIContent("Device velocity"));
        EditorGUILayout.PropertyField(isHeadSetDeviceAngularVelocity, new GUIContent("Device angular velocity"));
        EditorGUILayout.PropertyField(isHeadSetDeviceAcceleration, new GUIContent("Device acceleration"));
        EditorGUILayout.PropertyField(isHeadSetDeviceAngularAcceleration, new GUIContent("Device angular acceleration"));
        EditorGUILayout.PropertyField(isHeadSetLeftEyePosition, new GUIContent("Left eye position"));
        EditorGUILayout.PropertyField(isHeadSetLeftEyeRotation, new GUIContent("Left eye rotation"));
        EditorGUILayout.PropertyField(isHeadSetLeftEyeVelocity, new GUIContent("Left eye velocity"));
        EditorGUILayout.PropertyField(isHeadSetLeftEyeAngularVelocity, new GUIContent("Left eye angular velocity"));
        EditorGUILayout.PropertyField(isHeadSetLeftEyeAcceleration, new GUIContent("Left eye acceleration"));
        EditorGUILayout.PropertyField(isHeadSetLeftEyeAngularAcceleration, new GUIContent("Left eye angular acceleration"));
        EditorGUILayout.PropertyField(isHeadSetRightEyePosition, new GUIContent("Right eye position"));
        EditorGUILayout.PropertyField(isHeadSetRightEyeRotation, new GUIContent("Right eye rotation"));
        EditorGUILayout.PropertyField(isHeadSetRightEyeVelocity, new GUIContent("Right eye velocity"));
        EditorGUILayout.PropertyField(isHeadSetRightEyeAngularVelocity, new GUIContent("Right eye angular velocity"));
        EditorGUILayout.PropertyField(isHeadSetRightEyeAcceleration, new GUIContent("Right eye acceleration"));
        EditorGUILayout.PropertyField(isHeadSetRightEyeAngularAcceleration, new GUIContent("Right eye angular acceleration"));
        EditorGUILayout.PropertyField(isHeadSetCenterEyePosition, new GUIContent("Center eye position"));
        EditorGUILayout.PropertyField(isHeadSetCenterEyeRotation, new GUIContent("Center eye rotation"));
        EditorGUILayout.PropertyField(isHeadSetCenterEyeVelocity, new GUIContent("Center eye velocity"));
        EditorGUILayout.PropertyField(isHeadSetCenterEyeAngularVelocity, new GUIContent("Center eye angular velocity"));
        EditorGUILayout.PropertyField(isHeadSetCenterEyeAcceleration, new GUIContent("Ceneter eye acceleration"));
        EditorGUILayout.PropertyField(isHeadSetCenterEyeAngularAcceleration, new GUIContent("Center eye angular acceleration"));
        EditorGUILayout.PropertyField(isHeadSetBatterieLevel, new GUIContent("Battery level"));
        EditorGUILayout.PropertyField(isHeadSetColorCameraAcceleration, new GUIContent("Color camera acceleration"));
        EditorGUILayout.PropertyField(isHeadSetColorCameraAngularAcceleration, new GUIContent("Color camera angular acceleration"));
        EditorGUILayout.PropertyField(isHeadSetColorCameraAngularVelocity, new GUIContent("Color camera angular velocity"));
        EditorGUILayout.PropertyField(isHeadSetColorCameraPosition, new GUIContent("Color camera position"));
        EditorGUILayout.PropertyField(isHeadSetColorCameraRotation, new GUIContent("Color camera rotation"));
        EditorGUILayout.PropertyField(isHeadSetColorCameraVelocity, new GUIContent("Color camera velocity"));
        EditorGUILayout.PropertyField(isLeftFixationPoint, new GUIContent("Get the point on a gameObject that the player look with is left eye "));
        EditorGUILayout.PropertyField(isRightFixationPoint, new GUIContent("Get the point on a gameObject that the player look with is right eye"));
    }

    private void OculusLeftController()
    {
        EditorGUILayout.LabelField("Left controller", EditorStyles.boldLabel);

        EditorGUILayout.PropertyField(leftPrimary2DAxis, new GUIContent("Left primary 2D axis"));
        EditorGUILayout.PropertyField(leftGrip, new GUIContent("Left grip"));
        EditorGUILayout.PropertyField(leftGripButton, new GUIContent("Left grip button"));
        EditorGUILayout.PropertyField(leftMenuButton, new GUIContent("Left menu button"));
        EditorGUILayout.PropertyField(leftPrimaryButton, new GUIContent("Left primary button"));
        EditorGUILayout.PropertyField(leftPrimaryTouch, new GUIContent("Left primary touch"));
        EditorGUILayout.PropertyField(leftSecondaryButton, new GUIContent("Left secondary button"));
        EditorGUILayout.PropertyField(leftSecondaryTouch, new GUIContent("Left secondary touch"));
        EditorGUILayout.PropertyField(leftTrigger, new GUIContent("Left trigger"));
        EditorGUILayout.PropertyField(leftTriggerButton, new GUIContent("Left trigger button"));
        EditorGUILayout.PropertyField(leftPrimary2DAxisClick, new GUIContent("Left primary 2D axis click"));
        EditorGUILayout.PropertyField(leftPrimary2DAxisTouch, new GUIContent("Left primary 2D axis touch"));
        EditorGUILayout.PropertyField(leftIsTracked, new GUIContent("Left is tacked"));
        EditorGUILayout.PropertyField(leftTrackingState, new GUIContent("Left tracking state"));
        EditorGUILayout.PropertyField(leftDevicePosition, new GUIContent("Left device position"));
        EditorGUILayout.PropertyField(leftDeviceRotation, new GUIContent("Left device rotation"));
        EditorGUILayout.PropertyField(leftDeviceVelocity, new GUIContent("Left device velocity"));
        EditorGUILayout.PropertyField(leftDeviceAngularVelocity, new GUIContent("Left device angular velocity"));

    }

    private void OculusRightController()
    {
        EditorGUILayout.LabelField("Right controller", EditorStyles.boldLabel);

        EditorGUILayout.PropertyField(rightPrimary2DAxis, new GUIContent("Right primary 2D axis"));
        EditorGUILayout.PropertyField(rightGrip, new GUIContent("Right grip"));
        EditorGUILayout.PropertyField(rightGripButton, new GUIContent("Right grip button"));
        EditorGUILayout.PropertyField(rightMenuButton, new GUIContent("Right menu button"));
        EditorGUILayout.PropertyField(rightPrimaryButton, new GUIContent("Right primary button"));
        EditorGUILayout.PropertyField(rightPrimaryTouch, new GUIContent("Right primary touch"));
        EditorGUILayout.PropertyField(rightSecondaryButton, new GUIContent("Right secondary button"));
        EditorGUILayout.PropertyField(rightSecondaryTouch, new GUIContent("Right secondary touch"));
        EditorGUILayout.PropertyField(rightTrigger, new GUIContent("Right trigger"));
        EditorGUILayout.PropertyField(rightTriggerButton, new GUIContent("Right trigger button"));
        EditorGUILayout.PropertyField(rightPrimary2DAxisClick, new GUIContent("Right primary 2D axis click"));
        EditorGUILayout.PropertyField(rightPrimary2DAxisTouch, new GUIContent("Right primary 2D axis touch"));
        EditorGUILayout.PropertyField(rightIsTracked, new GUIContent("Right is tacked"));
        EditorGUILayout.PropertyField(rightTrackingState, new GUIContent("Right tracking state"));
        EditorGUILayout.PropertyField(rightDevicePosition, new GUIContent("Right device position"));
        EditorGUILayout.PropertyField(rightDeviceRotation, new GUIContent("Right device rotation"));
        EditorGUILayout.PropertyField(rightDeviceVelocity, new GUIContent("Right device velocity"));
        EditorGUILayout.PropertyField(rightDeviceAngularVelocity, new GUIContent("Right device angular velocity"));

    }

    private void PolarH10()
    {
        EditorGUILayout.HelpBox("PolarH10", MessageType.Info);
    }

}
