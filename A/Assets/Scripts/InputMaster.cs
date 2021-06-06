// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""435129f7-8d39-4cea-ab7f-d768f5e1e97a"",
            ""actions"": [
                {
                    ""name"": ""record"",
                    ""type"": ""PassThrough"",
                    ""id"": ""61f3fc87-49f0-4eb7-8f01-fb831a92c089"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5e62c8fd-d4a5-4a84-91ec-6b5e59f78d41"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""record"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""right hand "",
            ""bindingGroup"": ""right hand "",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_record = m_player.FindAction("record", throwIfNotFound: true);
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

    // player
    private readonly InputActionMap m_player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_player_record;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @record => m_Wrapper.m_player_record;
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @record.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRecord;
                @record.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRecord;
                @record.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRecord;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @record.started += instance.OnRecord;
                @record.performed += instance.OnRecord;
                @record.canceled += instance.OnRecord;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);
    private int m_righthandSchemeIndex = -1;
    public InputControlScheme righthandScheme
    {
        get
        {
            if (m_righthandSchemeIndex == -1) m_righthandSchemeIndex = asset.FindControlSchemeIndex("right hand ");
            return asset.controlSchemes[m_righthandSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnRecord(InputAction.CallbackContext context);
    }
}
