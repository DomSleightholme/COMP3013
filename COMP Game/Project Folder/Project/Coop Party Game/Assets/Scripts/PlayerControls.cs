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
                    ""groups"": ""WASD"",
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
                    ""groups"": ""WASD"",
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
                    ""groups"": ""WASD"",
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
                    ""groups"": ""WASD"",
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
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""6663b46d-bdd0-4baf-a382-91ab9f74f5a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7ab196b0-6182-477f-a973-057062e0e6ec"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""WASD"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        }
    ]
}");
        // Bumper
        m_Bumper = asset.FindActionMap("Bumper", throwIfNotFound: true);
        m_Bumper_Turning = m_Bumper.FindAction("Turning", throwIfNotFound: true);
        m_Bumper_Accleration = m_Bumper.FindAction("Accleration", throwIfNotFound: true);
        // Hippos
        m_Hippos = asset.FindActionMap("Hippos", throwIfNotFound: true);
        m_Hippos_Newaction = m_Hippos.FindAction("New action", throwIfNotFound: true);
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
    private readonly InputAction m_Hippos_Newaction;
    public struct HipposActions
    {
        private @PlayerControls m_Wrapper;
        public HipposActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Hippos_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Hippos; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HipposActions set) { return set.Get(); }
        public void SetCallbacks(IHipposActions instance)
        {
            if (m_Wrapper.m_HipposActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_HipposActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_HipposActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_HipposActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_HipposActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public HipposActions @Hippos => new HipposActions(this);
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
    public interface IBumperActions
    {
        void OnTurning(InputAction.CallbackContext context);
        void OnAccleration(InputAction.CallbackContext context);
    }
    public interface IHipposActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
