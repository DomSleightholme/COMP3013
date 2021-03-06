// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Bumper"",
            ""id"": ""26d83ba8-c013-432a-8b36-b1d42491abea"",
            ""actions"": [
                {
                    ""name"": ""Turning"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4907358e-31e8-41fd-8e6f-b711b0a00741"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accleration"",
                    ""type"": ""Button"",
                    ""id"": ""313f89f8-e828-4de1-8c65-f7af3180d0e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""3a3ce893-c06f-4dbe-bc32-1d74dd8a050c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bbb19fa4-9ff2-427c-8913-148345ae7ff3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""WASD"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4cd06b13-af8e-4869-873f-cd6659c1095d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""WASD"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""47942571-ac59-4b14-9020-78c64512adc6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""291056a2-4819-4816-b965-2d9a19933026"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ArrowKeys"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0cb4d953-7240-49c4-80f1-6b383d9d9740"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ArrowKeys"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPAD"",
                    ""id"": ""002c7fc1-c2e4-446b-8751-50ffba9bd664"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""11061824-4e04-420c-b78c-62b7a46da4c3"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3fed1b24-6c59-4f2b-90a4-3c3ea321bc8c"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Thumbstick"",
                    ""id"": ""1856a553-0db9-4949-aefe-0dac8cb5174d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b5435794-363a-4d53-81ce-5172f9d3780c"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""86275611-ae3b-43d5-ab28-b654d93550f4"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""da418897-49f4-47a1-a503-8be4cb2281b1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""WASD"",
                    ""action"": ""Accleration"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""44b294d5-e045-4104-870a-598339dfc180"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""WASD"",
                    ""action"": ""Accleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""61c4a896-1003-4434-b4c0-60dd251ff471"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""WASD"",
                    ""action"": ""Accleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""46fda31f-56bc-401e-9629-d2ebbce647ae"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accleration"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3b8b0a2d-2e69-4f28-9bd5-2903b6edd94b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ArrowKeys"",
                    ""action"": ""Accleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""be2f82b7-e940-42fc-8e56-db75a14fd4cf"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ArrowKeys"",
                    ""action"": ""Accleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPAD"",
                    ""id"": ""8e30497a-55d2-4b43-aa27-abc641c07416"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accleration"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2eaa0eb1-45e2-43e0-aeb1-27a92f9bca5e"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""891ec02e-3aa0-4807-bde6-4a088c478c27"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Thumbstick"",
                    ""id"": ""c7161844-c462-4a9f-a2f9-c1f2295ad3f1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accleration"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""799b04bc-7e27-400c-8fe3-35376148a2ab"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""83c866c3-36d0-413d-9b80-c5f224e9dd18"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Hippos"",
            ""id"": ""20bfd1d3-c650-4c6d-8e16-31b200d07c0d"",
            ""actions"": [
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""7fd69f71-c431-4deb-8431-07bbcef22461"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turning"",
                    ""type"": ""Button"",
                    ""id"": ""3ed54c09-9bb2-481b-bbc8-42b7b23dad30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6eb22763-a6ee-4a3d-a3a9-e7f8b81ccfc9"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""50747918-3f33-4844-a77e-2d6eafa05c4b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""47d5ac22-8955-4e7c-bd36-dfad0f3dce94"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""WASD"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c12955c0-41e6-47f6-aef7-91aff4431469"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""WASD"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""2d6cd973-b207-46d3-a164-619600ce8205"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b19fe1a8-5c06-4aa7-9c4d-263105abd9ce"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ArrowKeys"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8413a436-de50-454f-ad88-b5977da07747"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ArrowKeys"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPAD"",
                    ""id"": ""75f31776-7e62-4427-921c-2728079491eb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4a4eded4-2d86-4dc2-91cb-e1dfaa8fe81c"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ea558141-4d44-4c05-ad3a-513f4ee0335b"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Thumbstick"",
                    ""id"": ""c65f755e-ccdb-46f5-a1b2-166bf26f0146"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2fa705aa-598c-4626-a1d4-fbf32557c096"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1fb5d980-ca92-42ae-8da8-ac1e5383022c"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""ObstacleCourse"",
            ""id"": ""7e1c132f-03c1-4925-be25-37e8789d0265"",
            ""actions"": [
                {
                    ""name"": ""Turning"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d46bed26-d2ad-4b3c-8afd-1910c21ade64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Value"",
                    ""id"": ""699f59fd-5cf8-4a8e-ba7a-3fb18e04451e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""7224276f-9e7a-4a91-9d14-bf52f9ab0174"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""076f9939-abaf-4fd9-b7ca-6ac6f4573804"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""WASD"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d727a5da-c9bc-453b-b180-4563065eb539"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""WASD"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""0e7234c6-e14c-46b7-b87d-b0a81f91f9ee"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2a6870be-5ff8-4865-91f1-def962d2fbeb"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ArrowKeys"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bfa11253-8afb-4f6b-85b1-3acf5410e24a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ArrowKeys"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPAD"",
                    ""id"": ""b61836a0-4ada-42dd-8eb3-e28a081888d0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d38cafae-635b-4c67-9225-26be611a8731"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e6b64cdc-f0fd-4ac3-99f9-66812508db72"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Thumbstick"",
                    ""id"": ""562dfd1a-52e3-4ee3-a2b3-40f1fbb68a73"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fc1498c5-d137-466b-b84d-ccb154b3fde8"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""066d9bee-a78b-4912-b50f-4956d67dcc54"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""88f7bc97-586c-4aaa-936d-87829279eb91"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ee57b26f-ea21-449a-a5eb-e41f7e8758a2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""WASD"",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""810afdd6-a295-4d93-bbe6-484929b2a10c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""WASD"",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""3cd0bbe5-da61-49b6-b425-47bf82508b61"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""784f090f-517c-4384-aaab-6699d9997e20"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ArrowKeys"",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b2651aa8-7b60-4365-bf9f-21df4a42b951"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ArrowKeys"",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPAD"",
                    ""id"": ""947956ae-2606-4894-912d-4ed6846111fb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3cec3045-6df5-4355-81c2-66d43ff7cb01"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9a2acdd7-5a88-487c-9d2b-f482a02c6ae3"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Thumbstick"",
                    ""id"": ""85d05cdb-48d9-42a4-bcd7-50ff1338cd8f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""951478fd-8b62-4621-8f54-a188a87c6d4b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fcceb9b9-5efe-4d2f-ab43-06f8caa2b9d3"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""WASD"",
            ""bindingGroup"": ""WASD"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""ArrowKeys"",
            ""bindingGroup"": ""ArrowKeys"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Bumper
        m_Bumper = asset.FindActionMap("Bumper", throwIfNotFound: true);
        m_Bumper_Turning = m_Bumper.FindAction("Turning", throwIfNotFound: true);
        m_Bumper_Accleration = m_Bumper.FindAction("Accleration", throwIfNotFound: true);
        // Hippos
        m_Hippos = asset.FindActionMap("Hippos", throwIfNotFound: true);
        m_Hippos_Forward = m_Hippos.FindAction("Forward", throwIfNotFound: true);
        m_Hippos_Turning = m_Hippos.FindAction("Turning", throwIfNotFound: true);
        // ObstacleCourse
        m_ObstacleCourse = asset.FindActionMap("ObstacleCourse", throwIfNotFound: true);
        m_ObstacleCourse_Turning = m_ObstacleCourse.FindAction("Turning", throwIfNotFound: true);
        m_ObstacleCourse_Acceleration = m_ObstacleCourse.FindAction("Acceleration", throwIfNotFound: true);
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

    // Bumper
    private readonly InputActionMap m_Bumper;
    private IBumperActions m_BumperActionsCallbackInterface;
    private readonly InputAction m_Bumper_Turning;
    private readonly InputAction m_Bumper_Accleration;
    public struct BumperActions
    {
        private @PlayerControls m_Wrapper;
        public BumperActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Turning => m_Wrapper.m_Bumper_Turning;
        public InputAction @Accleration => m_Wrapper.m_Bumper_Accleration;
        public InputActionMap Get() { return m_Wrapper.m_Bumper; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BumperActions set) { return set.Get(); }
        public void SetCallbacks(IBumperActions instance)
        {
            if (m_Wrapper.m_BumperActionsCallbackInterface != null)
            {
                @Turning.started -= m_Wrapper.m_BumperActionsCallbackInterface.OnTurning;
                @Turning.performed -= m_Wrapper.m_BumperActionsCallbackInterface.OnTurning;
                @Turning.canceled -= m_Wrapper.m_BumperActionsCallbackInterface.OnTurning;
                @Accleration.started -= m_Wrapper.m_BumperActionsCallbackInterface.OnAccleration;
                @Accleration.performed -= m_Wrapper.m_BumperActionsCallbackInterface.OnAccleration;
                @Accleration.canceled -= m_Wrapper.m_BumperActionsCallbackInterface.OnAccleration;
            }
            m_Wrapper.m_BumperActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Turning.started += instance.OnTurning;
                @Turning.performed += instance.OnTurning;
                @Turning.canceled += instance.OnTurning;
                @Accleration.started += instance.OnAccleration;
                @Accleration.performed += instance.OnAccleration;
                @Accleration.canceled += instance.OnAccleration;
            }
        }
    }
    public BumperActions @Bumper => new BumperActions(this);

    // Hippos
    private readonly InputActionMap m_Hippos;
    private IHipposActions m_HipposActionsCallbackInterface;
    private readonly InputAction m_Hippos_Forward;
    private readonly InputAction m_Hippos_Turning;
    public struct HipposActions
    {
        private @PlayerControls m_Wrapper;
        public HipposActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Forward => m_Wrapper.m_Hippos_Forward;
        public InputAction @Turning => m_Wrapper.m_Hippos_Turning;
        public InputActionMap Get() { return m_Wrapper.m_Hippos; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HipposActions set) { return set.Get(); }
        public void SetCallbacks(IHipposActions instance)
        {
            if (m_Wrapper.m_HipposActionsCallbackInterface != null)
            {
                @Forward.started -= m_Wrapper.m_HipposActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_HipposActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_HipposActionsCallbackInterface.OnForward;
                @Turning.started -= m_Wrapper.m_HipposActionsCallbackInterface.OnTurning;
                @Turning.performed -= m_Wrapper.m_HipposActionsCallbackInterface.OnTurning;
                @Turning.canceled -= m_Wrapper.m_HipposActionsCallbackInterface.OnTurning;
            }
            m_Wrapper.m_HipposActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Turning.started += instance.OnTurning;
                @Turning.performed += instance.OnTurning;
                @Turning.canceled += instance.OnTurning;
            }
        }
    }
    public HipposActions @Hippos => new HipposActions(this);

    // ObstacleCourse
    private readonly InputActionMap m_ObstacleCourse;
    private IObstacleCourseActions m_ObstacleCourseActionsCallbackInterface;
    private readonly InputAction m_ObstacleCourse_Turning;
    private readonly InputAction m_ObstacleCourse_Acceleration;
    public struct ObstacleCourseActions
    {
        private @PlayerControls m_Wrapper;
        public ObstacleCourseActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Turning => m_Wrapper.m_ObstacleCourse_Turning;
        public InputAction @Acceleration => m_Wrapper.m_ObstacleCourse_Acceleration;
        public InputActionMap Get() { return m_Wrapper.m_ObstacleCourse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ObstacleCourseActions set) { return set.Get(); }
        public void SetCallbacks(IObstacleCourseActions instance)
        {
            if (m_Wrapper.m_ObstacleCourseActionsCallbackInterface != null)
            {
                @Turning.started -= m_Wrapper.m_ObstacleCourseActionsCallbackInterface.OnTurning;
                @Turning.performed -= m_Wrapper.m_ObstacleCourseActionsCallbackInterface.OnTurning;
                @Turning.canceled -= m_Wrapper.m_ObstacleCourseActionsCallbackInterface.OnTurning;
                @Acceleration.started -= m_Wrapper.m_ObstacleCourseActionsCallbackInterface.OnAcceleration;
                @Acceleration.performed -= m_Wrapper.m_ObstacleCourseActionsCallbackInterface.OnAcceleration;
                @Acceleration.canceled -= m_Wrapper.m_ObstacleCourseActionsCallbackInterface.OnAcceleration;
            }
            m_Wrapper.m_ObstacleCourseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Turning.started += instance.OnTurning;
                @Turning.performed += instance.OnTurning;
                @Turning.canceled += instance.OnTurning;
                @Acceleration.started += instance.OnAcceleration;
                @Acceleration.performed += instance.OnAcceleration;
                @Acceleration.canceled += instance.OnAcceleration;
            }
        }
    }
    public ObstacleCourseActions @ObstacleCourse => new ObstacleCourseActions(this);
    private int m_WASDSchemeIndex = -1;
    public InputControlScheme WASDScheme
    {
        get
        {
            if (m_WASDSchemeIndex == -1) m_WASDSchemeIndex = asset.FindControlSchemeIndex("WASD");
            return asset.controlSchemes[m_WASDSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_ArrowKeysSchemeIndex = -1;
    public InputControlScheme ArrowKeysScheme
    {
        get
        {
            if (m_ArrowKeysSchemeIndex == -1) m_ArrowKeysSchemeIndex = asset.FindControlSchemeIndex("ArrowKeys");
            return asset.controlSchemes[m_ArrowKeysSchemeIndex];
        }
    }
    public interface IBumperActions
    {
        void OnTurning(InputAction.CallbackContext context);
        void OnAccleration(InputAction.CallbackContext context);
    }
    public interface IHipposActions
    {
        void OnForward(InputAction.CallbackContext context);
        void OnTurning(InputAction.CallbackContext context);
    }
    public interface IObstacleCourseActions
    {
        void OnTurning(InputAction.CallbackContext context);
        void OnAcceleration(InputAction.CallbackContext context);
    }
}
