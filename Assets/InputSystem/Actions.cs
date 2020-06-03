// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/Actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Actions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Actions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Actions"",
    ""maps"": [
        {
            ""name"": ""CharacterBase"",
            ""id"": ""dc3888fb-3c7f-47ad-9bc2-f52a61fd617d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""634b4bb7-c28a-4db9-b1de-676bc64ccdb9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""e2645b74-5268-40c0-af1d-4b36feb39c1f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""201a1f80-1728-4409-9037-05c5b17c8d84"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Defend"",
                    ""type"": ""Button"",
                    ""id"": ""0d9b6463-405e-4cfd-990a-1ff33ee1e56b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""804478b7-996a-4524-bd70-12f925519ba4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""b635c4d9-8958-48d0-b82a-8ec72ad09901"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""9d3a26df-21cb-45f3-8353-6a1031bc68ec"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""26bd535e-3784-47b5-9715-affffbf72760"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a7ee821a-cbed-42f3-83a9-27703caccd23"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""854089f7-b4e5-49c9-83ee-19273fb9ca6a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""77efe1b8-aae3-400c-9f3e-b61b2e88ec70"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD Keys"",
                    ""id"": ""158e2823-a059-4b20-a8c0-12e7ec0015fd"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f8c1b467-f6b3-4d54-9c42-1977118b1809"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4105be09-37ce-43a6-b1ae-0020556f44a4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d4b543fc-e44e-480e-af8a-e3d301203372"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3fb0c061-7cda-4b6b-87c5-701825a17044"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Joystick"",
                    ""id"": ""82b2566f-04e4-4562-b0aa-71d00220a9af"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8444a0c9-59c0-406f-b7b7-ab7f61d3a755"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dc94f046-fc46-42b4-be48-c0903345a1cc"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a12ba170-d75c-4cb9-9d09-a33975f05428"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ae635a3b-215e-46b3-93e3-dc68c2519ecc"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a35bcf17-555f-444a-a602-c1e89d63611b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""528aee76-b9ff-476d-a232-5b256fab01e8"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98493757-46fb-44ba-b6d4-06177fb2751d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Defend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb9a3c0e-e5f4-4ad5-9bc9-c3b1ae78043f"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Defend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcfd3f19-fd02-493d-bfcf-8bb1fc8ccf0d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d415b808-b834-4ca2-8d8a-76b3bbee3447"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea1f969c-1dfb-470a-94df-87352c5d795e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f3d1b48-ddbf-412d-96e7-3db762bbb8f3"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Right Joystick"",
                    ""id"": ""615ff9ad-efad-4727-8ee2-97c2f32333e4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""30cd1aac-b2e7-4fb1-93da-766d4042d981"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""3b783536-a3f6-4c72-a818-51b5129f7e67"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""4bfd56d8-bcd0-4a0e-85ed-a2fa7632a6a6"",
                    ""path"": ""<XInputController>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""e68cfe60-f6ad-4982-bacc-31c7cb6f30ba"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8f43586b-94ee-4784-a575-d5173f49efb1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ThirdPerson"",
            ""id"": ""7b30dabf-b6c4-46ff-8ed9-aa08cd144eac"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""22f56d83-1405-4cfc-b04b-b312810419b4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""47a1f4e1-57b9-43f1-9754-136ccbe76f9f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""1c49c170-96ed-4e0f-9612-5c7de4f8ad84"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Defend"",
                    ""type"": ""Button"",
                    ""id"": ""62cb7821-0200-47f1-99c6-2f732ede27e9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""aad60e6d-5be6-4a28-a745-1b822092ec35"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""b6881cba-b96e-4802-b330-85309d7d0004"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim Or Target"",
                    ""type"": ""Button"",
                    ""id"": ""0310713e-3c74-4830-a46b-4f424eaceb1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""ResetCamera"",
                    ""type"": ""Value"",
                    ""id"": ""9c8ef185-1683-4721-9f9e-b4ace91729dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""589b7384-4302-4cfc-ad3c-72524615a6e8"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ef42c370-3971-474b-b16b-15bdb1d24158"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""681710d8-efec-4175-bd5b-2378ade52835"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cb3f3218-699f-40df-ae78-826c85c71c66"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9dc96e78-8c05-46fe-9e8b-bcf961f4b003"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD Keys"",
                    ""id"": ""989cb55e-a811-4f6c-af9d-40a688b19b79"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2a86de40-ea67-4400-96ce-3d46c6f66346"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""56d63688-f135-4908-b6d2-b126343906e7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""44b7099e-52ad-4cf5-97a8-2c2737a6f989"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""db6a4d36-b193-4792-967a-e43147e29a21"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Joystick"",
                    ""id"": ""976e522d-4ee8-4b99-a6f7-308dba8dab69"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""99616f33-1cf8-4ede-8e83-ffc8968d62c8"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8bf48d4d-5935-467a-a0c6-7652e87289d6"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""100411fa-6555-4870-8353-2957360e5466"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""06496432-81c6-40d8-bbcf-d0d56b1a53a6"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""af0f2dbf-2b02-4480-ad5a-54f3048b3b64"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd7b3603-5cab-41bf-8af9-84d2db4c4968"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17409ed1-b1ed-42af-bfb8-4e322b23f3a9"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Defend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""348de5ce-5bad-45f6-93e4-a0e70aa081cb"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Defend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2ec9a20-5613-467d-b700-a41a80b9d5c1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16c8049b-c5e5-4c80-bfd7-63edbcac2be3"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e81fc18c-11a8-45b2-9266-73ef4f73a5ed"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea143adf-db47-4bbf-8ef2-9adb8d5a000b"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Right Joystick"",
                    ""id"": ""8f54ac34-c9cc-4238-8160-b9905ac36679"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""4ac56213-1041-4adf-b080-884082112658"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""264912fe-c32e-40a3-85cc-ecb058887e7c"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""4756fd27-c0b3-4d68-bc59-6796e69b8bcd"",
                    ""path"": ""<XInputController>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""12519a1e-63e9-483a-bdf4-ce50a97c0a28"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""73727c72-d312-4de1-94fa-2517bded5825"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""228a2c29-6bfb-4a08-880d-a2bf46e21445"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Aim Or Target"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0b7de6f-2a88-4044-8134-6b174e767102"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Aim Or Target"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d64cde73-577e-4d74-8640-9f8c3a017777"",
                    ""path"": ""<XInputController>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""ResetCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CharacterSelection"",
            ""id"": ""6d02603c-dece-48f5-a6a6-46941dda77a4"",
            ""actions"": [
                {
                    ""name"": ""BrowseCharacters"",
                    ""type"": ""Button"",
                    ""id"": ""8e95bd95-3da5-4550-8233-4181e8bef36e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""933f6837-cf06-4fdc-b583-cd1d02affeb3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""73e80060-3fc5-4fd9-81f9-de5533d81088"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f6023660-d547-411d-b8bf-6bd867cc7879"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BrowseCharacters"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""67dc0806-b221-43ac-96f9-f837c2117871"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""BrowseCharacters"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""dde18961-b9b2-495d-8cae-39d2f9db7af4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""BrowseCharacters"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller"",
                    ""id"": ""7f030c1e-eb05-43c7-b522-5cfc06d8106d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press"",
                    ""processors"": ""AxisDeadzone(max=0.126)"",
                    ""groups"": """",
                    ""action"": ""BrowseCharacters"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""d5e265c8-e5dc-48d0-b204-f4949ccef66a"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""BrowseCharacters"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""948a7cc2-26ef-442f-af09-d40c7f68adf8"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""BrowseCharacters"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow keys"",
                    ""id"": ""2ddda27f-5c84-4197-af05-7f982aed431e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BrowseCharacters"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""141bfee2-5008-4987-9f3b-222e371a96cd"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""BrowseCharacters"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fca96892-a777-45b9-b3c9-ed59120c54df"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""BrowseCharacters"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""271da6cb-3dcc-46ba-a215-abfd88eb4071"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""417a4796-0c93-494e-b147-f307fe72e301"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd7e9474-cf07-4c59-bf3a-4a803a569d98"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a692b000-6f63-4e5a-9817-20594765613a"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Warrior"",
            ""id"": ""991e7840-ae1c-46a1-9685-8d11118c4f44"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b47a6724-3d4b-49b5-967f-aec4ca140eab"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""47239124-2259-4d64-9bae-9201263c7f25"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Special"",
                    ""type"": ""Button"",
                    ""id"": ""079e1237-ebec-4ddc-a36b-947685687c14"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""71a5a5a4-b751-4f13-a6ff-1176a0bc8ac2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""2b17747f-93d0-4814-aff2-aa1de5600f0f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill 1: Charge"",
                    ""type"": ""Value"",
                    ""id"": ""f727b258-a2d5-4a6f-a771-1420b5b07e9e"",
                    ""expectedControlType"": ""DiscreteButton"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Skill 2: Thunder Clap"",
                    ""type"": ""Button"",
                    ""id"": ""01a3ff85-1267-430c-a0d5-9c1c25f26f24"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Skill 3: Taunt"",
                    ""type"": ""Button"",
                    ""id"": ""8b01d5ec-40db-408b-8418-ec594a090976"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Skill 4: Shield Bash"",
                    ""type"": ""Button"",
                    ""id"": ""8e543e1c-4f0c-4b8d-bcc0-49947c724e0e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""265c3ef1-5e61-4e89-9dc9-1dadef8c97af"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""978aaf6b-33e6-4363-aadb-ac7452ce3915"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7c4ff407-6f9d-4bc9-930f-da9243c322ea"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dd7570aa-07f9-4460-b98d-211b64155e78"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""09860a21-91da-4955-aa1e-6c6faa25c36d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD Keys"",
                    ""id"": ""34837155-e3a4-44b7-af66-8a0f2305499b"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a3846e8b-d9f6-41da-92eb-fa1767707a87"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a75c3b8c-1587-47dd-bfd9-655b1c585f59"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9278bfb0-0b48-4d49-a32d-9aacc9f13157"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fdc5a7f1-55e6-4ced-94ff-134a24fd5849"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Joystick"",
                    ""id"": ""06df3268-9e14-4191-9167-1b45bf931181"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""078bd85b-a769-4c55-af25-a006696e7419"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""05d34f1a-926a-4d1e-87cf-45064fd4b038"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""84d1421a-7204-4393-85b4-cb669e4546e5"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""eaa2c200-4d74-4484-81f4-1a495ca67a70"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e6aeffc2-c866-45d2-bc54-770b7f6742c1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd2bf886-322a-47c6-8594-e753c250856f"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78c66277-12ed-4823-b461-3eaae51c6b37"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1022afc5-d015-495c-ae22-836667482aa3"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""500a156e-e9d6-4189-a2e6-9c20b8e64c7e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53c76c05-e05f-4e04-932f-5783aa2c1d43"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""114e2e27-a9f3-4a5b-9705-d9affaeda96f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a57b9ad-aeb1-4d30-80c3-11c62b996153"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""523430c3-3362-42a7-a5cd-e1d778d13a8e"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Skill 1: Charge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3ab0ed4-7444-4fdc-a152-00363c068c84"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Skill 1: Charge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f2ed82b-242b-4d8e-8013-940729225810"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Skill 2: Thunder Clap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c335c607-2510-4c6b-8bd5-ea8e7ea6fbba"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Skill 2: Thunder Clap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d44c0ce4-96d7-4b58-968b-7353a09acaa6"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Skill 3: Taunt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc191e06-78e9-468a-8afb-8eb3db9912bc"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Skill 3: Taunt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45b497fc-e088-4883-991a-c6970d9a5b0a"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Skill 4: Shield Bash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1d31ec8-916c-4b0f-abdc-ffd5d0abd7ac"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill 4: Shield Bash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Fire Mage"",
            ""id"": ""67bebe77-9878-4a15-9e2e-0d1c905b12d5"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""35de5ff2-c838-4492-abe5-fbac11bfe44c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""05a4184d-77b6-4b6a-9807-f7f29ca3082c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Special"",
                    ""type"": ""Button"",
                    ""id"": ""f60e85ec-bfc4-495a-b931-a989dd8226fb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""30a25771-3a14-47bf-a9e2-311504bd3449"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""0fd0fb4a-e497-438d-a153-0fc66564835a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill 1: Fire Ball"",
                    ""type"": ""Value"",
                    ""id"": ""e3451601-7b68-4cb2-9874-c3cb804a004e"",
                    ""expectedControlType"": ""DiscreteButton"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Skill 2: Fire Blast"",
                    ""type"": ""Button"",
                    ""id"": ""e35903e6-30d2-4e81-9025-46a6427347fa"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Skill 3: Fire Breath"",
                    ""type"": ""Button"",
                    ""id"": ""1eabe1a9-89af-4b0d-821b-045dd7b6e44b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Skill 4: Fire Missiles"",
                    ""type"": ""Button"",
                    ""id"": ""682b9403-10fb-4a4c-87c9-4035cc7f8854"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""09d4b2c9-8c0b-4beb-ae9e-ef28ba7eccab"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8892c376-5484-45bd-a7c8-c0d2ff2e29d3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""49b27152-e881-489e-91e1-152dbc70b089"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c47c6128-b7e6-479b-852e-d2b8050f253f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ae984bad-a63f-446c-be0e-325cc542a2f3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD Keys"",
                    ""id"": ""b67460a4-2ea4-4218-83ad-cdd3ec995fa2"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a19ec5a4-0e6c-4d41-be0b-9c9824412250"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e8b30797-7df8-4d06-85cf-cf4f38157ef7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""535f6b2d-5daf-435d-be3c-d601b9464a25"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""899dac9f-bddd-4228-a4d4-044e2d6f531c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Joystick"",
                    ""id"": ""071aea22-13e4-4077-aa2f-dcfc88896095"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a39260d3-97b6-4589-905e-ef62876c4ab8"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d265ac9d-c526-4c6c-85c7-62e6583b0e44"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""43d0b85a-49a6-45ce-9c02-0f727b7d0eaa"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""98fe554e-b99f-4a06-9093-9e9f0a3684a0"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3ef9f148-fa2a-48e7-b67f-a2ff537b7367"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7cd126a-40ec-4042-b08e-644c47b1d14c"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b86b4126-b314-4e06-9d17-25b400e115f6"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""810d4478-76ec-41e4-9fcc-1d149e894224"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a594706-2ccf-4e60-9555-e384b79e3eb4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81b67463-056f-438a-97c6-20358f57eb21"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9921498b-2962-4a89-9596-02e6d6e0a845"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b33c5624-1a14-4ff8-bf70-6a2358d217ce"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""750c2ca9-fb62-46aa-8d24-befb2cfb1d86"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Skill 1: Fire Ball"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f550d1de-eab8-4d43-87b7-dd32fec2eaac"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Skill 1: Fire Ball"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac448b4a-c2ee-4d30-ad22-978b50a47eb0"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Skill 2: Fire Blast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82ba5242-3806-4fa6-94b4-4fe8caa6bf50"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Skill 2: Fire Blast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4305199d-ea0e-4e77-b075-e3b29d2984bd"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Skill 3: Fire Breath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79104ef9-c72c-44e6-a389-1393861bce33"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Skill 3: Fire Breath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8354e9e-178b-435d-86a3-5c6a3f55705b"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Skill 4: Fire Missiles"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3321cc31-6847-4805-bd85-a41e8d2ff921"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill 4: Fire Missiles"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard And Mouse"",
            ""bindingGroup"": ""Keyboard And Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XboxController"",
            ""bindingGroup"": ""XboxController"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // CharacterBase
        m_CharacterBase = asset.FindActionMap("CharacterBase", throwIfNotFound: true);
        m_CharacterBase_Movement = m_CharacterBase.FindAction("Movement", throwIfNotFound: true);
        m_CharacterBase_Look = m_CharacterBase.FindAction("Look", throwIfNotFound: true);
        m_CharacterBase_Attack = m_CharacterBase.FindAction("Attack", throwIfNotFound: true);
        m_CharacterBase_Defend = m_CharacterBase.FindAction("Defend", throwIfNotFound: true);
        m_CharacterBase_Jump = m_CharacterBase.FindAction("Jump", throwIfNotFound: true);
        m_CharacterBase_Interact = m_CharacterBase.FindAction("Interact", throwIfNotFound: true);
        // ThirdPerson
        m_ThirdPerson = asset.FindActionMap("ThirdPerson", throwIfNotFound: true);
        m_ThirdPerson_Movement = m_ThirdPerson.FindAction("Movement", throwIfNotFound: true);
        m_ThirdPerson_Look = m_ThirdPerson.FindAction("Look", throwIfNotFound: true);
        m_ThirdPerson_Attack = m_ThirdPerson.FindAction("Attack", throwIfNotFound: true);
        m_ThirdPerson_Defend = m_ThirdPerson.FindAction("Defend", throwIfNotFound: true);
        m_ThirdPerson_Jump = m_ThirdPerson.FindAction("Jump", throwIfNotFound: true);
        m_ThirdPerson_Interact = m_ThirdPerson.FindAction("Interact", throwIfNotFound: true);
        m_ThirdPerson_AimOrTarget = m_ThirdPerson.FindAction("Aim Or Target", throwIfNotFound: true);
        m_ThirdPerson_ResetCamera = m_ThirdPerson.FindAction("ResetCamera", throwIfNotFound: true);
        // CharacterSelection
        m_CharacterSelection = asset.FindActionMap("CharacterSelection", throwIfNotFound: true);
        m_CharacterSelection_BrowseCharacters = m_CharacterSelection.FindAction("BrowseCharacters", throwIfNotFound: true);
        m_CharacterSelection_Confirm = m_CharacterSelection.FindAction("Confirm", throwIfNotFound: true);
        m_CharacterSelection_Back = m_CharacterSelection.FindAction("Back", throwIfNotFound: true);
        // Warrior
        m_Warrior = asset.FindActionMap("Warrior", throwIfNotFound: true);
        m_Warrior_Movement = m_Warrior.FindAction("Movement", throwIfNotFound: true);
        m_Warrior_Attack = m_Warrior.FindAction("Attack", throwIfNotFound: true);
        m_Warrior_Special = m_Warrior.FindAction("Special", throwIfNotFound: true);
        m_Warrior_Jump = m_Warrior.FindAction("Jump", throwIfNotFound: true);
        m_Warrior_Interact = m_Warrior.FindAction("Interact", throwIfNotFound: true);
        m_Warrior_Skill1Charge = m_Warrior.FindAction("Skill 1: Charge", throwIfNotFound: true);
        m_Warrior_Skill2ThunderClap = m_Warrior.FindAction("Skill 2: Thunder Clap", throwIfNotFound: true);
        m_Warrior_Skill3Taunt = m_Warrior.FindAction("Skill 3: Taunt", throwIfNotFound: true);
        m_Warrior_Skill4ShieldBash = m_Warrior.FindAction("Skill 4: Shield Bash", throwIfNotFound: true);
        // Fire Mage
        m_FireMage = asset.FindActionMap("Fire Mage", throwIfNotFound: true);
        m_FireMage_Movement = m_FireMage.FindAction("Movement", throwIfNotFound: true);
        m_FireMage_Attack = m_FireMage.FindAction("Attack", throwIfNotFound: true);
        m_FireMage_Special = m_FireMage.FindAction("Special", throwIfNotFound: true);
        m_FireMage_Jump = m_FireMage.FindAction("Jump", throwIfNotFound: true);
        m_FireMage_Interact = m_FireMage.FindAction("Interact", throwIfNotFound: true);
        m_FireMage_Skill1FireBall = m_FireMage.FindAction("Skill 1: Fire Ball", throwIfNotFound: true);
        m_FireMage_Skill2FireBlast = m_FireMage.FindAction("Skill 2: Fire Blast", throwIfNotFound: true);
        m_FireMage_Skill3FireBreath = m_FireMage.FindAction("Skill 3: Fire Breath", throwIfNotFound: true);
        m_FireMage_Skill4FireMissiles = m_FireMage.FindAction("Skill 4: Fire Missiles", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // CharacterBase
    private readonly InputActionMap m_CharacterBase;
    private ICharacterBaseActions m_CharacterBaseActionsCallbackInterface;
    private readonly InputAction m_CharacterBase_Movement;
    private readonly InputAction m_CharacterBase_Look;
    private readonly InputAction m_CharacterBase_Attack;
    private readonly InputAction m_CharacterBase_Defend;
    private readonly InputAction m_CharacterBase_Jump;
    private readonly InputAction m_CharacterBase_Interact;
    public struct CharacterBaseActions
    {
        private @Actions m_Wrapper;
        public CharacterBaseActions(@Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_CharacterBase_Movement;
        public InputAction @Look => m_Wrapper.m_CharacterBase_Look;
        public InputAction @Attack => m_Wrapper.m_CharacterBase_Attack;
        public InputAction @Defend => m_Wrapper.m_CharacterBase_Defend;
        public InputAction @Jump => m_Wrapper.m_CharacterBase_Jump;
        public InputAction @Interact => m_Wrapper.m_CharacterBase_Interact;
        public InputActionMap Get() { return m_Wrapper.m_CharacterBase; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterBaseActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterBaseActions instance)
        {
            if (m_Wrapper.m_CharacterBaseActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnLook;
                @Attack.started -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnAttack;
                @Defend.started -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnDefend;
                @Defend.performed -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnDefend;
                @Defend.canceled -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnDefend;
                @Jump.started -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnJump;
                @Interact.started -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_CharacterBaseActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_CharacterBaseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Defend.started += instance.OnDefend;
                @Defend.performed += instance.OnDefend;
                @Defend.canceled += instance.OnDefend;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public CharacterBaseActions @CharacterBase => new CharacterBaseActions(this);

    // ThirdPerson
    private readonly InputActionMap m_ThirdPerson;
    private IThirdPersonActions m_ThirdPersonActionsCallbackInterface;
    private readonly InputAction m_ThirdPerson_Movement;
    private readonly InputAction m_ThirdPerson_Look;
    private readonly InputAction m_ThirdPerson_Attack;
    private readonly InputAction m_ThirdPerson_Defend;
    private readonly InputAction m_ThirdPerson_Jump;
    private readonly InputAction m_ThirdPerson_Interact;
    private readonly InputAction m_ThirdPerson_AimOrTarget;
    private readonly InputAction m_ThirdPerson_ResetCamera;
    public struct ThirdPersonActions
    {
        private @Actions m_Wrapper;
        public ThirdPersonActions(@Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_ThirdPerson_Movement;
        public InputAction @Look => m_Wrapper.m_ThirdPerson_Look;
        public InputAction @Attack => m_Wrapper.m_ThirdPerson_Attack;
        public InputAction @Defend => m_Wrapper.m_ThirdPerson_Defend;
        public InputAction @Jump => m_Wrapper.m_ThirdPerson_Jump;
        public InputAction @Interact => m_Wrapper.m_ThirdPerson_Interact;
        public InputAction @AimOrTarget => m_Wrapper.m_ThirdPerson_AimOrTarget;
        public InputAction @ResetCamera => m_Wrapper.m_ThirdPerson_ResetCamera;
        public InputActionMap Get() { return m_Wrapper.m_ThirdPerson; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ThirdPersonActions set) { return set.Get(); }
        public void SetCallbacks(IThirdPersonActions instance)
        {
            if (m_Wrapper.m_ThirdPersonActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnLook;
                @Attack.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnAttack;
                @Defend.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnDefend;
                @Defend.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnDefend;
                @Defend.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnDefend;
                @Jump.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJump;
                @Interact.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnInteract;
                @AimOrTarget.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnAimOrTarget;
                @AimOrTarget.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnAimOrTarget;
                @AimOrTarget.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnAimOrTarget;
                @ResetCamera.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnResetCamera;
                @ResetCamera.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnResetCamera;
                @ResetCamera.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnResetCamera;
            }
            m_Wrapper.m_ThirdPersonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Defend.started += instance.OnDefend;
                @Defend.performed += instance.OnDefend;
                @Defend.canceled += instance.OnDefend;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @AimOrTarget.started += instance.OnAimOrTarget;
                @AimOrTarget.performed += instance.OnAimOrTarget;
                @AimOrTarget.canceled += instance.OnAimOrTarget;
                @ResetCamera.started += instance.OnResetCamera;
                @ResetCamera.performed += instance.OnResetCamera;
                @ResetCamera.canceled += instance.OnResetCamera;
            }
        }
    }
    public ThirdPersonActions @ThirdPerson => new ThirdPersonActions(this);

    // CharacterSelection
    private readonly InputActionMap m_CharacterSelection;
    private ICharacterSelectionActions m_CharacterSelectionActionsCallbackInterface;
    private readonly InputAction m_CharacterSelection_BrowseCharacters;
    private readonly InputAction m_CharacterSelection_Confirm;
    private readonly InputAction m_CharacterSelection_Back;
    public struct CharacterSelectionActions
    {
        private @Actions m_Wrapper;
        public CharacterSelectionActions(@Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @BrowseCharacters => m_Wrapper.m_CharacterSelection_BrowseCharacters;
        public InputAction @Confirm => m_Wrapper.m_CharacterSelection_Confirm;
        public InputAction @Back => m_Wrapper.m_CharacterSelection_Back;
        public InputActionMap Get() { return m_Wrapper.m_CharacterSelection; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterSelectionActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterSelectionActions instance)
        {
            if (m_Wrapper.m_CharacterSelectionActionsCallbackInterface != null)
            {
                @BrowseCharacters.started -= m_Wrapper.m_CharacterSelectionActionsCallbackInterface.OnBrowseCharacters;
                @BrowseCharacters.performed -= m_Wrapper.m_CharacterSelectionActionsCallbackInterface.OnBrowseCharacters;
                @BrowseCharacters.canceled -= m_Wrapper.m_CharacterSelectionActionsCallbackInterface.OnBrowseCharacters;
                @Confirm.started -= m_Wrapper.m_CharacterSelectionActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_CharacterSelectionActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_CharacterSelectionActionsCallbackInterface.OnConfirm;
                @Back.started -= m_Wrapper.m_CharacterSelectionActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_CharacterSelectionActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_CharacterSelectionActionsCallbackInterface.OnBack;
            }
            m_Wrapper.m_CharacterSelectionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @BrowseCharacters.started += instance.OnBrowseCharacters;
                @BrowseCharacters.performed += instance.OnBrowseCharacters;
                @BrowseCharacters.canceled += instance.OnBrowseCharacters;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
            }
        }
    }
    public CharacterSelectionActions @CharacterSelection => new CharacterSelectionActions(this);

    // Warrior
    private readonly InputActionMap m_Warrior;
    private IWarriorActions m_WarriorActionsCallbackInterface;
    private readonly InputAction m_Warrior_Movement;
    private readonly InputAction m_Warrior_Attack;
    private readonly InputAction m_Warrior_Special;
    private readonly InputAction m_Warrior_Jump;
    private readonly InputAction m_Warrior_Interact;
    private readonly InputAction m_Warrior_Skill1Charge;
    private readonly InputAction m_Warrior_Skill2ThunderClap;
    private readonly InputAction m_Warrior_Skill3Taunt;
    private readonly InputAction m_Warrior_Skill4ShieldBash;
    public struct WarriorActions
    {
        private @Actions m_Wrapper;
        public WarriorActions(@Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Warrior_Movement;
        public InputAction @Attack => m_Wrapper.m_Warrior_Attack;
        public InputAction @Special => m_Wrapper.m_Warrior_Special;
        public InputAction @Jump => m_Wrapper.m_Warrior_Jump;
        public InputAction @Interact => m_Wrapper.m_Warrior_Interact;
        public InputAction @Skill1Charge => m_Wrapper.m_Warrior_Skill1Charge;
        public InputAction @Skill2ThunderClap => m_Wrapper.m_Warrior_Skill2ThunderClap;
        public InputAction @Skill3Taunt => m_Wrapper.m_Warrior_Skill3Taunt;
        public InputAction @Skill4ShieldBash => m_Wrapper.m_Warrior_Skill4ShieldBash;
        public InputActionMap Get() { return m_Wrapper.m_Warrior; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WarriorActions set) { return set.Get(); }
        public void SetCallbacks(IWarriorActions instance)
        {
            if (m_Wrapper.m_WarriorActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_WarriorActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_WarriorActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_WarriorActionsCallbackInterface.OnMovement;
                @Attack.started -= m_Wrapper.m_WarriorActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_WarriorActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_WarriorActionsCallbackInterface.OnAttack;
                @Special.started -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSpecial;
                @Special.performed -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSpecial;
                @Special.canceled -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSpecial;
                @Jump.started -= m_Wrapper.m_WarriorActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_WarriorActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_WarriorActionsCallbackInterface.OnJump;
                @Interact.started -= m_Wrapper.m_WarriorActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_WarriorActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_WarriorActionsCallbackInterface.OnInteract;
                @Skill1Charge.started -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSkill1Charge;
                @Skill1Charge.performed -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSkill1Charge;
                @Skill1Charge.canceled -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSkill1Charge;
                @Skill2ThunderClap.started -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSkill2ThunderClap;
                @Skill2ThunderClap.performed -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSkill2ThunderClap;
                @Skill2ThunderClap.canceled -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSkill2ThunderClap;
                @Skill3Taunt.started -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSkill3Taunt;
                @Skill3Taunt.performed -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSkill3Taunt;
                @Skill3Taunt.canceled -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSkill3Taunt;
                @Skill4ShieldBash.started -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSkill4ShieldBash;
                @Skill4ShieldBash.performed -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSkill4ShieldBash;
                @Skill4ShieldBash.canceled -= m_Wrapper.m_WarriorActionsCallbackInterface.OnSkill4ShieldBash;
            }
            m_Wrapper.m_WarriorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Special.started += instance.OnSpecial;
                @Special.performed += instance.OnSpecial;
                @Special.canceled += instance.OnSpecial;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Skill1Charge.started += instance.OnSkill1Charge;
                @Skill1Charge.performed += instance.OnSkill1Charge;
                @Skill1Charge.canceled += instance.OnSkill1Charge;
                @Skill2ThunderClap.started += instance.OnSkill2ThunderClap;
                @Skill2ThunderClap.performed += instance.OnSkill2ThunderClap;
                @Skill2ThunderClap.canceled += instance.OnSkill2ThunderClap;
                @Skill3Taunt.started += instance.OnSkill3Taunt;
                @Skill3Taunt.performed += instance.OnSkill3Taunt;
                @Skill3Taunt.canceled += instance.OnSkill3Taunt;
                @Skill4ShieldBash.started += instance.OnSkill4ShieldBash;
                @Skill4ShieldBash.performed += instance.OnSkill4ShieldBash;
                @Skill4ShieldBash.canceled += instance.OnSkill4ShieldBash;
            }
        }
    }
    public WarriorActions @Warrior => new WarriorActions(this);

    // Fire Mage
    private readonly InputActionMap m_FireMage;
    private IFireMageActions m_FireMageActionsCallbackInterface;
    private readonly InputAction m_FireMage_Movement;
    private readonly InputAction m_FireMage_Attack;
    private readonly InputAction m_FireMage_Special;
    private readonly InputAction m_FireMage_Jump;
    private readonly InputAction m_FireMage_Interact;
    private readonly InputAction m_FireMage_Skill1FireBall;
    private readonly InputAction m_FireMage_Skill2FireBlast;
    private readonly InputAction m_FireMage_Skill3FireBreath;
    private readonly InputAction m_FireMage_Skill4FireMissiles;
    public struct FireMageActions
    {
        private @Actions m_Wrapper;
        public FireMageActions(@Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_FireMage_Movement;
        public InputAction @Attack => m_Wrapper.m_FireMage_Attack;
        public InputAction @Special => m_Wrapper.m_FireMage_Special;
        public InputAction @Jump => m_Wrapper.m_FireMage_Jump;
        public InputAction @Interact => m_Wrapper.m_FireMage_Interact;
        public InputAction @Skill1FireBall => m_Wrapper.m_FireMage_Skill1FireBall;
        public InputAction @Skill2FireBlast => m_Wrapper.m_FireMage_Skill2FireBlast;
        public InputAction @Skill3FireBreath => m_Wrapper.m_FireMage_Skill3FireBreath;
        public InputAction @Skill4FireMissiles => m_Wrapper.m_FireMage_Skill4FireMissiles;
        public InputActionMap Get() { return m_Wrapper.m_FireMage; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FireMageActions set) { return set.Get(); }
        public void SetCallbacks(IFireMageActions instance)
        {
            if (m_Wrapper.m_FireMageActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_FireMageActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_FireMageActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_FireMageActionsCallbackInterface.OnMovement;
                @Attack.started -= m_Wrapper.m_FireMageActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_FireMageActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_FireMageActionsCallbackInterface.OnAttack;
                @Special.started -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSpecial;
                @Special.performed -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSpecial;
                @Special.canceled -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSpecial;
                @Jump.started -= m_Wrapper.m_FireMageActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_FireMageActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_FireMageActionsCallbackInterface.OnJump;
                @Interact.started -= m_Wrapper.m_FireMageActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_FireMageActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_FireMageActionsCallbackInterface.OnInteract;
                @Skill1FireBall.started -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSkill1FireBall;
                @Skill1FireBall.performed -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSkill1FireBall;
                @Skill1FireBall.canceled -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSkill1FireBall;
                @Skill2FireBlast.started -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSkill2FireBlast;
                @Skill2FireBlast.performed -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSkill2FireBlast;
                @Skill2FireBlast.canceled -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSkill2FireBlast;
                @Skill3FireBreath.started -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSkill3FireBreath;
                @Skill3FireBreath.performed -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSkill3FireBreath;
                @Skill3FireBreath.canceled -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSkill3FireBreath;
                @Skill4FireMissiles.started -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSkill4FireMissiles;
                @Skill4FireMissiles.performed -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSkill4FireMissiles;
                @Skill4FireMissiles.canceled -= m_Wrapper.m_FireMageActionsCallbackInterface.OnSkill4FireMissiles;
            }
            m_Wrapper.m_FireMageActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Special.started += instance.OnSpecial;
                @Special.performed += instance.OnSpecial;
                @Special.canceled += instance.OnSpecial;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Skill1FireBall.started += instance.OnSkill1FireBall;
                @Skill1FireBall.performed += instance.OnSkill1FireBall;
                @Skill1FireBall.canceled += instance.OnSkill1FireBall;
                @Skill2FireBlast.started += instance.OnSkill2FireBlast;
                @Skill2FireBlast.performed += instance.OnSkill2FireBlast;
                @Skill2FireBlast.canceled += instance.OnSkill2FireBlast;
                @Skill3FireBreath.started += instance.OnSkill3FireBreath;
                @Skill3FireBreath.performed += instance.OnSkill3FireBreath;
                @Skill3FireBreath.canceled += instance.OnSkill3FireBreath;
                @Skill4FireMissiles.started += instance.OnSkill4FireMissiles;
                @Skill4FireMissiles.performed += instance.OnSkill4FireMissiles;
                @Skill4FireMissiles.canceled += instance.OnSkill4FireMissiles;
            }
        }
    }
    public FireMageActions @FireMage => new FireMageActions(this);
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard And Mouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    private int m_XboxControllerSchemeIndex = -1;
    public InputControlScheme XboxControllerScheme
    {
        get
        {
            if (m_XboxControllerSchemeIndex == -1) m_XboxControllerSchemeIndex = asset.FindControlSchemeIndex("XboxController");
            return asset.controlSchemes[m_XboxControllerSchemeIndex];
        }
    }
    public interface ICharacterBaseActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnDefend(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IThirdPersonActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnDefend(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnAimOrTarget(InputAction.CallbackContext context);
        void OnResetCamera(InputAction.CallbackContext context);
    }
    public interface ICharacterSelectionActions
    {
        void OnBrowseCharacters(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
    }
    public interface IWarriorActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnSpecial(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnSkill1Charge(InputAction.CallbackContext context);
        void OnSkill2ThunderClap(InputAction.CallbackContext context);
        void OnSkill3Taunt(InputAction.CallbackContext context);
        void OnSkill4ShieldBash(InputAction.CallbackContext context);
    }
    public interface IFireMageActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnSpecial(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnSkill1FireBall(InputAction.CallbackContext context);
        void OnSkill2FireBlast(InputAction.CallbackContext context);
        void OnSkill3FireBreath(InputAction.CallbackContext context);
        void OnSkill4FireMissiles(InputAction.CallbackContext context);
    }
}
