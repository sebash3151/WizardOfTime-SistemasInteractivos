// GENERATED AUTOMATICALLY FROM 'Assets/Colin/TouchControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TouchControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchControls"",
    ""maps"": [
        {
            ""name"": ""MultiTouch"",
            ""id"": ""eb8fc300-b5a0-4d59-87bf-a16089c0fb40"",
            ""actions"": [
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1b53e2c6-c0bf-4a06-802a-4fa7dcc2221c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpawnWater"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0b667360-57d4-4a2a-896c-af15de62a036"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpawnWaterStop"",
                    ""type"": ""Button"",
                    ""id"": ""3296d8dd-ba42-4c68-b07b-7f4ba43d8fdc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26861532-a143-4262-afff-0d8dffa1c955"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e55b24d9-be18-47d8-8301-db7c8f96d0b4"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9734bec3-a9a5-4474-ae16-3474a4f6ac9c"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnWater"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b3e6711-5602-4ae3-a6f0-c4a59084865f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnWater"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a096ba4-f176-4642-8e43-ac008acca9b6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnWater"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbe10b82-a279-41a2-a433-b264d219f724"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnWaterStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8aaa3d0e-7d89-42a5-b6a7-067bfcb0eb21"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnWaterStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a708a3d8-fdbe-4b1b-b85f-dfb9b668ae81"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnWaterStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MultiTouch
        m_MultiTouch = asset.FindActionMap("MultiTouch", throwIfNotFound: true);
        m_MultiTouch_MousePosition = m_MultiTouch.FindAction("MousePosition", throwIfNotFound: true);
        m_MultiTouch_SpawnWater = m_MultiTouch.FindAction("SpawnWater", throwIfNotFound: true);
        m_MultiTouch_SpawnWaterStop = m_MultiTouch.FindAction("SpawnWaterStop", throwIfNotFound: true);
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

    // MultiTouch
    private readonly InputActionMap m_MultiTouch;
    private IMultiTouchActions m_MultiTouchActionsCallbackInterface;
    private readonly InputAction m_MultiTouch_MousePosition;
    private readonly InputAction m_MultiTouch_SpawnWater;
    private readonly InputAction m_MultiTouch_SpawnWaterStop;
    public struct MultiTouchActions
    {
        private @TouchControls m_Wrapper;
        public MultiTouchActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePosition => m_Wrapper.m_MultiTouch_MousePosition;
        public InputAction @SpawnWater => m_Wrapper.m_MultiTouch_SpawnWater;
        public InputAction @SpawnWaterStop => m_Wrapper.m_MultiTouch_SpawnWaterStop;
        public InputActionMap Get() { return m_Wrapper.m_MultiTouch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MultiTouchActions set) { return set.Get(); }
        public void SetCallbacks(IMultiTouchActions instance)
        {
            if (m_Wrapper.m_MultiTouchActionsCallbackInterface != null)
            {
                @MousePosition.started -= m_Wrapper.m_MultiTouchActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_MultiTouchActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_MultiTouchActionsCallbackInterface.OnMousePosition;
                @SpawnWater.started -= m_Wrapper.m_MultiTouchActionsCallbackInterface.OnSpawnWater;
                @SpawnWater.performed -= m_Wrapper.m_MultiTouchActionsCallbackInterface.OnSpawnWater;
                @SpawnWater.canceled -= m_Wrapper.m_MultiTouchActionsCallbackInterface.OnSpawnWater;
                @SpawnWaterStop.started -= m_Wrapper.m_MultiTouchActionsCallbackInterface.OnSpawnWaterStop;
                @SpawnWaterStop.performed -= m_Wrapper.m_MultiTouchActionsCallbackInterface.OnSpawnWaterStop;
                @SpawnWaterStop.canceled -= m_Wrapper.m_MultiTouchActionsCallbackInterface.OnSpawnWaterStop;
            }
            m_Wrapper.m_MultiTouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @SpawnWater.started += instance.OnSpawnWater;
                @SpawnWater.performed += instance.OnSpawnWater;
                @SpawnWater.canceled += instance.OnSpawnWater;
                @SpawnWaterStop.started += instance.OnSpawnWaterStop;
                @SpawnWaterStop.performed += instance.OnSpawnWaterStop;
                @SpawnWaterStop.canceled += instance.OnSpawnWaterStop;
            }
        }
    }
    public MultiTouchActions @MultiTouch => new MultiTouchActions(this);
    public interface IMultiTouchActions
    {
        void OnMousePosition(InputAction.CallbackContext context);
        void OnSpawnWater(InputAction.CallbackContext context);
        void OnSpawnWaterStop(InputAction.CallbackContext context);
    }
}
